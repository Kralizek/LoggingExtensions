[![Buy me a pizza!](https://img.buymeacoffee.com/button-api/?text=Buy%20me%20a%20pizza&emoji=🍕&slug=rengol&button_colour=FFDD00&font_colour=000000&font_family=Cookie&outline_colour=000000&coffee_colour=ffffff)](https://www.buymeacoffee.com/rengol)

[![Build status](https://ci.appveyor.com/api/projects/status/p1ldsq86v38cgu5d?svg=true)](https://ci.appveyor.com/project/Kralizek/loggingextensions) [![NuGet version](https://img.shields.io/nuget/vpre/Kralizek.Extensions.Logging.svg)](https://www.nuget.org/packages/Kralizek.Extensions.Logging)

# Kralizek.Extensions.Logging

This package contains a set of extension methods designed to improve logging using `ILogger<T>` in .NET projects.

The extension methods use generics to avoid boxing of the logging values and check the logging level before unboxing them.

Further more, the extension methods are placed in the same namespace of `ILogger<T>`, once the package is installed, all your methods will automatically be using them.

## How to use it

You can install the package using the .NET SDK CLI

```bash
$ dotnet add package Kralizek.Extensions.Logging
```

Now you keep logging as usual.

```csharp
public class MyService(ILogger<MyService> logger) : IService
{
    public void DoSomething(int value)
    {
        logger.LogInformation("I'm doing something: {Value}", value);
    }
}
```

## How does it work?

The library relies on the C# compiler overload resolution algorithm to make sure that calls like the one above are routed to the extension methods instead of the default one whose signature is `LogInformation(this ILogger logger, string? message, params object?[] args)`.

## Gotchas

The library improves old-style logging. Across several releases, Microsoft has added more ways to generate efficient logging statements like [using `LoggerMessage`](https://learn.microsoft.com/en-us/dotnet/core/extensions/logger-message-generator). Consider reading this article by Microsoft regarding [high-performance logging in .NET](https://learn.microsoft.com/en-us/dotnet/core/extensions/high-performance-logging).

The library only handles typical green-path scenarios. Currently there are no extension methods accepting either instances of `EventId` or `Exception`. If this is important, feel free to create a feature request.

## Credits

This library implements the suggestions by Nick Chapsas in his video [You are doing .NET logging wrong. Let's fix it](https://www.youtube.com/watch?v=bnVfrd3lRv8).

## Versioning

This library follows [Semantic Versioning 2.0.0](http://semver.org/spec/v2.0.0.html) for the public releases (published to the [nuget.org](https://www.nuget.org/)).

## How to build

This project uses [Cake](https://cakebuild.net/) as a build engine.

If you would like to build this project locally, just execute the `build.cake` script.

You can do it by using the .NET tool created by CAKE authors and use it to execute the build script.

```powershell
dotnet tool install -g Cake.Tool
dotnet cake
```




