# IO.Swagger.Api.EmailApi

All URIs are relative to *https://accountname.exavault.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendReferralEmail**](EmailApi.md#sendreferralemail) | **POST** /email/referral | Send referral email to a given address
[**SendWelcomeEmail**](EmailApi.md#sendwelcomeemail) | **POST** /email/welcome/{username} | Resend welcome email to specific user

<a name="sendreferralemail"></a>
# **SendReferralEmail**
> EmptyResponse SendReferralEmail (string evApiKey, string evAccessToken, Body15 body = null)

Send referral email to a given address

Invite a friend to sign up for a free trial of ExaVault. Send a [referral](/lp/referafriend/) email to an email address. If the recipient signs up for ExaVault, we'll apply a credit to your account for the referral. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendReferralEmailExample
    {
        public void main()
        {
            var apiInstance = new EmailApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var body = new Body15(); // Body15 |  (optional) 

            try
            {
                // Send referral email to a given address
                EmptyResponse result = apiInstance.SendReferralEmail(evApiKey, evAccessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.SendReferralEmail: " + e.Message );
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
 **body** | [**Body15**](Body15.md)|  | [optional] 

### Return type

[**EmptyResponse**](EmptyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sendwelcomeemail"></a>
# **SendWelcomeEmail**
> EmptyResponse SendWelcomeEmail (string evApiKey, string evAccessToken, string username)

Resend welcome email to specific user

Send a welcome email to a user. The contents of the welcome email can be set by [PATCH /accounts](#operation/updateAccount).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendWelcomeEmailExample
    {
        public void main()
        {
            var apiInstance = new EmailApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var username = username_example;  // string | A username to send the welcome email to.

            try
            {
                // Resend welcome email to specific user
                EmptyResponse result = apiInstance.SendWelcomeEmail(evApiKey, evAccessToken, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.SendWelcomeEmail: " + e.Message );
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
 **username** | **string**| A username to send the welcome email to. | 

### Return type

[**EmptyResponse**](EmptyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
