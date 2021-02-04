﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Azure.AI.TextAnalytics.Models;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// RecognizeEntitiesActionResult
    /// </summary>
    public class RecognizeEntitiesActionResult : TextAnalyticsActionDetails
    {
        internal RecognizeEntitiesActionResult(RecognizeEntitiesResultCollection result, DateTimeOffset completedOn, IReadOnlyList<TextAnalyticsErrorInternal> errors, bool hasError) : base(completedOn, errors, hasError)
        {
            Result = result;
        }

        /// <summary>
        /// Results
        /// </summary>
        public RecognizeEntitiesResultCollection Result { get; }
    }
}
