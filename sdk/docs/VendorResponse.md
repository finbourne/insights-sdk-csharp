# Finbourne.Insights.Sdk.Model.VendorResponse
Details of a response to a request made to a vendor service.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the log. | 
**Response** | **string** | The body of the response. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string id = "id";
string response = "response";
List<Link> links = new List<Link>();

VendorResponse vendorResponseInstance = new VendorResponse(
    id: id,
    response: response,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
