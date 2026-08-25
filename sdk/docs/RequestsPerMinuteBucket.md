# Finbourne.Insights.Sdk.Model.RequestsPerMinuteBucket
One minute of request activity for a single service and endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MinuteBucket** | **DateTimeOffset** | Start of the whole minute this row covers, in UTC. | 
**Service** | **string** | The name of the service (application) that handled the requests. | [optional] 
**Endpoint** | **string** | The endpoint (API operation) the requests were made to. | [optional] 
**TotalRequests** | **long?** | The number of requests in this minute, or null if not reported. | [optional] 
**Requests5xx** | **long?** | The number of requests in this minute that returned a 5xx status code, or null if not reported. | [optional] 
**DurationSumMs** | **decimal?** | The sum of the request durations in this minute, in milliseconds, or null if not reported. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string service = "example service";
string endpoint = "example endpoint";

RequestsPerMinuteBucket requestsPerMinuteBucketInstance = new RequestsPerMinuteBucket(
    minuteBucket: minuteBucket,
    service: service,
    endpoint: endpoint,
    totalRequests: totalRequests,
    requests5xx: requests5xx,
    durationSumMs: durationSumMs);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
