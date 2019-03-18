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
    public interface IPaymentsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// Authorize the payment for the transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>PtsV2PaymentsPost201Response</returns>
        PtsV2PaymentsPost201Response CreatePayment (CreatePaymentRequest createPaymentRequest);

        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// Authorize the payment for the transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>ApiResponse of PtsV2PaymentsPost201Response</returns>
        ApiResponse<PtsV2PaymentsPost201Response> CreatePaymentWithHttpInfo (CreatePaymentRequest createPaymentRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// Authorize the payment for the transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of PtsV2PaymentsPost201Response</returns>
        System.Threading.Tasks.Task<PtsV2PaymentsPost201Response> CreatePaymentAsync (CreatePaymentRequest createPaymentRequest);

        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// Authorize the payment for the transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsPost201Response>> CreatePaymentAsyncWithHttpInfo (CreatePaymentRequest createPaymentRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentsApi : IPaymentsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentsApi(Configuration configuration = null)
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
        /// Process a Payment Authorize the payment for the transaction. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>PtsV2PaymentsPost201Response</returns>
        public PtsV2PaymentsPost201Response CreatePayment (CreatePaymentRequest createPaymentRequest)
        {
             ApiResponse<PtsV2PaymentsPost201Response> localVarResponse = CreatePaymentWithHttpInfo(createPaymentRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process a Payment Authorize the payment for the transaction. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>ApiResponse of PtsV2PaymentsPost201Response</returns>
        public ApiResponse< PtsV2PaymentsPost201Response > CreatePaymentWithHttpInfo (CreatePaymentRequest createPaymentRequest)
        {
            // verify the required parameter 'createPaymentRequest' is set
            if (createPaymentRequest == null)
                throw new ApiException(400, "Missing required parameter 'createPaymentRequest' when calling PaymentsApi->CreatePayment");

            var localVarPath = $"/pts/v2/payments";
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

            if (createPaymentRequest != null && createPaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createPaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createPaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PaymentsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsPost201Response)));
        }

        /// <summary>
        /// Process a Payment Authorize the payment for the transaction. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of PtsV2PaymentsPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2PaymentsPost201Response> CreatePaymentAsync (CreatePaymentRequest createPaymentRequest)
        {
             ApiResponse<PtsV2PaymentsPost201Response> localVarResponse = await CreatePaymentAsyncWithHttpInfo(createPaymentRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Process a Payment Authorize the payment for the transaction. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsPost201Response>> CreatePaymentAsyncWithHttpInfo (CreatePaymentRequest createPaymentRequest)
        {
            // verify the required parameter 'createPaymentRequest' is set
            if (createPaymentRequest == null)
                throw new ApiException(400, "Missing required parameter 'createPaymentRequest' when calling PaymentsApi->CreatePayment");

            var localVarPath = $"/pts/v2/payments";
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

            if (createPaymentRequest != null && createPaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createPaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createPaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PaymentsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsPost201Response)));
        }

    }
}

