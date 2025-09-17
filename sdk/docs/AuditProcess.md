# Finbourne.Insights.Sdk.Model.AuditProcess

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**RunId** | **string** |  | 
**StartTime** | **DateTimeOffset** |  | 
**EndTime** | **DateTimeOffset?** |  | [optional] 
**Succeeded** | **bool?** |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string name = "name";
string runId = "runId";
bool? succeeded = //"True";

AuditProcess auditProcessInstance = new AuditProcess(
    name: name,
    runId: runId,
    startTime: startTime,
    endTime: endTime,
    succeeded: succeeded);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
