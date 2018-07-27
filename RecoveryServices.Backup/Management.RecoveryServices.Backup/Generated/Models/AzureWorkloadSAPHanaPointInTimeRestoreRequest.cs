// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AzureWorkload SAP Hana -specific restore. Specifically for
    /// PointInTime/Log restore
    /// </summary>
    public partial class AzureWorkloadSAPHanaPointInTimeRestoreRequest : AzureWorkloadSAPHanaRestoreRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureWorkloadSAPHanaPointInTimeRestoreRequest class.
        /// </summary>
        public AzureWorkloadSAPHanaPointInTimeRestoreRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureWorkloadSAPHanaPointInTimeRestoreRequest class.
        /// </summary>
        /// <param name="targetInfo">Details of target database</param>
        /// <param name="recoveryType">OLR/ALR, RestoreDisks is invalid option.
        /// Possible values include: 'Invalid', 'OriginalLocation',
        /// 'AlternateLocation', 'RestoreDisks'</param>
        /// <param name="sourceResourceId">Fully qualified ARM ID of the VM on
        /// which workload that was running is being recovered.</param>
        /// <param name="propertyBag">Workload specific property bag.</param>
        /// <param name="pointInTime">PointInTime value</param>
        public AzureWorkloadSAPHanaPointInTimeRestoreRequest(TargetRestoreInfo targetInfo = default(TargetRestoreInfo), RecoveryType? recoveryType = default(RecoveryType?), string sourceResourceId = default(string), IDictionary<string, string> propertyBag = default(IDictionary<string, string>), System.DateTime? pointInTime = default(System.DateTime?))
            : base(targetInfo, recoveryType, sourceResourceId, propertyBag)
        {
            PointInTime = pointInTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets pointInTime value
        /// </summary>
        [JsonProperty(PropertyName = "pointInTime")]
        public System.DateTime? PointInTime { get; set; }

    }
}
