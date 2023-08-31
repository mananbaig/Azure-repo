// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Instance view status. </summary>
    public partial class MachineExtensionInstanceViewStatus
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineExtensionInstanceViewStatus"/>. </summary>
        public MachineExtensionInstanceViewStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineExtensionInstanceViewStatus"/>. </summary>
        /// <param name="code"> The status code. </param>
        /// <param name="level"> The level code. </param>
        /// <param name="displayStatus"> The short localizable label for the status. </param>
        /// <param name="message"> The detailed status message, including for alerts and error messages. </param>
        /// <param name="time"> The time of the status. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineExtensionInstanceViewStatus(string code, MachineExtensionStatusLevelType? level, string displayStatus, string message, DateTimeOffset? time, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Level = level;
            DisplayStatus = displayStatus;
            Message = message;
            Time = time;
            _rawData = rawData;
        }

        /// <summary> The status code. </summary>
        public string Code { get; }
        /// <summary> The level code. </summary>
        public MachineExtensionStatusLevelType? Level { get; }
        /// <summary> The short localizable label for the status. </summary>
        public string DisplayStatus { get; }
        /// <summary> The detailed status message, including for alerts and error messages. </summary>
        public string Message { get; }
        /// <summary> The time of the status. </summary>
        public DateTimeOffset? Time { get; }
    }
}
