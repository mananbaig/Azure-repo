// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// A rule of one of the following types:
    ///
    /// StaticRule:  A rule providing static rules that always return the same result, regardless of input.
    /// DirectMapRule:  A rule that return the same labels as the input labels.
    /// ExpressionRule: A rule providing inline expression rules.
    /// AzureFunctionRule: A rule providing a binding to an HTTP Triggered Azure Function.
    /// WebhookRule: A rule providing a binding to a webserver following OAuth2.0 authentication protocol.
    /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FunctionRouterRule"/>, <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownRouterRule))]
    public abstract partial class RouterRule
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RouterRule"/>. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of Rule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RouterRule(string kind, Dictionary<string, BinaryData> rawData)
        {
            Kind = kind;
            _rawData = rawData;
        }
    }
}
