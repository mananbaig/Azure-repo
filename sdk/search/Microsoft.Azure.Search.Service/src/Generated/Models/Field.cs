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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a field in an index definition, which describes the name,
    /// data type, and search behavior of a field.
    /// <see
    /// href="https://docs.microsoft.com/rest/api/searchservice/Create-Index"
    /// />
    /// </summary>
    public partial class Field
    {
        /// <summary>
        /// Initializes a new instance of the Field class.
        /// </summary>
        internal Field()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Field class.
        /// </summary>
        /// <param name="name">The name of the field, which must be unique
        /// within the fields collection of the index or parent field.</param>
        /// <param name="type">The data type of the field. Possible values
        /// include: 'Edm.String', 'Edm.Int32', 'Edm.Int64', 'Edm.Double',
        /// 'Edm.Boolean', 'Edm.DateTimeOffset', 'Edm.GeographyPoint',
        /// 'Edm.ComplexType'</param>
        /// <param name="key">A value indicating whether the field uniquely
        /// identifies documents in the index. Exactly one top-level field in
        /// each index must be chosen as the key field and it must be of type
        /// Edm.String. Key fields can be used to look up documents directly
        /// and update or delete specific documents. Default is false for
        /// simple fields and null for complex fields.</param>
        /// <param name="retrievable">A value indicating whether the field can
        /// be returned in a search result. You can disable this option if you
        /// want to use a field (for example, margin) as a filter, sorting, or
        /// scoring mechanism but do not want the field to be visible to the
        /// end user. This property must be true for key fields, and it must be
        /// null for complex fields. This property can be changed on existing
        /// fields. Enabling this property does not cause any increase in index
        /// storage requirements. Default is true for simple fields and null
        /// for complex fields.</param>
        /// <param name="searchable">A value indicating whether the field is
        /// full-text searchable. This means it will undergo analysis such as
        /// word-breaking during indexing. If you set a searchable field to a
        /// value like "sunny day", internally it will be split into the
        /// individual tokens "sunny" and "day". This enables full-text
        /// searches for these terms. Fields of type Edm.String or
        /// Collection(Edm.String) are searchable by default. This property
        /// must be false for simple fields of other non-string data types, and
        /// it must be null for complex fields. Note: searchable fields consume
        /// extra space in your index since Azure Cognitive Search will store
        /// an additional tokenized version of the field value for full-text
        /// searches. If you want to save space in your index and you don't
        /// need a field to be included in searches, set searchable to
        /// false.</param>
        /// <param name="filterable">A value indicating whether to enable the
        /// field to be referenced in $filter queries. filterable differs from
        /// searchable in how strings are handled. Fields of type Edm.String or
        /// Collection(Edm.String) that are filterable do not undergo
        /// word-breaking, so comparisons are for exact matches only. For
        /// example, if you set such a field f to "sunny day", $filter=f eq
        /// 'sunny' will find no matches, but $filter=f eq 'sunny day' will.
        /// This property must be null for complex fields. Default is true for
        /// simple fields and null for complex fields.</param>
        /// <param name="sortable">A value indicating whether to enable the
        /// field to be referenced in $orderby expressions. By default Azure
        /// Cognitive Search sorts results by score, but in many experiences
        /// users will want to sort by fields in the documents. A simple field
        /// can be sortable only if it is single-valued (it has a single value
        /// in the scope of the parent document). Simple collection fields
        /// cannot be sortable, since they are multi-valued. Simple sub-fields
        /// of complex collections are also multi-valued, and therefore cannot
        /// be sortable. This is true whether it's an immediate parent field,
        /// or an ancestor field, that's the complex collection. Complex fields
        /// cannot be sortable and the sortable property must be null for such
        /// fields. The default for sortable is true for single-valued simple
        /// fields, false for multi-valued simple fields, and null for complex
        /// fields.</param>
        /// <param name="facetable">A value indicating whether to enable the
        /// field to be referenced in facet queries. Typically used in a
        /// presentation of search results that includes hit count by category
        /// (for example, search for digital cameras and see hits by brand, by
        /// megapixels, by price, and so on). This property must be null for
        /// complex fields. Fields of type Edm.GeographyPoint or
        /// Collection(Edm.GeographyPoint) cannot be facetable. Default is true
        /// for all other simple fields.</param>
        /// <param name="analyzer">The name of the language analyzer to use for
        /// the field. This option can be used only with searchable fields and
        /// it can't be set together with either searchAnalyzer or
        /// indexAnalyzer. Once the analyzer is chosen, it cannot be changed
        /// for the field. Must be null for complex fields. Possible values
        /// include: 'ar.microsoft', 'ar.lucene', 'hy.lucene', 'bn.microsoft',
        /// 'eu.lucene', 'bg.microsoft', 'bg.lucene', 'ca.microsoft',
        /// 'ca.lucene', 'zh-Hans.microsoft', 'zh-Hans.lucene',
        /// 'zh-Hant.microsoft', 'zh-Hant.lucene', 'hr.microsoft',
        /// 'cs.microsoft', 'cs.lucene', 'da.microsoft', 'da.lucene',
        /// 'nl.microsoft', 'nl.lucene', 'en.microsoft', 'en.lucene',
        /// 'et.microsoft', 'fi.microsoft', 'fi.lucene', 'fr.microsoft',
        /// 'fr.lucene', 'gl.lucene', 'de.microsoft', 'de.lucene',
        /// 'el.microsoft', 'el.lucene', 'gu.microsoft', 'he.microsoft',
        /// 'hi.microsoft', 'hi.lucene', 'hu.microsoft', 'hu.lucene',
        /// 'is.microsoft', 'id.microsoft', 'id.lucene', 'ga.lucene',
        /// 'it.microsoft', 'it.lucene', 'ja.microsoft', 'ja.lucene',
        /// 'kn.microsoft', 'ko.microsoft', 'ko.lucene', 'lv.microsoft',
        /// 'lv.lucene', 'lt.microsoft', 'ml.microsoft', 'ms.microsoft',
        /// 'mr.microsoft', 'nb.microsoft', 'no.lucene', 'fa.lucene',
        /// 'pl.microsoft', 'pl.lucene', 'pt-BR.microsoft', 'pt-BR.lucene',
        /// 'pt-PT.microsoft', 'pt-PT.lucene', 'pa.microsoft', 'ro.microsoft',
        /// 'ro.lucene', 'ru.microsoft', 'ru.lucene', 'sr-cyrillic.microsoft',
        /// 'sr-latin.microsoft', 'sk.microsoft', 'sl.microsoft',
        /// 'es.microsoft', 'es.lucene', 'sv.microsoft', 'sv.lucene',
        /// 'ta.microsoft', 'te.microsoft', 'th.microsoft', 'th.lucene',
        /// 'tr.microsoft', 'tr.lucene', 'uk.microsoft', 'ur.microsoft',
        /// 'vi.microsoft', 'standard.lucene', 'standardasciifolding.lucene',
        /// 'keyword', 'pattern', 'simple', 'stop', 'whitespace'</param>
        /// <param name="searchAnalyzer">The name of the analyzer used at
        /// search time for the field. This option can be used only with
        /// searchable fields. It must be set together with indexAnalyzer and
        /// it cannot be set together with the analyzer option. This analyzer
        /// can be updated on an existing field. Must be null for complex
        /// fields. Possible values include: 'ar.microsoft', 'ar.lucene',
        /// 'hy.lucene', 'bn.microsoft', 'eu.lucene', 'bg.microsoft',
        /// 'bg.lucene', 'ca.microsoft', 'ca.lucene', 'zh-Hans.microsoft',
        /// 'zh-Hans.lucene', 'zh-Hant.microsoft', 'zh-Hant.lucene',
        /// 'hr.microsoft', 'cs.microsoft', 'cs.lucene', 'da.microsoft',
        /// 'da.lucene', 'nl.microsoft', 'nl.lucene', 'en.microsoft',
        /// 'en.lucene', 'et.microsoft', 'fi.microsoft', 'fi.lucene',
        /// 'fr.microsoft', 'fr.lucene', 'gl.lucene', 'de.microsoft',
        /// 'de.lucene', 'el.microsoft', 'el.lucene', 'gu.microsoft',
        /// 'he.microsoft', 'hi.microsoft', 'hi.lucene', 'hu.microsoft',
        /// 'hu.lucene', 'is.microsoft', 'id.microsoft', 'id.lucene',
        /// 'ga.lucene', 'it.microsoft', 'it.lucene', 'ja.microsoft',
        /// 'ja.lucene', 'kn.microsoft', 'ko.microsoft', 'ko.lucene',
        /// 'lv.microsoft', 'lv.lucene', 'lt.microsoft', 'ml.microsoft',
        /// 'ms.microsoft', 'mr.microsoft', 'nb.microsoft', 'no.lucene',
        /// 'fa.lucene', 'pl.microsoft', 'pl.lucene', 'pt-BR.microsoft',
        /// 'pt-BR.lucene', 'pt-PT.microsoft', 'pt-PT.lucene', 'pa.microsoft',
        /// 'ro.microsoft', 'ro.lucene', 'ru.microsoft', 'ru.lucene',
        /// 'sr-cyrillic.microsoft', 'sr-latin.microsoft', 'sk.microsoft',
        /// 'sl.microsoft', 'es.microsoft', 'es.lucene', 'sv.microsoft',
        /// 'sv.lucene', 'ta.microsoft', 'te.microsoft', 'th.microsoft',
        /// 'th.lucene', 'tr.microsoft', 'tr.lucene', 'uk.microsoft',
        /// 'ur.microsoft', 'vi.microsoft', 'standard.lucene',
        /// 'standardasciifolding.lucene', 'keyword', 'pattern', 'simple',
        /// 'stop', 'whitespace'</param>
        /// <param name="indexAnalyzer">The name of the analyzer used at
        /// indexing time for the field. This option can be used only with
        /// searchable fields. It must be set together with searchAnalyzer and
        /// it cannot be set together with the analyzer option. Once the
        /// analyzer is chosen, it cannot be changed for the field. Must be
        /// null for complex fields. Possible values include: 'ar.microsoft',
        /// 'ar.lucene', 'hy.lucene', 'bn.microsoft', 'eu.lucene',
        /// 'bg.microsoft', 'bg.lucene', 'ca.microsoft', 'ca.lucene',
        /// 'zh-Hans.microsoft', 'zh-Hans.lucene', 'zh-Hant.microsoft',
        /// 'zh-Hant.lucene', 'hr.microsoft', 'cs.microsoft', 'cs.lucene',
        /// 'da.microsoft', 'da.lucene', 'nl.microsoft', 'nl.lucene',
        /// 'en.microsoft', 'en.lucene', 'et.microsoft', 'fi.microsoft',
        /// 'fi.lucene', 'fr.microsoft', 'fr.lucene', 'gl.lucene',
        /// 'de.microsoft', 'de.lucene', 'el.microsoft', 'el.lucene',
        /// 'gu.microsoft', 'he.microsoft', 'hi.microsoft', 'hi.lucene',
        /// 'hu.microsoft', 'hu.lucene', 'is.microsoft', 'id.microsoft',
        /// 'id.lucene', 'ga.lucene', 'it.microsoft', 'it.lucene',
        /// 'ja.microsoft', 'ja.lucene', 'kn.microsoft', 'ko.microsoft',
        /// 'ko.lucene', 'lv.microsoft', 'lv.lucene', 'lt.microsoft',
        /// 'ml.microsoft', 'ms.microsoft', 'mr.microsoft', 'nb.microsoft',
        /// 'no.lucene', 'fa.lucene', 'pl.microsoft', 'pl.lucene',
        /// 'pt-BR.microsoft', 'pt-BR.lucene', 'pt-PT.microsoft',
        /// 'pt-PT.lucene', 'pa.microsoft', 'ro.microsoft', 'ro.lucene',
        /// 'ru.microsoft', 'ru.lucene', 'sr-cyrillic.microsoft',
        /// 'sr-latin.microsoft', 'sk.microsoft', 'sl.microsoft',
        /// 'es.microsoft', 'es.lucene', 'sv.microsoft', 'sv.lucene',
        /// 'ta.microsoft', 'te.microsoft', 'th.microsoft', 'th.lucene',
        /// 'tr.microsoft', 'tr.lucene', 'uk.microsoft', 'ur.microsoft',
        /// 'vi.microsoft', 'standard.lucene', 'standardasciifolding.lucene',
        /// 'keyword', 'pattern', 'simple', 'stop', 'whitespace'</param>
        /// <param name="synonymMaps">A list of the names of synonym maps to
        /// associate with this field. This option can be used only with
        /// searchable fields. Currently only one synonym map per field is
        /// supported. Assigning a synonym map to a field ensures that query
        /// terms targeting that field are expanded at query-time using the
        /// rules in the synonym map. This attribute can be changed on existing
        /// fields. Must be null or an empty collection for complex
        /// fields.</param>
        /// <param name="fields">A list of sub-fields if this is a field of
        /// type Edm.ComplexType or Collection(Edm.ComplexType). Must be null
        /// or empty for simple fields.</param>
        internal Field(string name, DataType type, bool? key = default(bool?), bool? retrievable = default(bool?), bool? searchable = default(bool?), bool? filterable = default(bool?), bool? sortable = default(bool?), bool? facetable = default(bool?), AnalyzerName? analyzer = default(AnalyzerName?), AnalyzerName? searchAnalyzer = default(AnalyzerName?), AnalyzerName? indexAnalyzer = default(AnalyzerName?), IList<string> synonymMaps = default(IList<string>), IList<Field> fields = default(IList<Field>))
        {
            Name = name;
            Type = type;
            Key = key;
            Retrievable = retrievable;
            Searchable = searchable;
            Filterable = filterable;
            Sortable = sortable;
            Facetable = facetable;
            Analyzer = analyzer;
            SearchAnalyzer = searchAnalyzer;
            IndexAnalyzer = indexAnalyzer;
            SynonymMaps = synonymMaps;
            Fields = fields;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the field, which must be unique within the
        /// fields collection of the index or parent field.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the data type of the field. Possible values include:
        /// 'Edm.String', 'Edm.Int32', 'Edm.Int64', 'Edm.Double',
        /// 'Edm.Boolean', 'Edm.DateTimeOffset', 'Edm.GeographyPoint',
        /// 'Edm.ComplexType'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public DataType Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the field uniquely
        /// identifies documents in the index. Exactly one top-level field in
        /// each index must be chosen as the key field and it must be of type
        /// Edm.String. Key fields can be used to look up documents directly
        /// and update or delete specific documents. Default is false for
        /// simple fields and null for complex fields.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        internal bool? Key { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the field can be returned
        /// in a search result. You can disable this option if you want to use
        /// a field (for example, margin) as a filter, sorting, or scoring
        /// mechanism but do not want the field to be visible to the end user.
        /// This property must be true for key fields, and it must be null for
        /// complex fields. This property can be changed on existing fields.
        /// Enabling this property does not cause any increase in index storage
        /// requirements. Default is true for simple fields and null for
        /// complex fields.
        /// </summary>
        [JsonProperty(PropertyName = "retrievable")]
        internal bool? Retrievable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the field is full-text
        /// searchable. This means it will undergo analysis such as
        /// word-breaking during indexing. If you set a searchable field to a
        /// value like "sunny day", internally it will be split into the
        /// individual tokens "sunny" and "day". This enables full-text
        /// searches for these terms. Fields of type Edm.String or
        /// Collection(Edm.String) are searchable by default. This property
        /// must be false for simple fields of other non-string data types, and
        /// it must be null for complex fields. Note: searchable fields consume
        /// extra space in your index since Azure Cognitive Search will store
        /// an additional tokenized version of the field value for full-text
        /// searches. If you want to save space in your index and you don't
        /// need a field to be included in searches, set searchable to false.
        /// </summary>
        [JsonProperty(PropertyName = "searchable")]
        internal bool? Searchable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable the field to be
        /// referenced in $filter queries. filterable differs from searchable
        /// in how strings are handled. Fields of type Edm.String or
        /// Collection(Edm.String) that are filterable do not undergo
        /// word-breaking, so comparisons are for exact matches only. For
        /// example, if you set such a field f to "sunny day", $filter=f eq
        /// 'sunny' will find no matches, but $filter=f eq 'sunny day' will.
        /// This property must be null for complex fields. Default is true for
        /// simple fields and null for complex fields.
        /// </summary>
        [JsonProperty(PropertyName = "filterable")]
        internal bool? Filterable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable the field to be
        /// referenced in $orderby expressions. By default Azure Cognitive
        /// Search sorts results by score, but in many experiences users will
        /// want to sort by fields in the documents. A simple field can be
        /// sortable only if it is single-valued (it has a single value in the
        /// scope of the parent document). Simple collection fields cannot be
        /// sortable, since they are multi-valued. Simple sub-fields of complex
        /// collections are also multi-valued, and therefore cannot be
        /// sortable. This is true whether it's an immediate parent field, or
        /// an ancestor field, that's the complex collection. Complex fields
        /// cannot be sortable and the sortable property must be null for such
        /// fields. The default for sortable is true for single-valued simple
        /// fields, false for multi-valued simple fields, and null for complex
        /// fields.
        /// </summary>
        [JsonProperty(PropertyName = "sortable")]
        internal bool? Sortable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable the field to be
        /// referenced in facet queries. Typically used in a presentation of
        /// search results that includes hit count by category (for example,
        /// search for digital cameras and see hits by brand, by megapixels, by
        /// price, and so on). This property must be null for complex fields.
        /// Fields of type Edm.GeographyPoint or Collection(Edm.GeographyPoint)
        /// cannot be facetable. Default is true for all other simple fields.
        /// </summary>
        [JsonProperty(PropertyName = "facetable")]
        internal bool? Facetable { get; set; }

        /// <summary>
        /// Gets or sets the name of the language analyzer to use for the
        /// field. This option can be used only with searchable fields and it
        /// can't be set together with either searchAnalyzer or indexAnalyzer.
        /// Once the analyzer is chosen, it cannot be changed for the field.
        /// Must be null for complex fields. Possible values include:
        /// 'ar.microsoft', 'ar.lucene', 'hy.lucene', 'bn.microsoft',
        /// 'eu.lucene', 'bg.microsoft', 'bg.lucene', 'ca.microsoft',
        /// 'ca.lucene', 'zh-Hans.microsoft', 'zh-Hans.lucene',
        /// 'zh-Hant.microsoft', 'zh-Hant.lucene', 'hr.microsoft',
        /// 'cs.microsoft', 'cs.lucene', 'da.microsoft', 'da.lucene',
        /// 'nl.microsoft', 'nl.lucene', 'en.microsoft', 'en.lucene',
        /// 'et.microsoft', 'fi.microsoft', 'fi.lucene', 'fr.microsoft',
        /// 'fr.lucene', 'gl.lucene', 'de.microsoft', 'de.lucene',
        /// 'el.microsoft', 'el.lucene', 'gu.microsoft', 'he.microsoft',
        /// 'hi.microsoft', 'hi.lucene', 'hu.microsoft', 'hu.lucene',
        /// 'is.microsoft', 'id.microsoft', 'id.lucene', 'ga.lucene',
        /// 'it.microsoft', 'it.lucene', 'ja.microsoft', 'ja.lucene',
        /// 'kn.microsoft', 'ko.microsoft', 'ko.lucene', 'lv.microsoft',
        /// 'lv.lucene', 'lt.microsoft', 'ml.microsoft', 'ms.microsoft',
        /// 'mr.microsoft', 'nb.microsoft', 'no.lucene', 'fa.lucene',
        /// 'pl.microsoft', 'pl.lucene', 'pt-BR.microsoft', 'pt-BR.lucene',
        /// 'pt-PT.microsoft', 'pt-PT.lucene', 'pa.microsoft', 'ro.microsoft',
        /// 'ro.lucene', 'ru.microsoft', 'ru.lucene', 'sr-cyrillic.microsoft',
        /// 'sr-latin.microsoft', 'sk.microsoft', 'sl.microsoft',
        /// 'es.microsoft', 'es.lucene', 'sv.microsoft', 'sv.lucene',
        /// 'ta.microsoft', 'te.microsoft', 'th.microsoft', 'th.lucene',
        /// 'tr.microsoft', 'tr.lucene', 'uk.microsoft', 'ur.microsoft',
        /// 'vi.microsoft', 'standard.lucene', 'standardasciifolding.lucene',
        /// 'keyword', 'pattern', 'simple', 'stop', 'whitespace'
        /// </summary>
        [JsonProperty(PropertyName = "analyzer")]
        public AnalyzerName? Analyzer { get; set; }

        /// <summary>
        /// Gets or sets the name of the analyzer used at search time for the
        /// field. This option can be used only with searchable fields. It must
        /// be set together with indexAnalyzer and it cannot be set together
        /// with the analyzer option. This analyzer can be updated on an
        /// existing field. Must be null for complex fields. Possible values
        /// include: 'ar.microsoft', 'ar.lucene', 'hy.lucene', 'bn.microsoft',
        /// 'eu.lucene', 'bg.microsoft', 'bg.lucene', 'ca.microsoft',
        /// 'ca.lucene', 'zh-Hans.microsoft', 'zh-Hans.lucene',
        /// 'zh-Hant.microsoft', 'zh-Hant.lucene', 'hr.microsoft',
        /// 'cs.microsoft', 'cs.lucene', 'da.microsoft', 'da.lucene',
        /// 'nl.microsoft', 'nl.lucene', 'en.microsoft', 'en.lucene',
        /// 'et.microsoft', 'fi.microsoft', 'fi.lucene', 'fr.microsoft',
        /// 'fr.lucene', 'gl.lucene', 'de.microsoft', 'de.lucene',
        /// 'el.microsoft', 'el.lucene', 'gu.microsoft', 'he.microsoft',
        /// 'hi.microsoft', 'hi.lucene', 'hu.microsoft', 'hu.lucene',
        /// 'is.microsoft', 'id.microsoft', 'id.lucene', 'ga.lucene',
        /// 'it.microsoft', 'it.lucene', 'ja.microsoft', 'ja.lucene',
        /// 'kn.microsoft', 'ko.microsoft', 'ko.lucene', 'lv.microsoft',
        /// 'lv.lucene', 'lt.microsoft', 'ml.microsoft', 'ms.microsoft',
        /// 'mr.microsoft', 'nb.microsoft', 'no.lucene', 'fa.lucene',
        /// 'pl.microsoft', 'pl.lucene', 'pt-BR.microsoft', 'pt-BR.lucene',
        /// 'pt-PT.microsoft', 'pt-PT.lucene', 'pa.microsoft', 'ro.microsoft',
        /// 'ro.lucene', 'ru.microsoft', 'ru.lucene', 'sr-cyrillic.microsoft',
        /// 'sr-latin.microsoft', 'sk.microsoft', 'sl.microsoft',
        /// 'es.microsoft', 'es.lucene', 'sv.microsoft', 'sv.lucene',
        /// 'ta.microsoft', 'te.microsoft', 'th.microsoft', 'th.lucene',
        /// 'tr.microsoft', 'tr.lucene', 'uk.microsoft', 'ur.microsoft',
        /// 'vi.microsoft', 'standard.lucene', 'standardasciifolding.lucene',
        /// 'keyword', 'pattern', 'simple', 'stop', 'whitespace'
        /// </summary>
        [JsonProperty(PropertyName = "searchAnalyzer")]
        public AnalyzerName? SearchAnalyzer { get; set; }

        /// <summary>
        /// Gets or sets the name of the analyzer used at indexing time for the
        /// field. This option can be used only with searchable fields. It must
        /// be set together with searchAnalyzer and it cannot be set together
        /// with the analyzer option. Once the analyzer is chosen, it cannot be
        /// changed for the field. Must be null for complex fields. Possible
        /// values include: 'ar.microsoft', 'ar.lucene', 'hy.lucene',
        /// 'bn.microsoft', 'eu.lucene', 'bg.microsoft', 'bg.lucene',
        /// 'ca.microsoft', 'ca.lucene', 'zh-Hans.microsoft', 'zh-Hans.lucene',
        /// 'zh-Hant.microsoft', 'zh-Hant.lucene', 'hr.microsoft',
        /// 'cs.microsoft', 'cs.lucene', 'da.microsoft', 'da.lucene',
        /// 'nl.microsoft', 'nl.lucene', 'en.microsoft', 'en.lucene',
        /// 'et.microsoft', 'fi.microsoft', 'fi.lucene', 'fr.microsoft',
        /// 'fr.lucene', 'gl.lucene', 'de.microsoft', 'de.lucene',
        /// 'el.microsoft', 'el.lucene', 'gu.microsoft', 'he.microsoft',
        /// 'hi.microsoft', 'hi.lucene', 'hu.microsoft', 'hu.lucene',
        /// 'is.microsoft', 'id.microsoft', 'id.lucene', 'ga.lucene',
        /// 'it.microsoft', 'it.lucene', 'ja.microsoft', 'ja.lucene',
        /// 'kn.microsoft', 'ko.microsoft', 'ko.lucene', 'lv.microsoft',
        /// 'lv.lucene', 'lt.microsoft', 'ml.microsoft', 'ms.microsoft',
        /// 'mr.microsoft', 'nb.microsoft', 'no.lucene', 'fa.lucene',
        /// 'pl.microsoft', 'pl.lucene', 'pt-BR.microsoft', 'pt-BR.lucene',
        /// 'pt-PT.microsoft', 'pt-PT.lucene', 'pa.microsoft', 'ro.microsoft',
        /// 'ro.lucene', 'ru.microsoft', 'ru.lucene', 'sr-cyrillic.microsoft',
        /// 'sr-latin.microsoft', 'sk.microsoft', 'sl.microsoft',
        /// 'es.microsoft', 'es.lucene', 'sv.microsoft', 'sv.lucene',
        /// 'ta.microsoft', 'te.microsoft', 'th.microsoft', 'th.lucene',
        /// 'tr.microsoft', 'tr.lucene', 'uk.microsoft', 'ur.microsoft',
        /// 'vi.microsoft', 'standard.lucene', 'standardasciifolding.lucene',
        /// 'keyword', 'pattern', 'simple', 'stop', 'whitespace'
        /// </summary>
        [JsonProperty(PropertyName = "indexAnalyzer")]
        public AnalyzerName? IndexAnalyzer { get; set; }

        /// <summary>
        /// Gets or sets a list of the names of synonym maps to associate with
        /// this field. This option can be used only with searchable fields.
        /// Currently only one synonym map per field is supported. Assigning a
        /// synonym map to a field ensures that query terms targeting that
        /// field are expanded at query-time using the rules in the synonym
        /// map. This attribute can be changed on existing fields. Must be null
        /// or an empty collection for complex fields.
        /// </summary>
        [JsonProperty(PropertyName = "synonymMaps")]
        public IList<string> SynonymMaps { get; set; }

        /// <summary>
        /// Gets or sets a list of sub-fields if this is a field of type
        /// Edm.ComplexType or Collection(Edm.ComplexType). Must be null or
        /// empty for simple fields.
        /// </summary>
        [JsonProperty(PropertyName = "fields")]
        public IList<Field> Fields { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Fields != null)
            {
                foreach (var element in Fields)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
