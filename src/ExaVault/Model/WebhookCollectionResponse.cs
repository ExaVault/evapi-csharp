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
using SwaggerDateConverter = ExaVault.Client.SwaggerDateConverter;

namespace ExaVault.Model
{
    /// <summary>
    /// WebhookCollectionResponse
    /// </summary>
    [DataContract]
        public partial class WebhookCollectionResponse :  IEquatable<WebhookCollectionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCollectionResponse" /> class.
        /// </summary>
        /// <param name="responseStatus">Http status code of the response. .</param>
        /// <param name="totalResults">Total results found..</param>
        /// <param name="returnedResults">Number of results returned..</param>
        /// <param name="data">data.</param>
        /// <param name="included">included.</param>
        public WebhookCollectionResponse(int? responseStatus = default(int?), int? totalResults = default(int?), int? returnedResults = default(int?), List<Webhook> data = default(List<Webhook>), List<AnyOfWebhookCollectionResponseIncludedItems> included = default(List<AnyOfWebhookCollectionResponseIncludedItems>))
        {
            this.ResponseStatus = responseStatus;
            this.TotalResults = totalResults;
            this.ReturnedResults = returnedResults;
            this.Data = data;
            this.Included = included;
        }
        
        /// <summary>
        /// Http status code of the response. 
        /// </summary>
        /// <value>Http status code of the response. </value>
        [DataMember(Name="responseStatus", EmitDefaultValue=false)]
        public int? ResponseStatus { get; set; }

        /// <summary>
        /// Total results found.
        /// </summary>
        /// <value>Total results found.</value>
        [DataMember(Name="totalResults", EmitDefaultValue=false)]
        public int? TotalResults { get; set; }

        /// <summary>
        /// Number of results returned.
        /// </summary>
        /// <value>Number of results returned.</value>
        [DataMember(Name="returnedResults", EmitDefaultValue=false)]
        public int? ReturnedResults { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<Webhook> Data { get; set; }

        /// <summary>
        /// Gets or Sets Included
        /// </summary>
        [DataMember(Name="included", EmitDefaultValue=false)]
        public List<AnyOfWebhookCollectionResponseIncludedItems> Included { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookCollectionResponse {\n");
            sb.Append("  ResponseStatus: ").Append(ResponseStatus).Append("\n");
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  ReturnedResults: ").Append(ReturnedResults).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
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
            return this.Equals(input as WebhookCollectionResponse);
        }

        /// <summary>
        /// Returns true if WebhookCollectionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookCollectionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookCollectionResponse input)
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
                ) && 
                (
                    this.Included == input.Included ||
                    this.Included != null &&
                    input.Included != null &&
                    this.Included.SequenceEqual(input.Included)
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
                if (this.Included != null)
                    hashCode = hashCode * 59 + this.Included.GetHashCode();
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