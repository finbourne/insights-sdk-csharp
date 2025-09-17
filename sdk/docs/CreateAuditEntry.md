# Finbourne.Insights.Sdk.Model.CreateAuditEntry
Details to create an audit entry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Process** | [**AuditProcess**](AuditProcess.md) |  | 
**Data** | [**AuditData**](AuditData.md) |  | 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

AuditProcess process = new AuditProcess();
AuditData data = new AuditData();

CreateAuditEntry createAuditEntryInstance = new CreateAuditEntry(
    process: process,
    data: data);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
