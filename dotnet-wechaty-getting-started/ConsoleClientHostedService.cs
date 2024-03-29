﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Wechaty.Module.Puppet.Schemas;
using Wechaty.User;


namespace dotnet_wechaty_getting_started
{
    public class ConsoleClientHostedService : IHostedService
    {
        private readonly IConfiguration _configuration;

        public ConsoleClientHostedService(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        private static Wechaty.Wechaty bot;

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            var PuppetOptions = new PuppetOptions()
            {
                Token = _configuration["WECHATY_PUPPET_HOSTIE_TOKEN"],
                //PuppetService = _configuration["WECHATY_PUPPET"]
                Endpoint= _configuration["WECHATY_ENDPOINT"]
            };
            bot = new Wechaty.Wechaty(PuppetOptions);

            await bot.OnScan(WechatyScanEventListener)
                .OnLogin(WechatyLoginEventListener)
                .OnMessage(WechatyMessageEventListenerAsync)
                .OnHeartbeat(WechatyHeartbeatEventListener)
                .Start();
        }

        public static void WechatyLoginEventListener(ContactSelf user)
        {
            Console.WriteLine($"{user.Name}在{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}上线了！");
        }

        private static void WechatyHeartbeatEventListener(object data)
        {
            Console.WriteLine(JsonConvert.SerializeObject(data));
        }

        private static void WechatyScanEventListener(string qrcode, ScanStatus status, string? data)
        {
            Console.WriteLine(qrcode);
            const string QrcodeServerUrl = "https://wechaty.js.org/qrcode/";
            if (status == ScanStatus.Waiting || status == ScanStatus.Timeout)
            {
                var qrcodeImageUrl = QrcodeServerUrl + qrcode;
                Console.WriteLine(qrcodeImageUrl);
            }
            else if (status == ScanStatus.Scanned)
            {
                Console.WriteLine(data);
            }
        }

        private static void WechatyMessageEventListenerAsync(Wechaty.User.Message message)
        {
            Console.WriteLine(message.Text);
            if (message.Text == "天王盖地虎" || message.Text == "小鸡啄米")
            {
                _ = message.Say("宝塔镇河妖");
            }

        }

        /// <summary>
        /// Stop
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Process.GetCurrentProcess().Kill();
            return;
        }
    }
}
