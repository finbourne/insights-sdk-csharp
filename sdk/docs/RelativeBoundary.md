# Finbourne.Insights.Sdk.Model.RelativeBoundary
One end of a relative time range. Exactly one of the options must be set: Finbourne.Insights.WebApi.Dtos.Querying.RelativeBoundary.Now (the current instant), Finbourne.Insights.WebApi.Dtos.Querying.RelativeBoundary.Midnight (the start of the current day in the range's time zone), Finbourne.Insights.WebApi.Dtos.Querying.RelativeBoundary.Offset (a duration back from now) or Finbourne.Insights.WebApi.Dtos.Querying.RelativeBoundary.Absolute (an explicit instant).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Now** | **bool** | When &#x60;true&#x60;, this boundary is the current instant (\&quot;now\&quot;). | [optional] 
**Midnight** | **bool** | When &#x60;true&#x60;, this boundary is the start of the current day (midnight) in the range&#39;s time zone. | [optional] 
**Offset** | [**RelativeOffset**](RelativeOffset.md) |  | [optional] 
**Absolute** | **DateTimeOffset?** | An explicit absolute instant. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

bool now = //"True";
bool midnight = //"True";
RelativeOffset? offset = new RelativeOffset();


RelativeBoundary relativeBoundaryInstance = new RelativeBoundary(
    now: now,
    midnight: midnight,
    offset: offset,
    absolute: absolute);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
