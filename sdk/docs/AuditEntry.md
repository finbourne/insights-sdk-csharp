# Finbourne.Insights.Sdk.Model.AuditEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Date** | **DateTimeOffset** |  | 
**Process** | [**AuditProcess**](AuditProcess.md) |  | 
**Data** | [**AuditData**](AuditData.md) |  | 
**Notes** | [**List&lt;AuditEntryNote&gt;**](AuditEntryNote.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string id = "id";
AuditProcess process = new AuditProcess();
AuditData data = new AuditData();
List<AuditEntryNote> notes = new List<AuditEntryNote>();

AuditEntry auditEntryInstance = new AuditEntry(
    id: id,
    date: date,
    process: process,
    data: data,
    notes: notes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
