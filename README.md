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
Simply reference specific constant from the `Softlr.Suppress` class in `SuppressMessageAttribute` like so:

```csharp
using System.Diagnostics.CodeAnalysis;

[SuppressMessage(Softl.Suppress.SONARQUBE, Softl.Suppress.S4018)]
public class MyClass
{
    // ...
}
```

or for even better syntax use the `using static` to import all constants.

```csharp
using System.Diagnostics.CodeAnalysis;
using static Softlr.Suppress;

[SuppressMessage(SONARQUBE, S4018)]
public class MyClass
{
    // ...
}
```
