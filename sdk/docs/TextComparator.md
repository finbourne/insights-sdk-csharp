# Finbourne.Insights.Sdk.Model.TextComparator
Filters a text field. Single-value operations (EqualTo, NotEqualTo, StartsWith, EndsWith) compare the field to Finbourne.Insights.WebApi.Dtos.Querying.TextComparator.Value; set operations (In, NotIn) compare it to Finbourne.Insights.WebApi.Dtos.Querying.TextComparator.Values. Exactly one of Finbourne.Insights.WebApi.Dtos.Querying.TextComparator.Value or Finbourne.Insights.WebApi.Dtos.Querying.TextComparator.Values is supplied, matching the chosen Finbourne.Insights.WebApi.Dtos.Querying.TextComparator.Operation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **string** | The comparison to apply between the field and the supplied value(s). One of the Finbourne.Insights.WebApi.Dtos.Querying.TextOperation values (e.g. EqualTo, StartsWith, In); discoverable via the queryable-fields metadata endpoint. | 
**Value** | **string** | The value to compare the field against, for the single-value operations (EqualTo, NotEqualTo, StartsWith, EndsWith). | [optional] 
**Values** | **List&lt;string&gt;** | The set of values to compare the field against, for the set operations (In, NotIn). | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string operation = "operation";
string value = "example value";
List<string> values = new List<string>();

TextComparator textComparatorInstance = new TextComparator(
    operation: operation,
    value: value,
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
