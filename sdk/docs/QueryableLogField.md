# Finbourne.Insights.Sdk.Model.QueryableLogField
Describes a field of a log type that can be selected and (where Finbourne.Insights.WebApi.Dtos.Querying.QueryableLogField.Filterable is set) filtered when querying logs, including the comparator operations available for it. Returned by the queryable-fields metadata endpoint so a UI can advertise the correct comparators for each field.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the field, as used when requesting it or filtering on it (case-insensitive). | 
**DataType** | **string** | The data type of the field: Text, Numeric, Date or Boolean. | 
**SupportedOperations** | **List&lt;string&gt;** | The comparator operations available for this field. Empty when the field is not filterable. | 
**Filterable** | **bool** | Whether the field can be used in a filter. | [optional] 
**AlwaysReturned** | **bool** | Whether the field is always returned (and therefore need not be requested). | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string name = "name";
string dataType = "dataType";
List<string> supportedOperations = new List<string>();
bool filterable = //"True";
bool alwaysReturned = //"True";

QueryableLogField queryableLogFieldInstance = new QueryableLogField(
    name: name,
    dataType: dataType,
    supportedOperations: supportedOperations,
    filterable: filterable,
    alwaysReturned: alwaysReturned);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
