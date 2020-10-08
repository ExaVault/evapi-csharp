# IO.Swagger.Model.UserAttributes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **int?** | Indicates user activity status. &#x60;0&#x60; means the user is locked and cannot log in. &#x60;1&#x60; means the user is active and can log in. | 
**Expiration** | **string** | Timestamp of user expiration. | [optional] 
**Created** | **DateTime?** | Timestamp of user creation. | 
**Modified** | **DateTime?** | Timestamp of user modification. | 
**AccessTimestamp** | **string** | Timestamp of most recent successful user login. | [optional] 
**AccountName** | **string** | Name of the account this user belongs to. | 
**Username** | **string** | Username of the user. | 
**Nickname** | **string** | Nickname of the user. | 
**Email** | **string** | Email address of the user. | [optional] 
**HomeDir** | **string** | Path to the user&#x27;s home folder. | 
**Permissions** | [**UserPermissions**](UserPermissions.md) |  | 
**Role** | **string** | User&#x27;s access level | 
**TimeZone** | **string** | User&#x27;s timezone. See &lt;a href&#x3D;&#x27;https://php.net/manual/en/timezones.php&#x27; target&#x3D;&#x27;blank&#x27;&gt;this page&lt;/a&gt; for allowed values. | 
**Onboarding** | **bool?** | Whether the onboarding help system is enabled for this user. &#x60;true&#x60; means that additional help popups are displayed in the web application for this user. | 
**FirstLogin** | **bool?** | &#x60;true&#x60; if the user has logged into the system. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

