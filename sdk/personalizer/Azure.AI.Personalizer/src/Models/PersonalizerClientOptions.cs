// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Personalizer
{
    /// <summary> Client options for PersonalizerClient. </summary>
    public partial class PersonalizerClientOptions : ClientOptions
    {
        private bool isLocalInference;
        private float subsampleRate;

        /// <summary> Initializes new instance of PersonalizerClientV1Preview3ClientOptions. </summary>
        public PersonalizerClientOptions(ServiceVersion version = LatestVersion, bool isLocalInference = false, float subsampleRate = 1)
        {
            this.isLocalInference = isLocalInference;
            this.subsampleRate = subsampleRate;

            Version = version switch
            {
                ServiceVersion.V1_1_preview_3 => "v1.1-preview.3",
                _ => throw new NotSupportedException()
            };

            Retry.NetworkTimeout = TimeSpan.FromMinutes(8);
        }

        internal float SubsampleRate { get => subsampleRate; }
        internal bool IsLocalInference { get => isLocalInference; }
    }
}
