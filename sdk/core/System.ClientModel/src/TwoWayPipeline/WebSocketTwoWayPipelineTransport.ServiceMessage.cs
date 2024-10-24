﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace System.ClientModel.Primitives.TwoWayPipeline;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public partial class WebSocketTwoWayPipelineTransport
{
    private sealed class WebSocketTransportServiceMessage : TwoWayPipelineServiceMessage
    {
        public override int Status => throw new NotImplementedException();

        public override BinaryData Content => throw new NotImplementedException();
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
