// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal static partial class KeyVaultCreateModeExtensions
    {
        public static string ToSerialString(this KeyVaultCreateMode value) => value switch
        {
            KeyVaultCreateMode.Default => "default",
            KeyVaultCreateMode.Recover => "recover",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyVaultCreateMode value.")
        };

        public static KeyVaultCreateMode ToKeyVaultCreateMode(this string value)
        {
            if (string.Equals(value, "default", StringComparison.InvariantCultureIgnoreCase)) return KeyVaultCreateMode.Default;
            if (string.Equals(value, "recover", StringComparison.InvariantCultureIgnoreCase)) return KeyVaultCreateMode.Recover;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyVaultCreateMode value.");
        }
    }
}
