// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class RunQueryOrderBy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("orderBy");
            writer.WriteStringValue(OrderBy.ToString());
            writer.WritePropertyName("order");
            writer.WriteStringValue(Order.ToString());
            writer.WriteEndObject();
        }
    }
}
