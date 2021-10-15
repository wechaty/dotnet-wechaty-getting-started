# dotnet-wechaty-getting-started [![Powered by Wechaty](https://img.shields.io/badge/Powered%20By-Wechaty-brightgreen.svg)](https://github.com/wechaty/dotnet-wechaty)

![Dotnet Wechaty](https://raw.githubusercontent.com/wechaty/dotnet-wechaty/master/docs/images/dotnet-wechaty.png)

## Quick Start

###   Start Wechaty  Gateway

1、 Wechaty Gateway  HTTP protocol

```
export WECHATY_LOG="verbose"
export WECHATY_PUPPET="wechaty-puppet-padlocal"
export WECHATY_PUPPET_PADLOCAL_TOKEN="puppet_padlocal_XXXX"
export WECHATY_PUPPET_SERVER_PORT="9002"
export WECHATY_TOKEN="set your gateway token"

docker run -it \
  --name wechaty-gateway-http \
  -e WECHATY_LOG \
  -e WECHATY_PUPPET \
  -e WECHATY_PUPPET_PADLOCAL_TOKEN \
  -e WECHATY_PUPPET_SERVER_PORT \
  -e WECHATY_TOKEN \
  -p "$WECHATY_PUPPET_SERVER_PORT:$WECHATY_PUPPET_SERVER_PORT" \
  wechaty/wechaty:0.56
```


2、Wechaty Gateway  HTTPS protocol

```
export WECHATY_LOG="verbose"
export WECHATY_PUPPET="wechaty-puppet-padlocal"
export WECHATY_PUPPET_PADLOCAL_TOKEN="puppet_padlocal_XXXX"
export WECHATY_PUPPET_SERVICE_NO_SSL_UNSAFE_CLIENT=true
export WECHATY_PUPPET_SERVER_PORT="9001"
export WECHATY_TOKEN="set your gateway token"

docker run -it \
  --name wechaty-gateway-xian-no-ssl \
  --network=public \
  -e WECHATY_LOG \
  -e WECHATY_PUPPET \
  -e WECHATY_PUPPET_PADLOCAL_TOKEN \
  -e WECHATY_PUPPET_SERVER_PORT \
  -e WECHATY_TOKEN \
  -e WECHATY_PUPPET_SERVICE_NO_SSL_UNSAFE_CLIENT \
  -p "$WECHATY_PUPPET_SERVER_PORT:$WECHATY_PUPPET_SERVER_PORT" \
  wechaty/wechaty
```



### Start .NET Wechaty Client
1、Clone dotnet-wechaty-getting-started repository
```
git clone https://github.com/wechaty/dotnet-wechaty-getting-started.git
cd  dotnet-wechaty-getting-started
```

2、install Nuget Package
```
nuget restore 
```

3、Set token for your bot 
open `appsettings.json` set wechaty configuration 

```
  // eg：http://localhost:9002  https://localhost:9002 

  "WECHATY_PUPPET_HOSTIE_TOKEN": "",
  "WECHATY_ENDPOINT": "",
```
 If you are using the HTTP protocol, use https://127.0.0.1:9001


4、Run the  bot
```
visual studio  F5 
# or
dotnet run
```




##  Wechaty Getting Started in Multiple Languages

<https://wechaty.js.org>

[![Wechaty in Python](https://img.shields.io/badge/Wechaty-Python-blue)](https://github.com/wechaty/python-wechaty)
[![Wechaty in Go](https://img.shields.io/badge/Wechaty-Go-7de)](https://github.com/wechaty/go-wechaty)
[![Wechaty in Java](https://img.shields.io/badge/Wechaty-Java-f80)](https://github.com/wechaty/java-wechaty)
[![Wechaty in Scala](https://img.shields.io/badge/Wechaty-Scala-890)](https://github.com/wechaty/scala-wechaty)
[![Wechaty in PHP](https://img.shields.io/badge/Wechaty-PHP-99c)](https://github.com/wechaty/php-wechaty)
[![Wechaty in .NET](https://img.shields.io/badge/Wechaty-.NET-629)](https://github.com/wechaty/dotnet-wechaty)

- [Python Wechaty Getting Started](https://github.com/wechaty/python-wechaty-getting-started)
- [Go Wechaty Getting Started](https://github.com/wechaty/go-wechaty-getting-started)
- [Java Wechaty Getting Started](https://github.com/wechaty/java-wechaty-getting-started)
- [Scala Wechaty Getting Started](https://github.com/wechaty/scala-wechaty-getting-started)
- [PHP Wechaty Getting Started](https://github.com/wechaty/php-wechaty-getting-started)
- [.NET Wechaty Getting Started](https://github.com/wechaty/dotnet-wechaty-getting-started)



## Maintainers

[@wechaty/dotnet](https://github.com/orgs/wechaty/teams/dotnet/members)

## Copyright & License

- Code & Docs © 2018-now Huan and Wechaty Community Contributors (<https://github.com/wechaty>)
- Code released under the Apache-2.0 License
- Docs released under Creative Commons
