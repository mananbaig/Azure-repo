// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary>
    /// The value of the translation property is a dictionary of (key, value) pairs. Each key is a BCP 47 language tag.
    /// A key identifies a language for which text can be translated to or translated from.
    /// </summary>
    public partial class TranslationLanguage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of TranslationLanguage. </summary>
        /// <param name="name"> Display name of the language in the locale requested via Accept-Language header. </param>
        /// <param name="nativeName"> Display name of the language in the locale native for this language. </param>
        /// <param name="dir"> Directionality, which is rtl for right-to-left languages or ltr for left-to-right languages. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="nativeName"/> or <paramref name="dir"/> is null. </exception>
        internal TranslationLanguage(string name, string nativeName, string dir)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(nativeName, nameof(nativeName));
            Argument.AssertNotNull(dir, nameof(dir));

            Name = name;
            NativeName = nativeName;
            Dir = dir;
        }

        /// <summary> Initializes a new instance of TranslationLanguage. </summary>
        /// <param name="name"> Display name of the language in the locale requested via Accept-Language header. </param>
        /// <param name="nativeName"> Display name of the language in the locale native for this language. </param>
        /// <param name="dir"> Directionality, which is rtl for right-to-left languages or ltr for left-to-right languages. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TranslationLanguage(string name, string nativeName, string dir, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            NativeName = nativeName;
            Dir = dir;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TranslationLanguage"/> for deserialization. </summary>
        internal TranslationLanguage()
        {
        }

        /// <summary> Display name of the language in the locale requested via Accept-Language header. </summary>
        public string Name { get; }
        /// <summary> Display name of the language in the locale native for this language. </summary>
        public string NativeName { get; }
        /// <summary> Directionality, which is rtl for right-to-left languages or ltr for left-to-right languages. </summary>
        public string Dir { get; }
    }
}
