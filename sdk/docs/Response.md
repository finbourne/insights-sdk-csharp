# Finbourne.Insights.Sdk.Model.Response
DTO of Finbourne.AspNetCore.Http.TrackingEntry.ResponseInformation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Headers** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | The headers | [optional] 
**ContentLength** | **long?** | The actual length of the body, which may be larger than the data recorded in Finbourne.Insights.WebApi.Dtos.Response.Body  (e.g. if actual Body is large, or not convertible to a string) | [optional] 
**ContentType** | **string** | The content type | [optional] 
**Body** | **string** | The recorded content. | [optional] 
**BodyWasTruncated** | **bool** | Determines if the recorded body was truncated. | [optional] 
**StatusCode** | **int** | Http Status Code of the request. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

