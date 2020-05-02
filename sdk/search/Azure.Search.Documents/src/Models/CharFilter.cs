﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Search.Documents.Models
{
    public partial class CharFilter
    {
        /// <summary> Initializes a new instance of CharFilter. </summary>
        /// <param name="name"> The name of the char filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        private protected CharFilter(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
