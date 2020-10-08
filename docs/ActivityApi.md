# IO.Swagger.Api.ActivityApi

All URIs are relative to *https://accountname.exavault.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSessionLogs**](ActivityApi.md#getsessionlogs) | **GET** /activity/session | Get activity logs
[**GetWebhookLogs**](ActivityApi.md#getwebhooklogs) | **GET** /activity/webhooks | Get webhook logs

<a name="getsessionlogs"></a>
# **GetSessionLogs**
> SessionActivityResponse GetSessionLogs (string evApiKey, string evAccessToken, DateTime? startDate = null, DateTime? endDate = null, string ipAddress = null, string userName = null, string path = null, string type = null, int? offset = null, int? limit = null, string sort = null)

Get activity logs

Returns the detailed activity logs for your account. Optional query paramaters will filter the returned results based on a number of options including usernames, activity types, or date ranges.     **Operation Types** Session activity is logged with an operation type that is different from what is visible through the [activity log interface in the web file manager](/docs/account/10-activity-logs/00-activity-logs). Consult the table below to compare the two:  | File Manager Value | API Value | Notes | |- -- --|- -- -|- --| | Connect | PASS | | | Disconnect | EXIT | | | Upload | STOR | | | Download | RETR | | | Delete | DELE | | | Create Folder | MKD | | | Rename | RNTO | | | Move | MOVE | | | Copy | COPY | | | Compress | COMPR | | | Extract | EXTRACT | | | Shared Folders | SHARE | | | Send Files | SEND | | | Receive Files | RECV | | | _N/A_ | EDIT\\_SEND | Update send. Not shown in file manager | | Update Share | EDIT\\_SHARE| |  | Update Receive | EDIT\\_RECV | | | Delete Send | DELE\\_SEND | | | Delete Receive | DELE\\_RECV | | | Delete Share | DELE\\_SHARE | | | Create Notification | NOTIFY | | | Update Notification | EDIT\\_NTFY| | | Delete Notification | DELE\\_NTFY | | | Create User | USER | | | Update User | EDIT\\_USER | | | Delete User | DELE\\_USER | | | _N/A_ | DFA | Create direct link. Not shown in file manager | | _N/A_ | EDIT\\_DFA | Update direct link options. Not shown in file manager | | _N/A_ | DELE\\_DFA | Deactivate direct link. Not shown in file manager| 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSessionLogsExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var evApiKey = evApiKey_example;  // string | API Key
            var evAccessToken = evAccessToken_example;  // string | Access Token
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date of the filter data range (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | End date of the filter data range (optional) 
            var ipAddress = ipAddress_example;  // string | Used to filter session logs by ip address. (optional) 
            var userName = userName_example;  // string | Username used for filtering a list (optional) 
            var path = path_example;  // string | Path used to filter records (optional) 
            var type = type_example;  // string | Filter session logs for operation type (see table above for acceptable values) (optional) 
            var offset = 56;  // int? | Offset of the records list (optional) 
            var limit = 56;  // int? | Limit of the records list (optional) 
            var sort = sort_example;  // string | Comma separated list sort params (optional) 

            try
            {
                // Get activity logs
                SessionActivityResponse result = apiInstance.GetSessionLogs(evApiKey, evAccessToken, startDate, endDate, ipAddress, userName, path, type, offset, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.GetSessionLogs: " + e.Message );
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
 **startDate** | **DateTime?**| Start date of the filter data range | [optional] 
 **endDate** | **DateTime?**| End date of the filter data range | [optional] 
 **ipAddress** | **string**| Used to filter session logs by ip address. | [optional] 
 **userName** | **string**| Username used for filtering a list | [optional] 
 **path** | **string**| Path used to filter records | [optional] 
 **type** | **string**| Filter session logs for operation type (see table above for acceptable values) | [optional] 
 **offset** | **int?**| Offset of the records list | [optional] 
 **limit** | **int?**| Limit of the records list | [optional] 
 **sort** | **string**| Comma separated list sort params | [optional] 

### Return type

[**SessionActivityResponse**](SessionActivityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwebhooklogs"></a>
# **GetWebhookLogs**
> WebhooksActivityResponse GetWebhookLogs (string evApiKey, string evAccessToken, string _event = null, int? statusCode = null, string path = null, string username = null, int? offset = null, int? limit = null, string sort = null)

Get webhook logs

Returns the webhook logs for your account. Optional query paramaters will filter the returned results based on a number of options including path, tpye of event, or status code.   **Event Types**  Webhooks are triggered by enabled event types for your account, which are configured on the [developer settings page](/docs/account/09-settings/06-developer-settings). These are the valid options for event types:  - Upload - Download - Delete File - Delete Folder - Create Folder - Rename - Move - Copy - Compress - Extract - Share Folder - Send Files - Receive Files - Update Share - Update Receive - Delete Send - Delete Receive - Delete Share - Create Notification - Update Notification - Delete Notification - Create User - Update User  - Delete User - Connect - Disconnect

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWebhookLogsExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var evApiKey = evApiKey_example;  // string | API Key
            var evAccessToken = evAccessToken_example;  // string | Access Token
            var _event = _event_example;  // string | Filter by triggered event (optional) 
            var statusCode = 56;  // int? | Filter by webhook response status code (optional) 
            var path = path_example;  // string | Path used to filter records (optional) 
            var username = username_example;  // string | Filter by triggering username. (optional) 
            var offset = 56;  // int? | Records to skip before returning results (optional) 
            var limit = 56;  // int? | Limit of the records list (optional) 
            var sort = sort_example;  // string | Comma separated list sort params (optional) 

            try
            {
                // Get webhook logs
                WebhooksActivityResponse result = apiInstance.GetWebhookLogs(evApiKey, evAccessToken, _event, statusCode, path, username, offset, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.GetWebhookLogs: " + e.Message );
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
 **_event** | **string**| Filter by triggered event | [optional] 
 **statusCode** | **int?**| Filter by webhook response status code | [optional] 
 **path** | **string**| Path used to filter records | [optional] 
 **username** | **string**| Filter by triggering username. | [optional] 
 **offset** | **int?**| Records to skip before returning results | [optional] 
 **limit** | **int?**| Limit of the records list | [optional] 
 **sort** | **string**| Comma separated list sort params | [optional] 

### Return type

[**WebhooksActivityResponse**](WebhooksActivityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
