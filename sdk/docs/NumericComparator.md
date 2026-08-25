# Finbourne.Insights.Sdk.Model.NumericComparator
Filters a numeric field by comparing it to a supplied numeric value.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **string** | The comparison to apply between the field and Finbourne.Insights.WebApi.Dtos.Querying.NumericComparator.Value. One of the Finbourne.Insights.WebApi.Dtos.Querying.NumericOperation values (e.g. EqualTo, GreaterThan); discoverable via the queryable-fields metadata endpoint. | 
**Value** | **decimal** | The value to compare the field against. | 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string operation = "operation";decimal value = "value";


NumericComparator numericComparatorInstance = new NumericComparator(
    operation: operation,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
