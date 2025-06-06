/*
 * FINBOURNE Insights API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Insights.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Insights.Sdk.Model
{
    /// <summary>
    /// Holds logged information about a request performed on an API.
    /// </summary>
    [DataContract(Name = "RequestLog")]
    public partial class RequestLog : IEquatable<RequestLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestLog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLog" /> class.
        /// </summary>
        /// <param name="timestamp">The timestamp of the request. (required).</param>
        /// <param name="application">The name of the application that the request was made to. (required).</param>
        /// <param name="id">The identifier of the request. (required).</param>
        /// <param name="sessionId">The identifier of the session that the request was made in..</param>
        /// <param name="verb">The HTTP verb of the request. (required).</param>
        /// <param name="url">The URL of the request. (required).</param>
        /// <param name="domain">The domain of the request..</param>
        /// <param name="user">The user who made the request. (required).</param>
        /// <param name="userType">The type of the user who made the request..</param>
        /// <param name="operation">The API operation invoked by the request..</param>
        /// <param name="outcome">The outcome of the request: Completed, Errored or Failed. (required).</param>
        /// <param name="duration">The duration of the request in milliseconds. (required).</param>
        /// <param name="httpStatusCode">The status code of the request. (required).</param>
        /// <param name="errorCode">Error code, if the request had a failure or error..</param>
        /// <param name="sdkLanguage">The language of the SDK used..</param>
        /// <param name="sdkVersion">The version of the SDK used..</param>
        /// <param name="sourceApplication">The name of the application that made the request..</param>
        /// <param name="correlationId">The chain of requestIds preceding this request.</param>
        /// <param name="impersonatingUser">The impersonating user. Only present if the request is an impersonated one.</param>
        /// <param name="links">links.</param>
        public RequestLog(DateTimeOffset timestamp = default(DateTimeOffset), string application = default(string), string id = default(string), string sessionId = default(string), string verb = default(string), string url = default(string), string domain = default(string), string user = default(string), string userType = default(string), string operation = default(string), string outcome = default(string), decimal duration = default(decimal), int httpStatusCode = default(int), string errorCode = default(string), string sdkLanguage = default(string), string sdkVersion = default(string), string sourceApplication = default(string), List<string> correlationId = default(List<string>), string impersonatingUser = default(string), List<Link> links = default(List<Link>))
        {
            this.Timestamp = timestamp;
            // to ensure "application" is required (not null)
            if (application == null)
            {
                throw new ArgumentNullException("application is a required property for RequestLog and cannot be null");
            }
            this.Application = application;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for RequestLog and cannot be null");
            }
            this.Id = id;
            // to ensure "verb" is required (not null)
            if (verb == null)
            {
                throw new ArgumentNullException("verb is a required property for RequestLog and cannot be null");
            }
            this.Verb = verb;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for RequestLog and cannot be null");
            }
            this.Url = url;
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new ArgumentNullException("user is a required property for RequestLog and cannot be null");
            }
            this.User = user;
            // to ensure "outcome" is required (not null)
            if (outcome == null)
            {
                throw new ArgumentNullException("outcome is a required property for RequestLog and cannot be null");
            }
            this.Outcome = outcome;
            this.Duration = duration;
            this.HttpStatusCode = httpStatusCode;
            this.SessionId = sessionId;
            this.Domain = domain;
            this.UserType = userType;
            this.Operation = operation;
            this.ErrorCode = errorCode;
            this.SdkLanguage = sdkLanguage;
            this.SdkVersion = sdkVersion;
            this.SourceApplication = sourceApplication;
            this.CorrelationId = correlationId;
            this.ImpersonatingUser = impersonatingUser;
            this.Links = links;
        }

        /// <summary>
        /// The timestamp of the request.
        /// </summary>
        /// <value>The timestamp of the request.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The name of the application that the request was made to.
        /// </summary>
        /// <value>The name of the application that the request was made to.</value>
        [DataMember(Name = "application", IsRequired = true, EmitDefaultValue = true)]
        public string Application { get; set; }

        /// <summary>
        /// The identifier of the request.
        /// </summary>
        /// <value>The identifier of the request.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier of the session that the request was made in.
        /// </summary>
        /// <value>The identifier of the session that the request was made in.</value>
        [DataMember(Name = "sessionId", EmitDefaultValue = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// The HTTP verb of the request.
        /// </summary>
        /// <value>The HTTP verb of the request.</value>
        [DataMember(Name = "verb", IsRequired = true, EmitDefaultValue = true)]
        public string Verb { get; set; }

        /// <summary>
        /// The URL of the request.
        /// </summary>
        /// <value>The URL of the request.</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The domain of the request.
        /// </summary>
        /// <value>The domain of the request.</value>
        [DataMember(Name = "domain", EmitDefaultValue = true)]
        public string Domain { get; set; }

        /// <summary>
        /// The user who made the request.
        /// </summary>
        /// <value>The user who made the request.</value>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// The type of the user who made the request.
        /// </summary>
        /// <value>The type of the user who made the request.</value>
        [DataMember(Name = "userType", EmitDefaultValue = true)]
        public string UserType { get; set; }

        /// <summary>
        /// The API operation invoked by the request.
        /// </summary>
        /// <value>The API operation invoked by the request.</value>
        [DataMember(Name = "operation", EmitDefaultValue = true)]
        public string Operation { get; set; }

        /// <summary>
        /// The outcome of the request: Completed, Errored or Failed.
        /// </summary>
        /// <value>The outcome of the request: Completed, Errored or Failed.</value>
        [DataMember(Name = "outcome", IsRequired = true, EmitDefaultValue = true)]
        public string Outcome { get; set; }

        /// <summary>
        /// The duration of the request in milliseconds.
        /// </summary>
        /// <value>The duration of the request in milliseconds.</value>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public decimal Duration { get; set; }

        /// <summary>
        /// The status code of the request.
        /// </summary>
        /// <value>The status code of the request.</value>
        [DataMember(Name = "httpStatusCode", IsRequired = true, EmitDefaultValue = true)]
        public int HttpStatusCode { get; set; }

        /// <summary>
        /// Error code, if the request had a failure or error.
        /// </summary>
        /// <value>Error code, if the request had a failure or error.</value>
        [DataMember(Name = "errorCode", EmitDefaultValue = true)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The language of the SDK used.
        /// </summary>
        /// <value>The language of the SDK used.</value>
        [DataMember(Name = "sdkLanguage", EmitDefaultValue = true)]
        public string SdkLanguage { get; set; }

        /// <summary>
        /// The version of the SDK used.
        /// </summary>
        /// <value>The version of the SDK used.</value>
        [DataMember(Name = "sdkVersion", EmitDefaultValue = true)]
        public string SdkVersion { get; set; }

        /// <summary>
        /// The name of the application that made the request.
        /// </summary>
        /// <value>The name of the application that made the request.</value>
        [DataMember(Name = "sourceApplication", EmitDefaultValue = true)]
        public string SourceApplication { get; set; }

        /// <summary>
        /// The chain of requestIds preceding this request
        /// </summary>
        /// <value>The chain of requestIds preceding this request</value>
        [DataMember(Name = "correlationId", EmitDefaultValue = true)]
        public List<string> CorrelationId { get; set; }

        /// <summary>
        /// The impersonating user. Only present if the request is an impersonated one
        /// </summary>
        /// <value>The impersonating user. Only present if the request is an impersonated one</value>
        [DataMember(Name = "impersonatingUser", EmitDefaultValue = true)]
        public string ImpersonatingUser { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestLog {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  Verb: ").Append(Verb).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  SdkLanguage: ").Append(SdkLanguage).Append("\n");
            sb.Append("  SdkVersion: ").Append(SdkVersion).Append("\n");
            sb.Append("  SourceApplication: ").Append(SourceApplication).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  ImpersonatingUser: ").Append(ImpersonatingUser).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequestLog);
        }

        /// <summary>
        /// Returns true if RequestLog instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestLog input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.Verb == input.Verb ||
                    (this.Verb != null &&
                    this.Verb.Equals(input.Verb))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.UserType == input.UserType ||
                    (this.UserType != null &&
                    this.UserType.Equals(input.UserType))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Outcome == input.Outcome ||
                    (this.Outcome != null &&
                    this.Outcome.Equals(input.Outcome))
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.HttpStatusCode == input.HttpStatusCode ||
                    this.HttpStatusCode.Equals(input.HttpStatusCode)
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.SdkLanguage == input.SdkLanguage ||
                    (this.SdkLanguage != null &&
                    this.SdkLanguage.Equals(input.SdkLanguage))
                ) && 
                (
                    this.SdkVersion == input.SdkVersion ||
                    (this.SdkVersion != null &&
                    this.SdkVersion.Equals(input.SdkVersion))
                ) && 
                (
                    this.SourceApplication == input.SourceApplication ||
                    (this.SourceApplication != null &&
                    this.SourceApplication.Equals(input.SourceApplication))
                ) && 
                (
                    this.CorrelationId == input.CorrelationId ||
                    this.CorrelationId != null &&
                    input.CorrelationId != null &&
                    this.CorrelationId.SequenceEqual(input.CorrelationId)
                ) && 
                (
                    this.ImpersonatingUser == input.ImpersonatingUser ||
                    (this.ImpersonatingUser != null &&
                    this.ImpersonatingUser.Equals(input.ImpersonatingUser))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.Application != null)
                {
                    hashCode = (hashCode * 59) + this.Application.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.SessionId != null)
                {
                    hashCode = (hashCode * 59) + this.SessionId.GetHashCode();
                }
                if (this.Verb != null)
                {
                    hashCode = (hashCode * 59) + this.Verb.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.UserType != null)
                {
                    hashCode = (hashCode * 59) + this.UserType.GetHashCode();
                }
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                }
                if (this.Outcome != null)
                {
                    hashCode = (hashCode * 59) + this.Outcome.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                hashCode = (hashCode * 59) + this.HttpStatusCode.GetHashCode();
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.SdkLanguage != null)
                {
                    hashCode = (hashCode * 59) + this.SdkLanguage.GetHashCode();
                }
                if (this.SdkVersion != null)
                {
                    hashCode = (hashCode * 59) + this.SdkVersion.GetHashCode();
                }
                if (this.SourceApplication != null)
                {
                    hashCode = (hashCode * 59) + this.SourceApplication.GetHashCode();
                }
                if (this.CorrelationId != null)
                {
                    hashCode = (hashCode * 59) + this.CorrelationId.GetHashCode();
                }
                if (this.ImpersonatingUser != null)
                {
                    hashCode = (hashCode * 59) + this.ImpersonatingUser.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Application (string) minLength
            if (this.Application != null && this.Application.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Application, length must be greater than 1.", new [] { "Application" });
            }

            // Id (string) minLength
            if (this.Id != null && this.Id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            // Verb (string) minLength
            if (this.Verb != null && this.Verb.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Verb, length must be greater than 1.", new [] { "Verb" });
            }

            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }

            // User (string) minLength
            if (this.User != null && this.User.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for User, length must be greater than 1.", new [] { "User" });
            }

            // Outcome (string) minLength
            if (this.Outcome != null && this.Outcome.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Outcome, length must be greater than 1.", new [] { "Outcome" });
            }

            yield break;
        }
    }
}
