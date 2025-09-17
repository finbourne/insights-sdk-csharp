# Finbourne.Insights.Sdk.Model.AccessEvaluationLog
Holds logged information about an access check performed on an API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTimeOffset** | The timestamp of the access evaluation. | 
**Application** | **string** | The name of the application that the request was made from. | 
**Id** | **string** | The ID of the access evaluation. | 
**RequestId** | **string** | The identifier of the request. | [optional] 
**SessionId** | **string** | The identifier of the session that the request was made in. | [optional] 
**User** | **string** | The user who made the request. | 
**UserType** | **string** | The type of the user who made the request. | [optional] 
**Duration** | **decimal** | The duration of the access evaluation. | 
**Result** | **string** | The result of the access evaluation. | [optional] 
**AuthoritativeRoleId** | **string** | The role that matched the access evaluation to provide a result. | [optional] 
**AuthoritativePolicyId** | **string** | The policy that matched the access evaluation to provide a result. | [optional] 
**AuthoritativeSelector** | **string** | The selector that matched the access evaluation to provide a result. | [optional] 
**ResourceType** | **string** | The type of the resource that the access evaluation is for. | [optional] 
**Action** | **string** | The action key of the access evaluation. | [optional] 
**Resource** | **Dictionary&lt;string, string&gt;** | The ID of the resource that the access evaluation is for. If the ResourceID could not be converted to a dictionary, it will return a single-value dictionary with the key \&quot;resourceId\&quot;. | [optional] 
**ResourceFromEffectiveDate** | **string** | The From effective date of the resource. | [optional] 
**ResourceToEffectiveDate** | **string** | The To effective date of the resource. | [optional] 
**ResourceFromAsAt** | **string** | The From AsAt date of the resource. | [optional] 
**ResourceToAsAt** | **string** | The To AsAt date of the resource. | [optional] 
**AccessExecutionTime** | **string** | The execution time of the entitlement. | [optional] 
**AccessAsAtTime** | **string** | The AsAt time of the entitlement. | [optional] 
**RequiredLicencePolicyId** | **string** | ID of the required licence policy. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string application = "application";
string id = "id";
string requestId = "example requestId";
string sessionId = "example sessionId";
string user = "user";
string userType = "example userType";decimal duration = "duration";

string result = "example result";
string authoritativeRoleId = "example authoritativeRoleId";
string authoritativePolicyId = "example authoritativePolicyId";
string authoritativeSelector = "example authoritativeSelector";
string resourceType = "example resourceType";
string action = "example action";
Dictionary<string, string> resource = new Dictionary<string, string>();
string resourceFromEffectiveDate = "example resourceFromEffectiveDate";
string resourceToEffectiveDate = "example resourceToEffectiveDate";
string resourceFromAsAt = "example resourceFromAsAt";
string resourceToAsAt = "example resourceToAsAt";
string accessExecutionTime = "example accessExecutionTime";
string accessAsAtTime = "example accessAsAtTime";
string requiredLicencePolicyId = "example requiredLicencePolicyId";
List<Link> links = new List<Link>();

AccessEvaluationLog accessEvaluationLogInstance = new AccessEvaluationLog(
    timestamp: timestamp,
    application: application,
    id: id,
    requestId: requestId,
    sessionId: sessionId,
    user: user,
    userType: userType,
    duration: duration,
    result: result,
    authoritativeRoleId: authoritativeRoleId,
    authoritativePolicyId: authoritativePolicyId,
    authoritativeSelector: authoritativeSelector,
    resourceType: resourceType,
    action: action,
    resource: resource,
    resourceFromEffectiveDate: resourceFromEffectiveDate,
    resourceToEffectiveDate: resourceToEffectiveDate,
    resourceFromAsAt: resourceFromAsAt,
    resourceToAsAt: resourceToAsAt,
    accessExecutionTime: accessExecutionTime,
    accessAsAtTime: accessAsAtTime,
    requiredLicencePolicyId: requiredLicencePolicyId,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
