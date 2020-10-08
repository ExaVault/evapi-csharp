# IO.Swagger.Model.Body17
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the share. | [optional] 
**Resources** | **List&lt;string&gt;** | Array of resources for this share. See details on [how to specify resources](#section/Identifying-Resources) above.  **shared_folder** and **receive** shares must have only one &#x60;resource&#x60;, which is a directory that does not have a current share attached.  **send** shares may have multiple &#x60;resource&#x60; parameters.   **NOTE**: Sending this parameter will **REPLACE** the existing resources with the resources included in this request. | [optional] 
**AccessMode** | **List&lt;string&gt;** | What visitors who view this share can do. Valid options include **download**, **upload**, **delete**, **modify** | [optional] 
**Embed** | **bool?** | Whether the share can be embedded in another web page. | [optional] 
**Recipients** | [**List&lt;SharesRecipients&gt;**](SharesRecipients.md) | People you want to invite to the share.   **Note**: unless you also set the &#x60;subject&#x60; and &#x60;message&#x60; for the new share, invitation emails will not be sent to these recipients.  **Note**: Recipients in this list will **REPLACE** the recipients already assigned to this share.  | [optional] 
**Expiration** | **DateTime?** | New expiration date and time for the share | [optional] 
**HasNotification** | **bool?** | Whether delivery receipts should be sent for this share. | [optional] 
**IsPublic** | **bool?** | Whether people can visit the share without following a link from an invitation email | [optional] 
**Message** | **string** | Message content to use for emails inviting recipients to the share. Ignored if you have not also provided &#x60;recipients&#x60; and a &#x60;subject&#x60; | [optional] 
**NotificationEmails** | **List&lt;string&gt;** | List of email addresses to send delivery receipts to. Ignored if &#x60;hasNotification&#x60; is false.  | [optional] 
**Password** | **string** | New password for the share. To leave the password unchanged, do not send this parameter. | [optional] 
**RequireEmail** | **bool?** | Whether visitors to the share will be required to enter their email in order to access the share. | [optional] 
**Subject** | **string** | Subject to use on emails inviting recipients to the share. Ignored if you have not also provided &#x60;recipients&#x60; and a &#x60;message&#x60; | [optional] 
**FileDropCreateFolders** | **bool?** | Whether uploads to a receive folder should be automatically placed into subfolders. See our [receive folder documentation](/docs/account/05-file-sharing/05-form-builder#advanced-form-settings) | [optional] 
**Status** | **int?** | New status for the share. You can set an active share to inactive by setting the status to **0** | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

