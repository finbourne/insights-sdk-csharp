# Finbourne.Insights.Sdk.Model.ResourceListWithHistogramOfVendorLog
ResourceList with additional aggregation data about the values.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Histogram** | [**Histogram**](Histogram.md) |  | [optional] 
**Values** | [**List&lt;VendorLog&gt;**](VendorLog.md) |  | 
**Href** | **string** |  | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

Histogram? histogram = new Histogram();

List<VendorLog> values = new List<VendorLog>();
string href = "example href";
string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<Link> links = new List<Link>();

ResourceListWithHistogramOfVendorLog resourceListWithHistogramOfVendorLogInstance = new ResourceListWithHistogramOfVendorLog(
    histogram: histogram,
    values: values,
    href: href,
    nextPage: nextPage,
    previousPage: previousPage,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
