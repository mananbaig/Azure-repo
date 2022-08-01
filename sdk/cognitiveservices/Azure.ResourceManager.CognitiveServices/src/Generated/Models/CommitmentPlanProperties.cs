// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Properties of Cognitive Services account commitment plan. </summary>
    public partial class CommitmentPlanProperties
    {
        /// <summary> Initializes a new instance of CommitmentPlanProperties. </summary>
        public CommitmentPlanProperties()
        {
        }

        /// <summary> Initializes a new instance of CommitmentPlanProperties. </summary>
        /// <param name="hostingModel"> Account hosting model. </param>
        /// <param name="planType"> Commitment plan type. </param>
        /// <param name="current"> Cognitive Services account commitment period. </param>
        /// <param name="autoRenew"> AutoRenew commitment plan. </param>
        /// <param name="next"> Cognitive Services account commitment period. </param>
        /// <param name="last"> Cognitive Services account commitment period. </param>
        internal CommitmentPlanProperties(ServiceAccountHostingModel? hostingModel, string planType, CommitmentPeriod current, bool? autoRenew, CommitmentPeriod next, CommitmentPeriod last)
        {
            HostingModel = hostingModel;
            PlanType = planType;
            Current = current;
            AutoRenew = autoRenew;
            Next = next;
            Last = last;
        }

        /// <summary> Account hosting model. </summary>
        public ServiceAccountHostingModel? HostingModel { get; set; }
        /// <summary> Commitment plan type. </summary>
        public string PlanType { get; set; }
        /// <summary> Cognitive Services account commitment period. </summary>
        public CommitmentPeriod Current { get; set; }
        /// <summary> AutoRenew commitment plan. </summary>
        public bool? AutoRenew { get; set; }
        /// <summary> Cognitive Services account commitment period. </summary>
        public CommitmentPeriod Next { get; set; }
        /// <summary> Cognitive Services account commitment period. </summary>
        public CommitmentPeriod Last { get; }
    }
}
