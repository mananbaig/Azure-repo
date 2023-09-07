// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Job output processing event data. Schema of the data property of an EventGridEvent for a Microsoft.Media.JobOutputProcessing event. </summary>
    public partial class MediaJobOutputProcessingEventData : MediaJobOutputStateChangeEventData
    {
        /// <summary> Initializes a new instance of <see cref="MediaJobOutputProcessingEventData"/>. </summary>
        internal MediaJobOutputProcessingEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobOutputProcessingEventData"/>. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="output">
        /// Gets the output.
        /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
        /// </param>
        /// <param name="jobCorrelationData"> Gets the Job correlation data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaJobOutputProcessingEventData(MediaJobState? previousState, MediaJobOutput output, IReadOnlyDictionary<string, string> jobCorrelationData, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(previousState, output, jobCorrelationData, serializedAdditionalRawData)
        {
        }
    }
}
