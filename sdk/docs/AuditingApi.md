# Finbourne.Insights.Sdk.Api.AuditingApi

All URIs are relative to *https://fbn-ci.lusid.com/insights*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEntry**](AuditingApi.md#createentry) | **POST** /api/auditing/entries | [EARLY ACCESS] CreateEntry: Create (persist) and audit entry.. |
| [**GetProcesses**](AuditingApi.md#getprocesses) | **GET** /api/auditing/processes | [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process. |
| [**ListEntries**](AuditingApi.md#listentries) | **GET** /api/auditing/entries | [EARLY ACCESS] ListEntries: Get the audit entries. |

<a id="createentry"></a>
# **CreateEntry**
> AuditEntry CreateEntry (CreateAuditEntry? createAuditEntry = null)

[EARLY ACCESS] CreateEntry: Create (persist) and audit entry..

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Insights.Sdk.Api;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Model;

namespace Example
{
    public class CreateEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/insights";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuditingApi(config);
            var createAuditEntry = new CreateAuditEntry?(); // CreateAuditEntry? | Information about the entry to be created. (optional) 

            try
            {
                // [EARLY ACCESS] CreateEntry: Create (persist) and audit entry..
                AuditEntry result = apiInstance.CreateEntry(createAuditEntry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuditingApi.CreateEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateEntry: Create (persist) and audit entry..
    ApiResponse<AuditEntry> response = apiInstance.CreateEntryWithHttpInfo(createAuditEntry);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuditingApi.CreateEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAuditEntry** | [**CreateAuditEntry?**](CreateAuditEntry?.md) | Information about the entry to be created. | [optional]  |

### Return type

[**AuditEntry**](AuditEntry.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **429** | There have been too many recent requests, retry later (using the RETRY-AFTER header value as the delay). |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprocesses"></a>
# **GetProcesses**
> ResourceListOfAuditProcessSummary GetProcesses ()

[EARLY ACCESS] GetProcesses: Get the latest audit entry for each process.

This will never be `null`, though it may be empty.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Insights.Sdk.Api;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Model;

namespace Example
{
    public class GetProcessesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/insights";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuditingApi(config);

            try
            {
                // [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process.
                ResourceListOfAuditProcessSummary result = apiInstance.GetProcesses();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuditingApi.GetProcesses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProcessesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process.
    ApiResponse<ResourceListOfAuditProcessSummary> response = apiInstance.GetProcessesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuditingApi.GetProcessesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ResourceListOfAuditProcessSummary**](ResourceListOfAuditProcessSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listentries"></a>
# **ListEntries**
> ScrollableCollectionOfAuditEntry ListEntries (string? filter = null, string? sortBy = null, int? size = null, string? state = null)

[EARLY ACCESS] ListEntries: Get the audit entries.

This will never be `null`, though it may be empty.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Insights.Sdk.Api;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Model;

namespace Example
{
    public class ListEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/insights";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuditingApi(config);
            var filter = "filter_example";  // string? | The filter to be applied to the results. (optional) 
            var sortBy = "sortBy_example";  // string? | The order to return the entries in. (optional) 
            var size = 1000;  // int? | The maximum number of entries to return. (optional)  (default to 1000)
            var state = "state_example";  // string? | The scrolling state, used to iterate through the data set. (optional) 

            try
            {
                // [EARLY ACCESS] ListEntries: Get the audit entries.
                ScrollableCollectionOfAuditEntry result = apiInstance.ListEntries(filter, sortBy, size, state);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuditingApi.ListEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListEntries: Get the audit entries.
    ApiResponse<ScrollableCollectionOfAuditEntry> response = apiInstance.ListEntriesWithHttpInfo(filter, sortBy, size, state);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuditingApi.ListEntriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string?** | The filter to be applied to the results. | [optional]  |
| **sortBy** | **string?** | The order to return the entries in. | [optional]  |
| **size** | **int?** | The maximum number of entries to return. | [optional] [default to 1000] |
| **state** | **string?** | The scrolling state, used to iterate through the data set. | [optional]  |

### Return type

[**ScrollableCollectionOfAuditEntry**](ScrollableCollectionOfAuditEntry.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

