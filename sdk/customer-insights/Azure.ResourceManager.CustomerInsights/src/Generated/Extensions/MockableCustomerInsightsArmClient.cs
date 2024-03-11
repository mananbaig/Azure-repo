// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableCustomerInsightsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableCustomerInsightsArmClient"/> class for mocking. </summary>
        protected MockableCustomerInsightsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableCustomerInsightsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableCustomerInsightsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableCustomerInsightsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="HubResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HubResource.CreateResourceIdentifier" /> to create a <see cref="HubResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HubResource"/> object. </returns>
        public virtual HubResource GetHubResource(ResourceIdentifier id)
        {
            HubResource.ValidateResourceId(id);
            return new HubResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ProfileResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProfileResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="ProfileResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProfileResourceFormatResource"/> object. </returns>
        public virtual ProfileResourceFormatResource GetProfileResourceFormatResource(ResourceIdentifier id)
        {
            ProfileResourceFormatResource.ValidateResourceId(id);
            return new ProfileResourceFormatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="InteractionResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="InteractionResourceFormatResource.CreateResourceIdentifier" /> to create an <see cref="InteractionResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="InteractionResourceFormatResource"/> object. </returns>
        public virtual InteractionResourceFormatResource GetInteractionResourceFormatResource(ResourceIdentifier id)
        {
            InteractionResourceFormatResource.ValidateResourceId(id);
            return new InteractionResourceFormatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RelationshipResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelationshipResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="RelationshipResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelationshipResourceFormatResource"/> object. </returns>
        public virtual RelationshipResourceFormatResource GetRelationshipResourceFormatResource(ResourceIdentifier id)
        {
            RelationshipResourceFormatResource.ValidateResourceId(id);
            return new RelationshipResourceFormatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RelationshipLinkResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelationshipLinkResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="RelationshipLinkResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelationshipLinkResourceFormatResource"/> object. </returns>
        public virtual RelationshipLinkResourceFormatResource GetRelationshipLinkResourceFormatResource(ResourceIdentifier id)
        {
            RelationshipLinkResourceFormatResource.ValidateResourceId(id);
            return new RelationshipLinkResourceFormatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AuthorizationPolicyResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AuthorizationPolicyResourceFormatResource.CreateResourceIdentifier" /> to create an <see cref="AuthorizationPolicyResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AuthorizationPolicyResourceFormatResource"/> object. </returns>
        public virtual AuthorizationPolicyResourceFormatResource GetAuthorizationPolicyResourceFormatResource(ResourceIdentifier id)
        {
            AuthorizationPolicyResourceFormatResource.ValidateResourceId(id);
            return new AuthorizationPolicyResourceFormatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ConnectorResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectorResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="ConnectorResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectorResourceFormatResource"/> object. </returns>
        public virtual ConnectorResourceFormatResource GetConnectorResourceFormatResource(ResourceIdentifier id)
        {
            ConnectorResourceFormatResource.ValidateResourceId(id);
            return new ConnectorResourceFormatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ConnectorMappingResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectorMappingResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="ConnectorMappingResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectorMappingResourceFormatResource"/> object. </returns>
        public virtual ConnectorMappingResourceFormatResource GetConnectorMappingResourceFormatResource(ResourceIdentifier id)
        {
            ConnectorMappingResourceFormatResource.ValidateResourceId(id);
            return new ConnectorMappingResourceFormatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KpiResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KpiResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="KpiResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KpiResourceFormatResource"/> object. </returns>
        public virtual KpiResourceFormatResource GetKpiResourceFormatResource(ResourceIdentifier id)
        {
            KpiResourceFormatResource.ValidateResourceId(id);
            return new KpiResourceFormatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WidgetTypeResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WidgetTypeResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="WidgetTypeResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WidgetTypeResourceFormatResource"/> object. </returns>
        public virtual WidgetTypeResourceFormatResource GetWidgetTypeResourceFormatResource(ResourceIdentifier id)
        {
            WidgetTypeResourceFormatResource.ValidateResourceId(id);
            return new WidgetTypeResourceFormatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ViewResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ViewResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="ViewResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ViewResourceFormatResource"/> object. </returns>
        public virtual ViewResourceFormatResource GetViewResourceFormatResource(ResourceIdentifier id)
        {
            ViewResourceFormatResource.ValidateResourceId(id);
            return new ViewResourceFormatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LinkResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LinkResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="LinkResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LinkResourceFormatResource"/> object. </returns>
        public virtual LinkResourceFormatResource GetLinkResourceFormatResource(ResourceIdentifier id)
        {
            LinkResourceFormatResource.ValidateResourceId(id);
            return new LinkResourceFormatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RoleAssignmentResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RoleAssignmentResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="RoleAssignmentResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RoleAssignmentResourceFormatResource"/> object. </returns>
        public virtual RoleAssignmentResourceFormatResource GetRoleAssignmentResourceFormatResource(ResourceIdentifier id)
        {
            RoleAssignmentResourceFormatResource.ValidateResourceId(id);
            return new RoleAssignmentResourceFormatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PredictionResourceFormatResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PredictionResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="PredictionResourceFormatResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PredictionResourceFormatResource"/> object. </returns>
        public virtual PredictionResourceFormatResource GetPredictionResourceFormatResource(ResourceIdentifier id)
        {
            PredictionResourceFormatResource.ValidateResourceId(id);
            return new PredictionResourceFormatResource(Client, id);
        }
    }
}
