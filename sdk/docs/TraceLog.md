# Finbourne.Insights.Sdk.Model.TraceLog
Holds metadata for a trace.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TraceId** | **string** | The identifier of the trace. | 
**CreatedAt** | **DateTimeOffset** | The datetime at which the trace was created. | 
**UserId** | **string** | The id of the user who created the trace. | 
**Description** | **string** | The description of the trace. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string traceId = "traceId";
string userId = "userId";
string description = "example description";
List<Link> links = new List<Link>();

TraceLog traceLogInstance = new TraceLog(
    traceId: traceId,
    createdAt: createdAt,
    userId: userId,
    description: description,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
