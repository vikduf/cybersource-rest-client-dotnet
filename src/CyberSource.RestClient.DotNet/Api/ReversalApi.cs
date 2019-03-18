/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Interfaces;
using CyberSource.Model;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReversalApi : IReversalApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReversalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReversalApi(String basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReversalApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReversalApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Process an Authorization Reversal Include the payment ID in the POST request to reverse the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>PtsV2PaymentsReversalsPost201Response</returns>
        public PtsV2PaymentsReversalsPost201Response AuthReversal (string id, AuthReversalRequest authReversalRequest)
        {
             ApiResponse<PtsV2PaymentsReversalsPost201Response> localVarResponse = AuthReversalWithHttpInfo(id, authReversalRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process an Authorization Reversal Include the payment ID in the POST request to reverse the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>ApiResponse of PtsV2PaymentsReversalsPost201Response</returns>
        public ApiResponse< PtsV2PaymentsReversalsPost201Response > AuthReversalWithHttpInfo (string id, AuthReversalRequest authReversalRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ReversalApi->AuthReversal");
            // verify the required parameter 'authReversalRequest' is set
            if (authReversalRequest == null)
                throw new ApiException(400, "Missing required parameter 'authReversalRequest' when calling ReversalApi->AuthReversal");

            var localVarPath = $"/pts/v2/payments/{id}/reversals";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
String[] localVarHttpHeaderAccepts = new String[] {"application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (authReversalRequest != null && authReversalRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(authReversalRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authReversalRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthReversal", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PaymentsReversalsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsReversalsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsReversalsPost201Response)));
        }

        /// <summary>
        /// Process an Authorization Reversal Include the payment ID in the POST request to reverse the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>Task of PtsV2PaymentsReversalsPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2PaymentsReversalsPost201Response> AuthReversalAsync (string id, AuthReversalRequest authReversalRequest)
        {
             ApiResponse<PtsV2PaymentsReversalsPost201Response> localVarResponse = await AuthReversalAsyncWithHttpInfo(id, authReversalRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Process an Authorization Reversal Include the payment ID in the POST request to reverse the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsReversalsPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsReversalsPost201Response>> AuthReversalAsyncWithHttpInfo (string id, AuthReversalRequest authReversalRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ReversalApi->AuthReversal");
            // verify the required parameter 'authReversalRequest' is set
            if (authReversalRequest == null)
                throw new ApiException(400, "Missing required parameter 'authReversalRequest' when calling ReversalApi->AuthReversal");

            var localVarPath = $"/pts/v2/payments/{id}/reversals";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
String[] localVarHttpHeaderAccepts = new String[] {"application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (authReversalRequest != null && authReversalRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(authReversalRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authReversalRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthReversal", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PaymentsReversalsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsReversalsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsReversalsPost201Response)));
        }

    }
}

