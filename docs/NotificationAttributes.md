# IO.Swagger.Model.NotificationAttributes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | ID of the user that the notification belongs to. | [optional] 
**Type** | **string** | Type of the resoucre the notification is attached to.  | [optional] 
**Path** | **string** | Path to the item that the notification is set on. | [optional] 
**Name** | **string** | Name of the item that the notification is set on. | [optional] 
**Action** | **string** | Action that triggers notification. | [optional] 
**Usernames** | **List&lt;string&gt;** | Detail on which users can trigger the notification. | [optional] 
**Recipients** | [**List&lt;NotificationRecipient&gt;**](NotificationRecipient.md) | Notification recipients. | [optional] 
**SendEmail** | **bool?** | Whether or not an email will send when the notification is triggered. | [optional] 
**ReadableDescription** | **string** | Human readable description of the notification. | [optional] 
**ReadableDescriptionWithoutPath** | **string** | Human readable description of the notification without item path. | [optional] 
**ShareId** | **string** | ID of the share that the notification belogns to. | [optional] 
**Message** | **string** | Custom message that will be sent to the notification recipients. | [optional] 
**Created** | **DateTime?** | Timestamp of notifiction creation. | [optional] 
**Modified** | **DateTime?** | Timestamp of notification modification. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

