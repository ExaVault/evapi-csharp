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
    /// SessionActivityEntryAttributes
    /// </summary>
    [DataContract]
        public partial class SessionActivityEntryAttributes :  IEquatable<SessionActivityEntryAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionActivityEntryAttributes" /> class.
        /// </summary>
        /// <param name="bytesTransferred">bytesTransferred.</param>
        /// <param name="created">created.</param>
        /// <param name="duration">duration.</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="fileSource">fileSource.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="operation">operation.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="status">status.</param>
        /// <param name="username">username.</param>
        public SessionActivityEntryAttributes(long? bytesTransferred = default(long?), string created = default(string), int? duration = default(int?), string fileName = default(string), string fileSource = default(string), string ipAddress = default(string), string operation = default(string), string protocol = default(string), string sessionId = default(string), string status = default(string), string username = default(string))
        {
            this.BytesTransferred = bytesTransferred;
            this.Created = created;
            this.Duration = duration;
            this.FileName = fileName;
            this.FileSource = fileSource;
            this.IpAddress = ipAddress;
            this.Operation = operation;
            this.Protocol = protocol;
            this.SessionId = sessionId;
            this.Status = status;
            this.Username = username;
        }
        
        /// <summary>
        /// Gets or Sets BytesTransferred
        /// </summary>
        [DataMember(Name="bytesTransferred", EmitDefaultValue=false)]
        public long? BytesTransferred { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets FileSource
        /// </summary>
        [DataMember(Name="fileSource", EmitDefaultValue=false)]
        public string FileSource { get; set; }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionActivityEntryAttributes {\n");
            sb.Append("  BytesTransferred: ").Append(BytesTransferred).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FileSource: ").Append(FileSource).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as SessionActivityEntryAttributes);
        }

        /// <summary>
        /// Returns true if SessionActivityEntryAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionActivityEntryAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionActivityEntryAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BytesTransferred == input.BytesTransferred ||
                    (this.BytesTransferred != null &&
                    this.BytesTransferred.Equals(input.BytesTransferred))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.FileSource == input.FileSource ||
                    (this.FileSource != null &&
                    this.FileSource.Equals(input.FileSource))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.BytesTransferred != null)
                    hashCode = hashCode * 59 + this.BytesTransferred.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FileSource != null)
                    hashCode = hashCode * 59 + this.FileSource.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
