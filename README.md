# SonarrSharp
C# Sonarr API wrapper. Still in a beta phase.

## Installation
Available as a NuGet package:
```
PM> Install-Package SonarrSharp
```

## Compatibility
.NET framework, .NET core and Xamarin

## Usage
These are some examples on how to use the API. All methods are async/awaitable.

Create the client
```c#
var sonarrClient = new SonarrClient("127.0.0.1", 8989, "apiKey");
```

Get all series
```c#
var series = await sonarrClient.Series.GetSeries();
foreach (var serie in series)
{
    Console.WriteLine($"{serie.Title}");
}
```

Search for all episodes in a series
```c#
var command = await.sonarrClient.SeriesSearch(123);

// Get status of command
Console.WriteLine($"{command.Name}: {command.State}");
```
