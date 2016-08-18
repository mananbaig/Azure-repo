// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{

    /// <summary>
    /// Defines values for Kind.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Kind
    {
        [System.Runtime.Serialization.EnumMember(Value = "Storage")]
        Storage,
        [System.Runtime.Serialization.EnumMember(Value = "BlobStorage")]
        BlobStorage
    }
}
