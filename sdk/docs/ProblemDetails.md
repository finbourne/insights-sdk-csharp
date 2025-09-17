# Finbourne.Insights.Sdk.Model.ProblemDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**Title** | **string** |  | [optional] 
**Status** | **int?** |  | [optional] 
**Detail** | **string** |  | [optional] 
**Instance** | **string** |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string type = "example type";
string title = "example title";
string detail = "example detail";
string instance = "example instance";

ProblemDetails problemDetailsInstance = new ProblemDetails(
    type: type,
    title: title,
    status: status,
    detail: detail,
    instance: instance);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
