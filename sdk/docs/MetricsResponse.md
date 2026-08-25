# Finbourne.Insights.Sdk.Model.MetricsResponse
The aggregated platform metrics for a domain: one nullable, strongly-typed property per data set.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset** | When this response was assembled, in UTC. Every data set in the response was resolved against this instant. | 
**Domain** | **string** | The domain the metrics are for, resolved from the authenticated request rather than from any parameter. | 
**RequestsPerMinute** | [**RequestsPerMinuteDataSet**](RequestsPerMinuteDataSet.md) |  | [optional] 
**ServiceEndpointDurations24h** | [**ServiceEndpointDurations24hDataSet**](ServiceEndpointDurations24hDataSet.md) |  | [optional] 
**ServiceRequests24h** | [**ServiceRequests24hDataSet**](ServiceRequests24hDataSet.md) |  | [optional] 
**IdentityMetrics** | [**IdentityMetricsDataSet**](IdentityMetricsDataSet.md) |  | [optional] 
**NotIncluded** | **List&lt;string&gt;** | The data sets the caller excluded via the &#x60;include&#x60; parameter, and which were therefore never queried. Each value is one of the Finbourne.Insights.WebApi.Dtos.Metrics.MetricDataSet values. | 
**Failed** | [**List&lt;MetricDataSetFailure&gt;**](MetricDataSetFailure.md) | The data sets that were requested but could not be returned, each with a caller-safe reason. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string domain = "domain";
RequestsPerMinuteDataSet? requestsPerMinute = new RequestsPerMinuteDataSet();

ServiceEndpointDurations24hDataSet? serviceEndpointDurations24h = new ServiceEndpointDurations24hDataSet();

ServiceRequests24hDataSet? serviceRequests24h = new ServiceRequests24hDataSet();

IdentityMetricsDataSet? identityMetrics = new IdentityMetricsDataSet();

List<string> notIncluded = new List<string>();
List<MetricDataSetFailure> failed = new List<MetricDataSetFailure>();
List<Link> links = new List<Link>();

MetricsResponse metricsResponseInstance = new MetricsResponse(
    asAt: asAt,
    domain: domain,
    requestsPerMinute: requestsPerMinute,
    serviceEndpointDurations24h: serviceEndpointDurations24h,
    serviceRequests24h: serviceRequests24h,
    identityMetrics: identityMetrics,
    notIncluded: notIncluded,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
