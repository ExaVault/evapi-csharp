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
        public interface IRecipientsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Resend invitations to share recipients
        /// </summary>
        /// <remarks>
        /// Resend invitations to one or all recipients attached to specified share. The most recent message that was sent for the share will be re-used for this email.  You can use [GET /shares/{id}](#operation/getShareById) to view the recipient list and message history for a share. Use [PATCH /shares/{id}](#operation/updateShareById) to add or remove recipients.
        /// </remarks>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="shareId">ID of the share to resend invites for.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ShareRecipientsResponse</returns>
        ShareRecipientsResponse ResendInvitationsForShare (string evApiKey, string evAccessToken, int? shareId, ResendInvitationsRequestBody body = null);

        /// <summary>
        /// Resend invitations to share recipients
        /// </summary>
        /// <remarks>
        /// Resend invitations to one or all recipients attached to specified share. The most recent message that was sent for the share will be re-used for this email.  You can use [GET /shares/{id}](#operation/getShareById) to view the recipient list and message history for a share. Use [PATCH /shares/{id}](#operation/updateShareById) to add or remove recipients.
        /// </remarks>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="shareId">ID of the share to resend invites for.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ShareRecipientsResponse</returns>
        ApiResponse<ShareRecipientsResponse> ResendInvitationsForShareWithHttpInfo (string evApiKey, string evAccessToken, int? shareId, ResendInvitationsRequestBody body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Resend invitations to share recipients
        /// </summary>
        /// <remarks>
        /// Resend invitations to one or all recipients attached to specified share. The most recent message that was sent for the share will be re-used for this email.  You can use [GET /shares/{id}](#operation/getShareById) to view the recipient list and message history for a share. Use [PATCH /shares/{id}](#operation/updateShareById) to add or remove recipients.
        /// </remarks>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="shareId">ID of the share to resend invites for.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ShareRecipientsResponse</returns>
        System.Threading.Tasks.Task<ShareRecipientsResponse> ResendInvitationsForShareAsync (string evApiKey, string evAccessToken, int? shareId, ResendInvitationsRequestBody body = null);

        /// <summary>
        /// Resend invitations to share recipients
        /// </summary>
        /// <remarks>
        /// Resend invitations to one or all recipients attached to specified share. The most recent message that was sent for the share will be re-used for this email.  You can use [GET /shares/{id}](#operation/getShareById) to view the recipient list and message history for a share. Use [PATCH /shares/{id}](#operation/updateShareById) to add or remove recipients.
        /// </remarks>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="shareId">ID of the share to resend invites for.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ShareRecipientsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShareRecipientsResponse>> ResendInvitationsForShareAsyncWithHttpInfo (string evApiKey, string evAccessToken, int? shareId, ResendInvitationsRequestBody body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class RecipientsApi : IRecipientsApi
    {
        private ExaVault.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RecipientsApi(String basePath)
        {
            this.Configuration = new ExaVault.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ExaVault.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientsApi"/> class
        /// </summary>
        /// <returns></returns>
        public RecipientsApi()
        {
            this.Configuration = ExaVault.Client.Configuration.Default;

            ExceptionFactory = ExaVault.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RecipientsApi(ExaVault.Client.Configuration configuration = null)
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
        /// Resend invitations to share recipients Resend invitations to one or all recipients attached to specified share. The most recent message that was sent for the share will be re-used for this email.  You can use [GET /shares/{id}](#operation/getShareById) to view the recipient list and message history for a share. Use [PATCH /shares/{id}](#operation/updateShareById) to add or remove recipients.
        /// </summary>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="shareId">ID of the share to resend invites for.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ShareRecipientsResponse</returns>
        public ShareRecipientsResponse ResendInvitationsForShare (string evApiKey, string evAccessToken, int? shareId, ResendInvitationsRequestBody body = null)
        {
             ApiResponse<ShareRecipientsResponse> localVarResponse = ResendInvitationsForShareWithHttpInfo(evApiKey, evAccessToken, shareId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Resend invitations to share recipients Resend invitations to one or all recipients attached to specified share. The most recent message that was sent for the share will be re-used for this email.  You can use [GET /shares/{id}](#operation/getShareById) to view the recipient list and message history for a share. Use [PATCH /shares/{id}](#operation/updateShareById) to add or remove recipients.
        /// </summary>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="shareId">ID of the share to resend invites for.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ShareRecipientsResponse</returns>
        public ApiResponse< ShareRecipientsResponse > ResendInvitationsForShareWithHttpInfo (string evApiKey, string evAccessToken, int? shareId, ResendInvitationsRequestBody body = null)
        {
            // verify the required parameter 'evApiKey' is set
            if (evApiKey == null)
                throw new ApiException(400, "Missing required parameter 'evApiKey' when calling RecipientsApi->ResendInvitationsForShare");
            // verify the required parameter 'evAccessToken' is set
            if (evAccessToken == null)
                throw new ApiException(400, "Missing required parameter 'evAccessToken' when calling RecipientsApi->ResendInvitationsForShare");
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling RecipientsApi->ResendInvitationsForShare");

            var localVarPath = "/recipients/shares/invites/{shareId}";
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

            if (shareId != null) localVarPathParams.Add("shareId", this.Configuration.ApiClient.ParameterToString(shareId)); // path parameter
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
                Exception exception = ExceptionFactory("ResendInvitationsForShare", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ShareRecipientsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ShareRecipientsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShareRecipientsResponse)));
        }

        /// <summary>
        /// Resend invitations to share recipients Resend invitations to one or all recipients attached to specified share. The most recent message that was sent for the share will be re-used for this email.  You can use [GET /shares/{id}](#operation/getShareById) to view the recipient list and message history for a share. Use [PATCH /shares/{id}](#operation/updateShareById) to add or remove recipients.
        /// </summary>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="shareId">ID of the share to resend invites for.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ShareRecipientsResponse</returns>
        public async System.Threading.Tasks.Task<ShareRecipientsResponse> ResendInvitationsForShareAsync (string evApiKey, string evAccessToken, int? shareId, ResendInvitationsRequestBody body = null)
        {
             ApiResponse<ShareRecipientsResponse> localVarResponse = await ResendInvitationsForShareAsyncWithHttpInfo(evApiKey, evAccessToken, shareId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Resend invitations to share recipients Resend invitations to one or all recipients attached to specified share. The most recent message that was sent for the share will be re-used for this email.  You can use [GET /shares/{id}](#operation/getShareById) to view the recipient list and message history for a share. Use [PATCH /shares/{id}](#operation/updateShareById) to add or remove recipients.
        /// </summary>
        /// <exception cref="ExaVault.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="evApiKey">API Key required to make the API call.</param>
        /// <param name="evAccessToken">Access token required to make the API call.</param>
        /// <param name="shareId">ID of the share to resend invites for.</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ShareRecipientsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShareRecipientsResponse>> ResendInvitationsForShareAsyncWithHttpInfo (string evApiKey, string evAccessToken, int? shareId, ResendInvitationsRequestBody body = null)
        {
            // verify the required parameter 'evApiKey' is set
            if (evApiKey == null)
                throw new ApiException(400, "Missing required parameter 'evApiKey' when calling RecipientsApi->ResendInvitationsForShare");
            // verify the required parameter 'evAccessToken' is set
            if (evAccessToken == null)
                throw new ApiException(400, "Missing required parameter 'evAccessToken' when calling RecipientsApi->ResendInvitationsForShare");
            // verify the required parameter 'shareId' is set
            if (shareId == null)
                throw new ApiException(400, "Missing required parameter 'shareId' when calling RecipientsApi->ResendInvitationsForShare");

            var localVarPath = "/recipients/shares/invites/{shareId}";
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

            if (shareId != null) localVarPathParams.Add("shareId", this.Configuration.ApiClient.ParameterToString(shareId)); // path parameter
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
                Exception exception = ExceptionFactory("ResendInvitationsForShare", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ShareRecipientsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ShareRecipientsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShareRecipientsResponse)));
        }

    }
}
