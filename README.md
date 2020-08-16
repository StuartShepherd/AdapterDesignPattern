# Adapter Example
Adapter is a structural design pattern, which allows incompatible objects to collaborate.

The Adapter acts as a wrapper between two objects. It catches calls for one object and transforms them to format and interface recognizable by the second object.

## Usage examples
The Adapter pattern is pretty common in C# code. It’s very often used in systems based on some legacy code. In such cases, Adapters make legacy code with modern classes.

## Identification
Adapter is recognizable by a constructor which takes an instance of a different abstract/interface type. When the adapter receives a call to any of its methods, it translates parameters to the appropriate format and then directs the call to one or several methods of the wrapped object.

## Applicability
Use the Adapter class when you want to use some existing class, but its interface isn’t compatible with the rest of your code.

Use the pattern when you want to reuse several existing subclasses that lack some common functionality that can’t be added to the superclass.

## Getting Started

### Prerequisites

[.NET Core 3.1 SDK or later](https://dotnet.microsoft.com/download/dotnet-core/3.1)