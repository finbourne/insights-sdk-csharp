# Finbourne.Insights.Sdk.Model.BooleanComparator
Filters a boolean field by comparing it to a supplied boolean value.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **string** | The comparison to apply between the field and Finbourne.Insights.WebApi.Dtos.Querying.BooleanComparator.Value. One of the Finbourne.Insights.WebApi.Dtos.Querying.BooleanOperation values (EqualTo, NotEqualTo); discoverable via the queryable-fields metadata endpoint. | 
**Value** | **bool** | The value to compare the field against. | 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string operation = "operation";
bool value = //"True";

BooleanComparator booleanComparatorInstance = new BooleanComparator(
    operation: operation,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
