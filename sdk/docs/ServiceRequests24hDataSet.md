# Finbourne.Insights.Sdk.Model.ServiceRequests24hDataSet
Request volume and server-error rate per service over a rolling twenty four hour window.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of this data set. Always &#x60;ServiceRequests24h&#x60;, matching the corresponding Finbourne.Insights.WebApi.Dtos.Metrics.MetricDataSet value and Finbourne.Insights.WebApi.Dtos.Metrics.MetricsResponse property. | 
**WindowStart** | **DateTimeOffset** | Inclusive start of the window the data covers, in UTC, floored to a whole minute. | 
**WindowEnd** | **DateTimeOffset** | End of the window the data covers, in UTC, floored to a whole minute. | 
**Truncated** | **bool** | True when the query reached the row cap, so some services are missing. False when the whole result set was returned. | 
**Values** | [**List&lt;ServiceRequests&gt;**](ServiceRequests.md) | The rows, ordered by service. | 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string name = "name";
bool truncated = //"True";
List<ServiceRequests> values = new List<ServiceRequests>();

ServiceRequests24hDataSet serviceRequests24hDataSetInstance = new ServiceRequests24hDataSet(
    name: name,
    windowStart: windowStart,
    windowEnd: windowEnd,
    truncated: truncated,
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
