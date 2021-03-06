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
    /// Attributes of the form including it&#x27;s included fields and css styles
    /// </summary>
    [DataContract]
        public partial class FormAttributes :  IEquatable<FormAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormAttributes" /> class.
        /// </summary>
        /// <param name="formDescription">Text that appears at the top of a receive form.</param>
        /// <param name="submitButtonText">Text that appears on the submit button for the form.</param>
        /// <param name="successMessage">Message displayed to submitter after files are uploaded.</param>
        /// <param name="cssStyles">CSS Styles of the form..</param>
        /// <param name="elements">Array of form fields defined for the form.</param>
        public FormAttributes(string formDescription = default(string), string submitButtonText = default(string), string successMessage = default(string), string cssStyles = default(string), List<FormField> elements = default(List<FormField>))
        {
            this.FormDescription = formDescription;
            this.SubmitButtonText = submitButtonText;
            this.SuccessMessage = successMessage;
            this.CssStyles = cssStyles;
            this.Elements = elements;
        }
        
        /// <summary>
        /// Text that appears at the top of a receive form
        /// </summary>
        /// <value>Text that appears at the top of a receive form</value>
        [DataMember(Name="formDescription", EmitDefaultValue=false)]
        public string FormDescription { get; set; }

        /// <summary>
        /// Text that appears on the submit button for the form
        /// </summary>
        /// <value>Text that appears on the submit button for the form</value>
        [DataMember(Name="submitButtonText", EmitDefaultValue=false)]
        public string SubmitButtonText { get; set; }

        /// <summary>
        /// Message displayed to submitter after files are uploaded
        /// </summary>
        /// <value>Message displayed to submitter after files are uploaded</value>
        [DataMember(Name="successMessage", EmitDefaultValue=false)]
        public string SuccessMessage { get; set; }

        /// <summary>
        /// CSS Styles of the form.
        /// </summary>
        /// <value>CSS Styles of the form.</value>
        [DataMember(Name="cssStyles", EmitDefaultValue=false)]
        public string CssStyles { get; set; }

        /// <summary>
        /// Array of form fields defined for the form
        /// </summary>
        /// <value>Array of form fields defined for the form</value>
        [DataMember(Name="elements", EmitDefaultValue=false)]
        public List<FormField> Elements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormAttributes {\n");
            sb.Append("  FormDescription: ").Append(FormDescription).Append("\n");
            sb.Append("  SubmitButtonText: ").Append(SubmitButtonText).Append("\n");
            sb.Append("  SuccessMessage: ").Append(SuccessMessage).Append("\n");
            sb.Append("  CssStyles: ").Append(CssStyles).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
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
            return this.Equals(input as FormAttributes);
        }

        /// <summary>
        /// Returns true if FormAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of FormAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FormDescription == input.FormDescription ||
                    (this.FormDescription != null &&
                    this.FormDescription.Equals(input.FormDescription))
                ) && 
                (
                    this.SubmitButtonText == input.SubmitButtonText ||
                    (this.SubmitButtonText != null &&
                    this.SubmitButtonText.Equals(input.SubmitButtonText))
                ) && 
                (
                    this.SuccessMessage == input.SuccessMessage ||
                    (this.SuccessMessage != null &&
                    this.SuccessMessage.Equals(input.SuccessMessage))
                ) && 
                (
                    this.CssStyles == input.CssStyles ||
                    (this.CssStyles != null &&
                    this.CssStyles.Equals(input.CssStyles))
                ) && 
                (
                    this.Elements == input.Elements ||
                    this.Elements != null &&
                    input.Elements != null &&
                    this.Elements.SequenceEqual(input.Elements)
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
                if (this.FormDescription != null)
                    hashCode = hashCode * 59 + this.FormDescription.GetHashCode();
                if (this.SubmitButtonText != null)
                    hashCode = hashCode * 59 + this.SubmitButtonText.GetHashCode();
                if (this.SuccessMessage != null)
                    hashCode = hashCode * 59 + this.SuccessMessage.GetHashCode();
                if (this.CssStyles != null)
                    hashCode = hashCode * 59 + this.CssStyles.GetHashCode();
                if (this.Elements != null)
                    hashCode = hashCode * 59 + this.Elements.GetHashCode();
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
