# Finbourne.Insights.Sdk.Model.TraceDiagramEdge
Represents an edge connecting two nodes within a trace diagram.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Sequential identifier of the edge. | [optional] 
**NodeId** | **string** | Identifier of the parent node. | [optional] 
**ChildNodeId** | **string** | Identifier of the child node. | [optional] 
**Label** | **string** | Label displayed for the edge. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string nodeId = "example nodeId";
string childNodeId = "example childNodeId";
string label = "example label";

TraceDiagramEdge traceDiagramEdgeInstance = new TraceDiagramEdge(
    id: id,
    nodeId: nodeId,
    childNodeId: childNodeId,
    label: label);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
