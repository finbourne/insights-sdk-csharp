# Finbourne.Insights.Sdk.Model.TimeRange
A server-resolved time window for a query, as an alternative to supplying absolute StartAt/EndAt. Supply either a Finbourne.Insights.WebApi.Dtos.Querying.TimeRange.Preset (e.g. LastWeek, CurrentMonth) or a relative range via Finbourne.Insights.WebApi.Dtos.Querying.TimeRange.From and Finbourne.Insights.WebApi.Dtos.Querying.TimeRange.To. The window is resolved on the server at query time, so a saved query re-runs against a sliding window. Calendar boundaries are anchored in Finbourne.Insights.WebApi.Dtos.Querying.TimeRange.TimeZone (default UTC); weeks start on Monday.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Preset** | **string** | A named preset window. One of the Finbourne.Insights.WebApi.Dtos.Querying.TimeRangePreset values. Mutually exclusive with Finbourne.Insights.WebApi.Dtos.Querying.TimeRange.From/Finbourne.Insights.WebApi.Dtos.Querying.TimeRange.To. | [optional] 
**From** | [**RelativeBoundary**](RelativeBoundary.md) |  | [optional] 
**To** | [**RelativeBoundary**](RelativeBoundary.md) |  | [optional] 
**VarTimeZone** | **string** | Optional IANA time-zone identifier (e.g. \&quot;Europe/London\&quot;) used to anchor calendar boundaries (start of day/week/month/quarter/year). Defaults to UTC when not supplied. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string preset = "example preset";
RelativeBoundary? from = new RelativeBoundary();

RelativeBoundary? to = new RelativeBoundary();

string varTimeZone = "example varTimeZone";

TimeRange timeRangeInstance = new TimeRange(
    preset: preset,
    from: from,
    to: to,
    varTimeZone: varTimeZone);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
