// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The UnknownAutomationAction. </summary>
    internal partial class UnknownAutomationAction : SecurityAutomationAction
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAutomationAction"/>. </summary>
        /// <param name="actionType"> The type of the action that will be triggered by the Automation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAutomationAction(ActionType actionType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(actionType, serializedAdditionalRawData)
        {
            ActionType = actionType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAutomationAction"/> for deserialization. </summary>
        internal UnknownAutomationAction()
        {
        }
    }
}
