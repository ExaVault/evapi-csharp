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
    /// AddSSHKeyRequestBody
    /// </summary>
    [DataContract]
        public partial class AddSSHKeyRequestBody :  IEquatable<AddSSHKeyRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddSSHKeyRequestBody" /> class.
        /// </summary>
        /// <param name="userId">ID of the user to assign the new key to.  (required).</param>
        /// <param name="publicKey">Public Key to provide ExaVault. You can provide the Public Key as formatted from the ssh-keygen command or a standard rfc-4716 format.  (required).</param>
        public AddSSHKeyRequestBody(int? userId = default(int?), string publicKey = default(string))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for AddSSHKeyRequestBody and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "publicKey" is required (not null)
            if (publicKey == null)
            {
                throw new InvalidDataException("publicKey is a required property for AddSSHKeyRequestBody and cannot be null");
            }
            else
            {
                this.PublicKey = publicKey;
            }
        }
        
        /// <summary>
        /// ID of the user to assign the new key to. 
        /// </summary>
        /// <value>ID of the user to assign the new key to. </value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Public Key to provide ExaVault. You can provide the Public Key as formatted from the ssh-keygen command or a standard rfc-4716 format. 
        /// </summary>
        /// <value>Public Key to provide ExaVault. You can provide the Public Key as formatted from the ssh-keygen command or a standard rfc-4716 format. </value>
        [DataMember(Name="publicKey", EmitDefaultValue=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddSSHKeyRequestBody {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
            return this.Equals(input as AddSSHKeyRequestBody);
        }

        /// <summary>
        /// Returns true if AddSSHKeyRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of AddSSHKeyRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddSSHKeyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
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
