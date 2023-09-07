// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines top-level WebApplicationFirewallPolicy configuration settings. </summary>
    public partial class FrontDoorWebApplicationFirewallPolicySettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorWebApplicationFirewallPolicySettings"/>. </summary>
        public FrontDoorWebApplicationFirewallPolicySettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorWebApplicationFirewallPolicySettings"/>. </summary>
        /// <param name="enabledState"> Describes if the policy is in enabled or disabled state. Defaults to Enabled if not specified. </param>
        /// <param name="mode"> Describes if it is in detection mode or prevention mode at policy level. </param>
        /// <param name="redirectUri"> If action type is redirect, this field represents redirect URL for the client. </param>
        /// <param name="customBlockResponseStatusCode"> If the action type is block, customer can override the response status code. </param>
        /// <param name="customBlockResponseBody"> If the action type is block, customer can override the response body. The body must be specified in base64 encoding. </param>
        /// <param name="requestBodyCheck"> Describes if policy managed rules will inspect the request body content. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorWebApplicationFirewallPolicySettings(PolicyEnabledState? enabledState, FrontDoorWebApplicationFirewallPolicyMode? mode, Uri redirectUri, int? customBlockResponseStatusCode, string customBlockResponseBody, PolicyRequestBodyCheck? requestBodyCheck, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnabledState = enabledState;
            Mode = mode;
            RedirectUri = redirectUri;
            CustomBlockResponseStatusCode = customBlockResponseStatusCode;
            CustomBlockResponseBody = customBlockResponseBody;
            RequestBodyCheck = requestBodyCheck;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Describes if the policy is in enabled or disabled state. Defaults to Enabled if not specified. </summary>
        public PolicyEnabledState? EnabledState { get; set; }
        /// <summary> Describes if it is in detection mode or prevention mode at policy level. </summary>
        public FrontDoorWebApplicationFirewallPolicyMode? Mode { get; set; }
        /// <summary> If action type is redirect, this field represents redirect URL for the client. </summary>
        public Uri RedirectUri { get; set; }
        /// <summary> If the action type is block, customer can override the response status code. </summary>
        public int? CustomBlockResponseStatusCode { get; set; }
        /// <summary> If the action type is block, customer can override the response body. The body must be specified in base64 encoding. </summary>
        public string CustomBlockResponseBody { get; set; }
        /// <summary> Describes if policy managed rules will inspect the request body content. </summary>
        public PolicyRequestBodyCheck? RequestBodyCheck { get; set; }
    }
}
