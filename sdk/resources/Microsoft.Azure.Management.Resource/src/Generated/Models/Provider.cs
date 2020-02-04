// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Resources.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource provider information.
    /// </summary>
    public partial class Provider
    {
        /// <summary>
        /// Initializes a new instance of the Provider class.
        /// </summary>
        public Provider()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Provider class.
        /// </summary>
        /// <param name="id">The provider ID.</param>
        /// <param name="namespaceProperty">The namespace of the resource
        /// provider.</param>
        /// <param name="registrationState">The registration state of the
        /// resource provider.</param>
        /// <param name="registrationPolicy">The registration policy of the
        /// resource provider.</param>
        /// <param name="resourceTypes">The collection of provider resource
        /// types.</param>
        public Provider(string id = default(string), string namespaceProperty = default(string), string registrationState = default(string), string registrationPolicy = default(string), IList<ProviderResourceType> resourceTypes = default(IList<ProviderResourceType>))
        {
            Id = id;
            NamespaceProperty = namespaceProperty;
            RegistrationState = registrationState;
            RegistrationPolicy = registrationPolicy;
            ResourceTypes = resourceTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provider ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the namespace of the resource provider.
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// Gets the registration state of the resource provider.
        /// </summary>
        [JsonProperty(PropertyName = "registrationState")]
        public string RegistrationState { get; private set; }

        /// <summary>
        /// Gets the registration policy of the resource provider.
        /// </summary>
        [JsonProperty(PropertyName = "registrationPolicy")]
        public string RegistrationPolicy { get; private set; }

        /// <summary>
        /// Gets the collection of provider resource types.
        /// </summary>
        [JsonProperty(PropertyName = "resourceTypes")]
        public IList<ProviderResourceType> ResourceTypes { get; private set; }

    }
}
