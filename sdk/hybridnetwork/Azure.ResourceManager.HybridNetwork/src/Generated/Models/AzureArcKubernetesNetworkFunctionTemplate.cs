// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.HybridNetwork;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure Arc kubernetes network function template. </summary>
    public partial class AzureArcKubernetesNetworkFunctionTemplate : ContainerizedNetworkFunctionTemplate
    {
        /// <summary> Initializes a new instance of <see cref="AzureArcKubernetesNetworkFunctionTemplate"/>. </summary>
        public AzureArcKubernetesNetworkFunctionTemplate()
        {
            NetworkFunctionApplications = new ChangeTrackingList<AzureArcKubernetesNetworkFunctionApplication>();
            NfviType = ContainerizedNetworkFunctionNfviType.AzureArcKubernetes;
        }

        /// <summary> Initializes a new instance of <see cref="AzureArcKubernetesNetworkFunctionTemplate"/>. </summary>
        /// <param name="nfviType"> The network function type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="networkFunctionApplications">
        /// Network function applications.
        /// Please note <see cref="AzureArcKubernetesNetworkFunctionApplication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureArcKubernetesHelmApplication"/>.
        /// </param>
        internal AzureArcKubernetesNetworkFunctionTemplate(ContainerizedNetworkFunctionNfviType nfviType, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<AzureArcKubernetesNetworkFunctionApplication> networkFunctionApplications) : base(nfviType, serializedAdditionalRawData)
        {
            NetworkFunctionApplications = networkFunctionApplications;
            NfviType = nfviType;
        }

        /// <summary>
        /// Network function applications.
        /// Please note <see cref="AzureArcKubernetesNetworkFunctionApplication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureArcKubernetesHelmApplication"/>.
        /// </summary>
        public IList<AzureArcKubernetesNetworkFunctionApplication> NetworkFunctionApplications { get; }
    }
}
