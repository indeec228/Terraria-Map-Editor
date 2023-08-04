﻿using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using TEdit.Geometry;

namespace TEdit.Common.Serialization;

public class Vector3Int32JsonConverter : JsonConverter<Vector3Int32>
{
    public override Vector3Int32 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray) { throw new JsonException(); }

        Vector3Int32 value = default;

        int ix = 0;
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray) { return value; }

            if (ix == 0) value.X = reader.GetInt32();
            if (ix == 1) value.Y = reader.GetInt32();
            if (ix == 2) value.Z = reader.GetInt32();

            ix++;
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, Vector3Int32 value, JsonSerializerOptions options) =>
        writer.WriteRawValue($"[{value.X:0},{value.Y:0},{value.Z:0}]", true);
}
