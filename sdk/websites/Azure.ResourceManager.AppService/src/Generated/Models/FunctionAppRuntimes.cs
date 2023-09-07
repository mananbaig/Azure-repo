// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Function App stack runtimes. </summary>
    public partial class FunctionAppRuntimes
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FunctionAppRuntimes"/>. </summary>
        internal FunctionAppRuntimes()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FunctionAppRuntimes"/>. </summary>
        /// <param name="linuxRuntimeSettings"> Linux-specific settings associated with the minor version. </param>
        /// <param name="windowsRuntimeSettings"> Windows-specific settings associated with the minor version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FunctionAppRuntimes(FunctionAppRuntimeSettings linuxRuntimeSettings, FunctionAppRuntimeSettings windowsRuntimeSettings, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LinuxRuntimeSettings = linuxRuntimeSettings;
            WindowsRuntimeSettings = windowsRuntimeSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Linux-specific settings associated with the minor version. </summary>
        public FunctionAppRuntimeSettings LinuxRuntimeSettings { get; }
        /// <summary> Windows-specific settings associated with the minor version. </summary>
        public FunctionAppRuntimeSettings WindowsRuntimeSettings { get; }
    }
}
