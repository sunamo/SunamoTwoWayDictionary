# SunamoTwoWayDictionary

A bidirectional dictionary for .NET that maintains forward and reverse mappings, allowing lookup in both directions.

## Features

- **Bidirectional lookup** - store key-value pairs and look up by either key or value
- **Type-safe generics** - supports any `notnull` types for both keys and values
- **Capacity constructor** - pre-allocate capacity for known collection sizes

## Usage

```csharp
var dictionary = new TwoWayDictionary<string, int>();
dictionary.Add("one", 1);
dictionary.Add("two", 2);

// Forward lookup (string -> int)
int value = dictionary.ForwardDictionary["one"]; // 1

// Reverse lookup (int -> string)
string key = dictionary.ReverseDictionary[2]; // "two"
```

## Installation

```bash
dotnet add package SunamoTwoWayDictionary
```

## Target Frameworks

`net10.0`, `net9.0`, `net8.0`

## Links

- [NuGet](https://www.nuget.org/profiles/sunamo)
- [GitHub](https://github.com/sunamo/PlatformIndependentNuGetPackages)
- [Developer site](https://sunamo.cz)

## License

MIT
