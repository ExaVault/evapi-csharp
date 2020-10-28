/* 
 * ExaVault API
 *
 * See our API reference documentation at https://www.exavault.com/developer/api-docs/
 *
 * OpenAPI spec version: 2.0
 * Contact: support@exavault.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ExaVault.Client;
using ExaVault.Model;

namespace ExaVault.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IEmailApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Send referral email to a given address
        /// </summary>
        /// <remarks>
        /// Invite a friend to sign up for a free trial of ExaVault. Send a [referral](/lp/referafriend/) email to an email address. If the recipient signs up for ExaVault, we&#x27;ll apply a credit to your account for the referral. 
        /// </remarks>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>EmptyResponse</returns>
        EmptyResponse SendReferralEmail (string evApiKey, string evAccessToken, Body15 body = null);

        /// <summary>
        /// Send referral email to a given address
        /// </summary>
        /// <remarks>
        /// Invite a friend to sign up for a free trial of ExaVault. Send a [referral](/lp/referafriend/) email to an email address. If the recipient signs up for ExaVault, we&#x27;ll apply a credit to your account for the referral. 
        /// </remarks>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EmptyResponse</returns>
        ApiResponse<EmptyResponse> SendReferralEmailWithHttpInfo (string evApiKey, string evAccessToken, Body15 body = null);
        /// <summary>
        /// Resend welcome email to specific user
        /// </summary>
        /// <remarks>
        /// Send a welcome email to a user. The contents of the welcome email can be set by [PATCH /accounts](#operation/updateAccount).
        /// </remarks>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="username">A username to send the welcome email to.</param>
        /// <returns>EmptyResponse</returns>
        EmptyResponse SendWelcomeEmail (string evApiKey, string evAccessToken, string username);

        /// <summary>
        /// Resend welcome email to specific user
        /// </summary>
        /// <remarks>
        /// Send a welcome email to a user. The contents of the welcome email can be set by [PATCH /accounts](#operation/updateAccount).
        /// </remarks>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="username">A username to send the welcome email to.</param>
        /// <returns>ApiResponse of EmptyResponse</returns>
        ApiResponse<EmptyResponse> SendWelcomeEmailWithHttpInfo (string evApiKey, string evAccessToken, string username);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Send referral email to a given address
        /// </summary>
        /// <remarks>
        /// Invite a friend to sign up for a free trial of ExaVault. Send a [referral](/lp/referafriend/) email to an email address. If the recipient signs up for ExaVault, we&#x27;ll apply a credit to your account for the referral. 
        /// </remarks>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EmptyResponse</returns>
        System.Threading.Tasks.Task<EmptyResponse> SendReferralEmailAsync (string evApiKey, string evAccessToken, Body15 body = null);

        /// <summary>
        /// Send referral email to a given address
        /// </summary>
        /// <remarks>
        /// Invite a friend to sign up for a free trial of ExaVault. Send a [referral](/lp/referafriend/) email to an email address. If the recipient signs up for ExaVault, we&#x27;ll apply a credit to your account for the referral. 
        /// </remarks>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EmptyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmptyResponse>> SendReferralEmailAsyncWithHttpInfo (string evApiKey, string evAccessToken, Body15 body = null);
        /// <summary>
        /// Resend welcome email to specific user
        /// </summary>
        /// <remarks>
        /// Send a welcome email to a user. The contents of the welcome email can be set by [PATCH /accounts](#operation/updateAccount).
        /// </remarks>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="username">A username to send the welcome email to.</param>
        /// <returns>Task of EmptyResponse</returns>
        System.Threading.Tasks.Task<EmptyResponse> SendWelcomeEmailAsync (string evApiKey, string evAccessToken, string username);

        /// <summary>
        /// Resend welcome email to specific user
        /// </summary>
        /// <remarks>
        /// Send a welcome email to a user. The contents of the welcome email can be set by [PATCH /accounts](#operation/updateAccount).
        /// </remarks>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="username">A username to send the welcome email to.</param>
        /// <returns>Task of ApiResponse (EmptyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmptyResponse>> SendWelcomeEmailAsyncWithHttpInfo (string evApiKey, string evAccessToken, string username);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class EmailApi : IEmailApi
    {
        private ExaVault.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailApi(String basePath)
        {
            this.Configuration = new ExaVault.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ExaVault.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class
        /// </summary>
        /// <returns></returns>
        public EmailApi()
        {
            this.Configuration = ExaVault.Client.Configuration.Default;

            ExceptionFactory = ExaVault.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EmailApi(ExaVault.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = ExaVault.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ExaVault.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
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
        public ExaVault.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExaVault.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Send referral email to a given address Invite a friend to sign up for a free trial of ExaVault. Send a [referral](/lp/referafriend/) email to an email address. If the recipient signs up for ExaVault, we&#x27;ll apply a credit to your account for the referral. 
        /// </summary>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>EmptyResponse</returns>
        public EmptyResponse SendReferralEmail (string evApiKey, string evAccessToken, Body15 body = null)
        {
             ApiResponse<EmptyResponse> localVarResponse = SendReferralEmailWithHttpInfo(evApiKey, evAccessToken, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send referral email to a given address Invite a friend to sign up for a free trial of ExaVault. Send a [referral](/lp/referafriend/) email to an email address. If the recipient signs up for ExaVault, we&#x27;ll apply a credit to your account for the referral. 
        /// </summary>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EmptyResponse</returns>
        public ApiResponse< EmptyResponse > SendReferralEmailWithHttpInfo (string evApiKey, string evAccessToken, Body15 body = null)
        {
            // verify the required parameter 'evApiKey' is set
            if (evApiKey == null)
                throw new ApiException(400, "Missing required parameter 'evApiKey' when calling EmailApi->SendReferralEmail");
            // verify the required parameter 'evAccessToken' is set
            if (evAccessToken == null)
                throw new ApiException(400, "Missing required parameter 'evAccessToken' when calling EmailApi->SendReferralEmail");

            var localVarPath = "/email/referral";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (evApiKey != null) localVarHeaderParams.Add("ev-api-key", this.Configuration.ApiClient.ParameterToString(evApiKey)); // header parameter
            if (evAccessToken != null) localVarHeaderParams.Add("ev-access-token", this.Configuration.ApiClient.ParameterToString(evAccessToken)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendReferralEmail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmptyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmptyResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmptyResponse)));
        }

        /// <summary>
        /// Send referral email to a given address Invite a friend to sign up for a free trial of ExaVault. Send a [referral](/lp/referafriend/) email to an email address. If the recipient signs up for ExaVault, we&#x27;ll apply a credit to your account for the referral. 
        /// </summary>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EmptyResponse</returns>
        public async System.Threading.Tasks.Task<EmptyResponse> SendReferralEmailAsync (string evApiKey, string evAccessToken, Body15 body = null)
        {
             ApiResponse<EmptyResponse> localVarResponse = await SendReferralEmailAsyncWithHttpInfo(evApiKey, evAccessToken, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send referral email to a given address Invite a friend to sign up for a free trial of ExaVault. Send a [referral](/lp/referafriend/) email to an email address. If the recipient signs up for ExaVault, we&#x27;ll apply a credit to your account for the referral. 
        /// </summary>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EmptyResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmptyResponse>> SendReferralEmailAsyncWithHttpInfo (string evApiKey, string evAccessToken, Body15 body = null)
        {
            // verify the required parameter 'evApiKey' is set
            if (evApiKey == null)
                throw new ApiException(400, "Missing required parameter 'evApiKey' when calling EmailApi->SendReferralEmail");
            // verify the required parameter 'evAccessToken' is set
            if (evAccessToken == null)
                throw new ApiException(400, "Missing required parameter 'evAccessToken' when calling EmailApi->SendReferralEmail");

            var localVarPath = "/email/referral";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (evApiKey != null) localVarHeaderParams.Add("ev-api-key", this.Configuration.ApiClient.ParameterToString(evApiKey)); // header parameter
            if (evAccessToken != null) localVarHeaderParams.Add("ev-access-token", this.Configuration.ApiClient.ParameterToString(evAccessToken)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendReferralEmail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmptyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmptyResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmptyResponse)));
        }

        /// <summary>
        /// Resend welcome email to specific user Send a welcome email to a user. The contents of the welcome email can be set by [PATCH /accounts](#operation/updateAccount).
        /// </summary>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="username">A username to send the welcome email to.</param>
        /// <returns>EmptyResponse</returns>
        public EmptyResponse SendWelcomeEmail (string evApiKey, string evAccessToken, string username)
        {
             ApiResponse<EmptyResponse> localVarResponse = SendWelcomeEmailWithHttpInfo(evApiKey, evAccessToken, username);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Resend welcome email to specific user Send a welcome email to a user. The contents of the welcome email can be set by [PATCH /accounts](#operation/updateAccount).
        /// </summary>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="username">A username to send the welcome email to.</param>
        /// <returns>ApiResponse of EmptyResponse</returns>
        public ApiResponse< EmptyResponse > SendWelcomeEmailWithHttpInfo (string evApiKey, string evAccessToken, string username)
        {
            // verify the required parameter 'evApiKey' is set
            if (evApiKey == null)
                throw new ApiException(400, "Missing required parameter 'evApiKey' when calling EmailApi->SendWelcomeEmail");
            // verify the required parameter 'evAccessToken' is set
            if (evAccessToken == null)
                throw new ApiException(400, "Missing required parameter 'evAccessToken' when calling EmailApi->SendWelcomeEmail");
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling EmailApi->SendWelcomeEmail");

            var localVarPath = "/email/welcome/{username}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (username != null) localVarPathParams.Add("username", this.Configuration.ApiClient.ParameterToString(username)); // path parameter
            if (evApiKey != null) localVarHeaderParams.Add("ev-api-key", this.Configuration.ApiClient.ParameterToString(evApiKey)); // header parameter
            if (evAccessToken != null) localVarHeaderParams.Add("ev-access-token", this.Configuration.ApiClient.ParameterToString(evAccessToken)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendWelcomeEmail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmptyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmptyResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmptyResponse)));
        }

        /// <summary>
        /// Resend welcome email to specific user Send a welcome email to a user. The contents of the welcome email can be set by [PATCH /accounts](#operation/updateAccount).
        /// </summary>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="username">A username to send the welcome email to.</param>
        /// <returns>Task of EmptyResponse</returns>
        public async System.Threading.Tasks.Task<EmptyResponse> SendWelcomeEmailAsync (string evApiKey, string evAccessToken, string username)
        {
             ApiResponse<EmptyResponse> localVarResponse = await SendWelcomeEmailAsyncWithHttpInfo(evApiKey, evAccessToken, username);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Resend welcome email to specific user Send a welcome email to a user. The contents of the welcome email can be set by [PATCH /accounts](#operation/updateAccount).
        /// </summary>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="username">A username to send the welcome email to.</param>
        /// <returns>Task of ApiResponse (EmptyResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmptyResponse>> SendWelcomeEmailAsyncWithHttpInfo (string evApiKey, string evAccessToken, string username)
        {
            // verify the required parameter 'evApiKey' is set
            if (evApiKey == null)
                throw new ApiException(400, "Missing required parameter 'evApiKey' when calling EmailApi->SendWelcomeEmail");
            // verify the required parameter 'evAccessToken' is set
            if (evAccessToken == null)
                throw new ApiException(400, "Missing required parameter 'evAccessToken' when calling EmailApi->SendWelcomeEmail");
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling EmailApi->SendWelcomeEmail");

            var localVarPath = "/email/welcome/{username}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (username != null) localVarPathParams.Add("username", this.Configuration.ApiClient.ParameterToString(username)); // path parameter
            if (evApiKey != null) localVarHeaderParams.Add("ev-api-key", this.Configuration.ApiClient.ParameterToString(evApiKey)); // header parameter
            if (evAccessToken != null) localVarHeaderParams.Add("ev-access-token", this.Configuration.ApiClient.ParameterToString(evAccessToken)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendWelcomeEmail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmptyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmptyResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmptyResponse)));
        }

    }
}