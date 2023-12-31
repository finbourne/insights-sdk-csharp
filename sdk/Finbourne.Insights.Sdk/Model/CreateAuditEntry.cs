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
    /// Details to create an audit entry
    /// </summary>
    [DataContract(Name = "CreateAuditEntry")]
    public partial class CreateAuditEntry : IEquatable<CreateAuditEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAuditEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAuditEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAuditEntry" /> class.
        /// </summary>
        /// <param name="process">process (required).</param>
        /// <param name="data">data (required).</param>
        public CreateAuditEntry(AuditProcess process = default(AuditProcess), AuditData data = default(AuditData))
        {
            // to ensure "process" is required (not null)
            if (process == null)
            {
                throw new ArgumentNullException("process is a required property for CreateAuditEntry and cannot be null");
            }
            this.Process = process;
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for CreateAuditEntry and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Process
        /// </summary>
        [DataMember(Name = "process", IsRequired = true, EmitDefaultValue = true)]
        public AuditProcess Process { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public AuditData Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAuditEntry {\n");
            sb.Append("  Process: ").Append(Process).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as CreateAuditEntry);
        }

        /// <summary>
        /// Returns true if CreateAuditEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAuditEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAuditEntry input)
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
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
