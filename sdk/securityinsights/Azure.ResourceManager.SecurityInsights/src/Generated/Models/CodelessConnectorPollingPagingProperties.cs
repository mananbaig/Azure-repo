// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Describe the properties needed to make a pagination call
    /// Serialized Name: CodelessConnectorPollingPagingProperties
    /// </summary>
    public partial class CodelessConnectorPollingPagingProperties
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

        /// <summary> Initializes a new instance of <see cref="CodelessConnectorPollingPagingProperties"/>. </summary>
        /// <param name="pagingType">
        /// Describes the type. could be 'None', 'PageToken', 'PageCount', 'TimeStamp'
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pagingType
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pagingType"/> is null. </exception>
        public CodelessConnectorPollingPagingProperties(string pagingType)
        {
            Argument.AssertNotNull(pagingType, nameof(pagingType));

            PagingType = pagingType;
        }

        /// <summary> Initializes a new instance of <see cref="CodelessConnectorPollingPagingProperties"/>. </summary>
        /// <param name="pagingType">
        /// Describes the type. could be 'None', 'PageToken', 'PageCount', 'TimeStamp'
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pagingType
        /// </param>
        /// <param name="nextPageParaName">
        /// Defines the name of a next page attribute
        /// Serialized Name: CodelessConnectorPollingPagingProperties.nextPageParaName
        /// </param>
        /// <param name="nextPageTokenJsonPath">
        /// Defines the path to a next page token JSON
        /// Serialized Name: CodelessConnectorPollingPagingProperties.nextPageTokenJsonPath
        /// </param>
        /// <param name="pageCountAttributePath">
        /// Defines the path to a page count attribute
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pageCountAttributePath
        /// </param>
        /// <param name="pageTotalCountAttributePath">
        /// Defines the path to a page total count attribute
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pageTotalCountAttributePath
        /// </param>
        /// <param name="pageTimeStampAttributePath">
        /// Defines the path to a paging time stamp attribute
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pageTimeStampAttributePath
        /// </param>
        /// <param name="searchTheLatestTimeStampFromEventsList">
        /// Determines whether to search for the latest time stamp in the events list
        /// Serialized Name: CodelessConnectorPollingPagingProperties.searchTheLatestTimeStampFromEventsList
        /// </param>
        /// <param name="pageSizeParaName">
        /// Defines the name of the page size parameter
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pageSizeParaName
        /// </param>
        /// <param name="pageSize">
        /// Defines the paging size
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pageSize
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CodelessConnectorPollingPagingProperties(string pagingType, string nextPageParaName, string nextPageTokenJsonPath, string pageCountAttributePath, string pageTotalCountAttributePath, string pageTimeStampAttributePath, string searchTheLatestTimeStampFromEventsList, string pageSizeParaName, int? pageSize, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PagingType = pagingType;
            NextPageParaName = nextPageParaName;
            NextPageTokenJsonPath = nextPageTokenJsonPath;
            PageCountAttributePath = pageCountAttributePath;
            PageTotalCountAttributePath = pageTotalCountAttributePath;
            PageTimeStampAttributePath = pageTimeStampAttributePath;
            SearchTheLatestTimeStampFromEventsList = searchTheLatestTimeStampFromEventsList;
            PageSizeParaName = pageSizeParaName;
            PageSize = pageSize;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CodelessConnectorPollingPagingProperties"/> for deserialization. </summary>
        internal CodelessConnectorPollingPagingProperties()
        {
        }

        /// <summary>
        /// Describes the type. could be 'None', 'PageToken', 'PageCount', 'TimeStamp'
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pagingType
        /// </summary>
        public string PagingType { get; set; }
        /// <summary>
        /// Defines the name of a next page attribute
        /// Serialized Name: CodelessConnectorPollingPagingProperties.nextPageParaName
        /// </summary>
        public string NextPageParaName { get; set; }
        /// <summary>
        /// Defines the path to a next page token JSON
        /// Serialized Name: CodelessConnectorPollingPagingProperties.nextPageTokenJsonPath
        /// </summary>
        public string NextPageTokenJsonPath { get; set; }
        /// <summary>
        /// Defines the path to a page count attribute
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pageCountAttributePath
        /// </summary>
        public string PageCountAttributePath { get; set; }
        /// <summary>
        /// Defines the path to a page total count attribute
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pageTotalCountAttributePath
        /// </summary>
        public string PageTotalCountAttributePath { get; set; }
        /// <summary>
        /// Defines the path to a paging time stamp attribute
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pageTimeStampAttributePath
        /// </summary>
        public string PageTimeStampAttributePath { get; set; }
        /// <summary>
        /// Determines whether to search for the latest time stamp in the events list
        /// Serialized Name: CodelessConnectorPollingPagingProperties.searchTheLatestTimeStampFromEventsList
        /// </summary>
        public string SearchTheLatestTimeStampFromEventsList { get; set; }
        /// <summary>
        /// Defines the name of the page size parameter
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pageSizeParaName
        /// </summary>
        public string PageSizeParaName { get; set; }
        /// <summary>
        /// Defines the paging size
        /// Serialized Name: CodelessConnectorPollingPagingProperties.pageSize
        /// </summary>
        public int? PageSize { get; set; }
    }
}
