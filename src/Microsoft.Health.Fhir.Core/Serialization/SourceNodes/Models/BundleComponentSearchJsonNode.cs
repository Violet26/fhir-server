﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace Microsoft.Health.Fhir.Core.Serialization.SourceNodes.Models
{
    public class BundleComponentSearchJsonNode
    {
        [JsonPropertyName("mode")]
        public string Mode { get; set; }
    }
}