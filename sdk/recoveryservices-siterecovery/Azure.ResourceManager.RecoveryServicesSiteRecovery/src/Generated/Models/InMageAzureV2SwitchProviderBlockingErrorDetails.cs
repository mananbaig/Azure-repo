// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageAzureV2 switch provider blocking error details. </summary>
    public partial class InMageAzureV2SwitchProviderBlockingErrorDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2SwitchProviderBlockingErrorDetails"/>. </summary>
        internal InMageAzureV2SwitchProviderBlockingErrorDetails()
        {
            ErrorMessageParameters = new ChangeTrackingDictionary<string, string>();
            ErrorTags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2SwitchProviderBlockingErrorDetails"/>. </summary>
        /// <param name="errorCode"> The error code. </param>
        /// <param name="errorMessage"> The error message. </param>
        /// <param name="possibleCauses"> The possible causes. </param>
        /// <param name="recommendedAction"> The recommended action. </param>
        /// <param name="errorMessageParameters"> The error message parameters. </param>
        /// <param name="errorTags"> The error tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageAzureV2SwitchProviderBlockingErrorDetails(string errorCode, string errorMessage, string possibleCauses, string recommendedAction, IReadOnlyDictionary<string, string> errorMessageParameters, IReadOnlyDictionary<string, string> errorTags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            PossibleCauses = possibleCauses;
            RecommendedAction = recommendedAction;
            ErrorMessageParameters = errorMessageParameters;
            ErrorTags = errorTags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The error code. </summary>
        public string ErrorCode { get; }
        /// <summary> The error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> The possible causes. </summary>
        public string PossibleCauses { get; }
        /// <summary> The recommended action. </summary>
        public string RecommendedAction { get; }
        /// <summary> The error message parameters. </summary>
        public IReadOnlyDictionary<string, string> ErrorMessageParameters { get; }
        /// <summary> The error tags. </summary>
        public IReadOnlyDictionary<string, string> ErrorTags { get; }
    }
}
