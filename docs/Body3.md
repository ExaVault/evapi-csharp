# IO.Swagger.Model.Body3
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Type of action be notified about. Notifications will only be sent for the given type of action. Valid choices are **upload**, **download**, **delete** or **all** (upload/download/delete) | [optional] 
**Usernames** | **List&lt;string&gt;** | Determines which users&#x27; actions should trigger the notification.   Rather than listing  individual users, you can also use 3 special options:  - **notice\\_user\\_all** for activity by any user or share recipient - **notice\\_user\\_all\\_users** for activity only by user accounts - **notice\\_user\\_all\\_recipient** for activity only by share recipients | [optional] 
**SendEmail** | **bool?** | Whether an email should be sent to the recipients when matching activity happens. | [optional] 
**Recipients** | **List&lt;string&gt;** | Email addresses to send notification emails to. If empty, sends to the current user&#x27;s email address. | [optional] 
**Message** | **string** | Custom message to insert into the notification emails, along with the matching activity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

