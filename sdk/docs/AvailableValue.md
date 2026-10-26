# Finbourne.Insights.Sdk.Model.AvailableValue
A value known to be valid for a queryable log field, which a UI can offer when filtering on that field.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | The value. | 
**Context** | **string** | Optional context qualifying the value. For the Operation field this is the comma-separated names of the applications that publish the operation. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string value = "value";
string context = "example context";

AvailableValue availableValueInstance = new AvailableValue(
    value: value,
    context: context);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
