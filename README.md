# Jacob

Jacob provides a succinct JSON combinator API over `Utf8JsonReader` for
deserializing/reading JSON data.

.NET Core 3.0 introduced [`Utf8JsonReader`], a high-performance, low-allocation,
forward-only reader for JSON text encoded in UTF-8. It is a low-level type for
building custom parsers and deserializers and because it has _low-level_
semantics, its API is not very straightforward to use. It's far more common
instead to see developers create simple classes that mirror the JSON data and
then use [`JsonSerializer`] to deserialize/read the JSON data into instances of
those classes. However, when your application or domain object model is far
richer than the values types available in JSON, you need to customize the
deserialization by writing and registering a [`JsonConverter`] that requires a
non-trivial amount of coding and understanding, not to mention having to work
with `Utf8JsonReader` and writing unit tests for each converter. Moreover, the
converters you create are not immediately reusable and composable (in an ad-hoc
manner or otherwise) without considerable effort. Jacob provides most of the
benefits of `Utf8JsonReader`, such as low-allocation, without all the ceremony
and complexity associated.

## Usage

All of the following examples assume these imports:

```c#
using System;
using System.Collections.Generic;
using Jacob;
```

Further more, to make the JSON data easier to read when encoded as C# literals,
e.g. by permitting single-quoted strings and unquoted JSON object member name so
double-quotes don't need escaping, the example assume the following helper
method is defined:

```c#
static class Json
{
    /// <summary>
    /// Takes somewhat non-conforming JSON
    /// (<a href="https://github.com/JamesNK/Newtonsoft.Json/issues/646#issuecomment-356194475">as accepted by Json.NET</a>)
    /// text and re-formats it to be strictly conforming to RFC 7159.
    /// </summary>
    public static string Strictify(string json) =>
        JToken.Parse(json).ToString(Formatting.None);
}
```

Reading a JSON number as an `int` in C# (or `System.Int32`):

```c#
var x = JsonReader.Int32().Read("42");
Console.WriteLine(x);
```

Reading a JSON string as a .NET string:

```c#
var s = JsonReader.String().Read(Json.Strictify("'foobar'"));
Console.WriteLine(s);
```

Note the use of `Json.Strictify` defined and mentioned earlier so the JSON
string `"foobar"` can be expressed in C# as `"'foobar'"` rather than
`"\"foobar\""` or `@"""foobar"""`.

Deserializing simple types like a string or an integer is pretty straightforward
and can be done with [`JsonSerializer.Deserialize`][deserialize] with equal
ease:

```c#
var x = JsonSerializer.Deserialize<int>("42");
Console.WriteLine(x);

var s = JsonSerializer.Deserialize<string>(Json.Strictify("'foobar'"));
Console.WriteLine(s);
```

The next example shows the benefits of a compositional API. It demonstrates is
how to read a tuple of string and integer expressed in JSON as an array of two
elements:

```c#
var (key, value) =
    JsonReader.Tuple(JsonReader.String(), JsonReader.Int32())
              .Read(Json.Strictify("['foobar', 42]"));
Console.WriteLine($"Key = {key}, Value = {value}");
```

Note how `JsonReader.Tuple` builds on top of the string and integer reader
introduced in previous examples. By supplying those readers as arguments, the
tuple reader then knows how to read each item of the tuple. The tuple reader
also knows to expect only a JSON array of two elements, so if more are supplied,
as in `["foobar", 42, null]` then it will produce the following error:

    Invalid JSON value; JSON array has too many values. See token "Null" at offset 13.

Attempting to do the same with `JsonSerializer.Deserialize` (assuming .NET 6):

```c#
var json = Json.Strictify("['foobar', 42]");
var (key, value) = JsonSerializer.Deserialize<(string, int)>(json);
Console.WriteLine($"Key = {key}, Value = {value}");
```

fails with the error:

    The JSON value could not be converted to System.ValueTuple`2[System.String,System.Int32]. Path: $ | LineNumber: 0 | BytePositionInLine: 1.

and this is where a custom [`JsonConverter`] implementation would be needed that knows how to deserialize a tuple of a string and an integer from a JSON array.

Once a reader is initialized, it can be reused:

```c#
var reader = JsonReader.Tuple(JsonReader.String(), JsonReader.Int32());

foreach (var json in new[]
            {
                "['foo', 123]",
                "['bar', 456]",
                "['baz', 789]",
            })
{
    json = Json.Strictify(json);
    var (key, value) = reader.Read(json);
    Console.WriteLine($"Key = {key}, Value = {value}");
}
```

Jacob also enables use to LINQ so you can read a value as one type and project
it to a value of another type:

```c#
    var reader =
        from t in JsonReader.Tuple(JsonReader.String(), JsonReader.Int32())
        select KeyValuePair.Create(t.Item1, t.Item2);

    var pair = reader.Read(Json.Strictify("['foobar', 42]"));
    Console.WriteLine(pair);
```

Here, a tuple `(string, int)` is converted to a `KeyValuePair<string, int>`.
Again, this demonstrates how readers just compose with one another. In the same vein, if an array of key-value pairs is what's needed, then it's just another composition away (this time, with `JsonReader.Array`):

```c#
var pairReader =
    from t in JsonReader.Tuple(JsonReader.String(), JsonReader.Int32())
    select KeyValuePair.Create(t.Item1, t.Item2);

const string json = @"[
    ['foo', 123],
    ['bar', 456],
    ['baz', 789]
]";

var pairs = JsonReader.Array(pairReader).Read(Json.Strictify(json));

foreach (var (key, value) in pairs)
    Console.WriteLine($"Key = {key}, Value = {value}");
```


[`Utf8JsonReader`]: https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-use-dom-utf8jsonreader-utf8jsonwriter?pivots=dotnet-6-0#use-utf8jsonreader
[`JsonSerializer`]: https://docs.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializer
[`JsonConverter`]: https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter?view=net-6.0
[x-strict-json]: https://github.com/JamesNK/Newtonsoft.Json/issues/646#issuecomment-356194475
[deserialize]: https://docs.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializer.deserialize?view=net-6.0
