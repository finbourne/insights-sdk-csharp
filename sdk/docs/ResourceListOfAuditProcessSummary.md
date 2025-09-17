# Finbourne.Insights.Sdk.Model.ResourceListOfAuditProcessSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;AuditProcessSummary&gt;**](AuditProcessSummary.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

List<AuditProcessSummary> values = new List<AuditProcessSummary>();
string href = "example href";
List<Link> links = new List<Link>();
string nextPage = "example nextPage";
string previousPage = "example previousPage";

ResourceListOfAuditProcessSummary resourceListOfAuditProcessSummaryInstance = new ResourceListOfAuditProcessSummary(
    values: values,
    href: href,
    links: links,
    nextPage: nextPage,
    previousPage: previousPage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
