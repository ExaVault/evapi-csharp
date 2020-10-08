# IO.Swagger.Api.EmailListsApi

All URIs are relative to *https://accountname.exavault.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddEmailList**](EmailListsApi.md#addemaillist) | **POST** /email-lists | Create new email list
[**DeleteEmailListById**](EmailListsApi.md#deleteemaillistbyid) | **DELETE** /email-lists/{id} | Delete an email group with given id
[**GetEmailListById**](EmailListsApi.md#getemaillistbyid) | **GET** /email-lists/{id} | Get individual email group
[**GetEmailLists**](EmailListsApi.md#getemaillists) | **GET** /email-lists | Get all email groups
[**UpdateEmailListById**](EmailListsApi.md#updateemaillistbyid) | **PATCH** /email-lists/{id} | Update an email group

<a name="addemaillist"></a>
# **AddEmailList**
> EmailListResponse AddEmailList (string evApiKey, string evAccessToken, Body body = null)

Create new email list

Create a new email list. Among other things, email lists can be used to send files or share folders with a group of email addresses at once.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddEmailListExample
    {
        public void main()
        {
            var apiInstance = new EmailListsApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var body = new Body(); // Body |  (optional) 

            try
            {
                // Create new email list
                EmailListResponse result = apiInstance.AddEmailList(evApiKey, evAccessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailListsApi.AddEmailList: " + e.Message );
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
 **body** | [**Body**](Body.md)|  | [optional] 

### Return type

[**EmailListResponse**](EmailListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteemaillistbyid"></a>
# **DeleteEmailListById**
> EmptyResponse DeleteEmailListById (string evApiKey, string evAccessToken, int? id)

Delete an email group with given id

Permanently delete an email group. This action is not reversable. We recommend making a user confirm this action before sending the API call. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteEmailListByIdExample
    {
        public void main()
        {
            var apiInstance = new EmailListsApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var id = 56;  // int? | ID of the email list to delete

            try
            {
                // Delete an email group with given id
                EmptyResponse result = apiInstance.DeleteEmailListById(evApiKey, evAccessToken, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailListsApi.DeleteEmailListById: " + e.Message );
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
 **id** | **int?**| ID of the email list to delete | 

### Return type

[**EmptyResponse**](EmptyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getemaillistbyid"></a>
# **GetEmailListById**
> EmailListResponse GetEmailListById (string evApiKey, string evAccessToken, int? id, string include = null)

Get individual email group

Retrieve all the details of a specifc email list including it's name, when it was created and all the email addresses that belong to the group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEmailListByIdExample
    {
        public void main()
        {
            var apiInstance = new EmailListsApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var id = 56;  // int? | ID of the email list to return.
            var include = include_example;  // string | Related record types to include in the response. Valid option is `ownerUser` (optional) 

            try
            {
                // Get individual email group
                EmailListResponse result = apiInstance.GetEmailListById(evApiKey, evAccessToken, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailListsApi.GetEmailListById: " + e.Message );
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
 **id** | **int?**| ID of the email list to return. | 
 **include** | **string**| Related record types to include in the response. Valid option is &#x60;ownerUser&#x60; | [optional] 

### Return type

[**EmailListResponse**](EmailListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getemaillists"></a>
# **GetEmailLists**
> EmailListCollectionResponse GetEmailLists (string evApiKey, string evAccessToken, string include = null)

Get all email groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEmailListsExample
    {
        public void main()
        {
            var apiInstance = new EmailListsApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var include = include_example;  // string | Related record types to include in the response. Valid option is `ownerUser` (optional) 

            try
            {
                // Get all email groups
                EmailListCollectionResponse result = apiInstance.GetEmailLists(evApiKey, evAccessToken, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailListsApi.GetEmailLists: " + e.Message );
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
 **include** | **string**| Related record types to include in the response. Valid option is &#x60;ownerUser&#x60; | [optional] 

### Return type

[**EmailListCollectionResponse**](EmailListCollectionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateemaillistbyid"></a>
# **UpdateEmailListById**
> EmailListResponse UpdateEmailListById (string evApiKey, string evAccessToken, int? id, Body1 body = null)

Update an email group

Add or remove emails from an email list that can be used to send and share files with groups.   **Notes**  *This call will **replace** your current email list in its entirety.* If you want to keep any existing emails on the list, be sure to submit the call with any current emails you want to keep on the list.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateEmailListByIdExample
    {
        public void main()
        {
            var apiInstance = new EmailListsApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var id = 56;  // int? | ID of the email list to update.
            var body = new Body1(); // Body1 |  (optional) 

            try
            {
                // Update an email group
                EmailListResponse result = apiInstance.UpdateEmailListById(evApiKey, evAccessToken, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailListsApi.UpdateEmailListById: " + e.Message );
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
 **id** | **int?**| ID of the email list to update. | 
 **body** | [**Body1**](Body1.md)|  | [optional] 

### Return type

[**EmailListResponse**](EmailListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
