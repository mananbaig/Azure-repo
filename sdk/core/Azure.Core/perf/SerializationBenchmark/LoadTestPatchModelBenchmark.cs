﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.Core.Serialization;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Azure.Core.Perf
{
    public class LoadTestPatchModelBenchmark : SerializationBenchmark<Developer.LoadTesting.Models.Test>
    {
        protected override void Serialize(Utf8JsonWriter writer)
        {
            _model.Serialize(writer);
        }

        protected override RequestContent CastToRequestContent()
        {
            return _model;
        }

        protected override Developer.LoadTesting.Models.Test CastFromResponse()
        {
            return (Developer.LoadTesting.Models.Test)_response;
        }

        protected override Developer.LoadTesting.Models.Test Deserialize(JsonElement jsonElement)
        {
            throw new System.NotImplementedException();
        }

        protected override Developer.LoadTesting.Models.Test Deserialize(BinaryData binaryData)
        {
            return (Developer.LoadTesting.Models.Test)((IModelSerializable)_model).Deserialize(binaryData, ModelSerializerOptions.AzureServiceDefault);
        }

        protected override string JsonFileName => "LoadTestPatchModel.json";
    }
}
