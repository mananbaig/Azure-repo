// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevSpaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ResourceProviderOperationDefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceProviderOperationDefinition class.
        /// </summary>
        public ResourceProviderOperationDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceProviderOperationDefinition class.
        /// </summary>
        /// <param name="name">Resource provider operation name.</param>
        public ResourceProviderOperationDefinition(string name = default(string), ResourceProviderOperationDisplay display = default(ResourceProviderOperationDisplay))
        {
            Name = name;
            Display = display;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource provider operation name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public ResourceProviderOperationDisplay Display { get; set; }

    }
}
