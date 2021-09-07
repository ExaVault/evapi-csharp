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
    /// Information for the email list, including its short title and recipient emails
    /// </summary>
    [DataContract]
        public partial class EmailListAttributes :  IEquatable<EmailListAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailListAttributes" /> class.
        /// </summary>
        /// <param name="name">Short title for email list.</param>
        /// <param name="emails">Recipient emails in the email list.</param>
        /// <param name="created">Created datetime.</param>
        /// <param name="modified">Modified datetime.</param>
        /// <param name="note">This will be any option notes to help you define what the list is for..</param>
        public EmailListAttributes(string name = default(string), List<string> emails = default(List<string>), DateTime? created = default(DateTime?), DateTime? modified = default(DateTime?), string note = default(string))
        {
            this.Name = name;
            this.Emails = emails;
            this.Created = created;
            this.Modified = modified;
            this.Note = note;
        }
        
        /// <summary>
        /// Short title for email list
        /// </summary>
        /// <value>Short title for email list</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Recipient emails in the email list
        /// </summary>
        /// <value>Recipient emails in the email list</value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Created datetime
        /// </summary>
        /// <value>Created datetime</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Modified datetime
        /// </summary>
        /// <value>Modified datetime</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// This will be any option notes to help you define what the list is for.
        /// </summary>
        /// <value>This will be any option notes to help you define what the list is for.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailListAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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
            return this.Equals(input as EmailListAttributes);
        }

        /// <summary>
        /// Returns true if EmailListAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailListAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailListAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
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
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
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
