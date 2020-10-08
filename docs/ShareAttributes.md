# IO.Swagger.Model.ShareAttributes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Share name. | [optional] 
**HasPassword** | **bool?** | True if the share has password. | [optional] 
**Public** | **bool?** | True if the share has a public url. | [optional] 
**AccessMode** | **string** | Access rights for the share. | [optional] 
**AccessDescription** | **string** | Description of the share access rights. | [optional] 
**Embed** | **bool?** | True if share can be embedded. | [optional] 
**Hash** | **string** | Share hash. | [optional] 
**OwnerHash** | **string** | Share owner&#x27;s hash. | [optional] 
**Expiration** | **string** | Expiration date of the share. | [optional] 
**Expired** | **bool?** | True if the share has expired. | [optional] 
**Resent** | **DateTime?** | Invitations resent date. Can be &#x60;null&#x60; if resent never happened. | [optional] 
**Type** | **string** | Type of share. | [optional] 
**RequireEmail** | **bool?** | True if share requires email to access. | [optional] 
**FileDropCreateFolders** | **bool?** | Flag to show if separate folders should be created for each file upload to receive folder. | [optional] 
**Paths** | **List&lt;string&gt;** | Path to the shared resource in your account. | [optional] 
**Recipients** | [**List&lt;ShareRecipient1&gt;**](ShareRecipient1.md) | Array of recipients. | [optional] 
**Messages** | [**List&lt;ShareMessage&gt;**](ShareMessage.md) | Array of invitation messages. | [optional] 
**Inherited** | **bool?** | True if share inherited from parent folder. | [optional] 
**Status** | **int?** | Share activity status. Can be active (1) or deactivated (0). | [optional] 
**HasNotification** | **bool?** | True if share has notification. | [optional] 
**Created** | **DateTime?** | Timestamp of share creation. | [optional] 
**Modified** | **DateTime?** | Timestamp of share modification. Can be &#x60;null&#x60; if it wasn&#x27;t modified. | [optional] 
**TrackingStatus** | **string** | Checks recipient received status and returns whether it&#x27;s been recevied (&#x60;complete&#x60;,) partial recevied (&#x60;incomplete&#x60;,) or not recevied yet (&#x60;pending&#x60;.) | [optional] 
**FormId** | **int?** | ID of the form. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

