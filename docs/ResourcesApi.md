# IO.Swagger.Api.ResourcesApi

All URIs are relative to *https://accountname.exavault.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFolder**](ResourcesApi.md#addfolder) | **POST** /resources | Create a folder
[**CompressFiles**](ResourcesApi.md#compressfiles) | **POST** /resources/compress | Compress resources
[**CopyResources**](ResourcesApi.md#copyresources) | **POST** /resources/copy | Copy resources
[**DeleteResourceById**](ResourcesApi.md#deleteresourcebyid) | **DELETE** /resources/{id} | Delete a Resource
[**DeleteResources**](ResourcesApi.md#deleteresources) | **DELETE** /resources | Delete Resources
[**Download**](ResourcesApi.md#download) | **GET** /resources/download | Download a file
[**ExtractFiles**](ResourcesApi.md#extractfiles) | **POST** /resources/extract | Extract resources
[**GetPreviewImage**](ResourcesApi.md#getpreviewimage) | **GET** /resources/preview | Preview a file
[**GetResourceInfo**](ResourcesApi.md#getresourceinfo) | **GET** /resources | Get Resource Properties
[**GetResourceInfoById**](ResourcesApi.md#getresourceinfobyid) | **GET** /resources/{id} | Get resource metadata
[**ListResourceContents**](ResourcesApi.md#listresourcecontents) | **GET** /resources/list/{id} | List contents of folder
[**ListResources**](ResourcesApi.md#listresources) | **GET** /resources/list | Get a list of all resources
[**MoveResources**](ResourcesApi.md#moveresources) | **POST** /resources/move | Move resources
[**UpdateResourceById**](ResourcesApi.md#updateresourcebyid) | **PATCH** /resources/{id} | Rename a resource.
[**UploadFile**](ResourcesApi.md#uploadfile) | **POST** /resources/upload | Upload a file

<a name="addfolder"></a>
# **AddFolder**
> ResourceResponse AddFolder (string evApiKey, string evAccessToken, Body8 body = null)

Create a folder

Create a new empty folder at the specified path. New files can be uploaded via the [/resources/upload](#operation/uploadFile) endpoint.  **Notes:** - Authenticated user should have modify permission. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddFolderExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var body = new Body8(); // Body8 |  (optional) 

            try
            {
                // Create a folder
                ResourceResponse result = apiInstance.AddFolder(evApiKey, evAccessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.AddFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **body** | [**Body8**](Body8.md)|  | [optional] 

### Return type

[**ResourceResponse**](ResourceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="compressfiles"></a>
# **CompressFiles**
> ResourceResponse CompressFiles (string evApiKey, string evAccessToken, Body10 body = null)

Compress resources

Create a zip archive containing the files from given set of paths. Note that this can be a very slow operation if you have indicated many files should be included in the archive.  **Notes:** - Authenticated user should have modify permission. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompressFilesExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var body = new Body10(); // Body10 |  (optional) 

            try
            {
                // Compress resources
                ResourceResponse result = apiInstance.CompressFiles(evApiKey, evAccessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.CompressFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **body** | [**Body10**](Body10.md)|  | [optional] 

### Return type

[**ResourceResponse**](ResourceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="copyresources"></a>
# **CopyResources**
> ResourceCopyMove CopyResources (string evApiKey, string evAccessToken, Body12 body = null)

Copy resources

Copies a set of exisiting files/folders (provided by an array `resources`) to the requested `parentResource` in your account. In the `resources` array, you may specify paths pointing files/folders throughout the account, but everything will be copied to the  root of the `parentResource`.  **Notes:** - Authenticated user should have modify permission. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CopyResourcesExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var body = new Body12(); // Body12 |  (optional) 

            try
            {
                // Copy resources
                ResourceCopyMove result = apiInstance.CopyResources(evApiKey, evAccessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.CopyResources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **body** | [**Body12**](Body12.md)|  | [optional] 

### Return type

[**ResourceCopyMove**](ResourceCopyMove.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteresourcebyid"></a>
# **DeleteResourceById**
> EmptyResponse DeleteResourceById (int? id, string evApiKey, string evAccessToken)

Delete a Resource

Delete a single file or folder resource. Deleting a folder will also delete all of the contents.  **Notes:** - Authenticated user should have [delete permission](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions). - There is no way to un-delete a deleted resource. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteResourceByIdExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var id = 56;  // int? | ID number of the resource
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.

            try
            {
                // Delete a Resource
                EmptyResponse result = apiInstance.DeleteResourceById(id, evApiKey, evAccessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.DeleteResourceById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID number of the resource | 
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 

### Return type

[**EmptyResponse**](EmptyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteresources"></a>
# **DeleteResources**
> EmptyResponse DeleteResources (string evApiKey, string evAccessToken, Body9 body = null)

Delete Resources

Delete multiple file or folder resourcess. Deleting a folder resource will also delete any resources in that folder.  **Notes:** - Authenticated user should have [delete permission](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions). - It is not possible to un-delete a deleted resource. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteResourcesExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evApiKey = evApiKey_example;  // string | API Key
            var evAccessToken = evAccessToken_example;  // string | Access Token
            var body = new Body9(); // Body9 |  (optional) 

            try
            {
                // Delete Resources
                EmptyResponse result = apiInstance.DeleteResources(evApiKey, evAccessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.DeleteResources: " + e.Message );
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
 **body** | [**Body9**](Body9.md)|  | [optional] 

### Return type

[**EmptyResponse**](EmptyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="download"></a>
# **Download**
> byte[] Download (string evApiKey, string evAccessToken, List<string> resources, string downloadName = null, bool? polling = null, string pollingZipName = null)

Download a file

Downloads a file. If more than one path is supplied, the files will be zipped before downloading with the downloadName parameter if supplied. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var resources = new List<string>(); // List<string> | Path of file or folder to be downloaded, starting from the root. Can also be an array of paths.
            var downloadName = downloadName_example;  // string | If zipping multiple files, the name of the zip file to create and download. (optional) 
            var polling = true;  // bool? | Used when downloading multiple files so url will be pulled till zip file is created. (optional) 
            var pollingZipName = pollingZipName_example;  // string | Reference to the previously created zip for polling operation. (optional) 

            try
            {
                // Download a file
                byte[] result = apiInstance.Download(evApiKey, evAccessToken, resources, downloadName, polling, pollingZipName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.Download: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **resources** | [**List&lt;string&gt;**](string.md)| Path of file or folder to be downloaded, starting from the root. Can also be an array of paths. | 
 **downloadName** | **string**| If zipping multiple files, the name of the zip file to create and download. | [optional] 
 **polling** | **bool?**| Used when downloading multiple files so url will be pulled till zip file is created. | [optional] 
 **pollingZipName** | **string**| Reference to the previously created zip for polling operation. | [optional] 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, application/zip, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="extractfiles"></a>
# **ExtractFiles**
> ResourceCollectionResponse ExtractFiles (string evApiKey, string evAccessToken, Body11 body = null)

Extract resources

Extract the contents of a zip archive to a specified directory. Note that this can be a very slow operation.  **Notes:** - You must have  [modify permission](/docs/account/04-users/00-introduction#managing-user-roles-and-permissions) to do this. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExtractFilesExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var body = new Body11(); // Body11 |  (optional) 

            try
            {
                // Extract resources
                ResourceCollectionResponse result = apiInstance.ExtractFiles(evApiKey, evAccessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.ExtractFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **body** | [**Body11**](Body11.md)|  | [optional] 

### Return type

[**ResourceCollectionResponse**](ResourceCollectionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpreviewimage"></a>
# **GetPreviewImage**
> PreviewFileResponse GetPreviewImage (string evApiKey, string evAccessToken, string resource, string size, int? width = null, int? height = null, int? page = null)

Preview a file

Returns a resized image of the specified document for supported file types.  Image data returned is encoded in base64 format and can be viewed using the `<img>` element.   ```<img src='data:image/jpeg;base64' + meta.image/>```  **Notes:** - Supported files types are `'jpg'`, `'jpeg'`, `'gif'`, `'png'`, `'bmp'`, `'pdf'`, `'psd'`, `'doc'` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPreviewImageExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evApiKey = evApiKey_example;  // string | API Key
            var evAccessToken = evAccessToken_example;  // string | Access Token
            var resource = resource_example;  // string | Resource identifier for the image file.
            var size = size_example;  // string | The size of the image.
            var width = 56;  // int? | Overrides sizes. Sets to a specific width. (optional) 
            var height = 56;  // int? | Overrides sizes. Sets to a specific height. (optional) 
            var page = 56;  // int? | Page number to extract from a multi-page document (0 is the first page). Vaild for **.pdf** or **.doc** files. (optional)  (default to 0)

            try
            {
                // Preview a file
                PreviewFileResponse result = apiInstance.GetPreviewImage(evApiKey, evAccessToken, resource, size, width, height, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.GetPreviewImage: " + e.Message );
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
 **resource** | **string**| Resource identifier for the image file. | 
 **size** | **string**| The size of the image. | 
 **width** | **int?**| Overrides sizes. Sets to a specific width. | [optional] 
 **height** | **int?**| Overrides sizes. Sets to a specific height. | [optional] 
 **page** | **int?**| Page number to extract from a multi-page document (0 is the first page). Vaild for **.pdf** or **.doc** files. | [optional] [default to 0]

### Return type

[**PreviewFileResponse**](PreviewFileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getresourceinfo"></a>
# **GetResourceInfo**
> ResourceResponse GetResourceInfo (string evApiKey, string evAccessToken, string resource, string include = null)

Get Resource Properties

Returns details for specified file/folder id or hash, including upload date, size and type. For the full list of returned properties, see the response syntax, below.  **Notes:** - Authenticated user should have list permission. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetResourceInfoExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var resource = resource_example;  // string | Resource identifier of the file or folder to get metadata for.
            var include = include_example;  // string | Comma separated list of relationships to include in response. Possible values are **share**, **notifications**, **directFile**, **parentResource**, **ownerUser**, **ownerUser**. (optional) 

            try
            {
                // Get Resource Properties
                ResourceResponse result = apiInstance.GetResourceInfo(evApiKey, evAccessToken, resource, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.GetResourceInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **resource** | **string**| Resource identifier of the file or folder to get metadata for. | 
 **include** | **string**| Comma separated list of relationships to include in response. Possible values are **share**, **notifications**, **directFile**, **parentResource**, **ownerUser**, **ownerUser**. | [optional] 

### Return type

[**ResourceResponse**](ResourceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getresourceinfobyid"></a>
# **GetResourceInfoById**
> ResourceResponse GetResourceInfoById (int? id, string evApiKey, string evAccessToken, string include = null)

Get resource metadata

Returns metadata for specified file/folder path, including upload date, size and type. For the full list of returned properties, see the response syntax, below.  **Notes:** - Authenticated user should have list permission. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetResourceInfoByIdExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var id = 56;  // int? | ID number of the resource
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var include = include_example;  // string | Comma separated list of relationships to include in response. Possible values are **share**, **notifications**, **directFile**, **parentResource**, **ownerUser**, **ownerAccount**. (optional) 

            try
            {
                // Get resource metadata
                ResourceResponse result = apiInstance.GetResourceInfoById(id, evApiKey, evAccessToken, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.GetResourceInfoById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID number of the resource | 
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **include** | **string**| Comma separated list of relationships to include in response. Possible values are **share**, **notifications**, **directFile**, **parentResource**, **ownerUser**, **ownerAccount**. | [optional] 

### Return type

[**ResourceResponse**](ResourceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listresourcecontents"></a>
# **ListResourceContents**
> ResourceCollectionResponse ListResourceContents (string evApiKey, string evAccessToken, int? id, string sort = null, int? offset = null, int? limit = null, string type = null, string include = null)

List contents of folder

Returns a list of files/folders for the parent resource ID.   You can use this API call to get information about all files and folders at a specified path. By default, the API returns basic metadata on each file/folder. An optional `include` parameter forces the return of additional metadata. As with all API calls, the path should be the full path relative to the user's home directory (e.g. **_/myfiles/some_folder**).  **Notes:** - Authenticated user should have list permission. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListResourceContentsExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call. 
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var id = 56;  // int? | ID of the parent resource to get a list of resources for.
            var sort = sort_example;  // string | Endpoint support multiple sort fields by allowing array of sort params. Sort fields should be applied in the order specified. The sort order for each sort field is ascending unless it is prefixed with a minus (“-“), in which case it will be descending. (optional) 
            var offset = 56;  // int? | Determines which item to start on for pagination. Use zero (0) to start at the beginning of the list. (optional)  (default to 0)
            var limit = 56;  // int? | The number of files to limit the result. Cannot be set higher than 100. If you have more than one hundred files in your directory, make multiple calls, incrementing the `offset parameter, above. (optional) 
            var type = type_example;  // string | Limit types of resources returned to \"file\" or \"dir\" only. (optional) 
            var include = include_example;  // string | Comma separated list of relationships to include in response. Possible values are **share**, **notifications**, **directFile**, **parentResource**, **ownerUser**, **ownerUser**. (optional) 

            try
            {
                // List contents of folder
                ResourceCollectionResponse result = apiInstance.ListResourceContents(evApiKey, evAccessToken, id, sort, offset, limit, type, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.ListResourceContents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call.  | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **id** | **int?**| ID of the parent resource to get a list of resources for. | 
 **sort** | **string**| Endpoint support multiple sort fields by allowing array of sort params. Sort fields should be applied in the order specified. The sort order for each sort field is ascending unless it is prefixed with a minus (“-“), in which case it will be descending. | [optional] 
 **offset** | **int?**| Determines which item to start on for pagination. Use zero (0) to start at the beginning of the list. | [optional] [default to 0]
 **limit** | **int?**| The number of files to limit the result. Cannot be set higher than 100. If you have more than one hundred files in your directory, make multiple calls, incrementing the &#x60;offset parameter, above. | [optional] 
 **type** | **string**| Limit types of resources returned to \&quot;file\&quot; or \&quot;dir\&quot; only. | [optional] 
 **include** | **string**| Comma separated list of relationships to include in response. Possible values are **share**, **notifications**, **directFile**, **parentResource**, **ownerUser**, **ownerUser**. | [optional] 

### Return type

[**ResourceCollectionResponse**](ResourceCollectionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listresources"></a>
# **ListResources**
> ResourceCollectionResponse ListResources (string evApiKey, string evAccessToken, string resource, string sort = null, int? offset = null, int? limit = null, string type = null, string name = null, string include = null)

Get a list of all resources

Returns a list of files and folders in the account. Use the `resource` query parameter to indicate the folder you wish to search in (which can be /).   **Searching for Files and Folders**  Using the `name` parameter triggers search mode, which will search the entire directory structure under the provided `resource` for files or folders with names matching the provided `name`. This supports wildcard matching such as:  - \\*Report\\* would find any files or folders with \"Report\" in the name. - Data\\_202?-09-30.xlsx would match items such as \"Data\\_2020-09-30.xlsx\", \"DATA\\_2021-09-30.xlsx\", \"data\\_2022-09-30.xlsx\" etc. - sales\\* would find any files or folders starting with the word \"Sales\" - \\*.csv would locate any files ending in \".csv\" - \\* matches everything within the directory tree starting at your given `resource`  The search is not case-sensitive. Searching for Clients\\* or clients\\* or CLIENTS\\*, etc. will provide identical results  You cannot use the `type` parameter if you are using the `name` parameter to run a search.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListResourcesExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var resource = resource_example;  // string | Resource identifier to get resources for. Can be path/id/name.
            var sort = sort_example;  // string | Endpoint support multiple sort fields by allowing array of sort params. Sort fields should be applied in the order specified. The sort order for each sort field is ascending unless it is prefixed with a minus (“-“), in which case it will be descending. (optional) 
            var offset = 56;  // int? | Determines which item to start on for pagination. Use zero (0) to start at the beginning of the list. (optional)  (default to 0)
            var limit = 56;  // int? | The number of files to limit the result. Cannot be set higher than 100. If you have more than one hundred files in your directory, make multiple calls, incrementing the `offset` parameter, above. (optional) 
            var type = type_example;  // string | Limit types of resources returned to \"file\" or \"dir\" only. This is ignored if you are using the name parameter to trigger a search. (optional) 
            var name = name_example;  // string | Text to match resource names. This allows you to filter the results returned. For example, to locate only zip archive files, you can enter `*zip` and only resources ending in \"zip\" will be included in the list of results. (optional) 
            var include = include_example;  // string | Comma separated list of relationships to include in response. Possible values are **share**, **notifications**, **directFile**, **parentResource**, **ownerUser**, **ownerAccount**. (optional) 

            try
            {
                // Get a list of all resources
                ResourceCollectionResponse result = apiInstance.ListResources(evApiKey, evAccessToken, resource, sort, offset, limit, type, name, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.ListResources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **resource** | **string**| Resource identifier to get resources for. Can be path/id/name. | 
 **sort** | **string**| Endpoint support multiple sort fields by allowing array of sort params. Sort fields should be applied in the order specified. The sort order for each sort field is ascending unless it is prefixed with a minus (“-“), in which case it will be descending. | [optional] 
 **offset** | **int?**| Determines which item to start on for pagination. Use zero (0) to start at the beginning of the list. | [optional] [default to 0]
 **limit** | **int?**| The number of files to limit the result. Cannot be set higher than 100. If you have more than one hundred files in your directory, make multiple calls, incrementing the &#x60;offset&#x60; parameter, above. | [optional] 
 **type** | **string**| Limit types of resources returned to \&quot;file\&quot; or \&quot;dir\&quot; only. This is ignored if you are using the name parameter to trigger a search. | [optional] 
 **name** | **string**| Text to match resource names. This allows you to filter the results returned. For example, to locate only zip archive files, you can enter &#x60;*zip&#x60; and only resources ending in \&quot;zip\&quot; will be included in the list of results. | [optional] 
 **include** | **string**| Comma separated list of relationships to include in response. Possible values are **share**, **notifications**, **directFile**, **parentResource**, **ownerUser**, **ownerAccount**. | [optional] 

### Return type

[**ResourceCollectionResponse**](ResourceCollectionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="moveresources"></a>
# **MoveResources**
> ResourceCopyMove MoveResources (string evApiKey, string evAccessToken, Body13 body = null)

Move resources

Moves a set of exisiting files/folders (provided by an array `resources`) to the requested `parentResource` in your account. In the `resources` array, you may specify paths pointing files/folders throughout the account, but everything will be moved to the root of the `parentResource`.  **Notes:** - Authenticated user should have modify permission. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MoveResourcesExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var body = new Body13(); // Body13 |  (optional) 

            try
            {
                // Move resources
                ResourceCopyMove result = apiInstance.MoveResources(evApiKey, evAccessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.MoveResources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **body** | [**Body13**](Body13.md)|  | [optional] 

### Return type

[**ResourceCopyMove**](ResourceCopyMove.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateresourcebyid"></a>
# **UpdateResourceById**
> ResourceResponse UpdateResourceById (string evAccessToken, string evApiKey, int? id, Body7 body = null)

Rename a resource.

Update the specified file or folder resource record's \"name\" parameter. The resource is identified by the numeric resource ID that is passed in as the last segment of the URI. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateResourceByIdExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var evApiKey = evApiKey_example;  // string | API key required to make the API call.
            var id = 56;  // int? | ID number of the resource
            var body = new Body7(); // Body7 |  (optional) 

            try
            {
                // Rename a resource.
                ResourceResponse result = apiInstance.UpdateResourceById(evAccessToken, evApiKey, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.UpdateResourceById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **evApiKey** | **string**| API key required to make the API call. | 
 **id** | **int?**| ID number of the resource | 
 **body** | [**Body7**](Body7.md)|  | [optional] 

### Return type

[**ResourceResponse**](ResourceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadfile"></a>
# **UploadFile**
> ResourceResponse UploadFile (string evApiKey, string evAccessToken, string path, int? fileSize, byte[] _file = null, int? offsetBytes = null, bool? resume = null, bool? allowOverwrite = null)

Upload a file

Uploads a file to a specified path, with optional support for resuming a partially uploaded existing file. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadFileExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();
            var evApiKey = evApiKey_example;  // string | API Key required to make the API call.
            var evAccessToken = evAccessToken_example;  // string | Access token required to make the API call.
            var path = path_example;  // string | Destination path for the file being uploaded, including the file name.
            var fileSize = 56;  // int? | File size, in bits, of the file being uploaded.
            var _file = _file_example;  // byte[] |  (optional) 
            var offsetBytes = 56;  // int? | Allows a file upload to resume at a certain number of bytes. (optional) 
            var resume = true;  // bool? | True if upload resume is supported, false if it isn't.  (optional)  (default to true)
            var allowOverwrite = true;  // bool? | True if a file with the same name is found in the designated path, should be overwritten. False if different file names should be generated.  (optional)  (default to false)

            try
            {
                // Upload a file
                ResourceResponse result = apiInstance.UploadFile(evApiKey, evAccessToken, path, fileSize, _file, offsetBytes, resume, allowOverwrite);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.UploadFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **evApiKey** | **string**| API Key required to make the API call. | 
 **evAccessToken** | **string**| Access token required to make the API call. | 
 **path** | **string**| Destination path for the file being uploaded, including the file name. | 
 **fileSize** | **int?**| File size, in bits, of the file being uploaded. | 
 **_file** | **byte[]****byte[]**|  | [optional] 
 **offsetBytes** | **int?**| Allows a file upload to resume at a certain number of bytes. | [optional] 
 **resume** | **bool?**| True if upload resume is supported, false if it isn&#x27;t.  | [optional] [default to true]
 **allowOverwrite** | **bool?**| True if a file with the same name is found in the designated path, should be overwritten. False if different file names should be generated.  | [optional] [default to false]

### Return type

[**ResourceResponse**](ResourceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
