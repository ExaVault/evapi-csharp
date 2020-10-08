# IO.Swagger.Api.RecipientsApi

All URIs are relative to *https://accountname.exavault.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ResendInvitationsForShare**](RecipientsApi.md#resendinvitationsforshare) | **POST** /recipients/shares/invites/{shareId} | Resend invitations to share recipients

<a name="resendinvitationsforshare"></a>
# **ResendInvitationsForShare**
> ShareRecipientsResponse ResendInvitationsForShare (string evApiKey, string evAccessToken, int? shareId, Body18 body = null)

Resend invitations to share recipients

Resend invitations to one or all recipients attached to specified share. The most recent message that was sent for the share will be re-used for this email.  You can use [GET /shares/{id}](#operation/getShareById) to view the recipient list and message history for a share. Use [PATCH /shares/{id}](#operation/updateShareById) to add or remove recipients.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResendInvitationsForShareExample
    {
        public void main()
        {
            var apiInstance = new RecipientsApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var shareId = 56;  // int? | ID of the share to resend invites for.
            var body = new Body18(); // Body18 |  (optional) 

            try
            {
                // Resend invitations to share recipients
                ShareRecipientsResponse result = apiInstance.ResendInvitationsForShare(evApiKey, evAccessToken, shareId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipientsApi.ResendInvitationsForShare: " + e.Message );
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
 **shareId** | **int?**| ID of the share to resend invites for. | 
 **body** | [**Body18**](Body18.md)|  | [optional] 

### Return type

[**ShareRecipientsResponse**](ShareRecipientsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
