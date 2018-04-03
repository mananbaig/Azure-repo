// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MicrosoftTokenizerLanguage.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MicrosoftTokenizerLanguage
    {
        [EnumMember(Value = "bangla")]
        Bangla,
        [EnumMember(Value = "bulgarian")]
        Bulgarian,
        [EnumMember(Value = "catalan")]
        Catalan,
        [EnumMember(Value = "chineseSimplified")]
        ChineseSimplified,
        [EnumMember(Value = "chineseTraditional")]
        ChineseTraditional,
        [EnumMember(Value = "croatian")]
        Croatian,
        [EnumMember(Value = "czech")]
        Czech,
        [EnumMember(Value = "danish")]
        Danish,
        [EnumMember(Value = "dutch")]
        Dutch,
        [EnumMember(Value = "english")]
        English,
        [EnumMember(Value = "french")]
        French,
        [EnumMember(Value = "german")]
        German,
        [EnumMember(Value = "greek")]
        Greek,
        [EnumMember(Value = "gujarati")]
        Gujarati,
        [EnumMember(Value = "hindi")]
        Hindi,
        [EnumMember(Value = "icelandic")]
        Icelandic,
        [EnumMember(Value = "indonesian")]
        Indonesian,
        [EnumMember(Value = "italian")]
        Italian,
        [EnumMember(Value = "japanese")]
        Japanese,
        [EnumMember(Value = "kannada")]
        Kannada,
        [EnumMember(Value = "korean")]
        Korean,
        [EnumMember(Value = "malay")]
        Malay,
        [EnumMember(Value = "malayalam")]
        Malayalam,
        [EnumMember(Value = "marathi")]
        Marathi,
        [EnumMember(Value = "norwegianBokmaal")]
        NorwegianBokmaal,
        [EnumMember(Value = "polish")]
        Polish,
        [EnumMember(Value = "portuguese")]
        Portuguese,
        [EnumMember(Value = "portugueseBrazilian")]
        PortugueseBrazilian,
        [EnumMember(Value = "punjabi")]
        Punjabi,
        [EnumMember(Value = "romanian")]
        Romanian,
        [EnumMember(Value = "russian")]
        Russian,
        [EnumMember(Value = "serbianCyrillic")]
        SerbianCyrillic,
        [EnumMember(Value = "serbianLatin")]
        SerbianLatin,
        [EnumMember(Value = "slovenian")]
        Slovenian,
        [EnumMember(Value = "spanish")]
        Spanish,
        [EnumMember(Value = "swedish")]
        Swedish,
        [EnumMember(Value = "tamil")]
        Tamil,
        [EnumMember(Value = "telugu")]
        Telugu,
        [EnumMember(Value = "thai")]
        Thai,
        [EnumMember(Value = "ukrainian")]
        Ukrainian,
        [EnumMember(Value = "urdu")]
        Urdu,
        [EnumMember(Value = "vietnamese")]
        Vietnamese
    }
    internal static class MicrosoftTokenizerLanguageEnumExtension
    {
        internal static string ToSerializedValue(this MicrosoftTokenizerLanguage? value)
        {
            return value == null ? null : ((MicrosoftTokenizerLanguage)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MicrosoftTokenizerLanguage value)
        {
            switch( value )
            {
                case MicrosoftTokenizerLanguage.Bangla:
                    return "bangla";
                case MicrosoftTokenizerLanguage.Bulgarian:
                    return "bulgarian";
                case MicrosoftTokenizerLanguage.Catalan:
                    return "catalan";
                case MicrosoftTokenizerLanguage.ChineseSimplified:
                    return "chineseSimplified";
                case MicrosoftTokenizerLanguage.ChineseTraditional:
                    return "chineseTraditional";
                case MicrosoftTokenizerLanguage.Croatian:
                    return "croatian";
                case MicrosoftTokenizerLanguage.Czech:
                    return "czech";
                case MicrosoftTokenizerLanguage.Danish:
                    return "danish";
                case MicrosoftTokenizerLanguage.Dutch:
                    return "dutch";
                case MicrosoftTokenizerLanguage.English:
                    return "english";
                case MicrosoftTokenizerLanguage.French:
                    return "french";
                case MicrosoftTokenizerLanguage.German:
                    return "german";
                case MicrosoftTokenizerLanguage.Greek:
                    return "greek";
                case MicrosoftTokenizerLanguage.Gujarati:
                    return "gujarati";
                case MicrosoftTokenizerLanguage.Hindi:
                    return "hindi";
                case MicrosoftTokenizerLanguage.Icelandic:
                    return "icelandic";
                case MicrosoftTokenizerLanguage.Indonesian:
                    return "indonesian";
                case MicrosoftTokenizerLanguage.Italian:
                    return "italian";
                case MicrosoftTokenizerLanguage.Japanese:
                    return "japanese";
                case MicrosoftTokenizerLanguage.Kannada:
                    return "kannada";
                case MicrosoftTokenizerLanguage.Korean:
                    return "korean";
                case MicrosoftTokenizerLanguage.Malay:
                    return "malay";
                case MicrosoftTokenizerLanguage.Malayalam:
                    return "malayalam";
                case MicrosoftTokenizerLanguage.Marathi:
                    return "marathi";
                case MicrosoftTokenizerLanguage.NorwegianBokmaal:
                    return "norwegianBokmaal";
                case MicrosoftTokenizerLanguage.Polish:
                    return "polish";
                case MicrosoftTokenizerLanguage.Portuguese:
                    return "portuguese";
                case MicrosoftTokenizerLanguage.PortugueseBrazilian:
                    return "portugueseBrazilian";
                case MicrosoftTokenizerLanguage.Punjabi:
                    return "punjabi";
                case MicrosoftTokenizerLanguage.Romanian:
                    return "romanian";
                case MicrosoftTokenizerLanguage.Russian:
                    return "russian";
                case MicrosoftTokenizerLanguage.SerbianCyrillic:
                    return "serbianCyrillic";
                case MicrosoftTokenizerLanguage.SerbianLatin:
                    return "serbianLatin";
                case MicrosoftTokenizerLanguage.Slovenian:
                    return "slovenian";
                case MicrosoftTokenizerLanguage.Spanish:
                    return "spanish";
                case MicrosoftTokenizerLanguage.Swedish:
                    return "swedish";
                case MicrosoftTokenizerLanguage.Tamil:
                    return "tamil";
                case MicrosoftTokenizerLanguage.Telugu:
                    return "telugu";
                case MicrosoftTokenizerLanguage.Thai:
                    return "thai";
                case MicrosoftTokenizerLanguage.Ukrainian:
                    return "ukrainian";
                case MicrosoftTokenizerLanguage.Urdu:
                    return "urdu";
                case MicrosoftTokenizerLanguage.Vietnamese:
                    return "vietnamese";
            }
            return null;
        }

        internal static MicrosoftTokenizerLanguage? ParseMicrosoftTokenizerLanguage(this string value)
        {
            switch( value )
            {
                case "bangla":
                    return MicrosoftTokenizerLanguage.Bangla;
                case "bulgarian":
                    return MicrosoftTokenizerLanguage.Bulgarian;
                case "catalan":
                    return MicrosoftTokenizerLanguage.Catalan;
                case "chineseSimplified":
                    return MicrosoftTokenizerLanguage.ChineseSimplified;
                case "chineseTraditional":
                    return MicrosoftTokenizerLanguage.ChineseTraditional;
                case "croatian":
                    return MicrosoftTokenizerLanguage.Croatian;
                case "czech":
                    return MicrosoftTokenizerLanguage.Czech;
                case "danish":
                    return MicrosoftTokenizerLanguage.Danish;
                case "dutch":
                    return MicrosoftTokenizerLanguage.Dutch;
                case "english":
                    return MicrosoftTokenizerLanguage.English;
                case "french":
                    return MicrosoftTokenizerLanguage.French;
                case "german":
                    return MicrosoftTokenizerLanguage.German;
                case "greek":
                    return MicrosoftTokenizerLanguage.Greek;
                case "gujarati":
                    return MicrosoftTokenizerLanguage.Gujarati;
                case "hindi":
                    return MicrosoftTokenizerLanguage.Hindi;
                case "icelandic":
                    return MicrosoftTokenizerLanguage.Icelandic;
                case "indonesian":
                    return MicrosoftTokenizerLanguage.Indonesian;
                case "italian":
                    return MicrosoftTokenizerLanguage.Italian;
                case "japanese":
                    return MicrosoftTokenizerLanguage.Japanese;
                case "kannada":
                    return MicrosoftTokenizerLanguage.Kannada;
                case "korean":
                    return MicrosoftTokenizerLanguage.Korean;
                case "malay":
                    return MicrosoftTokenizerLanguage.Malay;
                case "malayalam":
                    return MicrosoftTokenizerLanguage.Malayalam;
                case "marathi":
                    return MicrosoftTokenizerLanguage.Marathi;
                case "norwegianBokmaal":
                    return MicrosoftTokenizerLanguage.NorwegianBokmaal;
                case "polish":
                    return MicrosoftTokenizerLanguage.Polish;
                case "portuguese":
                    return MicrosoftTokenizerLanguage.Portuguese;
                case "portugueseBrazilian":
                    return MicrosoftTokenizerLanguage.PortugueseBrazilian;
                case "punjabi":
                    return MicrosoftTokenizerLanguage.Punjabi;
                case "romanian":
                    return MicrosoftTokenizerLanguage.Romanian;
                case "russian":
                    return MicrosoftTokenizerLanguage.Russian;
                case "serbianCyrillic":
                    return MicrosoftTokenizerLanguage.SerbianCyrillic;
                case "serbianLatin":
                    return MicrosoftTokenizerLanguage.SerbianLatin;
                case "slovenian":
                    return MicrosoftTokenizerLanguage.Slovenian;
                case "spanish":
                    return MicrosoftTokenizerLanguage.Spanish;
                case "swedish":
                    return MicrosoftTokenizerLanguage.Swedish;
                case "tamil":
                    return MicrosoftTokenizerLanguage.Tamil;
                case "telugu":
                    return MicrosoftTokenizerLanguage.Telugu;
                case "thai":
                    return MicrosoftTokenizerLanguage.Thai;
                case "ukrainian":
                    return MicrosoftTokenizerLanguage.Ukrainian;
                case "urdu":
                    return MicrosoftTokenizerLanguage.Urdu;
                case "vietnamese":
                    return MicrosoftTokenizerLanguage.Vietnamese;
            }
            return null;
        }
    }
}
