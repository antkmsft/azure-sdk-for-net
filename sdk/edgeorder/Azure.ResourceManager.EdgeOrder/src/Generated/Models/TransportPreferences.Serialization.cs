// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    internal partial class TransportPreferences : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("preferredShipmentType");
            writer.WriteStringValue(PreferredShipmentType.ToString());
            writer.WriteEndObject();
        }

        internal static TransportPreferences DeserializeTransportPreferences(JsonElement element)
        {
            TransportShipmentType preferredShipmentType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preferredShipmentType"))
                {
                    preferredShipmentType = new TransportShipmentType(property.Value.GetString());
                    continue;
                }
            }
            return new TransportPreferences(preferredShipmentType);
        }
    }
}
