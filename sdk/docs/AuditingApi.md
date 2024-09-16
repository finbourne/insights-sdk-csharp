# Finbourne.Insights.Sdk.Api.AuditingApi

All URIs are relative to *https://fbn-prd.lusid.com/insights*

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
using Finbourne.Insights.Sdk.Api;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Extensions;
using Finbourne.Insights.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""insightsUrl"": ""https://<your-domain>.lusid.com/insights"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AuditingApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AuditingApi>();
            var createAuditEntry = new CreateAuditEntry?(); // CreateAuditEntry? | Information about the entry to be created. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AuditEntry result = apiInstance.CreateEntry(createAuditEntry, opts: opts);

                // [EARLY ACCESS] CreateEntry: Create (persist) and audit entry..
                AuditEntry result = apiInstance.CreateEntry(createAuditEntry);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AuditingApi.CreateEntry: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AuditingApi.CreateEntryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAuditEntry** | [**CreateAuditEntry?**](CreateAuditEntry?.md) | Information about the entry to be created. | [optional]  |

### Return type

[**AuditEntry**](AuditEntry.md)

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

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getprocesses"></a>
# **GetProcesses**
> ResourceListOfAuditProcessSummary GetProcesses ()

[EARLY ACCESS] GetProcesses: Get the latest audit entry for each process.

This will never be `null`, though it may be empty.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Insights.Sdk.Api;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Extensions;
using Finbourne.Insights.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""insightsUrl"": ""https://<your-domain>.lusid.com/insights"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AuditingApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AuditingApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfAuditProcessSummary result = apiInstance.GetProcesses(opts: opts);

                // [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process.
                ResourceListOfAuditProcessSummary result = apiInstance.GetProcesses();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AuditingApi.GetProcesses: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AuditingApi.GetProcessesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ResourceListOfAuditProcessSummary**](ResourceListOfAuditProcessSummary.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listentries"></a>
# **ListEntries**
> ScrollableCollectionOfAuditEntry ListEntries (string? filter = null, string? sortBy = null, int? size = null, string? state = null)

[EARLY ACCESS] ListEntries: Get the audit entries.

This will never be `null`, though it may be empty.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Insights.Sdk.Api;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Extensions;
using Finbourne.Insights.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""insightsUrl"": ""https://<your-domain>.lusid.com/insights"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AuditingApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AuditingApi>();
            var filter = "filter_example";  // string? | The filter to be applied to the results. (optional) 
            var sortBy = "sortBy_example";  // string? | The order to return the entries in. (optional) 
            var size = 1000;  // int? | The maximum number of entries to return. (optional)  (default to 1000)
            var state = "state_example";  // string? | The scrolling state, used to iterate through the data set. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ScrollableCollectionOfAuditEntry result = apiInstance.ListEntries(filter, sortBy, size, state, opts: opts);

                // [EARLY ACCESS] ListEntries: Get the audit entries.
                ScrollableCollectionOfAuditEntry result = apiInstance.ListEntries(filter, sortBy, size, state);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AuditingApi.ListEntries: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AuditingApi.ListEntriesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
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

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

