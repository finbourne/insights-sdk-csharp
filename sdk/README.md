<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://fbn-prd.lusid.com/insights*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccessEvaluationsApi* | [**GetAccessEvaluationLog**](docs/AccessEvaluationsApi.md#getaccessevaluationlog) | **GET** /api/access/{id} | [EARLY ACCESS] GetAccessEvaluationLog: Get the log for a specific access evaluation.  This endpoint will be deprecated in the near future.
*AccessEvaluationsApi* | [**ListAccessEvaluationLogs**](docs/AccessEvaluationsApi.md#listaccessevaluationlogs) | **GET** /api/access | [EARLY ACCESS] ListAccessEvaluationLogs: List the logs for access evaluations.
*ApplicationMetadataApi* | [**ListAccessControlledResources**](docs/ApplicationMetadataApi.md#listaccesscontrolledresources) | **GET** /api/metadata/access/resources | ListAccessControlledResources: Get resources available for access control
*AuditingApi* | [**CreateEntry**](docs/AuditingApi.md#createentry) | **POST** /api/auditing/entries | [EARLY ACCESS] CreateEntry: Create (persist) and audit entry..
*AuditingApi* | [**GetProcesses**](docs/AuditingApi.md#getprocesses) | **GET** /api/auditing/processes | [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process.
*AuditingApi* | [**ListEntries**](docs/AuditingApi.md#listentries) | **GET** /api/auditing/entries | [EARLY ACCESS] ListEntries: Get the audit entries.
*CandelaTracesApi* | [**GetTraceLog**](docs/CandelaTracesApi.md#gettracelog) | **GET** /api/candelatraces/{scope}/{traceId} | [EXPERIMENTAL] GetTraceLog: Get the log for a specific trace.
*CandelaTracesApi* | [**ListTraceEventLogs**](docs/CandelaTracesApi.md#listtraceeventlogs) | **GET** /api/candelatraces/{scope}/{traceId}/events | [EXPERIMENTAL] ListTraceEventLogs: Get the trace event logs for a specific trace.
*CandelaTracesApi* | [**ListTraceLogs**](docs/CandelaTracesApi.md#listtracelogs) | **GET** /api/candelatraces | [EXPERIMENTAL] ListTraceLogs: Get the logs for traces.
*RequestsApi* | [**GetRequest**](docs/RequestsApi.md#getrequest) | **GET** /api/requests/{id}/request | GetRequest: Get the request content for a specific API request.
*RequestsApi* | [**GetRequestLog**](docs/RequestsApi.md#getrequestlog) | **GET** /api/requests/{id} | GetRequestLog: Get the log for a specific API request.
*RequestsApi* | [**GetResponse**](docs/RequestsApi.md#getresponse) | **GET** /api/requests/{id}/response | GetResponse: Get the response for a specific API request.
*RequestsApi* | [**ListRequestLogs**](docs/RequestsApi.md#listrequestlogs) | **GET** /api/requests | ListRequestLogs: Get the logs for API requests.
*VendorLogsApi* | [**GetVendorLog**](docs/VendorLogsApi.md#getvendorlog) | **GET** /api/vendor/{id} | [EXPERIMENTAL] GetVendorLog: Get the log for a specific vendor request.
*VendorLogsApi* | [**GetVendorRequest**](docs/VendorLogsApi.md#getvendorrequest) | **GET** /api/vendor/{id}/request | [EXPERIMENTAL] GetVendorRequest: Get the request body for a vendor request.
*VendorLogsApi* | [**GetVendorResponse**](docs/VendorLogsApi.md#getvendorresponse) | **GET** /api/vendor/{id}/response | [EXPERIMENTAL] GetVendorResponse: Get the response from a vendor request.
*VendorLogsApi* | [**ListVendorLogs**](docs/VendorLogsApi.md#listvendorlogs) | **GET** /api/vendor | [EXPERIMENTAL] ListVendorLogs: List the logs for vendor requests.


<a id="documentation-for-models"></a>
## Documentation for Models

 - [AccessControlledAction](docs/AccessControlledAction.md)
 - [AccessControlledResource](docs/AccessControlledResource.md)
 - [AccessEvaluationLog](docs/AccessEvaluationLog.md)
 - [ActionId](docs/ActionId.md)
 - [AuditData](docs/AuditData.md)
 - [AuditDataSummary](docs/AuditDataSummary.md)
 - [AuditEntry](docs/AuditEntry.md)
 - [AuditEntryNote](docs/AuditEntryNote.md)
 - [AuditProcess](docs/AuditProcess.md)
 - [AuditProcessSummary](docs/AuditProcessSummary.md)
 - [Bucket](docs/Bucket.md)
 - [CreateAuditEntry](docs/CreateAuditEntry.md)
 - [Histogram](docs/Histogram.md)
 - [IdSelectorDefinition](docs/IdSelectorDefinition.md)
 - [IdentifierPartSchema](docs/IdentifierPartSchema.md)
 - [Link](docs/Link.md)
 - [LusidProblemDetails](docs/LusidProblemDetails.md)
 - [LusidValidationProblemDetails](docs/LusidValidationProblemDetails.md)
 - [ProblemDetails](docs/ProblemDetails.md)
 - [Request](docs/Request.md)
 - [RequestLog](docs/RequestLog.md)
 - [Resource](docs/Resource.md)
 - [ResourceListOfAccessControlledResource](docs/ResourceListOfAccessControlledResource.md)
 - [ResourceListOfAuditProcessSummary](docs/ResourceListOfAuditProcessSummary.md)
 - [ResourceListOfTraceEventLog](docs/ResourceListOfTraceEventLog.md)
 - [ResourceListOfTraceLog](docs/ResourceListOfTraceLog.md)
 - [ResourceListWithHistogramOfAccessEvaluationLog](docs/ResourceListWithHistogramOfAccessEvaluationLog.md)
 - [ResourceListWithHistogramOfRequestLog](docs/ResourceListWithHistogramOfRequestLog.md)
 - [ResourceListWithHistogramOfVendorLog](docs/ResourceListWithHistogramOfVendorLog.md)
 - [Response](docs/Response.md)
 - [ScrollableCollectionOfAuditEntry](docs/ScrollableCollectionOfAuditEntry.md)
 - [TraceEventLog](docs/TraceEventLog.md)
 - [TraceLog](docs/TraceLog.md)
 - [VendorLog](docs/VendorLog.md)
 - [VendorRequest](docs/VendorRequest.md)
 - [VendorResponse](docs/VendorResponse.md)

