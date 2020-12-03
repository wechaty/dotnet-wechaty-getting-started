# dotnet-wechaty-getting-started [![Powered by Wechaty](https://img.shields.io/badge/Powered%20By-Wechaty-brightgreen.svg)](https://github.com/wechaty/dotnet-wechaty)

![Dotnet Wechaty](https://raw.githubusercontent.com/wechaty/dotnet-wechaty/master/docs/images/dotnet-wechaty.png)

## Quick Start


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
  "WECHATY_PUPPET": "wechaty-puppet-hostie",
  "WECHATY_PUPPET_HOSTIE_TOKEN": "",
```


4、Run the  bot
```
visual studio  F5 
# or
dotnet run
```

### Docker 


1、docker pull
```
docker pull  richpeople/dotnet-wechaty
```

2、docker  run
```
docker run -ti  --name dotnet-wechaty \ 
-e WECHATY_PUPPET="wechaty-puppet-hostie" \
-e WECHATY_PUPPET_HOSTIE_TOKEN="" \
-e TZ="Asia/Shanghai" \
richpeople/dotnet-wechaty
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