// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Communication.MediaComposition;

namespace Azure.Communication.MediaComposition.Models
{
    /// <summary> Configure a layout. </summary>
    public partial class MediaCompositionLayout
    {
        /// <summary> Initializes a new instance of MediaCompositionLayout. </summary>
        public MediaCompositionLayout()
        {
        }

        /// <summary> Initializes a new instance of MediaCompositionLayout. </summary>
        /// <param name="resolution"> The dimensions of the scene or objects in the scene. </param>
        /// <param name="grid"> Configure the grid layout. </param>
        /// <param name="autoGrid"> Configure the autogrid layout. </param>
        /// <param name="presenter"> Configure the presenter layout. </param>
        /// <param name="presentation"> Configure the presentation layout. </param>
        /// <param name="custom"> Configure custom layout. </param>
        /// <param name="placeholderImageUri"> Set global placeholder image. </param>
        /// <param name="kind"> Kind of layout. </param>
        internal MediaCompositionLayout(LayoutResolution resolution, GridLayoutOptions grid, AutoGridLayoutOptions autoGrid, PresenterLayoutOptions presenter, PresentationLayoutOptions presentation, CustomLayoutOptions custom, string placeholderImageUri, LayoutType? kind)
        {
            Resolution = resolution;
            Grid = grid;
            AutoGrid = autoGrid;
            Presenter = presenter;
            Presentation = presentation;
            Custom = custom;
            PlaceholderImageUri = placeholderImageUri;
            Kind = kind;
        }

        /// <summary> The dimensions of the scene or objects in the scene. </summary>
        public LayoutResolution Resolution { get; set; }
        /// <summary> Configure the grid layout. </summary>
        public GridLayoutOptions Grid { get; set; }
        /// <summary> Configure the autogrid layout. </summary>
        public AutoGridLayoutOptions AutoGrid { get; set; }
        /// <summary> Configure the presenter layout. </summary>
        public PresenterLayoutOptions Presenter { get; set; }
        /// <summary> Configure the presentation layout. </summary>
        public PresentationLayoutOptions Presentation { get; set; }
        /// <summary> Configure custom layout. </summary>
        public CustomLayoutOptions Custom { get; set; }
        /// <summary> Set global placeholder image. </summary>
        public string PlaceholderImageUri { get; set; }
        /// <summary> Kind of layout. </summary>
        public LayoutType? Kind { get; set; }
    }
}
