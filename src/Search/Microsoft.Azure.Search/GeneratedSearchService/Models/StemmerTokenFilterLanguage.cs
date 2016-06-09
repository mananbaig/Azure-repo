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
    /// Defines values for StemmerTokenFilterLanguage.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StemmerTokenFilterLanguage
    {
        [EnumMember(Value = "arabic")]
        Arabic,
        [EnumMember(Value = "armenian")]
        Armenian,
        [EnumMember(Value = "basque")]
        Basque,
        [EnumMember(Value = "brazilian")]
        Brazilian,
        [EnumMember(Value = "bulgarian")]
        Bulgarian,
        [EnumMember(Value = "catalan")]
        Catalan,
        [EnumMember(Value = "czech")]
        Czech,
        [EnumMember(Value = "danish")]
        Danish,
        [EnumMember(Value = "dutch")]
        Dutch,
        [EnumMember(Value = "dutch_kp")]
        DutchKp,
        [EnumMember(Value = "english")]
        English,
        [EnumMember(Value = "light_english")]
        LightEnglish,
        [EnumMember(Value = "minimal_english")]
        MinimalEnglish,
        [EnumMember(Value = "possessive_english")]
        PossessiveEnglish,
        [EnumMember(Value = "porter2")]
        Porter2,
        [EnumMember(Value = "lovins")]
        Lovins,
        [EnumMember(Value = "finnish")]
        Finnish,
        [EnumMember(Value = "light_finnish")]
        LightFinnish,
        [EnumMember(Value = "french")]
        French,
        [EnumMember(Value = "light_french")]
        LightFrench,
        [EnumMember(Value = "minimal_french")]
        MinimalFrench,
        [EnumMember(Value = "galician")]
        Galician,
        [EnumMember(Value = "minimal_galician")]
        MinimalGalician,
        [EnumMember(Value = "german")]
        German,
        [EnumMember(Value = "german2")]
        German2,
        [EnumMember(Value = "light_german")]
        LightGerman,
        [EnumMember(Value = "minimal_german")]
        MinimalGerman,
        [EnumMember(Value = "greek")]
        Greek,
        [EnumMember(Value = "hindi")]
        Hindi,
        [EnumMember(Value = "hungarian")]
        Hungarian,
        [EnumMember(Value = "light_hungarian")]
        LightHungarian,
        [EnumMember(Value = "indonesian")]
        Indonesian,
        [EnumMember(Value = "irish")]
        Irish,
        [EnumMember(Value = "italian")]
        Italian,
        [EnumMember(Value = "light_italian")]
        LightItalian,
        [EnumMember(Value = "sorani")]
        Sorani,
        [EnumMember(Value = "latvian")]
        Latvian,
        [EnumMember(Value = "norwegian")]
        Norwegian,
        [EnumMember(Value = "light_norwegian")]
        LightNorwegian,
        [EnumMember(Value = "minimal_norwegian")]
        MinimalNorwegian,
        [EnumMember(Value = "light_nynorsk")]
        LightNynorsk,
        [EnumMember(Value = "minimal_nynorsk")]
        MinimalNynorsk,
        [EnumMember(Value = "portuguese")]
        Portuguese,
        [EnumMember(Value = "light_portuguese")]
        LightPortuguese,
        [EnumMember(Value = "minimal_portuguese")]
        MinimalPortuguese,
        [EnumMember(Value = "portuguese_rslp")]
        PortugueseRslp,
        [EnumMember(Value = "romanian")]
        Romanian,
        [EnumMember(Value = "russian")]
        Russian,
        [EnumMember(Value = "light_russian")]
        LightRussian,
        [EnumMember(Value = "spanish")]
        Spanish,
        [EnumMember(Value = "light_spanish")]
        LightSpanish,
        [EnumMember(Value = "swedish")]
        Swedish,
        [EnumMember(Value = "light_swedish")]
        LightSwedish,
        [EnumMember(Value = "turkish")]
        Turkish
    }
}
