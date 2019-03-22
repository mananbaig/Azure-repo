﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Base.Http;
using Azure.Base.Http.Pipeline;

namespace Azure.ApplicationModel.Configuration
{
    internal class ClientRequestIdPolicy : HttpPipelinePolicy
    {
        const string ClientRequestIdHeader = "x-ms-client-request-id";
        const string EchoClientRequestId = "x-ms-return-client-request-id";

        public override async Task ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            message.AddHeader(ClientRequestIdHeader, Guid.NewGuid().ToString());
            message.AddHeader(EchoClientRequestId, "true");

            await ProcessNextAsync(pipeline, message);
        }
    }
}