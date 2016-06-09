// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SnowballAnalyzerLanguage.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SnowballAnalyzerLanguage
    {
        [EnumMember(Value = "danish")]
        Danish,
        [EnumMember(Value = "dutch")]
        Dutch,
        [EnumMember(Value = "english")]
        English,
        [EnumMember(Value = "finnish")]
        Finnish,
        [EnumMember(Value = "french")]
        French,
        [EnumMember(Value = "german")]
        German,
        [EnumMember(Value = "hungarian")]
        Hungarian,
        [EnumMember(Value = "italian")]
        Italian,
        [EnumMember(Value = "norwegian")]
        Norwegian,
        [EnumMember(Value = "portuguese")]
        Portuguese,
        [EnumMember(Value = "russian")]
        Russian,
        [EnumMember(Value = "spanish")]
        Spanish,
        [EnumMember(Value = "swedish")]
        Swedish
    }
}
