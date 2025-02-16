// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicSku
    {
        internal static LogicSku DeserializeLogicSku(JsonElement element)
        {
            LogicSkuName name = default;
            Optional<LogicResourceReference> plan = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = new LogicSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("plan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    plan = LogicResourceReference.DeserializeLogicResourceReference(property.Value);
                    continue;
                }
            }
            return new LogicSku(name, plan.Value);
        }
    }
}
