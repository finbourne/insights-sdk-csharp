# Finbourne.Insights.Sdk.Model.QueryableLogType
The queryable fields of a single log type, returned by the queryable-fields metadata endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LogType** | **string** | The log type, e.g. Requests, Vendor, Access, Trace or TraceEvent. | 
**Fields** | [**List&lt;QueryableLogField&gt;**](QueryableLogField.md) | The fields of this log type that can be selected and/or filtered. | 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;

string logType = "logType";
List<QueryableLogField> fields = new List<QueryableLogField>();

QueryableLogType queryableLogTypeInstance = new QueryableLogType(
    logType: logType,
    fields: fields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
