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
**Outcome** | **string** | The outcome of the request: Success, Failure or Error. | 
**Duration** | **decimal** | The duration of the request in milliseconds. | 
**HttpStatusCode** | **int** | The status code of the request. | 
**ErrorCode** | **string** | Error code, if the request had a failure or error. | [optional] 
**SdkLanguage** | **string** | The language of the SDK used. | [optional] 
**SdkVersion** | **string** | The version of the SDK used. | [optional] 
**SourceApplication** | **string** | The name of the application that made the request. | [optional] 
**CorrelationId** | **List&lt;string&gt;** | The chain of requestIds preceding this request | [optional] 
**ImpersonatingUser** | **string** | The impersonating user. Only present if the request is an impersonated one | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

