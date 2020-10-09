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
    /// Body17
    /// </summary>
    [DataContract]
        public partial class Body17 :  IEquatable<Body17>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body17" /> class.
        /// </summary>
        /// <param name="name">Name of the share..</param>
        /// <param name="resources">Array of resources for this share. See details on [how to specify resources](#section/Identifying-Resources) above.  **shared_folder** and **receive** shares must have only one &#x60;resource&#x60;, which is a directory that does not have a current share attached.  **send** shares may have multiple &#x60;resource&#x60; parameters.   **NOTE**: Sending this parameter will **REPLACE** the existing resources with the resources included in this request..</param>
        /// <param name="accessMode">What visitors who view this share can do. Valid options include **download**, **upload**, **delete**, **modify**.</param>
        /// <param name="embed">Whether the share can be embedded in another web page..</param>
        /// <param name="recipients">People you want to invite to the share.   **Note**: unless you also set the &#x60;subject&#x60; and &#x60;message&#x60; for the new share, invitation emails will not be sent to these recipients.  **Note**: Recipients in this list will **REPLACE** the recipients already assigned to this share. .</param>
        /// <param name="expiration">New expiration date and time for the share.</param>
        /// <param name="hasNotification">Whether delivery receipts should be sent for this share..</param>
        /// <param name="isPublic">Whether people can visit the share without following a link from an invitation email.</param>
        /// <param name="message">Message content to use for emails inviting recipients to the share. Ignored if you have not also provided &#x60;recipients&#x60; and a &#x60;subject&#x60;.</param>
        /// <param name="notificationEmails">List of email addresses to send delivery receipts to. Ignored if &#x60;hasNotification&#x60; is false. .</param>
        /// <param name="password">New password for the share. To leave the password unchanged, do not send this parameter..</param>
        /// <param name="requireEmail">Whether visitors to the share will be required to enter their email in order to access the share..</param>
        /// <param name="subject">Subject to use on emails inviting recipients to the share. Ignored if you have not also provided &#x60;recipients&#x60; and a &#x60;message&#x60;.</param>
        /// <param name="fileDropCreateFolders">Whether uploads to a receive folder should be automatically placed into subfolders. See our [receive folder documentation](/docs/account/05-file-sharing/05-form-builder#advanced-form-settings).</param>
        /// <param name="status">New status for the share. You can set an active share to inactive by setting the status to **0**.</param>
        public Body17(string name = default(string), List<string> resources = default(List<string>), List<string> accessMode = default(List<string>), bool? embed = default(bool?), List<SharesRecipients> recipients = default(List<SharesRecipients>), DateTime? expiration = default(DateTime?), bool? hasNotification = default(bool?), bool? isPublic = default(bool?), string message = default(string), List<string> notificationEmails = default(List<string>), string password = default(string), bool? requireEmail = default(bool?), string subject = default(string), bool? fileDropCreateFolders = default(bool?), int? status = default(int?))
        {
            this.Name = name;
            this.Resources = resources;
            this.AccessMode = accessMode;
            this.Embed = embed;
            this.Recipients = recipients;
            this.Expiration = expiration;
            this.HasNotification = hasNotification;
            this.IsPublic = isPublic;
            this.Message = message;
            this.NotificationEmails = notificationEmails;
            this.Password = password;
            this.RequireEmail = requireEmail;
            this.Subject = subject;
            this.FileDropCreateFolders = fileDropCreateFolders;
            this.Status = status;
        }
        
        /// <summary>
        /// Name of the share.
        /// </summary>
        /// <value>Name of the share.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Array of resources for this share. See details on [how to specify resources](#section/Identifying-Resources) above.  **shared_folder** and **receive** shares must have only one &#x60;resource&#x60;, which is a directory that does not have a current share attached.  **send** shares may have multiple &#x60;resource&#x60; parameters.   **NOTE**: Sending this parameter will **REPLACE** the existing resources with the resources included in this request.
        /// </summary>
        /// <value>Array of resources for this share. See details on [how to specify resources](#section/Identifying-Resources) above.  **shared_folder** and **receive** shares must have only one &#x60;resource&#x60;, which is a directory that does not have a current share attached.  **send** shares may have multiple &#x60;resource&#x60; parameters.   **NOTE**: Sending this parameter will **REPLACE** the existing resources with the resources included in this request.</value>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public List<string> Resources { get; set; }

        /// <summary>
        /// What visitors who view this share can do. Valid options include **download**, **upload**, **delete**, **modify**
        /// </summary>
        /// <value>What visitors who view this share can do. Valid options include **download**, **upload**, **delete**, **modify**</value>
        [DataMember(Name="accessMode", EmitDefaultValue=false)]
        public List<string> AccessMode { get; set; }

        /// <summary>
        /// Whether the share can be embedded in another web page.
        /// </summary>
        /// <value>Whether the share can be embedded in another web page.</value>
        [DataMember(Name="embed", EmitDefaultValue=false)]
        public bool? Embed { get; set; }

        /// <summary>
        /// People you want to invite to the share.   **Note**: unless you also set the &#x60;subject&#x60; and &#x60;message&#x60; for the new share, invitation emails will not be sent to these recipients.  **Note**: Recipients in this list will **REPLACE** the recipients already assigned to this share. 
        /// </summary>
        /// <value>People you want to invite to the share.   **Note**: unless you also set the &#x60;subject&#x60; and &#x60;message&#x60; for the new share, invitation emails will not be sent to these recipients.  **Note**: Recipients in this list will **REPLACE** the recipients already assigned to this share. </value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<SharesRecipients> Recipients { get; set; }

        /// <summary>
        /// New expiration date and time for the share
        /// </summary>
        /// <value>New expiration date and time for the share</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// Whether delivery receipts should be sent for this share.
        /// </summary>
        /// <value>Whether delivery receipts should be sent for this share.</value>
        [DataMember(Name="hasNotification", EmitDefaultValue=false)]
        public bool? HasNotification { get; set; }

        /// <summary>
        /// Whether people can visit the share without following a link from an invitation email
        /// </summary>
        /// <value>Whether people can visit the share without following a link from an invitation email</value>
        [DataMember(Name="isPublic", EmitDefaultValue=false)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Message content to use for emails inviting recipients to the share. Ignored if you have not also provided &#x60;recipients&#x60; and a &#x60;subject&#x60;
        /// </summary>
        /// <value>Message content to use for emails inviting recipients to the share. Ignored if you have not also provided &#x60;recipients&#x60; and a &#x60;subject&#x60;</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// List of email addresses to send delivery receipts to. Ignored if &#x60;hasNotification&#x60; is false. 
        /// </summary>
        /// <value>List of email addresses to send delivery receipts to. Ignored if &#x60;hasNotification&#x60; is false. </value>
        [DataMember(Name="notificationEmails", EmitDefaultValue=false)]
        public List<string> NotificationEmails { get; set; }

        /// <summary>
        /// New password for the share. To leave the password unchanged, do not send this parameter.
        /// </summary>
        /// <value>New password for the share. To leave the password unchanged, do not send this parameter.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Whether visitors to the share will be required to enter their email in order to access the share.
        /// </summary>
        /// <value>Whether visitors to the share will be required to enter their email in order to access the share.</value>
        [DataMember(Name="requireEmail", EmitDefaultValue=false)]
        public bool? RequireEmail { get; set; }

        /// <summary>
        /// Subject to use on emails inviting recipients to the share. Ignored if you have not also provided &#x60;recipients&#x60; and a &#x60;message&#x60;
        /// </summary>
        /// <value>Subject to use on emails inviting recipients to the share. Ignored if you have not also provided &#x60;recipients&#x60; and a &#x60;message&#x60;</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Whether uploads to a receive folder should be automatically placed into subfolders. See our [receive folder documentation](/docs/account/05-file-sharing/05-form-builder#advanced-form-settings)
        /// </summary>
        /// <value>Whether uploads to a receive folder should be automatically placed into subfolders. See our [receive folder documentation](/docs/account/05-file-sharing/05-form-builder#advanced-form-settings)</value>
        [DataMember(Name="fileDropCreateFolders", EmitDefaultValue=false)]
        public bool? FileDropCreateFolders { get; set; }

        /// <summary>
        /// New status for the share. You can set an active share to inactive by setting the status to **0**
        /// </summary>
        /// <value>New status for the share. You can set an active share to inactive by setting the status to **0**</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body17 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  AccessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  Embed: ").Append(Embed).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  HasNotification: ").Append(HasNotification).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  NotificationEmails: ").Append(NotificationEmails).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  RequireEmail: ").Append(RequireEmail).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  FileDropCreateFolders: ").Append(FileDropCreateFolders).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Body17);
        }

        /// <summary>
        /// Returns true if Body17 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body17 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body17 input)
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
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.AccessMode == input.AccessMode ||
                    this.AccessMode != null &&
                    input.AccessMode != null &&
                    this.AccessMode.SequenceEqual(input.AccessMode)
                ) && 
                (
                    this.Embed == input.Embed ||
                    (this.Embed != null &&
                    this.Embed.Equals(input.Embed))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    input.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && 
                (
                    this.HasNotification == input.HasNotification ||
                    (this.HasNotification != null &&
                    this.HasNotification.Equals(input.HasNotification))
                ) && 
                (
                    this.IsPublic == input.IsPublic ||
                    (this.IsPublic != null &&
                    this.IsPublic.Equals(input.IsPublic))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.NotificationEmails == input.NotificationEmails ||
                    this.NotificationEmails != null &&
                    input.NotificationEmails != null &&
                    this.NotificationEmails.SequenceEqual(input.NotificationEmails)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.RequireEmail == input.RequireEmail ||
                    (this.RequireEmail != null &&
                    this.RequireEmail.Equals(input.RequireEmail))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.FileDropCreateFolders == input.FileDropCreateFolders ||
                    (this.FileDropCreateFolders != null &&
                    this.FileDropCreateFolders.Equals(input.FileDropCreateFolders))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.AccessMode != null)
                    hashCode = hashCode * 59 + this.AccessMode.GetHashCode();
                if (this.Embed != null)
                    hashCode = hashCode * 59 + this.Embed.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                if (this.HasNotification != null)
                    hashCode = hashCode * 59 + this.HasNotification.GetHashCode();
                if (this.IsPublic != null)
                    hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.NotificationEmails != null)
                    hashCode = hashCode * 59 + this.NotificationEmails.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.RequireEmail != null)
                    hashCode = hashCode * 59 + this.RequireEmail.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.FileDropCreateFolders != null)
                    hashCode = hashCode * 59 + this.FileDropCreateFolders.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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