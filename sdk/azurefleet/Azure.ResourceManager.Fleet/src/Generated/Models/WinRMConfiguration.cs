// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Fleet.Models
{
    /// <summary> Describes Windows Remote Management configuration of the VM. </summary>
    internal partial class WinRMConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="WinRMConfiguration"/>. </summary>
        public WinRMConfiguration()
        {
            Listeners = new ChangeTrackingList<WinRMListener>();
        }

        /// <summary> Initializes a new instance of <see cref="WinRMConfiguration"/>. </summary>
        /// <param name="listeners"> The list of Windows Remote Management listeners. </param>
        internal WinRMConfiguration(IList<WinRMListener> listeners)
        {
            Listeners = listeners;
        }

        /// <summary> The list of Windows Remote Management listeners. </summary>
        public IList<WinRMListener> Listeners { get; }
    }
}
