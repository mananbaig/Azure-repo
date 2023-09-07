// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> List all existing live pipelines. </summary>
    public partial class LivePipelineListRequest : MethodRequest
    {
        /// <summary> Initializes a new instance of <see cref="LivePipelineListRequest"/>. </summary>
        public LivePipelineListRequest()
        {
            MethodName = "livePipelineList";
        }

        /// <summary> Initializes a new instance of <see cref="LivePipelineListRequest"/>. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LivePipelineListRequest(string methodName, string apiVersion, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(methodName, apiVersion, serializedAdditionalRawData)
        {
            MethodName = methodName ?? "livePipelineList";
        }
    }
}
