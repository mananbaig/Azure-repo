// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// A resource identifier for an alert which can be used to direct the alert to the right product exposure group (tenant, workspace, subscription etc.).
    /// Please note <see cref="SecurityAlertResourceIdentifier"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureResourceIdentifier"/> and <see cref="LogAnalyticsIdentifier"/>.
    /// </summary>
    public abstract partial class SecurityAlertResourceIdentifier
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityAlertResourceIdentifier"/>. </summary>
        protected SecurityAlertResourceIdentifier()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAlertResourceIdentifier"/>. </summary>
        /// <param name="resourceIdentifierType"> There can be multiple identifiers of different type per alert, this field specify the identifier type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityAlertResourceIdentifier(ResourceIdentifierType resourceIdentifierType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceIdentifierType = resourceIdentifierType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> There can be multiple identifiers of different type per alert, this field specify the identifier type. </summary>
        internal ResourceIdentifierType ResourceIdentifierType { get; set; }
    }
}
