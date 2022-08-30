// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Body for the save image POST. </summary>
    public partial class SaveImageBody
    {
        /// <summary> Initializes a new instance of SaveImageBody. </summary>
        public SaveImageBody()
        {
        }

        /// <summary> The name for the image we create. </summary>
        public string Name { get; set; }
        /// <summary> The ID of the lab virtual machine you want to save an image from. </summary>
        public string LabVirtualMachineId { get; set; }
    }
}
