// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the Slack channel. </summary>
    public partial class SlackChannelProperties
    {
        /// <summary> Initializes a new instance of SlackChannelProperties. </summary>
        /// <param name="isEnabled"> Whether this channel is enabled for the bot. </param>
        public SlackChannelProperties(bool isEnabled)
        {
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of SlackChannelProperties. </summary>
        /// <param name="clientId"> The Slack client id. </param>
        /// <param name="clientSecret"> The Slack client secret. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="verificationToken"> The Slack verification token. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="scopes"> The Slack permission scopes. </param>
        /// <param name="landingPageUri"> The Slack landing page Url. </param>
        /// <param name="redirectAction"> The Slack redirect action. </param>
        /// <param name="lastSubmissionId"> The Sms auth token. </param>
        /// <param name="registerBeforeOAuthFlow"> Whether to register the settings before OAuth validation is performed. Recommended to True. </param>
        /// <param name="isValidated"> Whether this channel is validated for the bot. </param>
        /// <param name="signingSecret"> The Slack signing secret. </param>
        /// <param name="isEnabled"> Whether this channel is enabled for the bot. </param>
        internal SlackChannelProperties(string clientId, string clientSecret, string verificationToken, string scopes, Uri landingPageUri, string redirectAction, string lastSubmissionId, bool? registerBeforeOAuthFlow, bool? isValidated, string signingSecret, bool isEnabled)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            VerificationToken = verificationToken;
            Scopes = scopes;
            LandingPageUri = landingPageUri;
            RedirectAction = redirectAction;
            LastSubmissionId = lastSubmissionId;
            RegisterBeforeOAuthFlow = registerBeforeOAuthFlow;
            IsValidated = isValidated;
            SigningSecret = signingSecret;
            IsEnabled = isEnabled;
        }

        /// <summary> The Slack client id. </summary>
        public string ClientId { get; set; }
        /// <summary> The Slack client secret. Value only returned through POST to the action Channel List API, otherwise empty. </summary>
        public string ClientSecret { get; set; }
        /// <summary> The Slack verification token. Value only returned through POST to the action Channel List API, otherwise empty. </summary>
        public string VerificationToken { get; set; }
        /// <summary> The Slack permission scopes. </summary>
        public string Scopes { get; set; }
        /// <summary> The Slack landing page Url. </summary>
        public Uri LandingPageUri { get; set; }
        /// <summary> The Slack redirect action. </summary>
        public string RedirectAction { get; }
        /// <summary> The Sms auth token. </summary>
        public string LastSubmissionId { get; }
        /// <summary> Whether to register the settings before OAuth validation is performed. Recommended to True. </summary>
        public bool? RegisterBeforeOAuthFlow { get; set; }
        /// <summary> Whether this channel is validated for the bot. </summary>
        public bool? IsValidated { get; }
        /// <summary> The Slack signing secret. </summary>
        public string SigningSecret { get; set; }
        /// <summary> Whether this channel is enabled for the bot. </summary>
        public bool IsEnabled { get; set; }
    }
}
