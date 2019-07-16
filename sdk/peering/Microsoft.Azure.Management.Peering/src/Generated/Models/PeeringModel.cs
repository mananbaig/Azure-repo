// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Peering is a logical representation of a set of connections to the
    /// Microsoft Cloud Edge at a location.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PeeringModel : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PeeringModel class.
        /// </summary>
        public PeeringModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeeringModel class.
        /// </summary>
        /// <param name="sku">The SKU that defines the tier and kind of the
        /// peering.</param>
        /// <param name="kind">The kind of the peering. Possible values
        /// include: 'Direct', 'Exchange'</param>
        /// <param name="location">The location of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="direct">The properties that define a direct
        /// peering.</param>
        /// <param name="exchange">The properties that define an exchange
        /// peering.</param>
        /// <param name="peeringLocation">The location of the peering.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="tags">The resource tags.</param>
        public PeeringModel(PeeringSku sku, string kind, string location, string name = default(string), string id = default(string), string type = default(string), PeeringPropertiesDirect direct = default(PeeringPropertiesDirect), PeeringPropertiesExchange exchange = default(PeeringPropertiesExchange), string peeringLocation = default(string), string provisioningState = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(name, id, type)
        {
            Sku = sku;
            Kind = kind;
            Direct = direct;
            Exchange = exchange;
            PeeringLocation = peeringLocation;
            ProvisioningState = provisioningState;
            Location = location;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU that defines the tier and kind of the peering.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public PeeringSku Sku { get; set; }

        /// <summary>
        /// Gets or sets the kind of the peering. Possible values include:
        /// 'Direct', 'Exchange'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets the properties that define a direct peering.
        /// </summary>
        [JsonProperty(PropertyName = "properties.direct")]
        public PeeringPropertiesDirect Direct { get; set; }

        /// <summary>
        /// Gets or sets the properties that define an exchange peering.
        /// </summary>
        [JsonProperty(PropertyName = "properties.exchange")]
        public PeeringPropertiesExchange Exchange { get; set; }

        /// <summary>
        /// Gets or sets the location of the peering.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringLocation")]
        public string PeeringLocation { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Kind == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Kind");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
