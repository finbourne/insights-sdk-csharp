# Finbourne.Insights.Sdk.Api.AccessEvaluationsApi

All URIs are relative to *https://fbn-prd.lusid.com/insights*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccessEvaluationLog**](AccessEvaluationsApi.md#getaccessevaluationlog) | **GET** /api/access/{id} | [EARLY ACCESS] GetAccessEvaluationLog: Get the log for a specific access evaluation.  This endpoint will be deprecated in the near future. |
| [**ListAccessEvaluationLogs**](AccessEvaluationsApi.md#listaccessevaluationlogs) | **GET** /api/access | [EARLY ACCESS] ListAccessEvaluationLogs: List the logs for access evaluations. |

<a id="getaccessevaluationlog"></a>
# **GetAccessEvaluationLog**
> AccessEvaluationLog GetAccessEvaluationLog (string id)

[EARLY ACCESS] GetAccessEvaluationLog: Get the log for a specific access evaluation.  This endpoint will be deprecated in the near future.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AccessEvaluationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AccessEvaluationsApi>();
            var id = "id_example";  // string | The identifier of the access evaluation to obtain the log for.

            try
            {
                // uncomment the below to set overrides at the request level
                // AccessEvaluationLog result = apiInstance.GetAccessEvaluationLog(id, opts: opts);

                // [EARLY ACCESS] GetAccessEvaluationLog: Get the log for a specific access evaluation.  This endpoint will be deprecated in the near future.
                AccessEvaluationLog result = apiInstance.GetAccessEvaluationLog(id);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AccessEvaluationsApi.GetAccessEvaluationLog: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccessEvaluationLogWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetAccessEvaluationLog: Get the log for a specific access evaluation.  This endpoint will be deprecated in the near future.
    ApiResponse<AccessEvaluationLog> response = apiInstance.GetAccessEvaluationLogWithHttpInfo(id);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AccessEvaluationsApi.GetAccessEvaluationLogWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the access evaluation to obtain the log for. |  |

### Return type

[**AccessEvaluationLog**](AccessEvaluationLog.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listaccessevaluationlogs"></a>
# **ListAccessEvaluationLogs**
> ResourceListWithHistogramOfAccessEvaluationLog ListAccessEvaluationLogs (DateTimeOffset? startAt = null, DateTimeOffset? endAt = null, string? filter = null, string? sortBy = null, int? limit = null, string? page = null, string? histogramInterval = null)

[EARLY ACCESS] ListAccessEvaluationLogs: List the logs for access evaluations.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AccessEvaluationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AccessEvaluationsApi>();
            var startAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Start date from which point to fetch logs. (optional) 
            var endAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | End date to which point to fetch logs. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about [ filtering results from LUSID](https://support.lusid.com/filtering-results-from-lusid). (optional) 
            var sortBy = "sortBy_example";  // string? | Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional) 
            var limit = 56;  // int? | When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. (optional) 
            var page = "page_example";  // string? | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. (optional) 
            var histogramInterval = "histogramInterval_example";  // string? | The interval for an included histogram of the logs (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListWithHistogramOfAccessEvaluationLog result = apiInstance.ListAccessEvaluationLogs(startAt, endAt, filter, sortBy, limit, page, histogramInterval, opts: opts);

                // [EARLY ACCESS] ListAccessEvaluationLogs: List the logs for access evaluations.
                ResourceListWithHistogramOfAccessEvaluationLog result = apiInstance.ListAccessEvaluationLogs(startAt, endAt, filter, sortBy, limit, page, histogramInterval);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AccessEvaluationsApi.ListAccessEvaluationLogs: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAccessEvaluationLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListAccessEvaluationLogs: List the logs for access evaluations.
    ApiResponse<ResourceListWithHistogramOfAccessEvaluationLog> response = apiInstance.ListAccessEvaluationLogsWithHttpInfo(startAt, endAt, filter, sortBy, limit, page, histogramInterval);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AccessEvaluationsApi.ListAccessEvaluationLogsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startAt** | **DateTimeOffset?** | Start date from which point to fetch logs. | [optional]  |
| **endAt** | **DateTimeOffset?** | End date to which point to fetch logs. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about [ filtering results from LUSID](https://support.lusid.com/filtering-results-from-lusid). | [optional]  |
| **sortBy** | **string?** | Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName | [optional]  |
| **limit** | **int?** | When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. | [optional]  |
| **page** | **string?** | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. | [optional]  |
| **histogramInterval** | **string?** | The interval for an included histogram of the logs | [optional]  |

### Return type

[**ResourceListWithHistogramOfAccessEvaluationLog**](ResourceListWithHistogramOfAccessEvaluationLog.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

