// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Text settings. </summary>
    internal partial class LogFileSettingsText : LogFileTextSettings
    {
        /// <summary> Initializes a new instance of <see cref="LogFileSettingsText"/>. </summary>
        /// <param name="recordStartTimestampFormat"> One of the supported timestamp formats. </param>
        public LogFileSettingsText(LogFileTextSettingsRecordStartTimestampFormat recordStartTimestampFormat) : base(recordStartTimestampFormat)
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogFileSettingsText"/>. </summary>
        /// <param name="recordStartTimestampFormat"> One of the supported timestamp formats. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogFileSettingsText(LogFileTextSettingsRecordStartTimestampFormat recordStartTimestampFormat, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(recordStartTimestampFormat, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogFileSettingsText"/> for deserialization. </summary>
        internal LogFileSettingsText()
        {
        }
    }
}
