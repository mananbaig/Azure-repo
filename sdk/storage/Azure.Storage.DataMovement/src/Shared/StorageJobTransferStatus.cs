﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Storage.DataMovement.Models
{
    /// <summary>
    /// Defines the status of the <see cref="TransferJobInternal"/>.
    /// </summary>
    public enum StorageJobTransferStatus
    {
        /// <summary>
        /// The Job has been queued up but has not yet begun any transfers.
        /// </summary>
        Queued,

        /// <summary>
        /// The Job has started, but has not yet completed.
        /// </summary>
        InProgress,

        /// <summary>
        /// The Job has completed with no failures.
        /// </summary>
        CompletedSuccessful,

        /// <summary>
        /// The Job has completed with failures.
        /// </summary>
        Failed,

        // TODO: should we create a status to show that it has completed with some failures?
        // e.g. was able to copy some files in a directory but not all..
    };
}
