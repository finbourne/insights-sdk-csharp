# Finbourne.Insights.Sdk.Model.IdentityMetricsDataSet
Identity population and activity counts for the domain, pivoted from the latest tranche the identity metrics provider collected.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of this data set. Always &#x60;IdentityMetrics&#x60;, matching the corresponding Finbourne.Insights.WebApi.Dtos.Metrics.MetricDataSet value and Finbourne.Insights.WebApi.Dtos.Metrics.MetricsResponse property. | 
**CollectedAt** | **DateTimeOffset?** | The timestamp of the tranche these values were collected in, in UTC, or null if no tranche was returned. | [optional] 
**PersonalUsers** | **long?** | The number of personal (human) users in the domain, or null if not reported. | [optional] 
**ServiceUsers** | **long?** | The number of service users in the domain, or null if not reported. | [optional] 
**NeverLoggedIn** | **long?** | The number of users that have never logged in, or null if not reported. | [optional] 
**Ignored** | **long?** | The number of users excluded from the other counts, or null if not reported. | [optional] 
**AccountLocked** | **long?** | The number of users whose account is locked, or null if not reported. | [optional] 
**SuspendedPwReset** | **long?** | The number of users suspended pending a password reset, or null if not reported. | [optional] 
**CreatedLast24Hours** | **long?** | The number of users created in the last 24 hours, or null if not reported. | [optional] 
**CreatedLast7Days** | **long?** | The number of users created in the last 7 days, or null if not reported. | [optional] 
**CreatedLast30Days** | **long?** | The number of users created in the last 30 days, or null if not reported. | [optional] 
**ActiveLast24Hours** | **long?** | The number of users active in the last 24 hours, or null if not reported. | [optional] 
**ActiveLast7Days** | **long?** | The number of users active in the last 7 days, or null if not reported. | [optional] 
**ActiveLast30Days** | **long?** | The number of users active in the last 30 days, or null if not reported. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string name = "name";

IdentityMetricsDataSet identityMetricsDataSetInstance = new IdentityMetricsDataSet(
    name: name,
    collectedAt: collectedAt,
    personalUsers: personalUsers,
    serviceUsers: serviceUsers,
    neverLoggedIn: neverLoggedIn,
    ignored: ignored,
    accountLocked: accountLocked,
    suspendedPwReset: suspendedPwReset,
    createdLast24Hours: createdLast24Hours,
    createdLast7Days: createdLast7Days,
    createdLast30Days: createdLast30Days,
    activeLast24Hours: activeLast24Hours,
    activeLast7Days: activeLast7Days,
    activeLast30Days: activeLast30Days);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
