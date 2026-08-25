# Finbourne.Insights.Sdk.Model.QueryRequestLogsRequest
Body of the QueryRequestLogs endpoint. A query is bounded by a time range (Finbourne.Insights.WebApi.Dtos.QueryRequestLogsRequest.StartAt/Finbourne.Insights.WebApi.Dtos.QueryRequestLogsRequest.EndAt) and refined by an optional set of Finbourne.Insights.WebApi.Dtos.QueryRequestLogsRequest.Filters that are combined with logical AND. The discoverable set of filterable fields, their data types and the operations available for each is returned by the queryable-fields metadata endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartAt** | **DateTimeOffset?** | The inclusive start of the time range to query. Required unless Finbourne.Insights.WebApi.Dtos.QueryRequestLogsRequest.Page is supplied. Used to bound the underlying partition scan, so a tighter range is cheaper and faster. | [optional] 
**EndAt** | **DateTimeOffset?** | The end of the time range to query. Required unless Finbourne.Insights.WebApi.Dtos.QueryRequestLogsRequest.Page or Finbourne.Insights.WebApi.Dtos.QueryRequestLogsRequest.TimeRange is supplied. | [optional] 
**TimeRange** | [**TimeRange**](TimeRange.md) |  | [optional] 
**Filters** | [**List&lt;InsightsFilter&gt;**](InsightsFilter.md) | Optional filters to apply, combined with logical AND. Each filter targets a filterable field and supplies exactly one comparator matching that field&#39;s data type. | [optional] 
**SortBy** | **string** | Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName. | [optional] 
**MaxResults** | **int?** | The maximum total number of records to capture in the result set; applied as the Luminesce query limit and so bounding the work the query performs. The minimum value is 1 and the maximum is 10000; defaults to 500 when not supplied. The per-page limit then controls how many of these captured records are returned per page. | [optional] 
**Limit** | **int** | When paginating, only return this number of records per page. The minimum value is 0 (return all captured records in a single page) and the maximum is 10000. | [optional] 
**Page** | **string** | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, the query-defining fields should not be supplied. | [optional] 
**Fields** | **List&lt;string&gt;** | Optional list of additional field names to include in the response. The fields Timestamp, Id, Application and Operation are always returned. Values are matched case-insensitively against the queryable fields of the request logs. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

TimeRange? timeRange = new TimeRange();

List<InsightsFilter> filters = new List<InsightsFilter>();
string sortBy = "example sortBy";
string page = "example page";
List<string> fields = new List<string>();

QueryRequestLogsRequest queryRequestLogsRequestInstance = new QueryRequestLogsRequest(
    startAt: startAt,
    endAt: endAt,
    timeRange: timeRange,
    filters: filters,
    sortBy: sortBy,
    maxResults: maxResults,
    limit: limit,
    page: page,
    fields: fields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
