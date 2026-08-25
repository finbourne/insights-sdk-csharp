# Finbourne.Insights.Sdk.Model.RequestsPerMinuteDataSet
Request volume, error count and total duration per minute, broken down by service and endpoint, over a rolling three hour window.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of this data set. Always &#x60;RequestsPerMinute&#x60;, matching the corresponding Finbourne.Insights.WebApi.Dtos.Metrics.MetricDataSet value and Finbourne.Insights.WebApi.Dtos.Metrics.MetricsResponse property. | 
**WindowStart** | **DateTimeOffset** | Inclusive start of the window the data covers, in UTC, floored to a whole minute. | 
**WindowEnd** | **DateTimeOffset** | End of the window the data covers, in UTC, floored to a whole minute. | 
**Truncated** | **bool** | True when the query reached the row cap, so the data covers only part of the window and totals are understated. False when the whole window was returned. | 
**Values** | [**List&lt;RequestsPerMinuteBucket&gt;**](RequestsPerMinuteBucket.md) | The per-minute rows, ordered by minute, then service, then endpoint. | 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string name = "name";
bool truncated = //"True";
List<RequestsPerMinuteBucket> values = new List<RequestsPerMinuteBucket>();

RequestsPerMinuteDataSet requestsPerMinuteDataSetInstance = new RequestsPerMinuteDataSet(
    name: name,
    windowStart: windowStart,
    windowEnd: windowEnd,
    truncated: truncated,
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
