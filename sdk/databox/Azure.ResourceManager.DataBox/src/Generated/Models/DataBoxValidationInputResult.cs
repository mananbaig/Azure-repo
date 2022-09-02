// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary>
    /// Minimum properties that should be present in each individual validation response.
    /// Please note <see cref="DataBoxValidationInputResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CreateOrderLimitForSubscriptionValidationResult"/>, <see cref="DataTransferDetailsValidationResult"/>, <see cref="PreferencesValidationResult"/>, <see cref="SkuAvailabilityValidationResult"/>, <see cref="SubscriptionIsAllowedToCreateJobValidationResult"/> and <see cref="AddressValidationResult"/>.
    /// </summary>
    public abstract partial class DataBoxValidationInputResult
    {
        /// <summary> Initializes a new instance of DataBoxValidationInputResult. </summary>
        protected DataBoxValidationInputResult()
        {
        }

        /// <summary> Initializes a new instance of DataBoxValidationInputResult. </summary>
        /// <param name="validationType"> Identifies the type of validation response. </param>
        /// <param name="error"> Error code and message of validation response. </param>
        internal DataBoxValidationInputResult(DataBoxValidationInputDiscriminator validationType, ResponseError error)
        {
            ValidationType = validationType;
            Error = error;
        }

        /// <summary> Identifies the type of validation response. </summary>
        internal DataBoxValidationInputDiscriminator ValidationType { get; set; }
        /// <summary> Error code and message of validation response. </summary>
        public ResponseError Error { get; }
    }
}
