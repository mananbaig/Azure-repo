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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Recovery plan planned failover input properties.
    /// </summary>
    public partial class RecoveryPlanPlannedFailoverInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanPlannedFailoverInputProperties class.
        /// </summary>
        public RecoveryPlanPlannedFailoverInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanPlannedFailoverInputProperties class.
        /// </summary>
        /// <param name="failoverDirection">The failover direction. Possible
        /// values include: 'PrimaryToRecovery', 'RecoveryToPrimary'</param>
        /// <param name="providerSpecificDetails">The provider specific
        /// properties.</param>
        public RecoveryPlanPlannedFailoverInputProperties(string failoverDirection, IList<RecoveryPlanProviderSpecificFailoverInput> providerSpecificDetails = default(IList<RecoveryPlanProviderSpecificFailoverInput>))
        {
            FailoverDirection = failoverDirection;
            ProviderSpecificDetails = providerSpecificDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the failover direction. Possible values include:
        /// 'PrimaryToRecovery', 'RecoveryToPrimary'
        /// </summary>
        [JsonProperty(PropertyName = "failoverDirection")]
        public string FailoverDirection { get; set; }

        /// <summary>
        /// Gets or sets the provider specific properties.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public IList<RecoveryPlanProviderSpecificFailoverInput> ProviderSpecificDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FailoverDirection == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FailoverDirection");
            }
        }
    }
}
