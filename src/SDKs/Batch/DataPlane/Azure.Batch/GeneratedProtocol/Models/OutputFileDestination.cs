// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// The destination to which a file should be uploaded.
    /// </summary>
    public partial class OutputFileDestination
    {
        /// <summary>
        /// Initializes a new instance of the OutputFileDestination class.
        /// </summary>
        public OutputFileDestination() { }

        /// <summary>
        /// Initializes a new instance of the OutputFileDestination class.
        /// </summary>
        /// <param name="container">A location in Azure blob storage to which
        /// files are uploaded.</param>
        public OutputFileDestination(OutputFileBlobContainerDestination container = default(OutputFileBlobContainerDestination))
        {
            this.Container = container;
        }

        /// <summary>
        /// Gets or sets a location in Azure blob storage to which files are
        /// uploaded.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "container")]
        public OutputFileBlobContainerDestination Container { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Container != null)
            {
                this.Container.Validate();
            }
        }
    }
}
