// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Template mapping rule profile. </summary>
    internal partial class ArmTemplateMappingRuleProfile
    {
        /// <summary> Initializes a new instance of ArmTemplateMappingRuleProfile. </summary>
        public ArmTemplateMappingRuleProfile()
        {
        }

        /// <summary> Initializes a new instance of ArmTemplateMappingRuleProfile. </summary>
        /// <param name="templateParameters"> List of template parameters. </param>
        internal ArmTemplateMappingRuleProfile(string templateParameters)
        {
            TemplateParameters = templateParameters;
        }

        /// <summary> List of template parameters. </summary>
        public string TemplateParameters { get; set; }
    }
}
