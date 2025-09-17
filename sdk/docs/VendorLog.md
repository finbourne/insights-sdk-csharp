# Finbourne.Insights.Sdk.Model.VendorLog
Holds logged information about a request made to an external vendor.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of a log entry. | 
**Provider** | **string** | The provider or service name. | 
**Timestamp** | **DateTimeOffset** | Timestamp of when the log was generated. | 
**Type** | **string** | Type of log. Possible values: HttpResponse. | 
**DestinationUrl** | **string** | The destination URL of the task. | 
**Operation** | **string** | The operation performed. Possible values: Evaluate. | 
**Outcome** | **string** | The outcome of the operation. Possible values: Success, Failure. | 
**Duration** | **decimal** | The duration of the operation in ms. | 
**HttpStatusCode** | **int** | The status code of the operation. | 
**UserId** | **string** | The user that made the request to LUSID. | 
**RequestId** | **string** | The ID of the request to LUSID. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string id = "id";
string provider = "provider";
string type = "type";
string destinationUrl = "destinationUrl";
string operation = "operation";
string outcome = "outcome";decimal duration = "duration";

string userId = "userId";
string requestId = "requestId";
List<Link> links = new List<Link>();

VendorLog vendorLogInstance = new VendorLog(
    id: id,
    provider: provider,
    timestamp: timestamp,
    type: type,
    destinationUrl: destinationUrl,
    operation: operation,
    outcome: outcome,
    duration: duration,
    httpStatusCode: httpStatusCode,
    userId: userId,
    requestId: requestId,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
