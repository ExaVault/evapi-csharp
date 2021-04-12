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
    /// WebhookV2EventData
    /// </summary>
    [DataContract]
        public partial class WebhookV2EventData :  IEquatable<WebhookV2EventData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookV2EventData" /> class.
        /// </summary>
        /// <param name="resources">resources.</param>
        /// <param name="formDetails">formDetails.</param>
        /// <param name="share">share.</param>
        /// <param name="transferStatus">For uploads, and downloads, whether the file transferred OK. &#x60;success&#x60; means the transfer did not have errors.</param>
        public WebhookV2EventData(List<WebhookV2EventDataResources> resources = default(List<WebhookV2EventDataResources>), List<Object> formDetails = default(List<Object>), List<WebhookV2EventDataShare> share = default(List<WebhookV2EventDataShare>), string transferStatus = default(string))
        {
            this.Resources = resources;
            this.FormDetails = formDetails;
            this.Share = share;
            this.TransferStatus = transferStatus;
        }
        
        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public List<WebhookV2EventDataResources> Resources { get; set; }

        /// <summary>
        /// Gets or Sets FormDetails
        /// </summary>
        [DataMember(Name="formDetails", EmitDefaultValue=false)]
        public List<Object> FormDetails { get; set; }

        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name="share", EmitDefaultValue=false)]
        public List<WebhookV2EventDataShare> Share { get; set; }

        /// <summary>
        /// For uploads, and downloads, whether the file transferred OK. &#x60;success&#x60; means the transfer did not have errors
        /// </summary>
        /// <value>For uploads, and downloads, whether the file transferred OK. &#x60;success&#x60; means the transfer did not have errors</value>
        [DataMember(Name="transferStatus", EmitDefaultValue=false)]
        public string TransferStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookV2EventData {\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  FormDetails: ").Append(FormDetails).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  TransferStatus: ").Append(TransferStatus).Append("\n");
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
            return this.Equals(input as WebhookV2EventData);
        }

        /// <summary>
        /// Returns true if WebhookV2EventData instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookV2EventData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookV2EventData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.FormDetails == input.FormDetails ||
                    this.FormDetails != null &&
                    input.FormDetails != null &&
                    this.FormDetails.SequenceEqual(input.FormDetails)
                ) && 
                (
                    this.Share == input.Share ||
                    this.Share != null &&
                    input.Share != null &&
                    this.Share.SequenceEqual(input.Share)
                ) && 
                (
                    this.TransferStatus == input.TransferStatus ||
                    (this.TransferStatus != null &&
                    this.TransferStatus.Equals(input.TransferStatus))
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
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.FormDetails != null)
                    hashCode = hashCode * 59 + this.FormDetails.GetHashCode();
                if (this.Share != null)
                    hashCode = hashCode * 59 + this.Share.GetHashCode();
                if (this.TransferStatus != null)
                    hashCode = hashCode * 59 + this.TransferStatus.GetHashCode();
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
