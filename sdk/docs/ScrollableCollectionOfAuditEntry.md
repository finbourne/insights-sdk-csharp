# Finbourne.Insights.Sdk.Model.ScrollableCollectionOfAuditEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;AuditEntry&gt;**](AuditEntry.md) |  | [optional] 
**State** | **string** |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

List<AuditEntry> data = new List<AuditEntry>();
string state = "example state";

ScrollableCollectionOfAuditEntry scrollableCollectionOfAuditEntryInstance = new ScrollableCollectionOfAuditEntry(
    data: data,
    state: state);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
