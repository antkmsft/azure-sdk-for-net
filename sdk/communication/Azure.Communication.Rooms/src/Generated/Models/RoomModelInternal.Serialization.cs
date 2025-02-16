// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Rooms
{
    internal partial class RoomModelInternal
    {
        internal static RoomModelInternal DeserializeRoomModelInternal(JsonElement element)
        {
            Optional<string> id = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<DateTimeOffset> validFrom = default;
            Optional<DateTimeOffset> validUntil = default;
            Optional<RoomJoinPolicy> roomJoinPolicy = default;
            Optional<IReadOnlyList<RoomParticipantInternal>> participants = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("validFrom"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    validFrom = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("validUntil"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    validUntil = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("roomJoinPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    roomJoinPolicy = new RoomJoinPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("participants"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RoomParticipantInternal> array = new List<RoomParticipantInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoomParticipantInternal.DeserializeRoomParticipantInternal(item));
                    }
                    participants = array;
                    continue;
                }
            }
            return new RoomModelInternal(id.Value, Optional.ToNullable(createdDateTime), Optional.ToNullable(validFrom), Optional.ToNullable(validUntil), Optional.ToNullable(roomJoinPolicy), Optional.ToList(participants));
        }
    }
}
