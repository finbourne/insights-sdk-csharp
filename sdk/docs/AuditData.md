# Finbourne.Insights.Sdk.Model.AuditData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** |  | 
**Category** | **string** |  | 
**UserId** | **string** |  | [optional] 
**Message** | **string** |  | [optional] 
**Resource** | [**Resource**](Resource.md) |  | [optional] 
**DetailsType** | **string** |  | [optional] 
**Details** | **Object** |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string action = "action";
string category = "category";
string userId = "example userId";
string message = "example message";
Resource? resource = new Resource();

string detailsType = "example detailsType";

AuditData auditDataInstance = new AuditData(
    action: action,
    category: category,
    userId: userId,
    message: message,
    resource: resource,
    detailsType: detailsType,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
