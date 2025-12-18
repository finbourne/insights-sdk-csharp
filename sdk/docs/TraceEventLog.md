# Finbourne.Insights.Sdk.Model.TraceEventLog
Holds information about a trace event.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TraceEventId** | **string** | The identifier of the trace event. | 
**TraceId** | **string** | The identifier of the parent trace. | 
**CreatedAt** | **DateTimeOffset** | The datetime at which the trace event was created. | 
**EventType** | **string** | The type of the trace event. | 
**Origin** | **string** | Whether the event originated from the AI or the user | 
**Content** | **string** | The content of the trace event. | 
**AgentScope** | **string** | The scope of the agent currently being interacted with | 
**AgentCode** | **string** | The code identifier of the agent currently being interacted with | 
**AgentVersion** | **int** | The version of the circuit in which the trace event occurred. | 
**NodeId** | **string** | The ID of the circuit&#39;s node at which the trace event occured. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string traceEventId = "traceEventId";
string traceId = "traceId";
string eventType = "eventType";
string origin = "origin";
string content = "content";
string agentScope = "agentScope";
string agentCode = "agentCode";
string nodeId = "nodeId";
List<Link> links = new List<Link>();

TraceEventLog traceEventLogInstance = new TraceEventLog(
    traceEventId: traceEventId,
    traceId: traceId,
    createdAt: createdAt,
    eventType: eventType,
    origin: origin,
    content: content,
    agentScope: agentScope,
    agentCode: agentCode,
    agentVersion: agentVersion,
    nodeId: nodeId,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
