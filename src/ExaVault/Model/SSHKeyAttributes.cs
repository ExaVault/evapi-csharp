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
    /// SSHKeyAttributes
    /// </summary>
    [DataContract]
        public partial class SSHKeyAttributes :  IEquatable<SSHKeyAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SSHKeyAttributes" /> class.
        /// </summary>
        /// <param name="fingerprint">The Key Fingerprint. The fingerprint can be used to identify and keep track of the key without exposing the actual credential. .</param>
        /// <param name="lastLogin">The date-time the SSH Key was last used to access ExaVault. .</param>
        /// <param name="created">The date-time the SSH Key was created..</param>
        public SSHKeyAttributes(string fingerprint = default(string), DateTime? lastLogin = default(DateTime?), DateTime? created = default(DateTime?))
        {
            this.Fingerprint = fingerprint;
            this.LastLogin = lastLogin;
            this.Created = created;
        }
        
        /// <summary>
        /// The Key Fingerprint. The fingerprint can be used to identify and keep track of the key without exposing the actual credential. 
        /// </summary>
        /// <value>The Key Fingerprint. The fingerprint can be used to identify and keep track of the key without exposing the actual credential. </value>
        [DataMember(Name="fingerprint", EmitDefaultValue=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// The date-time the SSH Key was last used to access ExaVault. 
        /// </summary>
        /// <value>The date-time the SSH Key was last used to access ExaVault. </value>
        [DataMember(Name="lastLogin", EmitDefaultValue=false)]
        public DateTime? LastLogin { get; set; }

        /// <summary>
        /// The date-time the SSH Key was created.
        /// </summary>
        /// <value>The date-time the SSH Key was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SSHKeyAttributes {\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
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
            return this.Equals(input as SSHKeyAttributes);
        }

        /// <summary>
        /// Returns true if SSHKeyAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of SSHKeyAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SSHKeyAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
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
                if (this.Fingerprint != null)
                    hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.LastLogin != null)
                    hashCode = hashCode * 59 + this.LastLogin.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
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
