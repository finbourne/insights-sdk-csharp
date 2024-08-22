# Finbourne.Insights.Sdk.Api.VendorLogsApi

All URIs are relative to *https://fbn-prd.lusid.com/insights*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetVendorLog**](VendorLogsApi.md#getvendorlog) | **GET** /api/vendor/{id} | [EXPERIMENTAL] GetVendorLog: Get the log for a specific vendor request. |
| [**GetVendorRequest**](VendorLogsApi.md#getvendorrequest) | **GET** /api/vendor/{id}/request | [EXPERIMENTAL] GetVendorRequest: Get the request body for a vendor request. |
| [**GetVendorResponse**](VendorLogsApi.md#getvendorresponse) | **GET** /api/vendor/{id}/response | [EXPERIMENTAL] GetVendorResponse: Get the response from a vendor request. |
| [**ListVendorLogs**](VendorLogsApi.md#listvendorlogs) | **GET** /api/vendor | [EXPERIMENTAL] ListVendorLogs: List the logs for vendor requests. |

<a id="getvendorlog"></a>
# **GetVendorLog**
> VendorLog GetVendorLog (string id)

[EXPERIMENTAL] GetVendorLog: Get the log for a specific vendor request.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<VendorLogsApi>();
            var id = "id_example";  // string | The identifier of the request to obtain the log for.

            try
            {
                // [EXPERIMENTAL] GetVendorLog: Get the log for a specific vendor request.
                VendorLog result = apiInstance.GetVendorLog(id);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling VendorLogsApi.GetVendorLog: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVendorLogWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetVendorLog: Get the log for a specific vendor request.
    ApiResponse<VendorLog> response = apiInstance.GetVendorLogWithHttpInfo(id);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling VendorLogsApi.GetVendorLogWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the request to obtain the log for. |  |

### Return type

[**VendorLog**](VendorLog.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getvendorrequest"></a>
# **GetVendorRequest**
> VendorRequest GetVendorRequest (string id)

[EXPERIMENTAL] GetVendorRequest: Get the request body for a vendor request.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<VendorLogsApi>();
            var id = "id_example";  // string | The identifier of the request to obtain the content for.

            try
            {
                // [EXPERIMENTAL] GetVendorRequest: Get the request body for a vendor request.
                VendorRequest result = apiInstance.GetVendorRequest(id);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling VendorLogsApi.GetVendorRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVendorRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetVendorRequest: Get the request body for a vendor request.
    ApiResponse<VendorRequest> response = apiInstance.GetVendorRequestWithHttpInfo(id);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling VendorLogsApi.GetVendorRequestWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the request to obtain the content for. |  |

### Return type

[**VendorRequest**](VendorRequest.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getvendorresponse"></a>
# **GetVendorResponse**
> VendorResponse GetVendorResponse (string id)

[EXPERIMENTAL] GetVendorResponse: Get the response from a vendor request.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<VendorLogsApi>();
            var id = "id_example";  // string | The identifier of the request to obtain the response for.

            try
            {
                // [EXPERIMENTAL] GetVendorResponse: Get the response from a vendor request.
                VendorResponse result = apiInstance.GetVendorResponse(id);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling VendorLogsApi.GetVendorResponse: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVendorResponseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetVendorResponse: Get the response from a vendor request.
    ApiResponse<VendorResponse> response = apiInstance.GetVendorResponseWithHttpInfo(id);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling VendorLogsApi.GetVendorResponseWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the request to obtain the response for. |  |

### Return type

[**VendorResponse**](VendorResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listvendorlogs"></a>
# **ListVendorLogs**
> ResourceListWithHistogramOfVendorLog ListVendorLogs (string? filter = null, string? sortBy = null, int? limit = null, string? page = null, string? histogramInterval = null)

[EXPERIMENTAL] ListVendorLogs: List the logs for vendor requests.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<VendorLogsApi>();
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about <see href=\"https://support.lusid.com/filtering-results-from-lusid\"> filtering results from LUSID</see>. (optional) 
            var sortBy = "sortBy_example";  // string? | Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional) 
            var limit = 56;  // int? | When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. (optional) 
            var page = "page_example";  // string? | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. (optional) 
            var histogramInterval = "histogramInterval_example";  // string? | Optional interval to use in a histogram of the returned values. If not provided, no histogram will be generated. (optional) 

            try
            {
                // [EXPERIMENTAL] ListVendorLogs: List the logs for vendor requests.
                ResourceListWithHistogramOfVendorLog result = apiInstance.ListVendorLogs(filter, sortBy, limit, page, histogramInterval);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling VendorLogsApi.ListVendorLogs: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListVendorLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListVendorLogs: List the logs for vendor requests.
    ApiResponse<ResourceListWithHistogramOfVendorLog> response = apiInstance.ListVendorLogsWithHttpInfo(filter, sortBy, limit, page, histogramInterval);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling VendorLogsApi.ListVendorLogsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string?** | Expression to filter the result set. Read more about &lt;see href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/see&gt;. | [optional]  |
| **sortBy** | **string?** | Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName | [optional]  |
| **limit** | **int?** | When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. | [optional]  |
| **page** | **string?** | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. | [optional]  |
| **histogramInterval** | **string?** | Optional interval to use in a histogram of the returned values. If not provided, no histogram will be generated. | [optional]  |

### Return type

[**ResourceListWithHistogramOfVendorLog**](ResourceListWithHistogramOfVendorLog.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

