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
    /// VMwareCbt specific test migrate input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("VMwareCbt")]
    public partial class VMwareCbtTestMigrateInput : TestMigrateProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the VMwareCbtTestMigrateInput class.
        /// </summary>
        public VMwareCbtTestMigrateInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMwareCbtTestMigrateInput class.
        /// </summary>
        /// <param name="recoveryPointId">The recovery point Id.</param>
        /// <param name="networkId">The test network Id.</param>
        public VMwareCbtTestMigrateInput(string recoveryPointId, string networkId)
        {
            RecoveryPointId = recoveryPointId;
            NetworkId = networkId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery point Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId { get; set; }

        /// <summary>
        /// Gets or sets the test network Id.
        /// </summary>
        [JsonProperty(PropertyName = "networkId")]
        public string NetworkId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RecoveryPointId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RecoveryPointId");
            }
            if (NetworkId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NetworkId");
            }
        }
    }
}
