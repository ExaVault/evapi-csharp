# IO.Swagger.Api.AccountApi

All URIs are relative to *https://accountname.exavault.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccount**](AccountApi.md#getaccount) | **GET** /account | Get account settings
[**UpdateAccount**](AccountApi.md#updateaccount) | **PATCH** /account | Update account settings

<a name="getaccount"></a>
# **GetAccount**
> AccountResponse GetAccount (string evApiKey, string evAccessToken, string include = null)

Get account settings

Get setttings for your account, such as current space usage, webhooks settings, welcome email content and IP address restrictions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var evApiKey = evApiKey_example;  // string | API Key required for the request
            var evAccessToken = evAccessToken_example;  // string | Access Token for the request
            var include = include_example;  // string | Related records to include in the response. Valid option is **masterUser** (optional) 

            try
            {
                // Get account settings
                AccountResponse result = apiInstance.GetAccount(evApiKey, evAccessToken, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required for the request | 
 **evAccessToken** | **string**| Access Token for the request | 
 **include** | **string**| Related records to include in the response. Valid option is **masterUser** | [optional] 

### Return type

[**AccountResponse**](AccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateaccount"></a>
# **UpdateAccount**
> AccountResponse UpdateAccount (string evApiKey, string evAccessToken, UpdateAccountBody body = null)

Update account settings

Update account settings, such as welcome email content, IP address restrictions, webhooks settings and secure password requirements.  **Notes**  - You must have [admin-level access](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions) to change account settings.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAccountExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var body = new UpdateAccountBody(); // UpdateAccountBody | Update Account Settings (optional) 

            try
            {
                // Update account settings
                AccountResponse result = apiInstance.UpdateAccount(evApiKey, evAccessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.UpdateAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **body** | [**UpdateAccountBody**](UpdateAccountBody.md)| Update Account Settings | [optional] 

### Return type

[**AccountResponse**](AccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
