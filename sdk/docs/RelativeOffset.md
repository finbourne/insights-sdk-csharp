# Finbourne.Insights.Sdk.Model.RelativeOffset
A relative offset back from \"now\", e.g. `{ Amount = 2, Unit = Hours }` meaning two hours before now.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int** | The number of units to go back from now. Must be at least 1. | 
**Unit** | **string** | The unit of the offset. One of the Finbourne.Insights.WebApi.Dtos.Querying.RelativeTimeUnit values. | 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string unit = "unit";

RelativeOffset relativeOffsetInstance = new RelativeOffset(
    amount: amount,
    unit: unit);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
