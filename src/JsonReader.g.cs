// Copyright (c) 2021 Atif Aziz.
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

//------------------------------------------------------------------------------
// This code was generated by a tool.
// Changes to this file will be lost if the code is re-generated.
//------------------------------------------------------------------------------

namespace JsonR;

using System;
using System.Text.Json;

partial class JsonReader
{
    public static IJsonReader<byte, JsonR.ReadResult<byte>> Byte() =>
        Create((ref Utf8JsonReader rdr) => rdr.TokenType == JsonTokenType.Number && rdr.TryGetByte(out var value)
                                         ? Value(value)
                                         : Error("Invalid JSON value; expecting a JSON number compatible with Byte."));

    public static IJsonReader<ushort, JsonR.ReadResult<ushort>> UInt16() =>
        Create((ref Utf8JsonReader rdr) => rdr.TokenType == JsonTokenType.Number && rdr.TryGetUInt16(out var value)
                                         ? Value(value)
                                         : Error("Invalid JSON value; expecting a JSON number compatible with UInt16."));

    public static IJsonReader<uint, JsonR.ReadResult<uint>> UInt32() =>
        Create((ref Utf8JsonReader rdr) => rdr.TokenType == JsonTokenType.Number && rdr.TryGetUInt32(out var value)
                                         ? Value(value)
                                         : Error("Invalid JSON value; expecting a JSON number compatible with UInt32."));

    public static IJsonReader<ulong, JsonR.ReadResult<ulong>> UInt64() =>
        Create((ref Utf8JsonReader rdr) => rdr.TokenType == JsonTokenType.Number && rdr.TryGetUInt64(out var value)
                                         ? Value(value)
                                         : Error("Invalid JSON value; expecting a JSON number compatible with UInt64."));

    public static IJsonReader<double, JsonR.ReadResult<double>> Double() =>
        Create((ref Utf8JsonReader rdr) => rdr.TokenType == JsonTokenType.Number && rdr.TryGetDouble(out var value)
                                         ? Value(value)
                                         : Error("Invalid JSON value; expecting a JSON number compatible with Double."));

    public static IJsonReader<float, JsonR.ReadResult<float>> Single() =>
        Create((ref Utf8JsonReader rdr) => rdr.TokenType == JsonTokenType.Number && rdr.TryGetSingle(out var value)
                                         ? Value(value)
                                         : Error("Invalid JSON value; expecting a JSON number compatible with Single."));

    public static IJsonReader<int, JsonR.ReadResult<int>> Int32() =>
        Create((ref Utf8JsonReader rdr) => rdr.TokenType == JsonTokenType.Number && rdr.TryGetInt32(out var value)
                                         ? Value(value)
                                         : Error("Invalid JSON value; expecting a JSON number compatible with Int32."));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2,
            Func<T1, T2, TResult> projector) =>
        Object(property1, property2,
                NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance,
                (v1, v2, _, _, _, _, _, _, _, _, _, _, _, _, _, _) =>
            projector(v1, v2));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3,
            Func<T1, T2, T3, TResult> projector) =>
        Object(property1, property2, property3,
                NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance,
                (v1, v2, v3, _, _, _, _, _, _, _, _, _, _, _, _, _) =>
            projector(v1, v2, v3));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, T4, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3, IJsonProperty<T4, JsonR.ReadResult<T4>> property4,
            Func<T1, T2, T3, T4, TResult> projector) =>
        Object(property1, property2, property3, property4,
                NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance,
                (v1, v2, v3, v4, _, _, _, _, _, _, _, _, _, _, _, _) =>
            projector(v1, v2, v3, v4));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, T4, T5, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3, IJsonProperty<T4, JsonR.ReadResult<T4>> property4, IJsonProperty<T5, JsonR.ReadResult<T5>> property5,
            Func<T1, T2, T3, T4, T5, TResult> projector) =>
        Object(property1, property2, property3, property4, property5,
                NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance,
                (v1, v2, v3, v4, v5, _, _, _, _, _, _, _, _, _, _, _) =>
            projector(v1, v2, v3, v4, v5));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, T4, T5, T6, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3, IJsonProperty<T4, JsonR.ReadResult<T4>> property4, IJsonProperty<T5, JsonR.ReadResult<T5>> property5, IJsonProperty<T6, JsonR.ReadResult<T6>> property6,
            Func<T1, T2, T3, T4, T5, T6, TResult> projector) =>
        Object(property1, property2, property3, property4, property5, property6,
                NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance,
                (v1, v2, v3, v4, v5, v6, _, _, _, _, _, _, _, _, _, _) =>
            projector(v1, v2, v3, v4, v5, v6));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, T4, T5, T6, T7, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3, IJsonProperty<T4, JsonR.ReadResult<T4>> property4, IJsonProperty<T5, JsonR.ReadResult<T5>> property5, IJsonProperty<T6, JsonR.ReadResult<T6>> property6, IJsonProperty<T7, JsonR.ReadResult<T7>> property7,
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> projector) =>
        Object(property1, property2, property3, property4, property5, property6, property7,
                NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance,
                (v1, v2, v3, v4, v5, v6, v7, _, _, _, _, _, _, _, _, _) =>
            projector(v1, v2, v3, v4, v5, v6, v7));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3, IJsonProperty<T4, JsonR.ReadResult<T4>> property4, IJsonProperty<T5, JsonR.ReadResult<T5>> property5, IJsonProperty<T6, JsonR.ReadResult<T6>> property6, IJsonProperty<T7, JsonR.ReadResult<T7>> property7, IJsonProperty<T8, JsonR.ReadResult<T8>> property8,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> projector) =>
        Object(property1, property2, property3, property4, property5, property6, property7, property8,
                NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance,
                (v1, v2, v3, v4, v5, v6, v7, v8, _, _, _, _, _, _, _, _) =>
            projector(v1, v2, v3, v4, v5, v6, v7, v8));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3, IJsonProperty<T4, JsonR.ReadResult<T4>> property4, IJsonProperty<T5, JsonR.ReadResult<T5>> property5, IJsonProperty<T6, JsonR.ReadResult<T6>> property6, IJsonProperty<T7, JsonR.ReadResult<T7>> property7, IJsonProperty<T8, JsonR.ReadResult<T8>> property8, IJsonProperty<T9, JsonR.ReadResult<T9>> property9,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> projector) =>
        Object(property1, property2, property3, property4, property5, property6, property7, property8, property9,
                NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance,
                (v1, v2, v3, v4, v5, v6, v7, v8, v9, _, _, _, _, _, _, _) =>
            projector(v1, v2, v3, v4, v5, v6, v7, v8, v9));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3, IJsonProperty<T4, JsonR.ReadResult<T4>> property4, IJsonProperty<T5, JsonR.ReadResult<T5>> property5, IJsonProperty<T6, JsonR.ReadResult<T6>> property6, IJsonProperty<T7, JsonR.ReadResult<T7>> property7, IJsonProperty<T8, JsonR.ReadResult<T8>> property8, IJsonProperty<T9, JsonR.ReadResult<T9>> property9, IJsonProperty<T10, JsonR.ReadResult<T10>> property10,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> projector) =>
        Object(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10,
                NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance,
                (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, _, _, _, _, _, _) =>
            projector(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3, IJsonProperty<T4, JsonR.ReadResult<T4>> property4, IJsonProperty<T5, JsonR.ReadResult<T5>> property5, IJsonProperty<T6, JsonR.ReadResult<T6>> property6, IJsonProperty<T7, JsonR.ReadResult<T7>> property7, IJsonProperty<T8, JsonR.ReadResult<T8>> property8, IJsonProperty<T9, JsonR.ReadResult<T9>> property9, IJsonProperty<T10, JsonR.ReadResult<T10>> property10, IJsonProperty<T11, JsonR.ReadResult<T11>> property11,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> projector) =>
        Object(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11,
                NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance,
                (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, _, _, _, _, _) =>
            projector(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3, IJsonProperty<T4, JsonR.ReadResult<T4>> property4, IJsonProperty<T5, JsonR.ReadResult<T5>> property5, IJsonProperty<T6, JsonR.ReadResult<T6>> property6, IJsonProperty<T7, JsonR.ReadResult<T7>> property7, IJsonProperty<T8, JsonR.ReadResult<T8>> property8, IJsonProperty<T9, JsonR.ReadResult<T9>> property9, IJsonProperty<T10, JsonR.ReadResult<T10>> property10, IJsonProperty<T11, JsonR.ReadResult<T11>> property11, IJsonProperty<T12, JsonR.ReadResult<T12>> property12,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> projector) =>
        Object(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12,
                NonProperty.Instance, NonProperty.Instance, NonProperty.Instance, NonProperty.Instance,
                (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, _, _, _, _) =>
            projector(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3, IJsonProperty<T4, JsonR.ReadResult<T4>> property4, IJsonProperty<T5, JsonR.ReadResult<T5>> property5, IJsonProperty<T6, JsonR.ReadResult<T6>> property6, IJsonProperty<T7, JsonR.ReadResult<T7>> property7, IJsonProperty<T8, JsonR.ReadResult<T8>> property8, IJsonProperty<T9, JsonR.ReadResult<T9>> property9, IJsonProperty<T10, JsonR.ReadResult<T10>> property10, IJsonProperty<T11, JsonR.ReadResult<T11>> property11, IJsonProperty<T12, JsonR.ReadResult<T12>> property12, IJsonProperty<T13, JsonR.ReadResult<T13>> property13,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> projector) =>
        Object(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12, property13,
                NonProperty.Instance, NonProperty.Instance, NonProperty.Instance,
                (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, _, _, _) =>
            projector(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3, IJsonProperty<T4, JsonR.ReadResult<T4>> property4, IJsonProperty<T5, JsonR.ReadResult<T5>> property5, IJsonProperty<T6, JsonR.ReadResult<T6>> property6, IJsonProperty<T7, JsonR.ReadResult<T7>> property7, IJsonProperty<T8, JsonR.ReadResult<T8>> property8, IJsonProperty<T9, JsonR.ReadResult<T9>> property9, IJsonProperty<T10, JsonR.ReadResult<T10>> property10, IJsonProperty<T11, JsonR.ReadResult<T11>> property11, IJsonProperty<T12, JsonR.ReadResult<T12>> property12, IJsonProperty<T13, JsonR.ReadResult<T13>> property13, IJsonProperty<T14, JsonR.ReadResult<T14>> property14,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> projector) =>
        Object(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12, property13, property14,
                NonProperty.Instance, NonProperty.Instance,
                (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, _, _) =>
            projector(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14));

    /// <remarks>
    /// Properties without a default value that are missing from the read JSON object will cause
    /// <see cref="JsonException"/> to be thrown.
    /// </remarks>
    public static IJsonReader<TResult, JsonR.ReadResult<TResult>>
        Object<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            IJsonProperty<T1, JsonR.ReadResult<T1>> property1, IJsonProperty<T2, JsonR.ReadResult<T2>> property2, IJsonProperty<T3, JsonR.ReadResult<T3>> property3, IJsonProperty<T4, JsonR.ReadResult<T4>> property4, IJsonProperty<T5, JsonR.ReadResult<T5>> property5, IJsonProperty<T6, JsonR.ReadResult<T6>> property6, IJsonProperty<T7, JsonR.ReadResult<T7>> property7, IJsonProperty<T8, JsonR.ReadResult<T8>> property8, IJsonProperty<T9, JsonR.ReadResult<T9>> property9, IJsonProperty<T10, JsonR.ReadResult<T10>> property10, IJsonProperty<T11, JsonR.ReadResult<T11>> property11, IJsonProperty<T12, JsonR.ReadResult<T12>> property12, IJsonProperty<T13, JsonR.ReadResult<T13>> property13, IJsonProperty<T14, JsonR.ReadResult<T14>> property14, IJsonProperty<T15, JsonR.ReadResult<T15>> property15,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> projector) =>
        Object(property1, property2, property3, property4, property5, property6, property7, property8, property9, property10, property11, property12, property13, property14, property15,
                NonProperty.Instance,
                (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, _) =>
            projector(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15));
}
