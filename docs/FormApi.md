# IO.Swagger.Api.FormApi

All URIs are relative to *https://accountname.exavault.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteFormMessageById**](FormApi.md#deleteformmessagebyid) | **DELETE** /forms/entries/{id} | Delete a receive form submission
[**GetFormById**](FormApi.md#getformbyid) | **GET** /forms/{id} | Get receive folder form by Id
[**GetFormByShareHash**](FormApi.md#getformbysharehash) | **GET** /forms | Get receive folder form settings
[**GetFormEntries**](FormApi.md#getformentries) | **GET** /forms/entries/{id} | Get form data entries for a receive
[**UpdateFormById**](FormApi.md#updateformbyid) | **PATCH** /forms/{id} | Updates a form with given parameters

<a name="deleteformmessagebyid"></a>
# **DeleteFormMessageById**
> EmptyResponse DeleteFormMessageById (string evApiKey, string evAccessToken, string id)

Delete a receive form submission

Deletes a form submission entry, which represents one time that a visitor filled out the form and uploaded files. This deletes only the record of the submission (the date, the values entered in the form and the names of the files uploaded by the visitor).The share and any associated file resources will not be deleted by this.   **Notes**:  - Use the [GET /form/entries/{formId}](#operation/getFormMessageById) to list the submissions and obtain the ID of the entry you want to delete - You must have the [DeleteFormData permission](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions) in order to use this operation - It is not possible to un-delete data that is removed in this way 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteFormMessageByIdExample
    {
        public void main()
        {
            var apiInstance = new FormApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call. 
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var id = id_example;  // string | ID of the entry to be deleted data for

            try
            {
                // Delete a receive form submission
                EmptyResponse result = apiInstance.DeleteFormMessageById(evApiKey, evAccessToken, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormApi.DeleteFormMessageById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call.  | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **id** | **string**| ID of the entry to be deleted data for | 

### Return type

[**EmptyResponse**](EmptyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getformbyid"></a>
# **GetFormById**
> FormResponse GetFormById (int? id, string evApiKey, string evAccessToken, string include = null)

Get receive folder form by Id

Returns the [file upload form](/docs/account/05-file-sharing/05-form-builder) assigned to a [receive folder](/docs/account/05-file-sharing/04-receive-folders). The form details will return all the input fields and their settings.   Use the `include` parameter (with the value **share**) to also retrieve the details of the associated receive folder.   **Note**  If you prefer to find a form by its shareHash, you can use the [GET /forms](#operation/getFormByShareHash) endpoint instead.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFormByIdExample
    {
        public void main()
        {
            var apiInstance = new FormApi();
            var id = 56;  // int? | Form unique ID number.
            var evApiKey = evApiKey_example;  // string | API key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access Token required to make the API call.
            var include = include_example;  // string | Enter \"**share**\" to get information about associated receive folder. (optional) 

            try
            {
                // Get receive folder form by Id
                FormResponse result = apiInstance.GetFormById(id, evApiKey, evAccessToken, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormApi.GetFormById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Form unique ID number. | 
 **evApiKey** | **string**| API key required to make the API call. | 
 **evAccessToken** | **string**| Access Token required to make the API call. | 
 **include** | **string**| Enter \&quot;**share**\&quot; to get information about associated receive folder. | [optional] 

### Return type

[**FormResponse**](FormResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getformbysharehash"></a>
# **GetFormByShareHash**
> FormResponse GetFormByShareHash (string evApiKey, string evAccessToken, string shareHash, string include = null)

Get receive folder form settings

Get the information for the [file upload form](/docs/account/05-file-sharing/05-form-builder) assigned to a [receive folder](/docs/account/05-file-sharing/04-receive-folders) by its shareHash. The form details will return all the input field settings and the CSS for the form.  Use the `include` parameter (with the value **share**) to also get the details of the associated receive folder.  **Note**  - If you prefer to find a form by its ID, you can use the [GET /forms/{id}](#operation/getFormById) endpoint instead.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFormByShareHashExample
    {
        public void main()
        {
            var apiInstance = new FormApi();
            var evApiKey = evApiKey_example;  // string | API key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access Token required to make the API call.
            var shareHash = shareHash_example;  // string | Share hash to retrieve the form for.
            var include = include_example;  // string | Related record types to include in the response. Valid option is **share** (optional) 

            try
            {
                // Get receive folder form settings
                FormResponse result = apiInstance.GetFormByShareHash(evApiKey, evAccessToken, shareHash, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormApi.GetFormByShareHash: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API key required to make the API call. | 
 **evAccessToken** | **string**| Access Token required to make the API call. | 
 **shareHash** | **string**| Share hash to retrieve the form for. | 
 **include** | **string**| Related record types to include in the response. Valid option is **share** | [optional] 

### Return type

[**FormResponse**](FormResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getformentries"></a>
# **GetFormEntries**
> FormEntryResponse GetFormEntries (string evApiKey, string evAccessToken, string id, int? limit = null, int? offset = null)

Get form data entries for a receive

Returns the form data entries for a specific form for a receive. Optional parameters can be included in the call to manage larger data sets. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFormEntriesExample
    {
        public void main()
        {
            var apiInstance = new FormApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call. 
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var id = id_example;  // string | ID of the form to retrieve entries for.
            var limit = 56;  // int? | Limit of records to be returned (for pagination) (optional) 
            var offset = 56;  // int? | Current offset of records (for pagination) (optional) 

            try
            {
                // Get form data entries for a receive
                FormEntryResponse result = apiInstance.GetFormEntries(evApiKey, evAccessToken, id, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormApi.GetFormEntries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call.  | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **id** | **string**| ID of the form to retrieve entries for. | 
 **limit** | **int?**| Limit of records to be returned (for pagination) | [optional] 
 **offset** | **int?**| Current offset of records (for pagination) | [optional] 

### Return type

[**FormEntryResponse**](FormEntryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateformbyid"></a>
# **UpdateFormById**
> FormResponse UpdateFormById (string evApiKey, string evAccessToken, int? id, Body2 body = null)

Updates a form with given parameters

Add, update, or delete a form's parameters. This will alter how your users/customers will see and interact with the form when sending you files.   **Notes**  *This call will **replace** your current form in its entirety.* If you want to keep any existing elements unchanged, be sure to submit the call with an element's current settings to preserve them.                          

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateFormByIdExample
    {
        public void main()
        {
            var apiInstance = new FormApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var id = 56;  // int? | Form unique ID number.
            var body = new Body2(); // Body2 |  (optional) 

            try
            {
                // Updates a form with given parameters
                FormResponse result = apiInstance.UpdateFormById(evApiKey, evAccessToken, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FormApi.UpdateFormById: " + e.Message );
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
 **id** | **int?**| Form unique ID number. | 
 **body** | [**Body2**](Body2.md)|  | [optional] 

### Return type

[**FormResponse**](FormResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
