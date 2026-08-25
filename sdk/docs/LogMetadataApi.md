# Finbourne.Insights.Sdk.Api.LogMetadataApi

All URIs are relative to *https://fbn-prd.lusid.com/insights*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListQueryableFields**](LogMetadataApi.md#listqueryablefields) | **GET** /api/metadata/logs | [EARLY ACCESS] ListQueryableFields: List the queryable fields for every supported log type. |

<a id="listqueryablefields"></a>
# **ListQueryableFields**
> ResourceListOfQueryableLogType ListQueryableFields ()

[EARLY ACCESS] ListQueryableFields: List the queryable fields for every supported log type.

Returns, for each log type, the fields that can be selected and/or filtered, their data types, and the comparator operations available for each filterable field. Intended to power a UI that advertises the correct comparators for a chosen field.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<LogMetadataApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<LogMetadataApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfQueryableLogType result = apiInstance.ListQueryableFields(opts: opts);

                // [EARLY ACCESS] ListQueryableFields: List the queryable fields for every supported log type.
                ResourceListOfQueryableLogType result = apiInstance.ListQueryableFields();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling LogMetadataApi.ListQueryableFields: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListQueryableFieldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListQueryableFields: List the queryable fields for every supported log type.
    ApiResponse<ResourceListOfQueryableLogType> response = apiInstance.ListQueryableFieldsWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling LogMetadataApi.ListQueryableFieldsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ResourceListOfQueryableLogType**](ResourceListOfQueryableLogType.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

