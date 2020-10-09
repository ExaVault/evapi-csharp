# IO.Swagger.Model.Body6
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Username** | **string** | New username for the user. This should follow standard username conventions - spaces are not allowed, etc. We do allow email addresses as usernames.  **Note** Usernames must be unique across all ExaVault accounts. | [optional] 
**Nickname** | **string** | An optional nickname (e.g. &#x27;David from Sales&#x27;). | [optional] 
**HomeResource** | **string** | Resource identifier for the user&#x27;s home folder. See details on [how to specify resources](#section/Identifying-Resources) above.  The user will be locked to this directory and unable to move &#x27;up&#x27; in the account. If the folder does not exist in the account, it will be created when the user logs in.  This setting is ignored for users with the &#x60;role&#x60; **admin**. | [optional] 
**Email** | **string** | Email address for the user | [optional] 
**Password** | **string** | New password for the user | [optional] 
**Role** | **string** | The type of user (**admin** or **user**). Note that admin users cannot have a &#x60;homeResource&#x60; other than &#x27;/&#x27;, and will have full permissions, but you must provide at least \&quot;download,upload,list,delete\&quot; in the &#x60;permissions&#x60; parameter. | [optional] 
**Permissions** | **string** | A CSV string of [user permissions](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions). For example: **upload,download,list**. Note that users will be unable to see any files in the account unless you include **list** permission.   Valid permissions are **list**, **download**, **upload**, **modify**, **delete**, **changePassword**, **share**, **notification**, **viewFormData**, **deleteFormData**  | [optional] 
**TimeZone** | **string** | Time zone, used for accurate time display within the application. See &lt;a href&#x3D;&#x27;https://php.net/manual/en/timezones.php&#x27; target&#x3D;&#x27;blank&#x27;&gt;this page&lt;/a&gt; for allowed values.  | [optional] 
**Expiration** | **string** | Optional timestamp when the user should expire. | [optional] 
**Locked** | **bool?** | If true, the user will be prevented from logging in | [optional] 
**Onboarding** | **bool?** | Set this to **true** to enable extra help popups in the web file manager for this user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
