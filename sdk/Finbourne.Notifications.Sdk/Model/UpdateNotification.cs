/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.683
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
    /// The information required to update a notification
    /// </summary>
    [DataContract(Name = "UpdateNotification")]
    public partial class UpdateNotification : IEquatable<UpdateNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNotification" /> class.
        /// </summary>
        /// <param name="displayName">The name of the notification.</param>
        /// <param name="description">The summary of the services provided by the notification (required).</param>
        /// <param name="notificationType">The contents of the notification type. (required).</param>
        public UpdateNotification(string displayName = default(string), string description = default(string), Object notificationType = default(Object))
        {
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for UpdateNotification and cannot be null");
            // to ensure "notificationType" is required (not null)
            this.NotificationType = notificationType ?? throw new ArgumentNullException("notificationType is a required property for UpdateNotification and cannot be null");
            this.DisplayName = displayName;
        }

        /// <summary>
        /// The name of the notification
        /// </summary>
        /// <value>The name of the notification</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The summary of the services provided by the notification
        /// </summary>
        /// <value>The summary of the services provided by the notification</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The contents of the notification type.
        /// </summary>
        /// <value>The contents of the notification type.</value>
        [DataMember(Name = "notificationType", IsRequired = true, EmitDefaultValue = true)]
        public Object NotificationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNotification {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  NotificationType: ").Append(NotificationType).Append("\n");
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
            return this.Equals(input as UpdateNotification);
        }

        /// <summary>
        /// Returns true if UpdateNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNotification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.NotificationType == input.NotificationType ||
                    (this.NotificationType != null &&
                    this.NotificationType.Equals(input.NotificationType))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.NotificationType != null)
                    hashCode = hashCode * 59 + this.NotificationType.GetHashCode();
                return hashCode;
            }
        }

    }
}
