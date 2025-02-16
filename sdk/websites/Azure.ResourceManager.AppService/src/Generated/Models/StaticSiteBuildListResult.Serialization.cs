// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class StaticSiteBuildListResult
    {
        internal static StaticSiteBuildListResult DeserializeStaticSiteBuildListResult(JsonElement element)
        {
            IReadOnlyList<StaticSiteBuildData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<StaticSiteBuildData> array = new List<StaticSiteBuildData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticSiteBuildData.DeserializeStaticSiteBuildData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new StaticSiteBuildListResult(value, nextLink.Value);
        }
    }
}
