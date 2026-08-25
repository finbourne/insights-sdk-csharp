# Finbourne.Insights.Sdk.Model.MetricDataSetFailure
Names a metric data set that was requested but could not be returned, with a caller-safe explanation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The data set that could not be returned. One of the Finbourne.Insights.WebApi.Dtos.Metrics.MetricDataSet values, and identical to the name of the Finbourne.Insights.WebApi.Dtos.Metrics.MetricsResponse property that would have carried it. | 
**Reason** | **string** | A generic, caller-safe explanation of why the data set is missing. Never contains provider names, query text, internal service names or exception detail. | 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string name = "name";
string reason = "reason";

MetricDataSetFailure metricDataSetFailureInstance = new MetricDataSetFailure(
    name: name,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
