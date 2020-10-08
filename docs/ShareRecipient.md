# IO.Swagger.Model.ShareRecipient
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | ID of the recipient. | [optional] 
**ShareId** | **string** | ID of the share that the recipoient belongs to. | [optional] 
**Type** | **string** | Type of the recipient. | [optional] 
**Hash** | **string** | Share hash. | [optional] 
**Email** | **string** | Recipient email address. | [optional] 
**Sent** | **bool?** | Set to true if invite email was sent; false otherwise. | [optional] 
**Received** | **bool?** | Set to true if recipient has accessed the share. Note this is set to true when the recipient clicks the link to access the share; not when they download a file. | [optional] 
**Created** | **DateTime?** | Timestamp of adding recipient to the share. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

