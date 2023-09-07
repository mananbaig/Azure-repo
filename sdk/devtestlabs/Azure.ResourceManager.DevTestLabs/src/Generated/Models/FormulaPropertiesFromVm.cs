// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Information about a VM from which a formula is to be created. </summary>
    internal partial class FormulaPropertiesFromVm
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FormulaPropertiesFromVm"/>. </summary>
        public FormulaPropertiesFromVm()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FormulaPropertiesFromVm"/>. </summary>
        /// <param name="labVmId"> The identifier of the VM from which a formula is to be created. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FormulaPropertiesFromVm(string labVmId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LabVmId = labVmId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The identifier of the VM from which a formula is to be created. </summary>
        public string LabVmId { get; set; }
    }
}
