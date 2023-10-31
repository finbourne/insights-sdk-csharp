# Finbourne.Insights.Sdk.Api.RequestsApi

All URIs are relative to *https://fbn-ci.lusid.com/insights*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetRequest**](RequestsApi.md#getrequest) | **GET** /api/requests/{id}/request | [EARLY ACCESS] GetRequest: Get the request content for a specific API request. |
| [**GetRequestLog**](RequestsApi.md#getrequestlog) | **GET** /api/requests/{id} | [EARLY ACCESS] GetRequestLog: Get the log for a specific API request. |
| [**GetResponse**](RequestsApi.md#getresponse) | **GET** /api/requests/{id}/response | [EARLY ACCESS] GetResponse: Get the response for a specific API request. |
| [**ListRequestLogs**](RequestsApi.md#listrequestlogs) | **GET** /api/requests | [EARLY ACCESS] ListRequestLogs: Get the logs for API requests. |

<a id="getrequest"></a>
# **GetRequest**
> Request GetRequest (string id)

[EARLY ACCESS] GetRequest: Get the request content for a specific API request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Insights.Sdk.Api;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Model;

namespace Example
{
    public class GetRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/insights";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RequestsApi(config);
            var id = "id_example";  // string | The identifier of the request to obtain the content for.

            try
            {
                // [EARLY ACCESS] GetRequest: Get the request content for a specific API request.
                Request result = apiInstance.GetRequest(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RequestsApi.GetRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetRequest: Get the request content for a specific API request.
    ApiResponse<Request> response = apiInstance.GetRequestWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RequestsApi.GetRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the request to obtain the content for. |  |

### Return type

[**Request**](Request.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrequestlog"></a>
# **GetRequestLog**
> RequestLog GetRequestLog (string id)

[EARLY ACCESS] GetRequestLog: Get the log for a specific API request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Insights.Sdk.Api;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Model;

namespace Example
{
    public class GetRequestLogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/insights";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RequestsApi(config);
            var id = "id_example";  // string | The identifier of the request to obtain the log for.

            try
            {
                // [EARLY ACCESS] GetRequestLog: Get the log for a specific API request.
                RequestLog result = apiInstance.GetRequestLog(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RequestsApi.GetRequestLog: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRequestLogWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetRequestLog: Get the log for a specific API request.
    ApiResponse<RequestLog> response = apiInstance.GetRequestLogWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RequestsApi.GetRequestLogWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the request to obtain the log for. |  |

### Return type

[**RequestLog**](RequestLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getresponse"></a>
# **GetResponse**
> Response GetResponse (string id)

[EARLY ACCESS] GetResponse: Get the response for a specific API request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Insights.Sdk.Api;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Model;

namespace Example
{
    public class GetResponseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/insights";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RequestsApi(config);
            var id = "id_example";  // string | The identifier of the request to obtain the response for.

            try
            {
                // [EARLY ACCESS] GetResponse: Get the response for a specific API request.
                Response result = apiInstance.GetResponse(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RequestsApi.GetResponse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResponseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetResponse: Get the response for a specific API request.
    ApiResponse<Response> response = apiInstance.GetResponseWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RequestsApi.GetResponseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the request to obtain the response for. |  |

### Return type

[**Response**](Response.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listrequestlogs"></a>
# **ListRequestLogs**
> ResourceListWithHistogramOfRequestLog ListRequestLogs (string? filter = null, string? sortBy = null, int? limit = null, string? page = null, string? histogramInterval = null)

[EARLY ACCESS] ListRequestLogs: Get the logs for API requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Insights.Sdk.Api;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Model;

namespace Example
{
    public class ListRequestLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/insights";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RequestsApi(config);
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about <see href=\"https://support.lusid.com/filtering-results-from-lusid\"> filtering results from LUSID</see>. (optional) 
            var sortBy = "sortBy_example";  // string? | Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional) 
            var limit = 56;  // int? | When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. (optional) 
            var page = "page_example";  // string? | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. (optional) 
            var histogramInterval = "histogramInterval_example";  // string? | Optional interval to use in a histogram of the returned values. If not provided, no histogram will be generated. (optional) 

            try
            {
                // [EARLY ACCESS] ListRequestLogs: Get the logs for API requests.
                ResourceListWithHistogramOfRequestLog result = apiInstance.ListRequestLogs(filter, sortBy, limit, page, histogramInterval);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RequestsApi.ListRequestLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRequestLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListRequestLogs: Get the logs for API requests.
    ApiResponse<ResourceListWithHistogramOfRequestLog> response = apiInstance.ListRequestLogsWithHttpInfo(filter, sortBy, limit, page, histogramInterval);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RequestsApi.ListRequestLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

[**ResourceListWithHistogramOfRequestLog**](ResourceListWithHistogramOfRequestLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

