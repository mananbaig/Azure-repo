// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Purview.Catalog.Models
{
    /// <summary> term template definition for glossary term. </summary>
    public partial class TermTemplateDef : AtlasStructDef
    {
        /// <summary> Initializes a new instance of TermTemplateDef. </summary>
        public TermTemplateDef()
        {
        }

        /// <summary> Initializes a new instance of TermTemplateDef. </summary>
        /// <param name="category"> The enum of type category. </param>
        /// <param name="createTime"> The created time of the record. </param>
        /// <param name="createdBy"> The user who created the record. </param>
        /// <param name="dateFormatter"> The date format. </param>
        /// <param name="description"> The description of the type definition. </param>
        /// <param name="guid"> The GUID of the type definition. </param>
        /// <param name="name"> The name of the type definition. </param>
        /// <param name="options"> The options for the type definition. </param>
        /// <param name="serviceType"> The service type. </param>
        /// <param name="typeVersion"> The version of the type. </param>
        /// <param name="updateTime"> The update time of the record. </param>
        /// <param name="updatedBy"> The user who updated the record. </param>
        /// <param name="version"> The version of the record. </param>
        /// <param name="lastModifiedTS"> ETag for concurrency control. </param>
        /// <param name="attributeDefs"> An array of attribute definitions. </param>
        internal TermTemplateDef(TypeCategory? category, float? createTime, string createdBy, DateFormat dateFormatter, string description, string guid, string name, IDictionary<string, string> options, string serviceType, string typeVersion, float? updateTime, string updatedBy, float? version, string lastModifiedTS, IList<AtlasAttributeDef> attributeDefs) : base(category, createTime, createdBy, dateFormatter, description, guid, name, options, serviceType, typeVersion, updateTime, updatedBy, version, lastModifiedTS, attributeDefs)
        {
        }
    }
}
