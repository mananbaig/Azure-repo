// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ApplicationInsights;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Properties that define a favorite that is associated to an Application Insights component. </summary>
    public partial class ApplicationInsightsComponentFavorite
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentFavorite"/>. </summary>
        public ApplicationInsightsComponentFavorite()
        {
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentFavorite"/>. </summary>
        /// <param name="name"> The user-defined name of the favorite. </param>
        /// <param name="config"> Configuration of this particular favorite, which are driven by the Azure portal UX. Configuration data is a string containing valid JSON. </param>
        /// <param name="version"> This instance's version of the data model. This can change as new features are added that can be marked favorite. Current examples include MetricsExplorer (ME) and Search. </param>
        /// <param name="favoriteId"> Internally assigned unique id of the favorite definition. </param>
        /// <param name="favoriteType"> Enum indicating if this favorite definition is owned by a specific user or is shared between all users with access to the Application Insights component. </param>
        /// <param name="sourceType"> The source of the favorite definition. </param>
        /// <param name="timeModified"> Date and time in UTC of the last modification that was made to this favorite definition. </param>
        /// <param name="tags"> A list of 0 or more tags that are associated with this favorite definition. </param>
        /// <param name="category"> Favorite category, as defined by the user at creation time. </param>
        /// <param name="isGeneratedFromTemplate"> Flag denoting wether or not this favorite was generated from a template. </param>
        /// <param name="userId"> Unique user id of the specific user that owns this favorite. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationInsightsComponentFavorite(string name, string config, string version, string favoriteId, FavoriteType? favoriteType, string sourceType, string timeModified, IList<string> tags, string category, bool? isGeneratedFromTemplate, string userId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Config = config;
            Version = version;
            FavoriteId = favoriteId;
            FavoriteType = favoriteType;
            SourceType = sourceType;
            TimeModified = timeModified;
            Tags = tags;
            Category = category;
            IsGeneratedFromTemplate = isGeneratedFromTemplate;
            UserId = userId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The user-defined name of the favorite. </summary>
        public string Name { get; set; }
        /// <summary> Configuration of this particular favorite, which are driven by the Azure portal UX. Configuration data is a string containing valid JSON. </summary>
        public string Config { get; set; }
        /// <summary> This instance's version of the data model. This can change as new features are added that can be marked favorite. Current examples include MetricsExplorer (ME) and Search. </summary>
        public string Version { get; set; }
        /// <summary> Internally assigned unique id of the favorite definition. </summary>
        public string FavoriteId { get; }
        /// <summary> Enum indicating if this favorite definition is owned by a specific user or is shared between all users with access to the Application Insights component. </summary>
        public FavoriteType? FavoriteType { get; set; }
        /// <summary> The source of the favorite definition. </summary>
        public string SourceType { get; set; }
        /// <summary> Date and time in UTC of the last modification that was made to this favorite definition. </summary>
        public string TimeModified { get; }
        /// <summary> A list of 0 or more tags that are associated with this favorite definition. </summary>
        public IList<string> Tags { get; }
        /// <summary> Favorite category, as defined by the user at creation time. </summary>
        public string Category { get; set; }
        /// <summary> Flag denoting wether or not this favorite was generated from a template. </summary>
        public bool? IsGeneratedFromTemplate { get; set; }
        /// <summary> Unique user id of the specific user that owns this favorite. </summary>
        public string UserId { get; }
    }
}
