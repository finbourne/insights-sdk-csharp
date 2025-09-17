# Finbourne.Insights.Sdk.Model.Histogram
A histogram showing an item's count in buckets of equal timespans.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Buckets** | [**List&lt;Bucket&gt;**](Bucket.md) | An ordered list of the histogram buckets. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

List<Bucket> buckets = new List<Bucket>();

Histogram histogramInstance = new Histogram(
    buckets: buckets);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
