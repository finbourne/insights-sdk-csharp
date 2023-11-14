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
    /// AuditProcessSummary
    /// </summary>
    [DataContract(Name = "AuditProcessSummary")]
    public partial class AuditProcessSummary : IEquatable<AuditProcessSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditProcessSummary" /> class.
        /// </summary>
        /// <param name="process">process.</param>
        /// <param name="latestEntry">latestEntry.</param>
        /// <param name="summary">summary.</param>
        public AuditProcessSummary(AuditProcess process = default(AuditProcess), AuditData latestEntry = default(AuditData), AuditDataSummary summary = default(AuditDataSummary))
        {
            this.Process = process;
            this.LatestEntry = latestEntry;
            this.Summary = summary;
        }

        /// <summary>
        /// Gets or Sets Process
        /// </summary>
        [DataMember(Name = "process", EmitDefaultValue = false)]
        public AuditProcess Process { get; set; }

        /// <summary>
        /// Gets or Sets LatestEntry
        /// </summary>
        [DataMember(Name = "latestEntry", EmitDefaultValue = false)]
        public AuditData LatestEntry { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public AuditDataSummary Summary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuditProcessSummary {\n");
            sb.Append("  Process: ").Append(Process).Append("\n");
            sb.Append("  LatestEntry: ").Append(LatestEntry).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
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
            return this.Equals(input as AuditProcessSummary);
        }

        /// <summary>
        /// Returns true if AuditProcessSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditProcessSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditProcessSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Process == input.Process ||
                    (this.Process != null &&
                    this.Process.Equals(input.Process))
                ) && 
                (
                    this.LatestEntry == input.LatestEntry ||
                    (this.LatestEntry != null &&
                    this.LatestEntry.Equals(input.LatestEntry))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
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
                if (this.Process != null)
                {
                    hashCode = (hashCode * 59) + this.Process.GetHashCode();
                }
                if (this.LatestEntry != null)
                {
                    hashCode = (hashCode * 59) + this.LatestEntry.GetHashCode();
                }
                if (this.Summary != null)
                {
                    hashCode = (hashCode * 59) + this.Summary.GetHashCode();
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
            yield break;
        }
    }
}