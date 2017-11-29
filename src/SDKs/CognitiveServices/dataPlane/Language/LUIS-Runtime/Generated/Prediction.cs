// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Prediction operations.
    /// </summary>
    public partial class Prediction : IServiceOperations<LuisRuntimeAPI>, IPrediction
    {
        /// <summary>
        /// Initializes a new instance of the Prediction class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public Prediction(LuisRuntimeAPI client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the LuisRuntimeAPI
        /// </summary>
        public LuisRuntimeAPI Client { get; private set; }

        /// <summary>
        /// Gets the published endpoint predictions for the given query.
        /// </summary>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='q'>
        /// The query to predict.
        /// </param>
        /// <param name='timezoneOffset'>
        /// The timezone offset for the location of the request.
        /// </param>
        /// <param name='verbose'>
        /// If true will return all intents instead of just the topscoring intent.
        /// </param>
        /// <param name='spellCheck'>
        /// Enable spell checking.
        /// </param>
        /// <param name='staging'>
        /// Use staging endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
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
        public async Task<HttpOperationResponse<LuisResult>> GetPredictionsFromEndpointViaGetWithHttpMessagesAsync(string appId, string q, double? timezoneOffset = default(double?), bool? verbose = default(bool?), bool? spellCheck = default(bool?), bool? staging = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (appId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "appId");
            }
            if (q == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "q");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("appId", appId);
                tracingParameters.Add("q", q);
                tracingParameters.Add("timezoneOffset", timezoneOffset);
                tracingParameters.Add("verbose", verbose);
                tracingParameters.Add("spellCheck", spellCheck);
                tracingParameters.Add("staging", staging);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetPredictionsFromEndpointViaGet", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri;
            var _url = _baseUrl + (_baseUrl.EndsWith("/") ? "" : "/") + "{appId}";
            _url = _url.Replace("{AzureRegion}", Rest.Serialization.SafeJsonConvert.SerializeObject(Client.AzureRegion, Client.SerializationSettings).Trim('"'));
            _url = _url.Replace("{appId}", System.Uri.EscapeDataString(appId));
            List<string> _queryParameters = new List<string>();
            if (q != null)
            {
                _queryParameters.Add(string.Format("q={0}", System.Uri.EscapeDataString(q)));
            }
            if (timezoneOffset != null)
            {
                _queryParameters.Add(string.Format("timezoneOffset={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(timezoneOffset, Client.SerializationSettings).Trim('"'))));
            }
            if (verbose != null)
            {
                _queryParameters.Add(string.Format("verbose={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(verbose, Client.SerializationSettings).Trim('"'))));
            }
            if (spellCheck != null)
            {
                _queryParameters.Add(string.Format("spellCheck={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(spellCheck, Client.SerializationSettings).Trim('"'))));
            }
            if (staging != null)
            {
                _queryParameters.Add(string.Format("staging={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(staging, Client.SerializationSettings).Trim('"'))));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


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
                var ex = new APIErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    APIError _errorBody =  Rest.Serialization.SafeJsonConvert.DeserializeObject<APIError>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
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
            var _result = new HttpOperationResponse<LuisResult>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Rest.Serialization.SafeJsonConvert.DeserializeObject<LuisResult>(_responseContent, Client.DeserializationSettings);
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

        /// <summary>
        /// Gets the published endpoint prediction for the given long query.
        /// </summary>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='q'>
        /// The query to predict.
        /// </param>
        /// <param name='timezoneOffset'>
        /// The timezone offset for the location of the request.
        /// </param>
        /// <param name='verbose'>
        /// If true will return all intents instead of just the topscoring intent.
        /// </param>
        /// <param name='spellCheck'>
        /// Enable spell checking.
        /// </param>
        /// <param name='staging'>
        /// Use staging endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
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
        public async Task<HttpOperationResponse<LuisResult>> GetPredictionsFromEndpointViaPostWithHttpMessagesAsync(string appId, string q, double? timezoneOffset = default(double?), bool? verbose = default(bool?), bool? spellCheck = default(bool?), bool? staging = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (appId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "appId");
            }
            if (q == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "q");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("appId", appId);
                tracingParameters.Add("q", q);
                tracingParameters.Add("timezoneOffset", timezoneOffset);
                tracingParameters.Add("verbose", verbose);
                tracingParameters.Add("spellCheck", spellCheck);
                tracingParameters.Add("staging", staging);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetPredictionsFromEndpointViaPost", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri;
            var _url = _baseUrl + (_baseUrl.EndsWith("/") ? "" : "/") + "{appId}";
            _url = _url.Replace("{AzureRegion}", Rest.Serialization.SafeJsonConvert.SerializeObject(Client.AzureRegion, Client.SerializationSettings).Trim('"'));
            _url = _url.Replace("{appId}", System.Uri.EscapeDataString(appId));
            List<string> _queryParameters = new List<string>();
            if (timezoneOffset != null)
            {
                _queryParameters.Add(string.Format("timezoneOffset={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(timezoneOffset, Client.SerializationSettings).Trim('"'))));
            }
            if (verbose != null)
            {
                _queryParameters.Add(string.Format("verbose={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(verbose, Client.SerializationSettings).Trim('"'))));
            }
            if (spellCheck != null)
            {
                _queryParameters.Add(string.Format("spellCheck={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(spellCheck, Client.SerializationSettings).Trim('"'))));
            }
            if (staging != null)
            {
                _queryParameters.Add(string.Format("staging={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(staging, Client.SerializationSettings).Trim('"'))));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


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
            if(q != null)
            {
                _requestContent = Rest.Serialization.SafeJsonConvert.SerializeObject(q, Client.SerializationSettings);
                _httpRequest.Content = new StringContent(_requestContent, System.Text.Encoding.UTF8);
                _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            }
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
                var ex = new APIErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    APIError _errorBody =  Rest.Serialization.SafeJsonConvert.DeserializeObject<APIError>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
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
            var _result = new HttpOperationResponse<LuisResult>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Rest.Serialization.SafeJsonConvert.DeserializeObject<LuisResult>(_responseContent, Client.DeserializationSettings);
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
