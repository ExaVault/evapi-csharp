# IO.Swagger.Api.NotificationsApi

All URIs are relative to *https://accountname.exavault.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddNotification**](NotificationsApi.md#addnotification) | **POST** /notifications | Create a new notification
[**DeleteNotificationById**](NotificationsApi.md#deletenotificationbyid) | **DELETE** /notifications/{id} | Delete a notification
[**GetNotificationById**](NotificationsApi.md#getnotificationbyid) | **GET** /notifications/{id} | Get notification details
[**ListNotifications**](NotificationsApi.md#listnotifications) | **GET** /notifications | Get a list of notifications
[**UpdateNotificationById**](NotificationsApi.md#updatenotificationbyid) | **PATCH** /notifications/{id} | Update a notification

<a name="addnotification"></a>
# **AddNotification**
> NotificationResponse AddNotification (string evApiKey, string evAccessToken, Body4 body = null)

Create a new notification

Create a new notification for a [resource](#section/Identifying-Resources) in your account. Notifications can be sent via email or webhook;  - To enable email, pass an array of email addresses to the `recipients` parameter of this call.  - To enable webhooks, setup the webhook callback URL in your account settings via [PATCH /account](#operation/updateAccount).   **Notes:**   - Authenticated user should have [notifications permission](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions) 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddNotificationExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make API call. 
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var body = new Body4(); // Body4 |  (optional) 

            try
            {
                // Create a new notification
                NotificationResponse result = apiInstance.AddNotification(evApiKey, evAccessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.AddNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make API call.  | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **body** | [**Body4**](Body4.md)|  | [optional] 

### Return type

[**NotificationResponse**](NotificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletenotificationbyid"></a>
# **DeleteNotificationById**
> EmptyResponse DeleteNotificationById (string evApiKey, string evAccessToken, int? id)

Delete a notification

Deletes a notification. Note that deleting a notification _only_ deletes the notification &ndash; it does not delete any underlying files or folders.  **Notes:**  - You need to have the [notifications permission](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions) to update a notification. - You can only delete notifications owned by your user account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteNotificationByIdExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var id = 56;  // int? | ID of the notification. Use [GET /notifications](#operation/listNotifications) if you need to lookup an ID.

            try
            {
                // Delete a notification
                EmptyResponse result = apiInstance.DeleteNotificationById(evApiKey, evAccessToken, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteNotificationById: " + e.Message );
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
 **id** | **int?**| ID of the notification. Use [GET /notifications](#operation/listNotifications) if you need to lookup an ID. | 

### Return type

[**EmptyResponse**](EmptyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getnotificationbyid"></a>
# **GetNotificationById**
> NotificationResponse GetNotificationById (string evApiKey, string evAccessToken, int? id, string include = null)

Get notification details

Get the details for a notification with a specific ID number. You'll be able to review its path, triggers and who's getting the notification.   **Notes**  - You need to have the [notifications permission](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions) to view the detail for a notification. - You can only retrieve notifications owned by your user account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNotificationByIdExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var id = 56;  // int? | ID of the notification. Use [GET /notifications](#operation/listNotifications) if you need to lookup an ID.
            var include = include_example;  // string | Related record types to include in the response. You can include multiple types by separating them with commas. Valid options are **ownerUser**, **resource**, and **share**. (optional) 

            try
            {
                // Get notification details
                NotificationResponse result = apiInstance.GetNotificationById(evApiKey, evAccessToken, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotificationById: " + e.Message );
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
 **id** | **int?**| ID of the notification. Use [GET /notifications](#operation/listNotifications) if you need to lookup an ID. | 
 **include** | **string**| Related record types to include in the response. You can include multiple types by separating them with commas. Valid options are **ownerUser**, **resource**, and **share**. | [optional] 

### Return type

[**NotificationResponse**](NotificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listnotifications"></a>
# **ListNotifications**
> NotificationCollectionResponse ListNotifications (string evApiKey, string evAccessToken, string type = null, int? offset = null, string sort = null, int? limit = null, string include = null, string action = null)

Get a list of notifications

Get a list of all the [notifications](/docs/account/06-notifications) you have access to. You can use sorting and filtering to limit the returned list.  **Notes:**   - Authenticated user should have [notifications permission](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListNotificationsExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call. 
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var type = type_example;  // string | Type of notification include in the list. Valid options are **file**, **folder**, **send_receipt**, **share_receipt**, **file_drop**  If this parameter is not used, only **file** and **folder** type notifications are included in the list. (optional) 
            var offset = 56;  // int? | Starting notification record in the result set. Can be used for pagination. (optional)  (default to 0)
            var sort = sort_example;  // string | What order the list of matches should be in. Valid sort fields are **resourcename**, **date**, **action** and **type**. The sort order for each sort field is ascending unless it is prefixed with a minus (“-“), in which case it will be descending.  You can chose multiple options for the sort by separating them with commmas, such as \"type,-date\" to sort by type, then most recent. (optional) 
            var limit = 56;  // int? | Number of notification records to return. Can be used for pagination. (optional)  (default to 25)
            var include = include_example;  // string | Related records to include in the response. Valid options are **ownerUser**, **resource**, **share** (optional) 
            var action = action_example;  // string | The kind of action which triggers the notification. Valid choices are **connect** (only for delivery receipts), **download**, **upload**, **delete**, or **all**   **Note** The **all** action matches notifications set to \"all\", not all notifications. For example, notifications set to trigger only on delete are not included if you filter for action=all (optional) 

            try
            {
                // Get a list of notifications
                NotificationCollectionResponse result = apiInstance.ListNotifications(evApiKey, evAccessToken, type, offset, sort, limit, include, action);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.ListNotifications: " + e.Message );
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
 **type** | **string**| Type of notification include in the list. Valid options are **file**, **folder**, **send_receipt**, **share_receipt**, **file_drop**  If this parameter is not used, only **file** and **folder** type notifications are included in the list. | [optional] 
 **offset** | **int?**| Starting notification record in the result set. Can be used for pagination. | [optional] [default to 0]
 **sort** | **string**| What order the list of matches should be in. Valid sort fields are **resourcename**, **date**, **action** and **type**. The sort order for each sort field is ascending unless it is prefixed with a minus (“-“), in which case it will be descending.  You can chose multiple options for the sort by separating them with commmas, such as \&quot;type,-date\&quot; to sort by type, then most recent. | [optional] 
 **limit** | **int?**| Number of notification records to return. Can be used for pagination. | [optional] [default to 25]
 **include** | **string**| Related records to include in the response. Valid options are **ownerUser**, **resource**, **share** | [optional] 
 **action** | **string**| The kind of action which triggers the notification. Valid choices are **connect** (only for delivery receipts), **download**, **upload**, **delete**, or **all**   **Note** The **all** action matches notifications set to \&quot;all\&quot;, not all notifications. For example, notifications set to trigger only on delete are not included if you filter for action&#x3D;all | [optional] 

### Return type

[**NotificationCollectionResponse**](NotificationCollectionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatenotificationbyid"></a>
# **UpdateNotificationById**
> NotificationResponse UpdateNotificationById (string evApiKey, string evAccessToken, int? id, Body3 body = null)

Update a notification

Update an existing notification. You can add additional emails or change the action or users that cause a notification to trigger.   When updating recipient emails, make sure your `recipients` parameter contains the full list of people who should be included on the notification. If you resend the list without an existing recipient, they will be deleted from the notification emails.   **Notes:**  - You need to have the [notifications permission](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions) to update a notification. - You can only change notifications owned by your user account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateNotificationByIdExample
    {
        public void main()
        {
            var apiInstance = new NotificationsApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var id = 56;  // int? | ID of the notification. Use [GET /notifications](#operation/listNotifications) if you need to lookup an ID.
            var body = new Body3(); // Body3 |  (optional) 

            try
            {
                // Update a notification
                NotificationResponse result = apiInstance.UpdateNotificationById(evApiKey, evAccessToken, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.UpdateNotificationById: " + e.Message );
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
 **id** | **int?**| ID of the notification. Use [GET /notifications](#operation/listNotifications) if you need to lookup an ID. | 
 **body** | [**Body3**](Body3.md)|  | [optional] 

### Return type

[**NotificationResponse**](NotificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
