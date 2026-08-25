# Finbourne.Insights.Sdk.Model.ServiceEndpointDuration
The request duration distribution for a single service and endpoint over the window.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Service** | **string** | The name of the service (application) that handled the requests. | [optional] 
**Endpoint** | **string** | The endpoint (API operation) the requests were made to. | [optional] 
**TotalRequests** | **long?** | The number of requests over the window, or null if not reported. | [optional] 
**MeanDurationMs** | **decimal?** | The mean request duration in milliseconds, or null if not reported. | [optional] 
**MedianDurationMs** | **decimal?** | The median (50th percentile) request duration in milliseconds, or null if not reported. | [optional] 
**P95DurationMs** | **decimal?** | The 95th percentile request duration in milliseconds, or null if not reported. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string service = "example service";
string endpoint = "example endpoint";

ServiceEndpointDuration serviceEndpointDurationInstance = new ServiceEndpointDuration(
    service: service,
    endpoint: endpoint,
    totalRequests: totalRequests,
    meanDurationMs: meanDurationMs,
    medianDurationMs: medianDurationMs,
    p95DurationMs: p95DurationMs);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
