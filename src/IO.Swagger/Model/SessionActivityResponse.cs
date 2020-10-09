/* 
 * ExaVault API
 *
 * See our API reference documentation at https://www.exavault.com/developer/api-docs/
 *
 * OpenAPI spec version: 2.0
 * Contact: support@exavault.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Session activity list response
    /// </summary>
    [DataContract]
        public partial class SessionActivityResponse :  IEquatable<SessionActivityResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionActivityResponse" /> class.
        /// </summary>
        /// <param name="responseStatus">responseStatus.</param>
        /// <param name="totalResults">totalResults.</param>
        /// <param name="returnedResults">returnedResults.</param>
        /// <param name="data">data.</param>
        public SessionActivityResponse(int? responseStatus = default(int?), int? totalResults = default(int?), int? returnedResults = default(int?), List<SessionActivityEntry> data = default(List<SessionActivityEntry>))
        {
            this.ResponseStatus = responseStatus;
            this.TotalResults = totalResults;
            this.ReturnedResults = returnedResults;
            this.Data = data;
        }
        
        /// <summary>
        /// Gets or Sets ResponseStatus
        /// </summary>
        [DataMember(Name="responseStatus", EmitDefaultValue=false)]
        public int? ResponseStatus { get; set; }

        /// <summary>
        /// Gets or Sets TotalResults
        /// </summary>
        [DataMember(Name="totalResults", EmitDefaultValue=false)]
        public int? TotalResults { get; set; }

        /// <summary>
        /// Gets or Sets ReturnedResults
        /// </summary>
        [DataMember(Name="returnedResults", EmitDefaultValue=false)]
        public int? ReturnedResults { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<SessionActivityEntry> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionActivityResponse {\n");
            sb.Append("  ResponseStatus: ").Append(ResponseStatus).Append("\n");
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  ReturnedResults: ").Append(ReturnedResults).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SessionActivityResponse);
        }

        /// <summary>
        /// Returns true if SessionActivityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionActivityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionActivityResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseStatus == input.ResponseStatus ||
                    (this.ResponseStatus != null &&
                    this.ResponseStatus.Equals(input.ResponseStatus))
                ) && 
                (
                    this.TotalResults == input.TotalResults ||
                    (this.TotalResults != null &&
                    this.TotalResults.Equals(input.TotalResults))
                ) && 
                (
                    this.ReturnedResults == input.ReturnedResults ||
                    (this.ReturnedResults != null &&
                    this.ReturnedResults.Equals(input.ReturnedResults))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.ResponseStatus != null)
                    hashCode = hashCode * 59 + this.ResponseStatus.GetHashCode();
                if (this.TotalResults != null)
                    hashCode = hashCode * 59 + this.TotalResults.GetHashCode();
                if (this.ReturnedResults != null)
                    hashCode = hashCode * 59 + this.ReturnedResults.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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