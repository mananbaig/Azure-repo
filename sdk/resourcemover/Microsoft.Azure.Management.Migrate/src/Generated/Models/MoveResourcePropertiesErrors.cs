// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Migrate.ResourceMover.Models
{
    using System.Linq;

    /// <summary>
    /// Defines the move resource errors.
    /// </summary>
    public partial class MoveResourcePropertiesErrors : MoveResourceError
    {
        /// <summary>
        /// Initializes a new instance of the MoveResourcePropertiesErrors
        /// class.
        /// </summary>
        public MoveResourcePropertiesErrors()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MoveResourcePropertiesErrors
        /// class.
        /// </summary>
        /// <param name="properties">The move resource error body.</param>
        public MoveResourcePropertiesErrors(MoveResourceErrorBody properties = default(MoveResourceErrorBody))
            : base(properties)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
