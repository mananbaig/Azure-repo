// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Deletes an existing remote device adapter. </summary>
    public partial class RemoteDeviceAdapterDeleteRequest : MethodRequestEmptyBodyBase
    {
        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapterDeleteRequest"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public RemoteDeviceAdapterDeleteRequest(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            MethodName = "remoteDeviceAdapterDelete";
        }

        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapterDeleteRequest"/>. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RemoteDeviceAdapterDeleteRequest(string methodName, string apiVersion, string name, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(methodName, apiVersion, name, serializedAdditionalRawData)
        {
            MethodName = methodName ?? "remoteDeviceAdapterDelete";
        }

        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapterDeleteRequest"/> for deserialization. </summary>
        internal RemoteDeviceAdapterDeleteRequest()
        {
        }
    }
}
