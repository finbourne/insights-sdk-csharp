# Finbourne.Insights.Sdk.Api.MetricsApi

All URIs are relative to *https://fbn-prd.lusid.com/insights*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMetrics**](MetricsApi.md#getmetrics) | **GET** /api/metrics | [EARLY ACCESS] GetMetrics: Get the aggregated platform metrics for the caller&#39;s domain. |

<a id="getmetrics"></a>
# **GetMetrics**
> MetricsResponse GetMetrics (List<string>? include = null)

[EARLY ACCESS] GetMetrics: Get the aggregated platform metrics for the caller's domain.

 Returns request volumes, error rates and duration distributions for the domain's services, plus its identity             population and activity counts. The domain is taken from the authenticated request, never from a parameter.  <b>This endpoint is slow by design.</b> It runs several analytical queries in parallel and commonly takes             upwards of thirty seconds when the underlying data is cold. The server abandons a data set that has not             completed within its configured budget and reports it in `failed`, so a call returns rather than hanging             indefinitely; allow comfortably more than that budget on the client, and do not call this on a             user-interactive code path without showing progress.  Partial success is normal and is still reported as a `200`. A data set that could not be retrieved is             null in the response and named in `failed` with a reason; a data set excluded via             include is null and named in `notIncluded`. Render a null data set as unavailable             rather than as an absence of activity.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<MetricsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<MetricsApi>();
            var include = new List<string>?(); // List<string>? | The data sets to return, by name. Omit to return all of them. Repeat the parameter to request several, for example `?include=RequestsPerMinute&include=IdentityMetrics`. Matched case-insensitively against the data set names, which are the `name` values on the response's data sets; duplicates are ignored. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // MetricsResponse result = apiInstance.GetMetrics(include, opts: opts);

                // [EARLY ACCESS] GetMetrics: Get the aggregated platform metrics for the caller's domain.
                MetricsResponse result = apiInstance.GetMetrics(include);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling MetricsApi.GetMetrics: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetricsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetMetrics: Get the aggregated platform metrics for the caller's domain.
    ApiResponse<MetricsResponse> response = apiInstance.GetMetricsWithHttpInfo(include);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling MetricsApi.GetMetricsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **include** | [**List&lt;string&gt;?**](string.md) | The data sets to return, by name. Omit to return all of them. Repeat the parameter to request several, for example &#x60;?include&#x3D;RequestsPerMinute&amp;include&#x3D;IdentityMetrics&#x60;. Matched case-insensitively against the data set names, which are the &#x60;name&#x60; values on the response&#39;s data sets; duplicates are ignored. | [optional]  |

### Return type

[**MetricsResponse**](MetricsResponse.md)

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

