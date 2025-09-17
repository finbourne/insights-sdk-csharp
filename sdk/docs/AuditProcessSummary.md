# Finbourne.Insights.Sdk.Model.AuditProcessSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Process** | [**AuditProcess**](AuditProcess.md) |  | [optional] 
**LatestEntry** | [**AuditData**](AuditData.md) |  | [optional] 
**Summary** | [**AuditDataSummary**](AuditDataSummary.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

AuditProcess? process = new AuditProcess();

AuditData? latestEntry = new AuditData();

AuditDataSummary? summary = new AuditDataSummary();


AuditProcessSummary auditProcessSummaryInstance = new AuditProcessSummary(
    process: process,
    latestEntry: latestEntry,
    summary: summary);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
