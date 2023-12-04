// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> Unknown version of WorkerSelectorAttachment. </summary>
    internal partial class UnknownWorkerSelectorAttachment : WorkerSelectorAttachment
    {
        /// <summary> Initializes a new instance of <see cref="UnknownWorkerSelectorAttachment"/>. </summary>
        internal UnknownWorkerSelectorAttachment()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownWorkerSelectorAttachment"/>. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of WorkerSelectorAttachment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownWorkerSelectorAttachment(WorkerSelectorAttachmentKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, serializedAdditionalRawData)
        {
        }
    }
}
