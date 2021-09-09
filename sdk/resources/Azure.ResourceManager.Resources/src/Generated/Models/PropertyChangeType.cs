// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The type of property change. </summary>
    public enum PropertyChangeType
    {
        /// <summary> The property does not exist in the current state but is present in the desired state. The property will be created when the deployment is executed. </summary>
        Create,
        /// <summary> The property exists in the current state and is missing from the desired state. It will be deleted when the deployment is executed. </summary>
        Delete,
        /// <summary> The property exists in both current and desired state and is different. The value of the property will change when the deployment is executed. </summary>
        Modify,
        /// <summary> The property is an array and contains nested changes. </summary>
        Array,
        /// <summary> The property will not be set or updated. </summary>
        NoEffect
    }
}
