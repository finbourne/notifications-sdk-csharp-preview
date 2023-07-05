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
    /// Holds readonly information about an API request notification
    /// </summary>
    [DataContract(Name = "ApiRequestNotificationTypeResponse")]
    public partial class ApiRequestNotificationTypeResponse : IEquatable<ApiRequestNotificationTypeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiRequestNotificationTypeResponse" /> class.
        /// </summary>
        /// <param name="httpMethod">The HTTP method such as GET, POST, etc. to use on the Api Request.</param>
        /// <param name="pathAndQuery">The url to send the request to..</param>
        /// <param name="content">The content of the request.</param>
        public ApiRequestNotificationTypeResponse(string httpMethod = default(string), string pathAndQuery = default(string), Object content = default(Object))
        {
            this.HttpMethod = httpMethod;
            this.PathAndQuery = pathAndQuery;
            this.Content = content;
        }

        /// <summary>
        /// The type of delivery mechanism for this notification
        /// </summary>
        /// <value>The type of delivery mechanism for this notification</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; private set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// The HTTP method such as GET, POST, etc. to use on the Api Request
        /// </summary>
        /// <value>The HTTP method such as GET, POST, etc. to use on the Api Request</value>
        [DataMember(Name = "httpMethod", EmitDefaultValue = true)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// The url to send the request to.
        /// </summary>
        /// <value>The url to send the request to.</value>
        [DataMember(Name = "pathAndQuery", EmitDefaultValue = true)]
        public string PathAndQuery { get; set; }

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
            sb.Append("class ApiRequestNotificationTypeResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HttpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  PathAndQuery: ").Append(PathAndQuery).Append("\n");
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
            return this.Equals(input as ApiRequestNotificationTypeResponse);
        }

        /// <summary>
        /// Returns true if ApiRequestNotificationTypeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiRequestNotificationTypeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiRequestNotificationTypeResponse input)
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
                    this.PathAndQuery == input.PathAndQuery ||
                    (this.PathAndQuery != null &&
                    this.PathAndQuery.Equals(input.PathAndQuery))
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
                if (this.PathAndQuery != null)
                {
                    hashCode = (hashCode * 59) + this.PathAndQuery.GetHashCode();
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
            yield break;
        }
    }
}
