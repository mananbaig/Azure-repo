// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Localizable String object containing the name and a localized value. </summary>
    public partial class SignalRUsageName
    {
        /// <summary> Initializes a new instance of SignalRUsageName. </summary>
        internal SignalRUsageName()
        {
        }

        /// <summary> Initializes a new instance of SignalRUsageName. </summary>
        /// <param name="value"> The identifier of the usage. </param>
        /// <param name="localizedValue"> Localized name of the usage. </param>
        internal SignalRUsageName(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> The identifier of the usage. </summary>
        public string Value { get; }
        /// <summary> Localized name of the usage. </summary>
        public string LocalizedValue { get; }
    }
}
