# Finbourne.Insights.Sdk.Model.Bucket
A single histogram bucket.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTime** | **DateTimeOffset** | The bucket&#39;s start time as a DateTimeOffset. | [optional] 
**ItemCount** | **long** | The number of items in the bucket. | [optional] 

```csharp
using Finbourne.Insights.Sdk.Model;
using System;


Bucket bucketInstance = new Bucket(
    startTime: startTime,
    itemCount: itemCount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
