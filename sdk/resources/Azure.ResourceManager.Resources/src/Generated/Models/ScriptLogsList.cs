// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment script execution logs. </summary>
    public partial class ScriptLogsList
    {
        /// <summary> Initializes a new instance of ScriptLogsList. </summary>
        internal ScriptLogsList()
        {
            Value = new ChangeTrackingList<ScriptLog>();
        }

        /// <summary> Initializes a new instance of ScriptLogsList. </summary>
        /// <param name="value"> Deployment scripts logs. </param>
        internal ScriptLogsList(IReadOnlyList<ScriptLog> value)
        {
            Value = value;
        }

        /// <summary> Deployment scripts logs. </summary>
        public IReadOnlyList<ScriptLog> Value { get; }
    }
}
