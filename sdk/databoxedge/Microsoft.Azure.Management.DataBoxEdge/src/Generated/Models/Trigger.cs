// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using System.Linq;

    /// <summary>
    /// Trigger details.
    /// </summary>
    public partial class Trigger : ARMBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the Trigger class.
        /// </summary>
        public Trigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Trigger class.
        /// </summary>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The object name.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        public Trigger(string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
