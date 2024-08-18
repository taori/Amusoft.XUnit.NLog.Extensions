# Amusoft.XUnit.NLog.Extensions

## Description

This extension allows you to derive your tests from LoggedTestBase which will automatically link NLog with XUnitTestOutputHelper

By adding nlog.config to your test project with this content

```xml
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
      throwExceptions="true">
	<extensions>
		<add assembly="Amusoft.XUnit.NLog.Extensions" />
	</extensions>
	<variable name="loggingLayout" value="${time}|${level:uppercase=true}|${logger}|${message}"/>

	<targets async="false">
		<target xsi:type="XUnitOutputTarget"
		        layout="${loggingLayout}"
		        name="XUnitTestOutput" />
		<target xsi:type="Console" name="console"/>
	</targets>

	<rules>
		<logger name="*" minlevel="Warn" writeTo="console,XUnitTestOutput" />
	</rules>

</nlog>
```

you will now receive log output from your actual library classes

## Project state

[![.GitHub](https://github.com/taori/Amusoft.XUnit.NLog.Extensions/actions/workflows/dotnet.yml/badge.svg)](https://github.com/taori/Amusoft.XUnit.NLog.Extensions/actions/workflows/dotnet.yml)
[![GitHub issues](https://img.shields.io/github/issues/taori/Amusoft.XUnit.NLog.Extensions)](https://github.com/taori/Amusoft.XUnit.NLog.Extensions/issues)
[![NuGet version (Amusoft.XUnit.NLog.Extensions)](https://img.shields.io/nuget/v/Amusoft.XUnit.NLog.Extensions.svg)](https://www.nuget.org/packages/Amusoft.XUnit.NLog.Extensions/)

<!--CoverageStart-->
![Code Coverage](https://img.shields.io/badge/Code%20Coverage-100%25-success?style=flat)

Package | Line Rate | Branch Rate | Health
-------- | --------- | ----------- | ------
Amusoft.XUnit.NLog.Extensions | 100% | 100% | ✔
**Summary** | **100%** (6 / 6) | **100%** (0 / 0) | ✔

_Minimum allowed line rate is 85%_

[Coverage details](https://taori.github.io/Amusoft.XUnit.NLog.Extensions)
<!--CoverageEnd-->

