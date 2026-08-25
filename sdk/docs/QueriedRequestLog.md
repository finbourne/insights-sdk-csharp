# Finbourne.Insights.Sdk.Model.QueriedRequestLog
Holds logged information about a request performed on an API, where only a subset of fields may be populated depending on which fields were requested via the QueryRequestLogs endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTimeOffset** | The timestamp of the request. | 
**Id** | **string** | The identifier of the request. | 
**Application** | **string** | The name of the application that the request was made to. | 
**Operation** | **string** | The API operation invoked by the request. | 
**SessionId** | **string** | The identifier of the session that the request was made in. | [optional] 
**Verb** | **string** | The HTTP verb of the request. | [optional] 
**Url** | **string** | The URL of the request. | [optional] 
**Domain** | **string** | The domain of the request. | [optional] 
**User** | **string** | The user who made the request. | [optional] 
**UserType** | **string** | The type of the user who made the request. | [optional] 
**Outcome** | **string** | The outcome of the request: Completed, Errored or Failed. | [optional] 
**Duration** | **decimal?** | The duration of the request in milliseconds. | [optional] 
**HttpStatusCode** | **int?** | The status code of the request. | [optional] 
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

string id = "id";
string application = "application";
string operation = "operation";
string sessionId = "example sessionId";
string verb = "example verb";
string url = "example url";
string domain = "example domain";
string user = "example user";
string userType = "example userType";
string outcome = "example outcome";
string errorCode = "example errorCode";
string sdkLanguage = "example sdkLanguage";
string sdkVersion = "example sdkVersion";
string sourceApplication = "example sourceApplication";
List<string> correlationId = new List<string>();
string impersonatingUser = "example impersonatingUser";
List<Link> links = new List<Link>();

QueriedRequestLog queriedRequestLogInstance = new QueriedRequestLog(
    timestamp: timestamp,
    id: id,
    application: application,
    operation: operation,
    sessionId: sessionId,
    verb: verb,
    url: url,
    domain: domain,
    user: user,
    userType: userType,
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
