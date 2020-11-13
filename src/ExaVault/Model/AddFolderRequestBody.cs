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
    /// AddFolderRequestBody
    /// </summary>
    [DataContract]
        public partial class AddFolderRequestBody :  IEquatable<AddFolderRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddFolderRequestBody" /> class.
        /// </summary>
        /// <param name="path">Path to the newly created folder including new ame.</param>
        /// <param name="name">Name of the folder to create. Required if **path** is not used.</param>
        /// <param name="parentResource">Resource identifier where to create a folder. Required if **path** is not used.</param>
        public AddFolderRequestBody(string path = default(string), string name = default(string), string parentResource = default(string))
        {
            this.Path = path;
            this.Name = name;
            this.ParentResource = parentResource;
        }
        
        /// <summary>
        /// Path to the newly created folder including new ame
        /// </summary>
        /// <value>Path to the newly created folder including new ame</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Name of the folder to create. Required if **path** is not used
        /// </summary>
        /// <value>Name of the folder to create. Required if **path** is not used</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Resource identifier where to create a folder. Required if **path** is not used
        /// </summary>
        /// <value>Resource identifier where to create a folder. Required if **path** is not used</value>
        [DataMember(Name="parentResource", EmitDefaultValue=false)]
        public string ParentResource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddFolderRequestBody {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentResource: ").Append(ParentResource).Append("\n");
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
            return this.Equals(input as AddFolderRequestBody);
        }

        /// <summary>
        /// Returns true if AddFolderRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of AddFolderRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddFolderRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParentResource == input.ParentResource ||
                    (this.ParentResource != null &&
                    this.ParentResource.Equals(input.ParentResource))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParentResource != null)
                    hashCode = hashCode * 59 + this.ParentResource.GetHashCode();
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
