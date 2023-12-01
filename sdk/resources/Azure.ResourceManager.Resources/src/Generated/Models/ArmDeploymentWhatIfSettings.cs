// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment What-If operation settings. </summary>
    internal partial class ArmDeploymentWhatIfSettings
    {
        /// <summary> Initializes a new instance of <see cref="ArmDeploymentWhatIfSettings"/>. </summary>
        public ArmDeploymentWhatIfSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentWhatIfSettings"/>. </summary>
        /// <param name="resultFormat"> The format of the What-If results. </param>
        internal ArmDeploymentWhatIfSettings(WhatIfResultFormat? resultFormat)
        {
            ResultFormat = resultFormat;
        }

        /// <summary> The format of the What-If results. </summary>
        public WhatIfResultFormat? ResultFormat { get; set; }
    }
}
