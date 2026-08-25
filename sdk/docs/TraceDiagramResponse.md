# Finbourne.Insights.Sdk.Model.TraceDiagramResponse
Represents a trace diagram composed of nodes and edges.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Nodes** | [**List&lt;TraceDiagramNode&gt;**](TraceDiagramNode.md) | The nodes that make up the diagram. | [optional] 
**Edges** | [**List&lt;TraceDiagramEdge&gt;**](TraceDiagramEdge.md) | The edges that connect the nodes in the diagram. | [optional] 
**IsPossiblyIncomplete** | **bool** | Whether detected retrieval or diagram degradation means some events may not be shown. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

List<TraceDiagramNode> nodes = new List<TraceDiagramNode>();
List<TraceDiagramEdge> edges = new List<TraceDiagramEdge>();
bool isPossiblyIncomplete = //"True";

TraceDiagramResponse traceDiagramResponseInstance = new TraceDiagramResponse(
    nodes: nodes,
    edges: edges,
    isPossiblyIncomplete: isPossiblyIncomplete);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
