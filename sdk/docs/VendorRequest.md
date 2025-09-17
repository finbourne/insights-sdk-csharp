# Finbourne.Insights.Sdk.Model.VendorRequest
Details of a request made to a vendor service.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the log. | 
**Request** | **string** | The body of the request. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string id = "id";
string request = "request";
List<Link> links = new List<Link>();

VendorRequest vendorRequestInstance = new VendorRequest(
    id: id,
    request: request,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
