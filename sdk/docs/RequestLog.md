# Finbourne.Insights.Sdk.Model.RequestLog
Holds logged information about a request performed on an API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTimeOffset** | The timestamp of the request. | 
**Application** | **string** | The name of the application that the request was made to. | 
**Id** | **string** | The identifier of the request. | 
**SessionId** | **string** | The identifier of the session that the request was made in. | [optional] 
**Verb** | **string** | The HTTP verb of the request. | 
**Url** | **string** | The URL of the request. | 
**Domain** | **string** | The domain of the request. | [optional] 
**User** | **string** | The user who made the request. | 
**UserType** | **string** | The type of the user who made the request. | [optional] 
**Operation** | **string** | The API operation invoked by the request. | [optional] 
**Outcome** | **string** | The outcome of the request: Completed, Errored or Failed. | 
**Duration** | **decimal** | The duration of the request in milliseconds. | 
**HttpStatusCode** | **int** | The status code of the request. | 
**ErrorCode** | **string** | Error code, if the request had a failure or error. | [optional] 
**SdkLanguage** | **string** | The language of the SDK used. | [optional] 
**SdkVersion** | **string** | The version of the SDK used. | [optional] 
**SourceApplication** | **string** | The name of the application that made the request. | [optional] 
**CorrelationId** | **List&lt;string&gt;** | The chain of requestIds preceding this request | [optional] 
**ImpersonatingUser** | **string** | The impersonating user. Only present if the request is an impersonated one | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string application = "application";
string id = "id";
string sessionId = "example sessionId";
string verb = "verb";
string url = "url";
string domain = "example domain";
string user = "user";
string userType = "example userType";
string operation = "example operation";
string outcome = "outcome";decimal duration = "duration";

string errorCode = "example errorCode";
string sdkLanguage = "example sdkLanguage";
string sdkVersion = "example sdkVersion";
string sourceApplication = "example sourceApplication";
List<string> correlationId = new List<string>();
string impersonatingUser = "example impersonatingUser";
List<Link> links = new List<Link>();

RequestLog requestLogInstance = new RequestLog(
    timestamp: timestamp,
    application: application,
    id: id,
    sessionId: sessionId,
    verb: verb,
    url: url,
    domain: domain,
    user: user,
    userType: userType,
    operation: operation,
    outcome: outcome,
    duration: duration,
    httpStatusCode: httpStatusCode,
    errorCode: errorCode,
    sdkLanguage: sdkLanguage,
    sdkVersion: sdkVersion,
    sourceApplication: sourceApplication,
    correlationId: correlationId,
    impersonatingUser: impersonatingUser,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
