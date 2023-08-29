// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The AutomationWatcherPatch. </summary>
    public partial class AutomationWatcherPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationWatcherPatch"/>. </summary>
        public AutomationWatcherPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationWatcherPatch"/>. </summary>
        /// <param name="name"> Gets or sets the name of the resource. </param>
        /// <param name="executionFrequencyInSeconds"> Gets or sets the frequency at which the watcher is invoked. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationWatcherPatch(string name, long? executionFrequencyInSeconds, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ExecutionFrequencyInSeconds = executionFrequencyInSeconds;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the frequency at which the watcher is invoked. </summary>
        public long? ExecutionFrequencyInSeconds { get; set; }
    }
}
