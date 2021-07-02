﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Administration
{
    /// <summary>
    /// A webhook is the entry point for all the information available from the Metrics Advisor service, and calls a user-provided API when an alert is triggered.
    /// All alerts can be sent through a webhook.
    /// </summary>
    [CodeGenModel("WebhookHookInfo")]
    [CodeGenSuppress(nameof(WebNotificationHook), typeof(string), typeof(WebhookHookParameter))]
    public partial class WebNotificationHook : NotificationHook
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebNotificationHook"/> class.
        /// </summary>
        /// <param name="name">The name of the hook.</param>
        /// <param name="endpoint">The API address to be called when an alert is triggered.</param>
        public WebNotificationHook(string name, Uri endpoint) : base(name)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));

            Endpoint = endpoint;
            HookKind = NotificationHookKind.Webhook;
            Headers = new ChangeTrackingDictionary<string, string>();
        }

        internal WebNotificationHook(NotificationHookKind hookType, string id, string name, string description, string externalLink, IList<string> administrators, WebhookHookParameter hookParameter)
            : base(hookType, id, name, description, externalLink, administrators)
        {
            HookKind = hookType;
            Endpoint = new Uri(hookParameter.Endpoint);
            Username = hookParameter.Username;
            Password = hookParameter.Password;
            CertificateKey = hookParameter.CertificateKey;
            CertificatePassword = hookParameter.CertificatePassword;
            Headers = hookParameter.Headers;
        }

        /// <summary>
        /// The API address to be called when an alert is triggered.
        /// </summary>
        public Uri Endpoint { get; set; }

        /// <summary>
        /// The username for authenticating to the API address. Leave this blank if authentication isn't needed.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The password for authenticating to the API address. Leave this blank if authentication isn't needed.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The certificate key for authenticating to the API address. Leave this blank if authentication isn't needed.
        /// </summary>
        public string CertificateKey { get; set; }

        /// <summary>
        /// The certificate password for authenticating to the API address. Leave this blank if authentication isn't needed.
        /// </summary>
        public string CertificatePassword { get; set; }

        /// <summary>
        /// Custom headers to send in the API call.
        /// </summary>
        public IDictionary<string, string> Headers { get; }

        /// <summary>
        /// Used by CodeGen during serialization.
        /// </summary>
        internal WebhookHookParameter HookParameter => new WebhookHookParameter(Endpoint.AbsoluteUri)
        {
            Username = Username,
            Password = Password,
            CertificateKey = CertificateKey,
            CertificatePassword = CertificatePassword,
            Headers = Headers
        };
    }
}
