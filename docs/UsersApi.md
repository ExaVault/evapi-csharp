# IO.Swagger.Api.UsersApi

All URIs are relative to *https://accountname.exavault.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUser**](UsersApi.md#adduser) | **POST** /users | Create a user
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /users/{id} | Delete a user
[**GetUserById**](UsersApi.md#getuserbyid) | **GET** /users/{id} | Get info for a user
[**ListUsers**](UsersApi.md#listusers) | **GET** /users | Get a list of users
[**UpdateUser**](UsersApi.md#updateuser) | **PATCH** /users/{id} | Update a user

<a name="adduser"></a>
# **AddUser**
> UserResponse AddUser (string evApiKey, string evAccessToken, Body5 body = null)

Create a user

Adds a new user to the account. The user may be configured as an admin or standard user, and (if a standard user) may be assigned a restricted [home directory](/docs/account/04-users/00-introduction#setting-the-user-s-home-directory) and restricted [permissions](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions).   **Notes:**  - You must be an [admin-level user](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions) to use this.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var evApiKey = evApiKey_example;  // string | API key required to make the API call
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var body = new Body5(); // Body5 |  (optional) 

            try
            {
                // Create a user
                UserResponse result = apiInstance.AddUser(evApiKey, evAccessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.AddUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API key required to make the API call | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **body** | [**Body5**](Body5.md)|  | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteuser"></a>
# **DeleteUser**
> EmptyResponse DeleteUser (decimal? id, string evApiKey, string evAccessToken)

Delete a user

Delete a user from the account. Deleting a user does **NOT** delete any files from the account; it merely removes a user's access. Aternatively, locking a user via the [PATCH /users/{id}](#operation/updateUser) will keep the user in your account, but make it unable to log in.   Resources and shares owned by the deleted user will be owned by the master user after the deletion.  **Notes:**   - You must have [admin-level access](/docs/account/04-users/01-admin-users) to delete a user. - The primary owner of the account cannot be deleted. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var id = 1.2;  // decimal? | The user's ID. Note that this is our internal ID, and _not the username_. You can obtain it by calling the [GET /users](#operation/listUsers) method.
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.

            try
            {
                // Delete a user
                EmptyResponse result = apiInstance.DeleteUser(id, evApiKey, evAccessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| The user&#x27;s ID. Note that this is our internal ID, and _not the username_. You can obtain it by calling the [GET /users](#operation/listUsers) method. | 
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
<a name="getuserbyid"></a>
# **GetUserById**
> UserResponse GetUserById (decimal? id, string evApiKey, string evAccessToken, string include = null)

Get info for a user

Get the details for a specific user. You can use the `include` parameter to also get the details of related records, such as the account or the home directory.  **Notes:**  - You must have [admin or master](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions) access to use this.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserByIdExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var id = 1.2;  // decimal? | The user's ID. Note that this is our internal ID, and _not the username_. You can obtain it by calling the [GET /users](#operation/listUsers) method.
            var evApiKey = evApiKey_example;  // string | API Key
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var include = include_example;  // string | Comma-separated list of relationships to include in response. Possible values include **homeResource** and **ownerAccount**. (optional) 

            try
            {
                // Get info for a user
                UserResponse result = apiInstance.GetUserById(id, evApiKey, evAccessToken, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**| The user&#x27;s ID. Note that this is our internal ID, and _not the username_. You can obtain it by calling the [GET /users](#operation/listUsers) method. | 
 **evApiKey** | **string**| API Key | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **include** | **string**| Comma-separated list of relationships to include in response. Possible values include **homeResource** and **ownerAccount**. | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listusers"></a>
# **ListUsers**
> UserCollectionResponse ListUsers (string evApiKey, string evAccessToken, string username = null, string nickname = null, string email = null, string role = null, int? status = null, string homeDir = null, string search = null, int? offset = null, string sort = null, int? limit = null, string include = null)

Get a list of users

Get a list of the users in your account. There are three main types of searches you can do with this method:  1. Search for a user by username. If you provide the `username` parameter in your call, then only the user who exactly matches that username will be in the list of matches. Any other parameters are ignored. 1. Search for a user by individual filter fields (`nickname`,`email`,`role`,`status`,`homeDir`). Users in the list will be ones who match all of the filters you choose to search by. For example, you could look for users with the \"admin\" `role` AND `email` addresses ending in \"*@acme.com\".  1. Search for a user by search string. If you provide the `search` parameter, users whose nickname OR email OR role OR homeDir match value your provide.  **Notes:**  - You must be an [admin-level user](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions) to use this. - The homeDir is the full path to the user's home directory, not a resource ID or hash.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListUsersExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var evApiKey = evApiKey_example;  // string | API key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var username = username_example;  // string | The username of the user you are looking for. Only entries with the same username as this will be in the list of results. Does not support wildcard searches. (optional) 
            var nickname = nickname_example;  // string | Nickname to search for. Ignored if `username` is provided. Supports wildcard searches. (optional) 
            var email = email_example;  // string | Email to search for. Ignored if `username` is provided. Supports wildcard searches (optional) 
            var role = role_example;  // string | Types of users to include the list. Ignored if `username` is provided. Valid options are **admin**, **master** and **user** (optional) 
            var status = 56;  // int? | Whether a user is locked. Ignored if `username` is provided. **0** means user is locked, **1** means user is not locked.  (optional) 
            var homeDir = homeDir_example;  // string | Path for user's home directory. Ignored if `username` is provided. Supports wildcard searches. (optional) 
            var search = search_example;  // string | Searches the nickname, email, role and homeDir fields for the provided value. Ignored if `username` is provided. Supports wildcard searches. (optional) 
            var offset = 56;  // int? | Starting user record in the result set. Can be used for pagination. (optional) 
            var sort = sort_example;  // string | Sort order or matching users. You can sort by multiple columns by separating sort options with a comma; the sort will be applied in the order specified. The sort order for each sort field is ascending unless it is prefixed with a minus (“-“), in which case it will be descending.  Valid sort fields are: **nickname**, **username**, **email**, **homeDir** and **modified** (optional) 
            var limit = 56;  // int? | Number of users to return. Can be used for pagination. (optional) 
            var include = include_example;  // string | Comma separated list of relationships to include in response. Valid options are **homeResource** and **ownerAccount**. (optional) 

            try
            {
                // Get a list of users
                UserCollectionResponse result = apiInstance.ListUsers(evApiKey, evAccessToken, username, nickname, email, role, status, homeDir, search, offset, sort, limit, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ListUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **username** | **string**| The username of the user you are looking for. Only entries with the same username as this will be in the list of results. Does not support wildcard searches. | [optional] 
 **nickname** | **string**| Nickname to search for. Ignored if &#x60;username&#x60; is provided. Supports wildcard searches. | [optional] 
 **email** | **string**| Email to search for. Ignored if &#x60;username&#x60; is provided. Supports wildcard searches | [optional] 
 **role** | **string**| Types of users to include the list. Ignored if &#x60;username&#x60; is provided. Valid options are **admin**, **master** and **user** | [optional] 
 **status** | **int?**| Whether a user is locked. Ignored if &#x60;username&#x60; is provided. **0** means user is locked, **1** means user is not locked.  | [optional] 
 **homeDir** | **string**| Path for user&#x27;s home directory. Ignored if &#x60;username&#x60; is provided. Supports wildcard searches. | [optional] 
 **search** | **string**| Searches the nickname, email, role and homeDir fields for the provided value. Ignored if &#x60;username&#x60; is provided. Supports wildcard searches. | [optional] 
 **offset** | **int?**| Starting user record in the result set. Can be used for pagination. | [optional] 
 **sort** | **string**| Sort order or matching users. You can sort by multiple columns by separating sort options with a comma; the sort will be applied in the order specified. The sort order for each sort field is ascending unless it is prefixed with a minus (“-“), in which case it will be descending.  Valid sort fields are: **nickname**, **username**, **email**, **homeDir** and **modified** | [optional] 
 **limit** | **int?**| Number of users to return. Can be used for pagination. | [optional] 
 **include** | **string**| Comma separated list of relationships to include in response. Valid options are **homeResource** and **ownerAccount**. | [optional] 

### Return type

[**UserCollectionResponse**](UserCollectionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateuser"></a>
# **UpdateUser**
> UserResponse UpdateUser (string evApiKey, string evAccessToken, decimal? id, Body6 body = null)

Update a user

Updates the settings for the user. Note that the unique key for this API call is our internal ID, and _not_ the username, as the username can be changed.  In the request body, you should only send the parameters for values that you wish to change for the user.  **Notes:**  - You must have [admin or master](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions) access to edit other users. If you have user-level access, you can only update your own user settings. - You cannot edit a master user with this method.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var evApiKey = evApiKey_example;  // string | API key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var id = 1.2;  // decimal? | The user's ID. Note that this is our internal ID, and _not the username_. You can obtain it by calling the [GET /users](#operation/listUsers) method.
            var body = new Body6(); // Body6 |  (optional) 

            try
            {
                // Update a user
                UserResponse result = apiInstance.UpdateUser(evApiKey, evAccessToken, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **id** | **decimal?**| The user&#x27;s ID. Note that this is our internal ID, and _not the username_. You can obtain it by calling the [GET /users](#operation/listUsers) method. | 
 **body** | [**Body6**](Body6.md)|  | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
