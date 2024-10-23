/*
 * FINBOURNE Notifications API
 *
 * ### Introduction   # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"711\">711</a>|Subscription already exists|  | | <a name=\"712\">712</a>|Could not find subscription|  | | <a name=\"713\">713</a>|Notification already exists|  | | <a name=\"714\">714</a>|Could not find notification|  | | <a name=\"734\">734</a>|Email address is incorrectly formatted.|  | | <a name=\"740\">740</a>|Event type was missing|  | | <a name=\"741\">741</a>|Unknown event type|  | | <a name=\"747\">747</a>|Duplicate sort field used.|  | | <a name=\"748\">748</a>|Defined template attributes failure.|  | | <a name=\"749\">749</a>|Operation on wrong notification type.|  | | <a name=\"759\">759</a>|Invalid configuration item path|  | | <a name=\"760\">760</a>|Invalid configuration set type|  | | <a name=\"761\">761</a>|Invalid webhook HTTP content|  | | <a name=\"762\">762</a>|A failure occured when making a webhook request|  | | <a name=\"776\">776</a>|Delivery already exists|  | | <a name=\"777\">777</a>|Delivery not found|  | | <a name=\"779\">779</a>|Invalid message content|  | | <a name=\"794\">794</a>|Cannot modify the existing subscription.|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"884\">884</a>|Missing licence to access feature.|  | | <a name=\"885\">885</a>|Error sending to AWS SQS.|  | 
 *
 * The version of the OpenAPI document: 0.1.1057
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
using OpenAPIDateConverter = Finbourne.Notifications.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Notifications.Sdk.Model
{
    /// <summary>
    /// The information required to create a notification which, when processed, will send an email
    /// </summary>
    [DataContract(Name = "CreateEmailNotification")]
    public partial class CreateEmailNotification : IEquatable<CreateEmailNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmailNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateEmailNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmailNotification" /> class.
        /// </summary>
        /// <param name="description">The summary of the services provided by the notification (required).</param>
        /// <param name="subject">The subject of the email (required).</param>
        /// <param name="plainTextBody">The plain text body of the email (required).</param>
        /// <param name="htmlBody">The HTML body of the email (if any).</param>
        /// <param name="emailAddressTo">&#39;To&#39; recipients of the email (required).</param>
        /// <param name="emailAddressCc">&#39;Cc&#39; recipients of the email.</param>
        /// <param name="emailAddressBcc">&#39;Bcc&#39; recipients of the email.</param>
        public CreateEmailNotification(string description = default(string), string subject = default(string), string plainTextBody = default(string), string htmlBody = default(string), List<string> emailAddressTo = default(List<string>), List<string> emailAddressCc = default(List<string>), List<string> emailAddressBcc = default(List<string>))
        {
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for CreateEmailNotification and cannot be null");
            // to ensure "subject" is required (not null)
            this.Subject = subject ?? throw new ArgumentNullException("subject is a required property for CreateEmailNotification and cannot be null");
            // to ensure "plainTextBody" is required (not null)
            this.PlainTextBody = plainTextBody ?? throw new ArgumentNullException("plainTextBody is a required property for CreateEmailNotification and cannot be null");
            // to ensure "emailAddressTo" is required (not null)
            this.EmailAddressTo = emailAddressTo ?? throw new ArgumentNullException("emailAddressTo is a required property for CreateEmailNotification and cannot be null");
            this.HtmlBody = htmlBody;
            this.EmailAddressCc = emailAddressCc;
            this.EmailAddressBcc = emailAddressBcc;
        }

        /// <summary>
        /// The summary of the services provided by the notification
        /// </summary>
        /// <value>The summary of the services provided by the notification</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The subject of the email
        /// </summary>
        /// <value>The subject of the email</value>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// The plain text body of the email
        /// </summary>
        /// <value>The plain text body of the email</value>
        [DataMember(Name = "plainTextBody", IsRequired = true, EmitDefaultValue = false)]
        public string PlainTextBody { get; set; }

        /// <summary>
        /// The HTML body of the email (if any)
        /// </summary>
        /// <value>The HTML body of the email (if any)</value>
        [DataMember(Name = "htmlBody", EmitDefaultValue = true)]
        public string HtmlBody { get; set; }

        /// <summary>
        /// &#39;To&#39; recipients of the email
        /// </summary>
        /// <value>&#39;To&#39; recipients of the email</value>
        [DataMember(Name = "emailAddressTo", IsRequired = true, EmitDefaultValue = false)]
        public List<string> EmailAddressTo { get; set; }

        /// <summary>
        /// &#39;Cc&#39; recipients of the email
        /// </summary>
        /// <value>&#39;Cc&#39; recipients of the email</value>
        [DataMember(Name = "emailAddressCc", EmitDefaultValue = true)]
        public List<string> EmailAddressCc { get; set; }

        /// <summary>
        /// &#39;Bcc&#39; recipients of the email
        /// </summary>
        /// <value>&#39;Bcc&#39; recipients of the email</value>
        [DataMember(Name = "emailAddressBcc", EmitDefaultValue = true)]
        public List<string> EmailAddressBcc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEmailNotification {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  PlainTextBody: ").Append(PlainTextBody).Append("\n");
            sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
            sb.Append("  EmailAddressTo: ").Append(EmailAddressTo).Append("\n");
            sb.Append("  EmailAddressCc: ").Append(EmailAddressCc).Append("\n");
            sb.Append("  EmailAddressBcc: ").Append(EmailAddressBcc).Append("\n");
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
            return this.Equals(input as CreateEmailNotification);
        }

        /// <summary>
        /// Returns true if CreateEmailNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateEmailNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateEmailNotification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.PlainTextBody == input.PlainTextBody ||
                    (this.PlainTextBody != null &&
                    this.PlainTextBody.Equals(input.PlainTextBody))
                ) && 
                (
                    this.HtmlBody == input.HtmlBody ||
                    (this.HtmlBody != null &&
                    this.HtmlBody.Equals(input.HtmlBody))
                ) && 
                (
                    this.EmailAddressTo == input.EmailAddressTo ||
                    this.EmailAddressTo != null &&
                    input.EmailAddressTo != null &&
                    this.EmailAddressTo.SequenceEqual(input.EmailAddressTo)
                ) && 
                (
                    this.EmailAddressCc == input.EmailAddressCc ||
                    this.EmailAddressCc != null &&
                    input.EmailAddressCc != null &&
                    this.EmailAddressCc.SequenceEqual(input.EmailAddressCc)
                ) && 
                (
                    this.EmailAddressBcc == input.EmailAddressBcc ||
                    this.EmailAddressBcc != null &&
                    input.EmailAddressBcc != null &&
                    this.EmailAddressBcc.SequenceEqual(input.EmailAddressBcc)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.PlainTextBody != null)
                    hashCode = hashCode * 59 + this.PlainTextBody.GetHashCode();
                if (this.HtmlBody != null)
                    hashCode = hashCode * 59 + this.HtmlBody.GetHashCode();
                if (this.EmailAddressTo != null)
                    hashCode = hashCode * 59 + this.EmailAddressTo.GetHashCode();
                if (this.EmailAddressCc != null)
                    hashCode = hashCode * 59 + this.EmailAddressCc.GetHashCode();
                if (this.EmailAddressBcc != null)
                    hashCode = hashCode * 59 + this.EmailAddressBcc.GetHashCode();
                return hashCode;
            }
        }

    }
}
