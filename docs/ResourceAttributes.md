# IO.Swagger.Model.ResourceAttributes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hash** | **string** | Unique hash of the resource. | [optional] 
**Name** | **string** | Resource name, e.g. the name of the file or folder. | [optional] 
**Extension** | **string** | Resource extension. Property exists only if resource &#x60;type&#x60; is file. | [optional] 
**Type** | **string** | Type of the resource. | [optional] 
**CreatedBy** | **string** | Username of the creator. | [optional] 
**UploadDate** | **DateTime?** | Timestamp of resource upload. | [optional] 
**CreatedAt** | **DateTime?** | Date-time of resource creation. | [optional] 
**UpdatedAt** | **DateTime?** | Date-time of resource modification. | [optional] 
**AccessedAt** | **DateTime?** | Date-time of the time when resource was accessed. | [optional] 
**CreatedTime** | **int?** | UNIX timestamp of resource creation | [optional] 
**UpdatedTime** | **int?** | UNIX timestamp of resource modification | [optional] 
**AccessedTime** | **int?** | UNIX timestamp of last access | [optional] 
**Path** | **string** | Full path to the resource. | [optional] 
**Size** | **long?** | Resource size in bytes | [optional] 
**FileCount** | **int?** | Number of files within folder. null if resource type is a file. | [optional] 
**Previewable** | **bool?** | Can resource be previewed. Property equals &#x60;null&#x60; if resource &#x60;type&#x60; is dir. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

