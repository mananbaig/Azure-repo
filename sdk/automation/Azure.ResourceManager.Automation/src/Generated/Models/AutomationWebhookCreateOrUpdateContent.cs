// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update webhook operation. </summary>
    public partial class AutomationWebhookCreateOrUpdateContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationWebhookCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the webhook. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public AutomationWebhookCreateOrUpdateContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Parameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationWebhookCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the webhook. </param>
        /// <param name="isEnabled"> Gets or sets the value of the enabled flag of webhook. </param>
        /// <param name="uri"> Gets or sets the uri. </param>
        /// <param name="expireOn"> Gets or sets the expiry time. </param>
        /// <param name="parameters"> Gets or sets the parameters of the job. </param>
        /// <param name="runbook"> Gets or sets the runbook. </param>
        /// <param name="runOn"> Gets or sets the name of the hybrid worker group the webhook job will run on. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationWebhookCreateOrUpdateContent(string name, bool? isEnabled, Uri uri, DateTimeOffset? expireOn, IDictionary<string, string> parameters, RunbookAssociationProperty runbook, string runOn, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            IsEnabled = isEnabled;
            Uri = uri;
            ExpireOn = expireOn;
            Parameters = parameters;
            Runbook = runbook;
            RunOn = runOn;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationWebhookCreateOrUpdateContent"/> for deserialization. </summary>
        internal AutomationWebhookCreateOrUpdateContent()
        {
        }

        /// <summary> Gets or sets the name of the webhook. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the value of the enabled flag of webhook. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Gets or sets the uri. </summary>
        public Uri Uri { get; set; }
        /// <summary> Gets or sets the expiry time. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> Gets or sets the parameters of the job. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> Gets or sets the runbook. </summary>
        internal RunbookAssociationProperty Runbook { get; set; }
        /// <summary> Gets or sets the name of the runbook. </summary>
        public string RunbookName
        {
            get => Runbook is null ? default : Runbook.Name;
            set
            {
                if (Runbook is null)
                    Runbook = new RunbookAssociationProperty();
                Runbook.Name = value;
            }
        }

        /// <summary> Gets or sets the name of the hybrid worker group the webhook job will run on. </summary>
        public string RunOn { get; set; }
    }
}
