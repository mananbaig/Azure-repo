// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A processor that allows the media graph to send video frames (mostly at
    /// low frame rates e.g. &lt;5 fps) to an external inference container over
    /// an HTTP-based RESTful API. Inference results are relayed to downstream
    /// nodes.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.MediaGraphHttpExtension")]
    public partial class MediaGraphHttpExtension : MediaGraphExtensionProcessorBase
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphHttpExtension class.
        /// </summary>
        public MediaGraphHttpExtension()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphHttpExtension class.
        /// </summary>
        /// <param name="name">The name for this processor node.</param>
        /// <param name="inputs">An array of the names of the other nodes in
        /// the media graph, the outputs of which are used as input for this
        /// processor node.</param>
        /// <param name="endpoint">Endpoint to which this processor should
        /// connect.</param>
        /// <param name="image">Describes the parameters of the image that is
        /// sent as input to the endpoint.</param>
        public MediaGraphHttpExtension(string name, IList<MediaGraphNodeInput> inputs, MediaGraphEndpoint endpoint = default(MediaGraphEndpoint), MediaGraphImage image = default(MediaGraphImage))
            : base(name, inputs, endpoint, image)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
