# Finbourne.Insights.Sdk.Model.ServiceRequests
The request volume and server-error rate for a single service over the window.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Service** | **string** | The name of the service (application) that handled the requests. | [optional] 
**TotalRequests** | **long?** | The number of requests over the window, or null if not reported. | [optional] 
**Requests5xx** | **long?** | The number of requests over the window that returned a 5xx status code, or null if not reported. | [optional] 
**Pct5xx** | **decimal?** | The percentage of requests that returned a 5xx status code, or null if not reported. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string service = "example service";

ServiceRequests serviceRequestsInstance = new ServiceRequests(
    service: service,
    totalRequests: totalRequests,
    requests5xx: requests5xx,
    pct5xx: pct5xx);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
