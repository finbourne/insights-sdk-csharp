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
    /// AuditProcess
    /// </summary>
    [DataContract(Name = "AuditProcess")]
    public partial class AuditProcess : IEquatable<AuditProcess>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditProcess" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditProcess() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditProcess" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="runId">runId (required).</param>
        /// <param name="startTime">startTime (required).</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="succeeded">succeeded.</param>
        public AuditProcess(string name = default(string), string runId = default(string), DateTimeOffset startTime = default(DateTimeOffset), DateTimeOffset? endTime = default(DateTimeOffset?), bool? succeeded = default(bool?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AuditProcess and cannot be null");
            }
            this.Name = name;
            // to ensure "runId" is required (not null)
            if (runId == null)
            {
                throw new ArgumentNullException("runId is a required property for AuditProcess and cannot be null");
            }
            this.RunId = runId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Succeeded = succeeded;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RunId
        /// </summary>
        [DataMember(Name = "runId", IsRequired = true, EmitDefaultValue = true)]
        public string RunId { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = true)]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Succeeded
        /// </summary>
        [DataMember(Name = "succeeded", EmitDefaultValue = true)]
        public bool? Succeeded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuditProcess {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
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
            return this.Equals(input as AuditProcess);
        }

        /// <summary>
        /// Returns true if AuditProcess instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditProcess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditProcess input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RunId == input.RunId ||
                    (this.RunId != null &&
                    this.RunId.Equals(input.RunId))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Succeeded == input.Succeeded ||
                    (this.Succeeded != null &&
                    this.Succeeded.Equals(input.Succeeded))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.RunId != null)
                {
                    hashCode = (hashCode * 59) + this.RunId.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.Succeeded != null)
                {
                    hashCode = (hashCode * 59) + this.Succeeded.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            // RunId (string) minLength
            if (this.RunId != null && this.RunId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RunId, length must be greater than 1.", new [] { "RunId" });
            }

            yield break;
        }
    }
}
