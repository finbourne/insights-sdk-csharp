# Finbourne.Insights.Sdk.Model.AuditDataSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **int** |  | [optional] [readonly] 
**Categories** | **Dictionary&lt;string, int&gt;** |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

Dictionary<string, int> categories = new Dictionary<string, int>();

AuditDataSummary auditDataSummaryInstance = new AuditDataSummary(
    count: count,
    categories: categories);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
