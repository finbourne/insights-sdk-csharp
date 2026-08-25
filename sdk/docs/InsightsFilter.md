# Finbourne.Insights.Sdk.Model.InsightsFilter
A single filter applied to a queryable log field. Exactly one comparator (Finbourne.Insights.WebApi.Dtos.Querying.InsightsFilter.Text, Finbourne.Insights.WebApi.Dtos.Querying.InsightsFilter.Numeric, Finbourne.Insights.WebApi.Dtos.Querying.InsightsFilter.Date or Finbourne.Insights.WebApi.Dtos.Querying.InsightsFilter.Boolean) must be populated, and its type must match the data type of the field named by Finbourne.Insights.WebApi.Dtos.Querying.InsightsFilter.Field. The available comparator and operation for a field can be discovered via the queryable-fields metadata endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | The name of the field to filter on (case-insensitive). Must be a filterable field of the queried log type. | 
**Text** | [**TextComparator**](TextComparator.md) |  | [optional] 
**Numeric** | [**NumericComparator**](NumericComparator.md) |  | [optional] 
**Date** | [**DateComparator**](DateComparator.md) |  | [optional] 
**Boolean** | [**BooleanComparator**](BooleanComparator.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string field = "field";
TextComparator? text = new TextComparator();

NumericComparator? numeric = new NumericComparator();

DateComparator? date = new DateComparator();

BooleanComparator? boolean = new BooleanComparator();


InsightsFilter insightsFilterInstance = new InsightsFilter(
    field: field,
    text: text,
    numeric: numeric,
    date: date,
    boolean: boolean);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
