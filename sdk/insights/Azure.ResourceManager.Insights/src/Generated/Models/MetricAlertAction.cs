// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> An alert action. </summary>
    public partial class MetricAlertAction
    {
        /// <summary> Initializes a new instance of MetricAlertAction. </summary>
        public MetricAlertAction()
        {
            WebHookProperties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of MetricAlertAction. </summary>
        /// <param name="actionGroupId"> the id of the action group to use. </param>
        /// <param name="webHookProperties"> The properties of a webhook object. </param>
        internal MetricAlertAction(string actionGroupId, IDictionary<string, string> webHookProperties)
        {
            ActionGroupId = actionGroupId;
            WebHookProperties = webHookProperties;
        }

        /// <summary> the id of the action group to use. </summary>
        public string ActionGroupId { get; set; }
        /// <summary> The properties of a webhook object. </summary>
        public IDictionary<string, string> WebHookProperties { get; }
    }
}
