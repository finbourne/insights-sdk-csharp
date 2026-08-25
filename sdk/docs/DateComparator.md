# Finbourne.Insights.Sdk.Model.DateComparator
Filters a date/time field by comparing it to a supplied date/time value.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **string** | The comparison to apply between the field and Finbourne.Insights.WebApi.Dtos.Querying.DateComparator.Value. One of the Finbourne.Insights.WebApi.Dtos.Querying.DateOperation values (e.g. Before, OnOrAfter); discoverable via the queryable-fields metadata endpoint. | 
**Value** | **DateTimeOffset** | The value to compare the field against. | 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string operation = "operation";

DateComparator dateComparatorInstance = new DateComparator(
    operation: operation,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
