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
    /// BrandingSettings1
    /// </summary>
    [DataContract]
        public partial class BrandingSettings1 :  IEquatable<BrandingSettings1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandingSettings1" /> class.
        /// </summary>
        /// <param name="companyName">Custom company name to include in copyright and title bar..</param>
        /// <param name="customEmail">Address to use as sender of email messages generated by ExaVault.</param>
        /// <param name="theme">Color scheme for web file manager. Valid options are **default**, **light** and **dark**.</param>
        public BrandingSettings1(string companyName = default(string), string customEmail = default(string), string theme = default(string))
        {
            this.CompanyName = companyName;
            this.CustomEmail = customEmail;
            this.Theme = theme;
        }
        
        /// <summary>
        /// Custom company name to include in copyright and title bar.
        /// </summary>
        /// <value>Custom company name to include in copyright and title bar.</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Address to use as sender of email messages generated by ExaVault
        /// </summary>
        /// <value>Address to use as sender of email messages generated by ExaVault</value>
        [DataMember(Name="customEmail", EmitDefaultValue=false)]
        public string CustomEmail { get; set; }

        /// <summary>
        /// Color scheme for web file manager. Valid options are **default**, **light** and **dark**
        /// </summary>
        /// <value>Color scheme for web file manager. Valid options are **default**, **light** and **dark**</value>
        [DataMember(Name="theme", EmitDefaultValue=false)]
        public string Theme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandingSettings1 {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CustomEmail: ").Append(CustomEmail).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
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
            return this.Equals(input as BrandingSettings1);
        }

        /// <summary>
        /// Returns true if BrandingSettings1 instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandingSettings1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandingSettings1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.CustomEmail == input.CustomEmail ||
                    (this.CustomEmail != null &&
                    this.CustomEmail.Equals(input.CustomEmail))
                ) && 
                (
                    this.Theme == input.Theme ||
                    (this.Theme != null &&
                    this.Theme.Equals(input.Theme))
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
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.CustomEmail != null)
                    hashCode = hashCode * 59 + this.CustomEmail.GetHashCode();
                if (this.Theme != null)
                    hashCode = hashCode * 59 + this.Theme.GetHashCode();
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