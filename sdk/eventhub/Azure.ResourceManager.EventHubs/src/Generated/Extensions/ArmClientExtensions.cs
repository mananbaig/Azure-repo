// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region Cluster
        /// <summary> Gets an object representing a Cluster along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Cluster" /> object. </returns>
        public static Cluster GetCluster(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Cluster(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region EHNamespace
        /// <summary> Gets an object representing a EHNamespace along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EHNamespace" /> object. </returns>
        public static EHNamespace GetEHNamespace(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new EHNamespace(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateEndpointConnection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Eventhub
        /// <summary> Gets an object representing a Eventhub along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Eventhub" /> object. </returns>
        public static Eventhub GetEventhub(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Eventhub(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ArmDisasterRecovery
        /// <summary> Gets an object representing a ArmDisasterRecovery along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArmDisasterRecovery" /> object. </returns>
        public static ArmDisasterRecovery GetArmDisasterRecovery(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ArmDisasterRecovery(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AuthorizationRuleNamespace
        /// <summary> Gets an object representing a AuthorizationRuleNamespace along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AuthorizationRuleNamespace" /> object. </returns>
        public static AuthorizationRuleNamespace GetAuthorizationRuleNamespace(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AuthorizationRuleNamespace(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AuthorizationRuleDisasterRecoveryConfig
        /// <summary> Gets an object representing a AuthorizationRuleDisasterRecoveryConfig along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AuthorizationRuleDisasterRecoveryConfig" /> object. </returns>
        public static AuthorizationRuleDisasterRecoveryConfig GetAuthorizationRuleDisasterRecoveryConfig(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AuthorizationRuleDisasterRecoveryConfig(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AuthorizationRuleEventHub
        /// <summary> Gets an object representing a AuthorizationRuleEventHub along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AuthorizationRuleEventHub" /> object. </returns>
        public static AuthorizationRuleEventHub GetAuthorizationRuleEventHub(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AuthorizationRuleEventHub(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ConsumerGroup
        /// <summary> Gets an object representing a ConsumerGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConsumerGroup" /> object. </returns>
        public static ConsumerGroup GetConsumerGroup(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ConsumerGroup(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
