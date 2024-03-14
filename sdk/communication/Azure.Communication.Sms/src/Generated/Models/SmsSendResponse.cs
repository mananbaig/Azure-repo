// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication.Sms;

namespace Azure.Communication.Sms.Models
{
    /// <summary> Response for a successful or multi status send Sms request. </summary>
    internal partial class SmsSendResponse
    {
        /// <summary> Initializes a new instance of <see cref="SmsSendResponse"/>. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SmsSendResponse(IEnumerable<SmsSendResult> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SmsSendResponse"/>. </summary>
        /// <param name="value"></param>
        internal SmsSendResponse(IReadOnlyList<SmsSendResult> value)
        {
            Value = value;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<SmsSendResult> Value { get; }
    }
}
