// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Fleet.Models
{
    /// <summary> Instance view status. </summary>
    public partial class InstanceViewStatus
    {
        /// <summary> Initializes a new instance of <see cref="InstanceViewStatus"/>. </summary>
        public InstanceViewStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InstanceViewStatus"/>. </summary>
        /// <param name="code"> The status code. </param>
        /// <param name="level"> The level code. </param>
        /// <param name="displayStatus"> The short localizable label for the status. </param>
        /// <param name="message"> The detailed status message, including for alerts and error messages. </param>
        /// <param name="time"> The time of the status. </param>
        internal InstanceViewStatus(string code, StatusLevelType? level, string displayStatus, string message, DateTimeOffset? time)
        {
            Code = code;
            Level = level;
            DisplayStatus = displayStatus;
            Message = message;
            Time = time;
        }

        /// <summary> The status code. </summary>
        public string Code { get; set; }
        /// <summary> The level code. </summary>
        public StatusLevelType? Level { get; set; }
        /// <summary> The short localizable label for the status. </summary>
        public string DisplayStatus { get; set; }
        /// <summary> The detailed status message, including for alerts and error messages. </summary>
        public string Message { get; set; }
        /// <summary> The time of the status. </summary>
        public DateTimeOffset? Time { get; set; }
    }
}
