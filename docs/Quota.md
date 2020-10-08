# IO.Swagger.Model.Quota
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiskLimit** | **long?** | Amount of disk space that the account has available to it. This may be increased by upgrading to a larger plan. | [optional] 
**DiskUsed** | **long?** | Amount of disk space currently in use. | [optional] 
**NoticeEnabled** | **bool?** | Should a quota warning be sent to the account owner when a threshold level of space utilization is reached? | [optional] 
**NoticeThreshold** | **int?** | Treshold that triggers a quota notification. This represents the \&quot;percent full\&quot; your account must be before the quota notification is generated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

