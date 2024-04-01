// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.Chat
{
    /// <summary>
    /// Data retention policy for auto deletion.
    /// Please note <see cref="ChatRetentionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="NoneRetentionPolicy"/> and <see cref="ThreadCreationDateRetentionPolicy"/>.
    /// </summary>
    public abstract partial class ChatRetentionPolicy
    {
        /// <summary> Initializes a new instance of <see cref="ChatRetentionPolicy"/>. </summary>
        protected ChatRetentionPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ChatRetentionPolicy"/>. </summary>
        /// <param name="kind"> Retention Policy Type. </param>
        internal ChatRetentionPolicy(RetentionPolicyKind kind)
        {
            Kind = kind;
        }

        /// <summary> Retention Policy Type. </summary>
        internal RetentionPolicyKind Kind { get; set; }
    }
}
