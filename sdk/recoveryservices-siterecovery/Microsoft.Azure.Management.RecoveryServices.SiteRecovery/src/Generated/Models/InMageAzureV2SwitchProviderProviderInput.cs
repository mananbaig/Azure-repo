// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Provider specific input for InMageAzureV2 switch provider.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageAzureV2")]
    public partial class InMageAzureV2SwitchProviderProviderInput : SwitchProviderProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2SwitchProviderProviderInput class.
        /// </summary>
        public InMageAzureV2SwitchProviderProviderInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2SwitchProviderProviderInput class.
        /// </summary>
        /// <param name="targetVaultID">The target vault Id.</param>
        /// <param name="targetFabricID">The target fabric Id.</param>
        /// <param name="targetApplianceID">The target appliance Id.</param>
        public InMageAzureV2SwitchProviderProviderInput(string targetVaultID, string targetFabricID, string targetApplianceID)
        {
            TargetVaultID = targetVaultID;
            TargetFabricID = targetFabricID;
            TargetApplianceID = targetApplianceID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the target vault Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetVaultID")]
        public string TargetVaultID { get; set; }

        /// <summary>
        /// Gets or sets the target fabric Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetFabricID")]
        public string TargetFabricID { get; set; }

        /// <summary>
        /// Gets or sets the target appliance Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetApplianceID")]
        public string TargetApplianceID { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetVaultID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetVaultID");
            }
            if (TargetFabricID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetFabricID");
            }
            if (TargetApplianceID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetApplianceID");
            }
        }
    }
}
