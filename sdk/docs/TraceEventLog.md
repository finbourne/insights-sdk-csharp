# Finbourne.Insights.Sdk.Model.TraceEventLog
Holds information about a trace event.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TraceEventId** | **string** | The identifier of the trace event. | 
**TraceId** | **string** | The identifier of the parent trace. | 
**CreatedAt** | **DateTimeOffset** | The datetime at which the trace event was created. | 
**EventType** | **string** | The type of the trace event. | 
**Content** | **string** | The content of the trace event. | 
**SessionId** | **string** | The session ID of the trace event. | 
**CircuitId** | **string** | The ID of the circuit in which the trace event occurred. | 
**CircuitVersion** | **string** | The version of the circuit in which the trace event occurred. | 
**NodeId** | **string** | The ID of the circuit&#39;s node at which the trace event occured. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string traceEventId = "traceEventId";
string traceId = "traceId";
string eventType = "eventType";
string content = "content";
string sessionId = "sessionId";
string circuitId = "circuitId";
string circuitVersion = "circuitVersion";
string nodeId = "nodeId";
List<Link> links = new List<Link>();

TraceEventLog traceEventLogInstance = new TraceEventLog(
    traceEventId: traceEventId,
    traceId: traceId,
    createdAt: createdAt,
    eventType: eventType,
    content: content,
    sessionId: sessionId,
    circuitId: circuitId,
    circuitVersion: circuitVersion,
    nodeId: nodeId,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
