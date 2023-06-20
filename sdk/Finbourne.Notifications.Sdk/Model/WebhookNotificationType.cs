/*
 * FINBOURNE Notifications API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Finbourne.Notifications.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Finbourne.Notifications.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Notifications.Sdk.Model
{
    /// <summary>
    /// The information required to create or update a Webhook notification
    /// </summary>
    [DataContract(Name = "WebhookNotificationType")]
    public partial class WebhookNotificationType : IEquatable<WebhookNotificationType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookNotificationType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookNotificationType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookNotificationType" /> class.
        /// </summary>
        /// <param name="type">The type of delivery mechanism for this notification (required).</param>
        /// <param name="httpMethod">The HTTP method such as GET, POST, etc. to use on the request (required).</param>
        /// <param name="url">The URL to send the request to (required).</param>
        /// <param name="authenticationType">The type of authentication to use on the request (required).</param>
        /// <param name="authenticationConfigurationItemPaths">The paths of the Configuration Store configuration items that contain the authentication configuration. Each  authentication type requires different keys:  - Lusid - None required  - BasicAuth - Requires &#39;Username&#39; and &#39;Password&#39;  - BearerToken - Requires &#39;BearerToken&#39; and optionally &#39;BearerScheme&#39;                e.g. the following would be valid assuming that the config is present in the configuration store at the  specified paths:                    \&quot;authenticationType\&quot;: \&quot;BasicAuth\&quot;,      \&quot;authenticationConfigurationItemPaths\&quot;: {          \&quot;Username\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminUser\&quot;,          \&quot;Password\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminPassword\&quot;      }.</param>
        /// <param name="contentType">The type of the content e.g. Json (required).</param>
        /// <param name="content">The content of the request.</param>
        public WebhookNotificationType(string type = default(string), string httpMethod = default(string), string url = default(string), string authenticationType = default(string), Dictionary<string, string> authenticationConfigurationItemPaths = default(Dictionary<string, string>), string contentType = default(string), Object content = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for WebhookNotificationType and cannot be null");
            }
            this.Type = type;
            // to ensure "httpMethod" is required (not null)
            if (httpMethod == null)
            {
                throw new ArgumentNullException("httpMethod is a required property for WebhookNotificationType and cannot be null");
            }
            this.HttpMethod = httpMethod;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for WebhookNotificationType and cannot be null");
            }
            this.Url = url;
            // to ensure "authenticationType" is required (not null)
            if (authenticationType == null)
            {
                throw new ArgumentNullException("authenticationType is a required property for WebhookNotificationType and cannot be null");
            }
            this.AuthenticationType = authenticationType;
            // to ensure "contentType" is required (not null)
            if (contentType == null)
            {
                throw new ArgumentNullException("contentType is a required property for WebhookNotificationType and cannot be null");
            }
            this.ContentType = contentType;
            this.AuthenticationConfigurationItemPaths = authenticationConfigurationItemPaths;
            this.Content = content;
        }

        /// <summary>
        /// The type of delivery mechanism for this notification
        /// </summary>
        /// <value>The type of delivery mechanism for this notification</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The HTTP method such as GET, POST, etc. to use on the request
        /// </summary>
        /// <value>The HTTP method such as GET, POST, etc. to use on the request</value>
        [DataMember(Name = "httpMethod", IsRequired = true, EmitDefaultValue = true)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// The URL to send the request to
        /// </summary>
        /// <value>The URL to send the request to</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The type of authentication to use on the request
        /// </summary>
        /// <value>The type of authentication to use on the request</value>
        [DataMember(Name = "authenticationType", IsRequired = true, EmitDefaultValue = true)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// The paths of the Configuration Store configuration items that contain the authentication configuration. Each  authentication type requires different keys:  - Lusid - None required  - BasicAuth - Requires &#39;Username&#39; and &#39;Password&#39;  - BearerToken - Requires &#39;BearerToken&#39; and optionally &#39;BearerScheme&#39;                e.g. the following would be valid assuming that the config is present in the configuration store at the  specified paths:                    \&quot;authenticationType\&quot;: \&quot;BasicAuth\&quot;,      \&quot;authenticationConfigurationItemPaths\&quot;: {          \&quot;Username\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminUser\&quot;,          \&quot;Password\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminPassword\&quot;      }
        /// </summary>
        /// <value>The paths of the Configuration Store configuration items that contain the authentication configuration. Each  authentication type requires different keys:  - Lusid - None required  - BasicAuth - Requires &#39;Username&#39; and &#39;Password&#39;  - BearerToken - Requires &#39;BearerToken&#39; and optionally &#39;BearerScheme&#39;                e.g. the following would be valid assuming that the config is present in the configuration store at the  specified paths:                    \&quot;authenticationType\&quot;: \&quot;BasicAuth\&quot;,      \&quot;authenticationConfigurationItemPaths\&quot;: {          \&quot;Username\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminUser\&quot;,          \&quot;Password\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminPassword\&quot;      }</value>
        [DataMember(Name = "authenticationConfigurationItemPaths", EmitDefaultValue = true)]
        public Dictionary<string, string> AuthenticationConfigurationItemPaths { get; set; }

        /// <summary>
        /// The type of the content e.g. Json
        /// </summary>
        /// <value>The type of the content e.g. Json</value>
        [DataMember(Name = "contentType", IsRequired = true, EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// The content of the request
        /// </summary>
        /// <value>The content of the request</value>
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public Object Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookNotificationType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HttpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  AuthenticationConfigurationItemPaths: ").Append(AuthenticationConfigurationItemPaths).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebhookNotificationType);
        }

        /// <summary>
        /// Returns true if WebhookNotificationType instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookNotificationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookNotificationType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.HttpMethod == input.HttpMethod ||
                    (this.HttpMethod != null &&
                    this.HttpMethod.Equals(input.HttpMethod))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.AuthenticationType == input.AuthenticationType ||
                    (this.AuthenticationType != null &&
                    this.AuthenticationType.Equals(input.AuthenticationType))
                ) && 
                (
                    this.AuthenticationConfigurationItemPaths == input.AuthenticationConfigurationItemPaths ||
                    this.AuthenticationConfigurationItemPaths != null &&
                    input.AuthenticationConfigurationItemPaths != null &&
                    this.AuthenticationConfigurationItemPaths.SequenceEqual(input.AuthenticationConfigurationItemPaths)
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.HttpMethod != null)
                {
                    hashCode = (hashCode * 59) + this.HttpMethod.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.AuthenticationType != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationType.GetHashCode();
                }
                if (this.AuthenticationConfigurationItemPaths != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationConfigurationItemPaths.GetHashCode();
                }
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
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
            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            // HttpMethod (string) minLength
            if (this.HttpMethod != null && this.HttpMethod.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HttpMethod, length must be greater than 1.", new [] { "HttpMethod" });
            }

            // Url (string) maxLength
            if (this.Url != null && this.Url.Length > 16384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be less than 16384.", new [] { "Url" });
            }

            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }

            // Url (string) pattern
            Regex regexUrl = new Regex(@"^([A-Za-z0-9-._~:\/?#[\]@!$&'()*+,;%=]|(\{\{([a-zA-Z0-9\s])*\}\}))*$", RegexOptions.CultureInvariant);
            if (false == regexUrl.Match(this.Url).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, must match a pattern of " + regexUrl, new [] { "Url" });
            }

            // AuthenticationType (string) minLength
            if (this.AuthenticationType != null && this.AuthenticationType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthenticationType, length must be greater than 1.", new [] { "AuthenticationType" });
            }

            // ContentType (string) minLength
            if (this.ContentType != null && this.ContentType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContentType, length must be greater than 1.", new [] { "ContentType" });
            }

            yield break;
        }
    }
}
