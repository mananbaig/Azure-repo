// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes a Power BI output data source. </summary>
    public partial class PowerBIOutputDataSource : StreamingJobOutputDataSource
    {
        /// <summary> Initializes a new instance of <see cref="PowerBIOutputDataSource"/>. </summary>
        public PowerBIOutputDataSource()
        {
            OutputDataSourceType = "PowerBI";
        }

        /// <summary> Initializes a new instance of <see cref="PowerBIOutputDataSource"/>. </summary>
        /// <param name="outputDataSourceType"> Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="refreshToken"> A refresh token that can be used to obtain a valid access token that can then be used to authenticate with the data source. A valid refresh token is currently only obtainable via the Azure Portal. It is recommended to put a dummy string value here when creating the data source and then going to the Azure Portal to authenticate the data source which will update this property with a valid refresh token. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="tokenUserPrincipalName"> The user principal name (UPN) of the user that was used to obtain the refresh token. Use this property to help remember which user was used to obtain the refresh token. </param>
        /// <param name="tokenUserDisplayName"> The user display name of the user that was used to obtain the refresh token. Use this property to help remember which user was used to obtain the refresh token. </param>
        /// <param name="dataset"> The name of the Power BI dataset. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="table"> The name of the Power BI table under the specified dataset. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="groupId"> The ID of the Power BI group. </param>
        /// <param name="groupName"> The name of the Power BI group. Use this property to help remember which specific Power BI group id was used. </param>
        /// <param name="authenticationMode"> Authentication Mode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PowerBIOutputDataSource(string outputDataSourceType, string refreshToken, string tokenUserPrincipalName, string tokenUserDisplayName, string dataset, string table, Guid? groupId, string groupName, StreamAnalyticsAuthenticationMode? authenticationMode, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(outputDataSourceType, serializedAdditionalRawData)
        {
            RefreshToken = refreshToken;
            TokenUserPrincipalName = tokenUserPrincipalName;
            TokenUserDisplayName = tokenUserDisplayName;
            Dataset = dataset;
            Table = table;
            GroupId = groupId;
            GroupName = groupName;
            AuthenticationMode = authenticationMode;
            OutputDataSourceType = outputDataSourceType ?? "PowerBI";
        }

        /// <summary> A refresh token that can be used to obtain a valid access token that can then be used to authenticate with the data source. A valid refresh token is currently only obtainable via the Azure Portal. It is recommended to put a dummy string value here when creating the data source and then going to the Azure Portal to authenticate the data source which will update this property with a valid refresh token. Required on PUT (CreateOrReplace) requests. </summary>
        public string RefreshToken { get; set; }
        /// <summary> The user principal name (UPN) of the user that was used to obtain the refresh token. Use this property to help remember which user was used to obtain the refresh token. </summary>
        public string TokenUserPrincipalName { get; set; }
        /// <summary> The user display name of the user that was used to obtain the refresh token. Use this property to help remember which user was used to obtain the refresh token. </summary>
        public string TokenUserDisplayName { get; set; }
        /// <summary> The name of the Power BI dataset. Required on PUT (CreateOrReplace) requests. </summary>
        public string Dataset { get; set; }
        /// <summary> The name of the Power BI table under the specified dataset. Required on PUT (CreateOrReplace) requests. </summary>
        public string Table { get; set; }
        /// <summary> The ID of the Power BI group. </summary>
        public Guid? GroupId { get; set; }
        /// <summary> The name of the Power BI group. Use this property to help remember which specific Power BI group id was used. </summary>
        public string GroupName { get; set; }
        /// <summary> Authentication Mode. </summary>
        public StreamAnalyticsAuthenticationMode? AuthenticationMode { get; set; }
    }
}
