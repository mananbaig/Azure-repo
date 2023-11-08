// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmResourceGraphModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.ResourceQueryContent"/>. </summary>
        /// <param name="subscriptions"> Azure subscriptions against which to execute the query. </param>
        /// <param name="managementGroups"> Azure management groups against which to execute the query. Example: [ 'mg1', 'mg2' ]. </param>
        /// <param name="query"> The resources query. </param>
        /// <param name="options"> The query evaluation options. </param>
        /// <param name="facets"> An array of facet requests to be computed against the query result. </param>
        /// <returns> A new <see cref="Models.ResourceQueryContent"/> instance for mocking. </returns>
        public static ResourceQueryContent ResourceQueryContent(IEnumerable<string> subscriptions = null, IEnumerable<string> managementGroups = null, string query = null, ResourceQueryRequestOptions options = null, IEnumerable<FacetRequest> facets = null)
        {
            subscriptions ??= new List<string>();
            managementGroups ??= new List<string>();
            facets ??= new List<FacetRequest>();

            return new ResourceQueryContent(subscriptions?.ToList(), managementGroups?.ToList(), query, options, facets?.ToList(), new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Models.FacetRequest"/>. </summary>
        /// <param name="expression"> The column or list of columns to summarize by. </param>
        /// <param name="options"> The options for facet evaluation. </param>
        /// <returns> A new <see cref="Models.FacetRequest"/> instance for mocking. </returns>
        public static FacetRequest FacetRequest(string expression = null, FacetRequestOptions options = null)
        {
            return new FacetRequest(expression, options, new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Models.ResourceQueryResult"/>. </summary>
        /// <param name="totalRecords"> Number of total records matching the query. </param>
        /// <param name="count"> Number of records returned in the current response. In the case of paging, this is the number of records in the current page. </param>
        /// <param name="resultTruncated"> Indicates whether the query results are truncated. </param>
        /// <param name="skipToken"> When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data. </param>
        /// <param name="data"> Query output in JObject array or Table format. </param>
        /// <param name="facets">
        /// Query facets.
        /// Please note <see cref="Models.Facet"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Models.FacetError"/> and <see cref="Models.FacetResult"/>.
        /// </param>
        /// <returns> A new <see cref="Models.ResourceQueryResult"/> instance for mocking. </returns>
        public static ResourceQueryResult ResourceQueryResult(long totalRecords = default, long count = default, ResultTruncated resultTruncated = default, string skipToken = null, BinaryData data = null, IEnumerable<Facet> facets = null)
        {
            facets ??= new List<Facet>();

            return new ResourceQueryResult(totalRecords, count, resultTruncated, skipToken, data, facets?.ToList(), new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Models.Facet"/>. </summary>
        /// <param name="expression"> Facet expression, same as in the corresponding facet request. </param>
        /// <param name="resultType"> Result type. </param>
        /// <returns> A new <see cref="Models.Facet"/> instance for mocking. </returns>
        public static Facet Facet(string expression = null, string resultType = null)
        {
            return new UnknownFacet(expression, resultType, new Dictionary<string, BinaryData>());
        }

        /// <summary> Initializes a new instance of <see cref="Models.FacetErrorDetails"/>. </summary>
        /// <param name="code"> Error code identifying the specific error. </param>
        /// <param name="message"> A human readable error message. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.FacetErrorDetails"/> instance for mocking. </returns>
        public static FacetErrorDetails FacetErrorDetails(string code = null, string message = null, IReadOnlyDictionary<string, BinaryData> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, BinaryData>();

            return new FacetErrorDetails(code, message, additionalProperties);
        }

        /// <summary> Initializes a new instance of <see cref="Models.FacetResult"/>. </summary>
        /// <param name="expression"> Facet expression, same as in the corresponding facet request. </param>
        /// <param name="totalRecords"> Number of total records in the facet results. </param>
        /// <param name="count"> Number of records returned in the facet response. </param>
        /// <param name="data"> A JObject array or Table containing the desired facets. Only present if the facet is valid. </param>
        /// <returns> A new <see cref="Models.FacetResult"/> instance for mocking. </returns>
        public static FacetResult FacetResult(string expression = null, long totalRecords = default, int count = default, BinaryData data = null)
        {
            return new FacetResult(expression, "FacetResult", new Dictionary<string, BinaryData>(), totalRecords, count, data);
        }

        /// <summary> Initializes a new instance of <see cref="Models.FacetError"/>. </summary>
        /// <param name="expression"> Facet expression, same as in the corresponding facet request. </param>
        /// <param name="errors"> An array containing detected facet errors with details. </param>
        /// <returns> A new <see cref="Models.FacetError"/> instance for mocking. </returns>
        public static FacetError FacetError(string expression = null, IEnumerable<FacetErrorDetails> errors = null)
        {
            errors ??= new List<FacetErrorDetails>();

            return new FacetError(expression, "FacetError", new Dictionary<string, BinaryData>(), errors?.ToList());
        }
    }
}
