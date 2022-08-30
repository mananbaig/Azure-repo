// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// The base definition of the custom setup.
    /// Please note <see cref="CustomSetupBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzPowerShellSetup"/>, <see cref="CmdkeySetup"/>, <see cref="ComponentSetup"/> and <see cref="EnvironmentVariableSetup"/>.
    /// </summary>
    public abstract partial class CustomSetupBase
    {
        /// <summary> Initializes a new instance of CustomSetupBase. </summary>
        protected CustomSetupBase()
        {
        }

        /// <summary> Initializes a new instance of CustomSetupBase. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        internal CustomSetupBase(string customSetupBaseType)
        {
            CustomSetupBaseType = customSetupBaseType;
        }

        /// <summary> The type of custom setup. </summary>
        internal string CustomSetupBaseType { get; set; }
    }
}
