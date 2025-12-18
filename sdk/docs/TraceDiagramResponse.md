# Finbourne.Insights.Sdk.Model.TraceDiagramResponse
Represents a trace diagram composed of nodes and edges.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Nodes** | [**List&lt;TraceDiagramNode&gt;**](TraceDiagramNode.md) | The nodes that make up the diagram. | [optional] 
**Edges** | [**List&lt;TraceDiagramEdge&gt;**](TraceDiagramEdge.md) | The edges that connect the nodes in the diagram. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

List<TraceDiagramNode> nodes = new List<TraceDiagramNode>();
List<TraceDiagramEdge> edges = new List<TraceDiagramEdge>();

TraceDiagramResponse traceDiagramResponseInstance = new TraceDiagramResponse(
    nodes: nodes,
    edges: edges);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
