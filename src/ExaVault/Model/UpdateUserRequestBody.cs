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
    /// UpdateUserRequestBody
    /// </summary>
    [DataContract]
        public partial class UpdateUserRequestBody :  IEquatable<UpdateUserRequestBody>, IValidatableObject
    {
        /// <summary>
        /// The type of user (**admin** or **user**). Note that admin users cannot have a &#x60;homeResource&#x60; other than &#x27;/&#x27;, and will have full permissions, but you must provide at least \&quot;download,upload,list,delete\&quot; in the &#x60;permissions&#x60; parameter.
        /// </summary>
        /// <value>The type of user (**admin** or **user**). Note that admin users cannot have a &#x60;homeResource&#x60; other than &#x27;/&#x27;, and will have full permissions, but you must provide at least \&quot;download,upload,list,delete\&quot; in the &#x60;permissions&#x60; parameter.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RoleEnum
        {
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 1,
            /// <summary>
            /// Enum Admin for value: admin
            /// </summary>
            [EnumMember(Value = "admin")]
            Admin = 2        }
        /// <summary>
        /// The type of user (**admin** or **user**). Note that admin users cannot have a &#x60;homeResource&#x60; other than &#x27;/&#x27;, and will have full permissions, but you must provide at least \&quot;download,upload,list,delete\&quot; in the &#x60;permissions&#x60; parameter.
        /// </summary>
        /// <value>The type of user (**admin** or **user**). Note that admin users cannot have a &#x60;homeResource&#x60; other than &#x27;/&#x27;, and will have full permissions, but you must provide at least \&quot;download,upload,list,delete\&quot; in the &#x60;permissions&#x60; parameter.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequestBody" /> class.
        /// </summary>
        /// <param name="username">New username for the user. This should follow standard username conventions - spaces are not allowed, etc. We do allow email addresses as usernames.  **Note** Usernames must be unique across all ExaVault accounts..</param>
        /// <param name="nickname">An optional nickname (e.g. &#x27;David from Sales&#x27;)..</param>
        /// <param name="homeResource">Resource identifier for the user&#x27;s home folder. See details on [how to specify resources](#section/Identifying-Resources) above.  The user will be locked to this directory and unable to move &#x27;up&#x27; in the account. If the folder does not exist in the account, it will be created when the user logs in.  This setting is ignored for users with the &#x60;role&#x60; **admin**..</param>
        /// <param name="email">Email address for the user.</param>
        /// <param name="password">New password for the user.</param>
        /// <param name="role">The type of user (**admin** or **user**). Note that admin users cannot have a &#x60;homeResource&#x60; other than &#x27;/&#x27;, and will have full permissions, but you must provide at least \&quot;download,upload,list,delete\&quot; in the &#x60;permissions&#x60; parameter..</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="timeZone">Time zone, used for accurate time display within the application. See &lt;a href&#x3D;&#x27;https://php.net/manual/en/timezones.php&#x27; target&#x3D;&#x27;blank&#x27;&gt;this page&lt;/a&gt; for allowed values. .</param>
        /// <param name="expiration">Optional timestamp when the user should expire..</param>
        /// <param name="locked">If true, the user will be prevented from logging in.</param>
        /// <param name="onboarding">Set this to **true** to enable extra help popups in the web file manager for this user..</param>
        public UpdateUserRequestBody(string username = default(string), string nickname = default(string), string homeResource = default(string), string email = default(string), string password = default(string), RoleEnum? role = default(RoleEnum?), UserPermissions permissions = default(UserPermissions), string timeZone = default(string), string expiration = default(string), bool? locked = default(bool?), bool? onboarding = default(bool?))
        {
            this.Username = username;
            this.Nickname = nickname;
            this.HomeResource = homeResource;
            this.Email = email;
            this.Password = password;
            this.Role = role;
            this.Permissions = permissions;
            this.TimeZone = timeZone;
            this.Expiration = expiration;
            this.Locked = locked;
            this.Onboarding = onboarding;
        }
        
        /// <summary>
        /// New username for the user. This should follow standard username conventions - spaces are not allowed, etc. We do allow email addresses as usernames.  **Note** Usernames must be unique across all ExaVault accounts.
        /// </summary>
        /// <value>New username for the user. This should follow standard username conventions - spaces are not allowed, etc. We do allow email addresses as usernames.  **Note** Usernames must be unique across all ExaVault accounts.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// An optional nickname (e.g. &#x27;David from Sales&#x27;).
        /// </summary>
        /// <value>An optional nickname (e.g. &#x27;David from Sales&#x27;).</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Resource identifier for the user&#x27;s home folder. See details on [how to specify resources](#section/Identifying-Resources) above.  The user will be locked to this directory and unable to move &#x27;up&#x27; in the account. If the folder does not exist in the account, it will be created when the user logs in.  This setting is ignored for users with the &#x60;role&#x60; **admin**.
        /// </summary>
        /// <value>Resource identifier for the user&#x27;s home folder. See details on [how to specify resources](#section/Identifying-Resources) above.  The user will be locked to this directory and unable to move &#x27;up&#x27; in the account. If the folder does not exist in the account, it will be created when the user logs in.  This setting is ignored for users with the &#x60;role&#x60; **admin**.</value>
        [DataMember(Name="homeResource", EmitDefaultValue=false)]
        public string HomeResource { get; set; }

        /// <summary>
        /// Email address for the user
        /// </summary>
        /// <value>Email address for the user</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// New password for the user
        /// </summary>
        /// <value>New password for the user</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }


        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public UserPermissions Permissions { get; set; }

        /// <summary>
        /// Time zone, used for accurate time display within the application. See &lt;a href&#x3D;&#x27;https://php.net/manual/en/timezones.php&#x27; target&#x3D;&#x27;blank&#x27;&gt;this page&lt;/a&gt; for allowed values. 
        /// </summary>
        /// <value>Time zone, used for accurate time display within the application. See &lt;a href&#x3D;&#x27;https://php.net/manual/en/timezones.php&#x27; target&#x3D;&#x27;blank&#x27;&gt;this page&lt;/a&gt; for allowed values. </value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Optional timestamp when the user should expire.
        /// </summary>
        /// <value>Optional timestamp when the user should expire.</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// If true, the user will be prevented from logging in
        /// </summary>
        /// <value>If true, the user will be prevented from logging in</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Set this to **true** to enable extra help popups in the web file manager for this user.
        /// </summary>
        /// <value>Set this to **true** to enable extra help popups in the web file manager for this user.</value>
        [DataMember(Name="onboarding", EmitDefaultValue=false)]
        public bool? Onboarding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUserRequestBody {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  HomeResource: ").Append(HomeResource).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Onboarding: ").Append(Onboarding).Append("\n");
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
            return this.Equals(input as UpdateUserRequestBody);
        }

        /// <summary>
        /// Returns true if UpdateUserRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateUserRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateUserRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.HomeResource == input.HomeResource ||
                    (this.HomeResource != null &&
                    this.HomeResource.Equals(input.HomeResource))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.Onboarding == input.Onboarding ||
                    (this.Onboarding != null &&
                    this.Onboarding.Equals(input.Onboarding))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.HomeResource != null)
                    hashCode = hashCode * 59 + this.HomeResource.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Onboarding != null)
                    hashCode = hashCode * 59 + this.Onboarding.GetHashCode();
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
