[![Build Status](https://ci.appveyor.com/api/projects/status/x822m4m7t5mfy63m?svg=true)](https://ci.appveyor.com/project/RaYell/suppress)
[![Build Status](https://travis-ci.org/Softlr/Suppress.svg?branch=develop)](https://travis-ci.org/Softlr/Suppress)
[![Quality Gate](https://sonarcloud.io/api/project_badges/measure?project=softlr.suppress&metric=alert_status)](https://sonarcloud.io/dashboard?id=softlr.suppress)

# Description
This library allows easy suppression of C# code analyzers warnings by defining a bunch of contants for all of the rules. The following analyzers are supported:

* [SonarQube](https://www.sonarqube.org/)
* [FxCop](https://msdn.microsoft.com/en-us/library/bb429476.aspx)
* [StyleCop.Analyzers](https://github.com/DotNetAnalyzers/StyleCopAnalyzers)
* [CodeCracker](https://github.com/code-cracker/code-cracker)

# Known limitations
[ReSharper](https://www.jetbrains.com/resharper/) rules cannot be suppressed with constants defined this way, this is [by design](https://stackoverflow.com/questions/44652818/why-cant-i-use-constants-in-suppressmessage-together-with-resharper).

# Installation
Run the following command in Visual Studio Package Manager Console.
```posh
Install-Package Softlr.Suppress
```

# Usage
Simply reference specific constant from the `Softlr.Suppress` class in `SuppressMessageAttribute` like so

```csharp
using System.Diagnostics.CodeAnalysis;

[SuppressMessage(Softl.Suppress.CODE_CRACKER, Softlr.Suppress.CC0001)]
[SuppressMessage(Softl.Suppress.FXCOP, Softlr.Suppress.CA1000)]
[SuppressMessage(Softl.Suppress.SONARQUBE, Softlr.Suppress.S100)]
[SuppressMessage(Softl.Suppress.STYLECOP, Softlr.Suppress.SA1001)]
public class MyClass
{
    // ...
}
```

or use the `using static` to import all constants

```csharp
using System.Diagnostics.CodeAnalysis;
using static Softlr.Suppress;

[SuppressMessage(CODE_CRACKER, CC0001)]
[SuppressMessage(FXCOP, CA1000)]
[SuppressMessage(SONARQUBE, S100)]
[SuppressMessage(STYLECOP, SA1001)]
public class MyClass
{
    // ...
}
```

or, if you are using C# 10 or newer (net6.0+) you can declare the suppression constants as global and not have to reference it again in every file where you need to use any of the constants.

```csharp
global using System.Diagnostics.CodeAnalysis;
global using static Softlr.Suppress;

[SuppressMessage(CODE_CRACKER, CC0001)]
[SuppressMessage(FXCOP, CA1000)]
[SuppressMessage(SONARQUBE, S100)]
[SuppressMessage(STYLECOP, SA1001)]
public class MyClass
{
    // ...
}
```

When referencing `Softlr.Suppress` library in a project that creates a NuGet package the reference for this library doesn't need to be defined as a NuGet dependency.
If you are generating NuGet packages with project files, this can be achieved with `PrivateAssets` metadata.

```
<PackageReference Include="Softlr.Suppress" Version="1.0.0">
    <PrivateAssets>all</PrivateAssets>
</PackageReference>
```