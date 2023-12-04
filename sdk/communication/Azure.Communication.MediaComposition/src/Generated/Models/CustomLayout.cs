// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    /// <summary> Configure custom layout. </summary>
    public partial class CustomLayout : MediaCompositionLayout
    {
        /// <summary> Initializes a new instance of <see cref="CustomLayout"/>. </summary>
        /// <param name="inputGroups">
        /// Configure input groups of the layout
        /// Please note <see cref="InputGroup"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoGridInputGroup"/> and <see cref="GridInputGroup"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputGroups"/> is null. </exception>
        public CustomLayout(IDictionary<string, InputGroup> inputGroups)
        {
            Argument.AssertNotNull(inputGroups, nameof(inputGroups));

            Layers = new ChangeTrackingDictionary<string, LayoutLayer>();
            InputGroups = inputGroups;
            Kind = LayoutType.Custom;
        }

        /// <summary> Initializes a new instance of <see cref="CustomLayout"/>. </summary>
        /// <param name="kind"> Kind of layout. </param>
        /// <param name="resolution"> The dimensions of the scene or objects in the scene. </param>
        /// <param name="placeholderImageUri"> Set global placeholder image. </param>
        /// <param name="scalingMode"> The scaling mode for the view of a video stream in a cell. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="layers"> Configure layer to control the z-position of input groups. </param>
        /// <param name="inputGroups">
        /// Configure input groups of the layout
        /// Please note <see cref="InputGroup"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoGridInputGroup"/> and <see cref="GridInputGroup"/>.
        /// </param>
        internal CustomLayout(LayoutType kind, LayoutResolution resolution, string placeholderImageUri, ScalingMode? scalingMode, IDictionary<string, BinaryData> serializedAdditionalRawData, IDictionary<string, LayoutLayer> layers, IDictionary<string, InputGroup> inputGroups) : base(kind, resolution, placeholderImageUri, scalingMode, serializedAdditionalRawData)
        {
            Layers = layers;
            InputGroups = inputGroups;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="CustomLayout"/> for deserialization. </summary>
        internal CustomLayout()
        {
        }

        /// <summary> Configure layer to control the z-position of input groups. </summary>
        public IDictionary<string, LayoutLayer> Layers { get; }
        /// <summary>
        /// Configure input groups of the layout
        /// Please note <see cref="InputGroup"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoGridInputGroup"/> and <see cref="GridInputGroup"/>.
        /// </summary>
        public IDictionary<string, InputGroup> InputGroups { get; }
    }
}
