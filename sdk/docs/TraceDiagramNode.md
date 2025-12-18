# Finbourne.Insights.Sdk.Model.TraceDiagramNode
Represents a node within a trace diagram.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the node. | [optional] 
**DisplayName** | **string** | Display name of the node. | [optional] 
**Level** | **int** | Depth level of the node within the diagram. | [optional] 
**Parent** | **string** | Identifier of the node&#39;s parent. This is null for the root node. | [optional] 
**Type** | **string** | Type classification of the node. | [optional] 
**AgentScope** | **string** | The scope of the agent. | [optional] 
**AgentVersion** | **int** | The version of the agent. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string id = "example id";
string displayName = "example displayName";
string parent = "example parent";
string type = "example type";
string agentScope = "example agentScope";

TraceDiagramNode traceDiagramNodeInstance = new TraceDiagramNode(
    id: id,
    displayName: displayName,
    level: level,
    parent: parent,
    type: type,
    agentScope: agentScope,
    agentVersion: agentVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
