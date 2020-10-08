# IO.Swagger.Api.SharesApi

All URIs are relative to *https://accountname.exavault.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddShare**](SharesApi.md#addshare) | **POST** /shares | Creates a share
[**CompleteDirectSend**](SharesApi.md#completedirectsend) | **POST** /shares/complete-send/{id} | Complete send files
[**DeleteShareById**](SharesApi.md#deletesharebyid) | **DELETE** /shares/{id} | Deactivate a share
[**GetShareById**](SharesApi.md#getsharebyid) | **GET** /shares/{id} | Get a share
[**ListShares**](SharesApi.md#listshares) | **GET** /shares | Get a list of shares
[**UpdateShareById**](SharesApi.md#updatesharebyid) | **PATCH** /shares/{id} | Update a share

<a name="addshare"></a>
# **AddShare**
> ShareResponse AddShare (string evApiKey, string evAccessToken, Body16 body = null)

Creates a share

Creates a new share object for the given path in your account. We support three types of shares:    - A **shared folder** allows you to let outside parties access a folder in your account (including any files and nested subfolders) using just a link. Shared folders can be restricted; e.g. with an expiration date, password, download-only, etc. Shared folders are 'live'; if someone makes a change to a file in your shared folder, it will be immediately reflected in your account, and vice-versa.   - A file **send** lets you send one or more files via an easy download link. File sends are different than shared folders because file sends are 'point in time' - - the recipient will get the files as you sent them. If you later make a change to the source file, it will not be updated for the recipient.   - A **receive** folder lets you receive files into your account. You can either send users a link, or optionally [embed a customized form](/docs/account/05-file-sharing/05-upload-widget) on your website.    **How to send files from your computer using the API**:  In order to use the API to send files which are not already stored in your account, you'll need to follow a three-step process:  1. Use the [POST /shares](#operation/addShare) endpoint to set up your send, including password, recipients, expiration, etc. You must include **upload** among the permissions in the `accessMode` and set the `sendingLocalFiles` paramter to **true**. The response that is returned will include a \"meta\" attribute, which contains an **accessToken** attribute. This new access token is valid only for the send. 2. Use the [POST /resources/upload](#operation/uploadFile) endpoint to upload your files to the send you've created. The \"/\" path represents the root of the share, not your home directory. **You must send the access token that you received from the first step in the `ev-access-token` header** 3. Use the [POST /shares/complete-send/{id}](#operation/completeDirectSend) endpoint to indicate that you have finished uploading files to your send. This will trigger the system to remove the **upload** permission from the share and send any invitation emails you set up in the first step of the process. **You must send YOUR access token in the `ev-access-token` header, not the temporary access token**  **Notes:**  Authenticated user requires [share permission](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddShareExample
    {
        public void main()
        {
            var apiInstance = new SharesApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var body = new Body16(); // Body16 |  (optional) 

            try
            {
                // Creates a share
                ShareResponse result = apiInstance.AddShare(evApiKey, evAccessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharesApi.AddShare: " + e.Message );
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
 **body** | [**Body16**](Body16.md)|  | [optional] 

### Return type

[**ShareResponse**](ShareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="completedirectsend"></a>
# **CompleteDirectSend**
> ShareResponse CompleteDirectSend (string evApiKey, string evAccessToken, int? id)

Complete send files

After uploading the file(s) to be sent, this method will trigger invitation emails and finish the send files setup. If you are not sending files from your own computer in a send, you will not need this step.    **How to send files from your computer using the API**:  In order to use the API to send files which are not already stored in your account, you'll need to follow a three-step process:  1. Use the [POST /shares](#operation/addShare) endpoint to set up your send, including password, recipients, expiration, etc. You must include **upload** among the permissions in the `accessMode` and set the `sendingLocalFiles` paramter to **true**. The response that is returned will include a \"meta\" attribute, which contains an **accessToken** attribute. This new access token is valid only for the send. 2. Use the [POST /resources/upload](#operation/uploadFile) endpoint to upload your files to the send you've created. The \"/\" path represents the root of the share, not your home directory. **You must send the access token that you received from the first step in the `ev-access-token` header** 3. Use the [POST /shares/complete-send/{id}](#operation/completeDirectSend) endpoint to indicate that you have finished uploading files to your send. This will trigger the system to remove the **upload** permission from the share and send any invitation emails you set up in the first step of the process. **You must send YOUR access token in the `ev-access-token` header, not the temporary access token** 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompleteDirectSendExample
    {
        public void main()
        {
            var apiInstance = new SharesApi();
            var evApiKey = evApiKey_example;  // string | API Key
            var evAccessToken = evAccessToken_example;  // string | Access Token
            var id = 56;  // int? | ID of the share to trigger invitations for.

            try
            {
                // Complete send files
                ShareResponse result = apiInstance.CompleteDirectSend(evApiKey, evAccessToken, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharesApi.CompleteDirectSend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key | 
 **evAccessToken** | **string**| Access Token | 
 **id** | **int?**| ID of the share to trigger invitations for. | 

### Return type

[**ShareResponse**](ShareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesharebyid"></a>
# **DeleteShareById**
> EmptyResponse DeleteShareById (int? id, string evApiKey, string evAccessToken)

Deactivate a share

Deactivate a share. Deactivating a share does not remove the underlying files for **shared_folder** and **receive** share types; it merely removes the access URL. Deleting a **send** share type does remove the associated files, as files that have been sent are only associated with the share, and aren't stored anywhere else in the account.  **Notes:**  - You must have [sharing permissons](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions) to use this. - You must have [admin-level access](/docs/account/04-users/01-admin-users), or you must be the owner of the specified share you wish to delete.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteShareByIdExample
    {
        public void main()
        {
            var apiInstance = new SharesApi();
            var id = 56;  // int? | ID of the share entry
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.

            try
            {
                // Deactivate a share
                EmptyResponse result = apiInstance.DeleteShareById(id, evApiKey, evAccessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharesApi.DeleteShareById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the share entry | 
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 

### Return type

[**EmptyResponse**](EmptyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsharebyid"></a>
# **GetShareById**
> ShareResponse GetShareById (int? id, string evApiKey, string evAccessToken, string include = null)

Get a share

Get the details for a specific share entry. You can use the `include` parameter to also get the details of related records, such as the owning user or the resources involved in the share.  **Notes:**  - Authenticated user requires [share permission](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions). - To get share objects with type send, authenticated user's role must be admin or master.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShareByIdExample
    {
        public void main()
        {
            var apiInstance = new SharesApi();
            var id = 56;  // int? | ID of the share entry
            var evApiKey = evApiKey_example;  // string | API Key
            var evAccessToken = evAccessToken_example;  // string | Access Token
            var include = include_example;  // string | Comma separated list of relationships to include in response. Possible values are **owner**, **resources**, **notifications**, **activity**. (optional) 

            try
            {
                // Get a share
                ShareResponse result = apiInstance.GetShareById(id, evApiKey, evAccessToken, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharesApi.GetShareById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the share entry | 
 **evApiKey** | **string**| API Key | 
 **evAccessToken** | **string**| Access Token | 
 **include** | **string**| Comma separated list of relationships to include in response. Possible values are **owner**, **resources**, **notifications**, **activity**. | [optional] 

### Return type

[**ShareResponse**](ShareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listshares"></a>
# **ListShares**
> ShareCollectionResponse ListShares (string evApiKey, string evAccessToken, int? offset = null, int? limit = null, string scope = null, string sort = null, string type = null, string include = null, string name = null, string recipient = null, string message = null, string username = null, string search = null)

Get a list of shares

Get a list of shares that you would have access to view through the web interface. You can limit which results are returned by specifying specific types of shares you wish to view, finding things shared with a specific email address, as well as finding shares for specific folder names.   **Notes:**  - Authenticated user requires [share permission](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions). - To get share objects with type send, authenticated user's role must be admin or master.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListSharesExample
    {
        public void main()
        {
            var apiInstance = new SharesApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var offset = 56;  // int? | Current offset of records (for pagination) (optional) 
            var limit = 56;  // int? | Limit of records to be returned (for pagination) (optional)  (default to 100)
            var scope = scope_example;  // string | Set of shares to return. (**all**=all of them, **active**=shares that are currently active, **curentUser**=shares created by you) (optional) 
            var sort = sort_example;  // string | What order the list of matches should be in. (optional) 
            var type = type_example;  // string | Limit the list of matches to only certain types of shares. (optional) 
            var include = include_example;  // string | Comma separated list of relationships to include in response. Possible values are **owner**, **resources**, **notifications**, **activity**. (optional) 
            var name = name_example;  // string | When provided, only shares whose names include this value will be in the list. Supports wildcards, such as **send\\*** to return everything starting with \"send\".  Use this parameter if you are searching for shares or receives for a specific folder name. For example **_/Clients/ACME/To Be Processed**. (optional) 
            var recipient = recipient_example;  // string | Filter the results to include only shares that invited a certain email address. Supports wildcard matching so that **\\*@example.com** will give back entries shared with addresses ending in \"@example.com\".  (optional) 
            var message = message_example;  // string | When provided, only shares with a message that contains the text will be included in the list of matches. Both the subject and the body of all messages will be checked for matches. This will allways be a wildcard match, so that searching for **taxes** will return any shares with a message that contains the word \"taxes\". (optional) 
            var username = username_example;  // string | When provided, only shares created by the user with that `username` will be included in the list. Does not support wildcard searching. (optional) 
            var search = search_example;  // string | Searches the share name, username, recipients, share messages fields for the provided value. Supports wildcard searches. (optional) 

            try
            {
                // Get a list of shares
                ShareCollectionResponse result = apiInstance.ListShares(evApiKey, evAccessToken, offset, limit, scope, sort, type, include, name, recipient, message, username, search);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharesApi.ListShares: " + e.Message );
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
 **offset** | **int?**| Current offset of records (for pagination) | [optional] 
 **limit** | **int?**| Limit of records to be returned (for pagination) | [optional] [default to 100]
 **scope** | **string**| Set of shares to return. (**all**&#x3D;all of them, **active**&#x3D;shares that are currently active, **curentUser**&#x3D;shares created by you) | [optional] 
 **sort** | **string**| What order the list of matches should be in. | [optional] 
 **type** | **string**| Limit the list of matches to only certain types of shares. | [optional] 
 **include** | **string**| Comma separated list of relationships to include in response. Possible values are **owner**, **resources**, **notifications**, **activity**. | [optional] 
 **name** | **string**| When provided, only shares whose names include this value will be in the list. Supports wildcards, such as **send\\*** to return everything starting with \&quot;send\&quot;.  Use this parameter if you are searching for shares or receives for a specific folder name. For example **_/Clients/ACME/To Be Processed**. | [optional] 
 **recipient** | **string**| Filter the results to include only shares that invited a certain email address. Supports wildcard matching so that **\\*@example.com** will give back entries shared with addresses ending in \&quot;@example.com\&quot;.  | [optional] 
 **message** | **string**| When provided, only shares with a message that contains the text will be included in the list of matches. Both the subject and the body of all messages will be checked for matches. This will allways be a wildcard match, so that searching for **taxes** will return any shares with a message that contains the word \&quot;taxes\&quot;. | [optional] 
 **username** | **string**| When provided, only shares created by the user with that &#x60;username&#x60; will be included in the list. Does not support wildcard searching. | [optional] 
 **search** | **string**| Searches the share name, username, recipients, share messages fields for the provided value. Supports wildcard searches. | [optional] 

### Return type

[**ShareCollectionResponse**](ShareCollectionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatesharebyid"></a>
# **UpdateShareById**
> ShareResponse UpdateShareById (Body17 body, string evApiKey, string evAccessToken, int? id)

Update a share

Change the settings on an active share. Any changes made will affect all users that have access to the share.   When updating invitees, pass the `recipients` body paramater with the full list of people who should be included on the share. If you resend the list without an existing recipient, they will be removed from the share.  **Notes:**    - Authenticated user should be the owner of the specified share.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateShareByIdExample
    {
        public void main()
        {
            var apiInstance = new SharesApi();
            var body = new Body17(); // Body17 | 
            var evApiKey = evApiKey_example;  // string | API Key
            var evAccessToken = evAccessToken_example;  // string | Access Token
            var id = 56;  // int? | ID of the share entry

            try
            {
                // Update a share
                ShareResponse result = apiInstance.UpdateShareById(body, evApiKey, evAccessToken, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharesApi.UpdateShareById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body17**](Body17.md)|  | 
 **evApiKey** | **string**| API Key | 
 **evAccessToken** | **string**| Access Token | 
 **id** | **int?**| ID of the share entry | 

### Return type

[**ShareResponse**](ShareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
