// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PercentileSourceTargetOperations operations.
    /// </summary>
    internal partial class PercentileSourceTargetOperations : IServiceOperations<CosmosDBManagementClient>, IPercentileSourceTargetOperations
    {
        /// <summary>
        /// Initializes a new instance of the PercentileSourceTargetOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        internal PercentileSourceTargetOperations(CosmosDBManagementClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the CosmosDBManagementClient
        /// </summary>
        public CosmosDBManagementClient Client { get; private set; }

        /// <summary>
        /// Retrieves the metrics determined by the given filter for the given account,
        /// source and target region. This url is only for PBS and Replication Latency
        /// data
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure resource group.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='sourceRegion'>
        /// Source region from which data is written. Cosmos DB region, with spaces
        /// between words and each word capitalized.
        /// </param>
        /// <param name='targetRegion'>
        /// Target region to which data is written. Cosmos DB region, with spaces
        /// between words and each word capitalized.
        /// </param>
        /// <param name='filter'>
        /// An OData filter expression that describes a subset of metrics to return.
        /// The parameters that can be filtered are name.value (name of the metric, can
        /// have an or of multiple names), startTime, endTime, and timeGrain. The
        /// supported operator is eq.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse<IEnumerable<PercentileMetric>>> ListMetricsWithHttpMessagesAsync(string resourceGroupName, string accountName, string sourceRegion, string targetRegion, string filter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (Client.SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.Client.SubscriptionId");
            }
            if (resourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceGroupName");
            }
            if (resourceGroupName != null)
            {
                if (resourceGroupName.Length > 90)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "resourceGroupName", 90);
                }
                if (resourceGroupName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "resourceGroupName", 1);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(resourceGroupName, "^[-\\w\\._\\(\\)]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "resourceGroupName", "^[-\\w\\._\\(\\)]+$");
                }
            }
            if (accountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "accountName");
            }
            if (accountName != null)
            {
                if (accountName.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "accountName", 50);
                }
                if (accountName.Length < 3)
                {
                    throw new ValidationException(ValidationRules.MinLength, "accountName", 3);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(accountName, "^[a-z0-9]+(-[a-z0-9]+)*"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "accountName", "^[a-z0-9]+(-[a-z0-9]+)*");
                }
            }
            if (sourceRegion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "sourceRegion");
            }
            if (targetRegion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "targetRegion");
            }
            if (filter == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "filter");
            }
            string apiVersion = "2020-03-01";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("accountName", accountName);
                tracingParameters.Add("sourceRegion", sourceRegion);
                tracingParameters.Add("targetRegion", targetRegion);
                tracingParameters.Add("apiVersion", apiVersion);
                tracingParameters.Add("filter", filter);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "ListMetrics", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sourceRegion/{sourceRegion}/targetRegion/{targetRegion}/percentile/metrics").ToString();
            _url = _url.Replace("{subscriptionId}", System.Uri.EscapeDataString(Client.SubscriptionId));
            _url = _url.Replace("{resourceGroupName}", System.Uri.EscapeDataString(resourceGroupName));
            _url = _url.Replace("{accountName}", System.Uri.EscapeDataString(accountName));
            _url = _url.Replace("{sourceRegion}", System.Uri.EscapeDataString(sourceRegion));
            _url = _url.Replace("{targetRegion}", System.Uri.EscapeDataString(targetRegion));
            List<string> _queryParameters = new List<string>();
            if (apiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(apiVersion)));
            }
            if (filter != null)
            {
                _queryParameters.Add(string.Format("$filter={0}", System.Uri.EscapeDataString(filter)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", Client.AcceptLanguage);
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new CloudException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    CloudError _errorBody =  Rest.Serialization.SafeJsonConvert.DeserializeObject<CloudError>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex = new CloudException(_errorBody.Message);
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_httpResponse.Headers.Contains("x-ms-request-id"))
                {
                    ex.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                }
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationResponse<IEnumerable<PercentileMetric>>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Rest.Serialization.SafeJsonConvert.DeserializeObject<Page<PercentileMetric>>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
