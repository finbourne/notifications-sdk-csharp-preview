/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.934
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
    /// A subscription object
    /// </summary>
    [DataContract(Name = "Subscription")]
    public partial class Subscription : IEquatable<Subscription>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Subscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="displayName">The name of the subscription (required).</param>
        /// <param name="description">The summary of the services provided by the subscription.</param>
        /// <param name="status">The current status of the subscription (required).</param>
        /// <param name="matchingPattern">matchingPattern (required).</param>
        /// <param name="createdAt">The time at which the subscription was made (required).</param>
        /// <param name="useAsAuth">The user to use as auth for the subscription (required).</param>
        public Subscription(ResourceId id = default(ResourceId), string displayName = default(string), string description = default(string), string status = default(string), MatchingPattern matchingPattern = default(MatchingPattern), DateTimeOffset createdAt = default(DateTimeOffset), string useAsAuth = default(string))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Subscription and cannot be null");
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for Subscription and cannot be null");
            // to ensure "status" is required (not null)
            this.Status = status ?? throw new ArgumentNullException("status is a required property for Subscription and cannot be null");
            // to ensure "matchingPattern" is required (not null)
            this.MatchingPattern = matchingPattern ?? throw new ArgumentNullException("matchingPattern is a required property for Subscription and cannot be null");
            this.CreatedAt = createdAt;
            // to ensure "useAsAuth" is required (not null)
            this.UseAsAuth = useAsAuth ?? throw new ArgumentNullException("useAsAuth is a required property for Subscription and cannot be null");
            this.Description = description;
        }

        /// <summary>
        /// List of notifications belonging to a subscription
        /// </summary>
        /// <value>List of notifications belonging to a subscription</value>
        [DataMember(Name = "notifications", EmitDefaultValue = true)]
        public List<Notification> Notifications { get; private set; }

        /// <summary>
        /// Returns false as Notifications should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNotifications()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The name of the subscription
        /// </summary>
        /// <value>The name of the subscription</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The summary of the services provided by the subscription
        /// </summary>
        /// <value>The summary of the services provided by the subscription</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The current status of the subscription
        /// </summary>
        /// <value>The current status of the subscription</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets MatchingPattern
        /// </summary>
        [DataMember(Name = "matchingPattern", IsRequired = true, EmitDefaultValue = false)]
        public MatchingPattern MatchingPattern { get; set; }

        /// <summary>
        /// The time at which the subscription was made
        /// </summary>
        /// <value>The time at which the subscription was made</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The user who made the subscription
        /// </summary>
        /// <value>The user who made the subscription</value>
        [DataMember(Name = "createdBy", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }

        /// <summary>
        /// The time at which the subscription was last modified
        /// </summary>
        /// <value>The time at which the subscription was last modified</value>
        [DataMember(Name = "lastModifiedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset LastModifiedAt { get; private set; }

        /// <summary>
        /// Returns false as LastModifiedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastModifiedAt()
        {
            return false;
        }

        /// <summary>
        /// The user who last modified the subscription
        /// </summary>
        /// <value>The user who last modified the subscription</value>
        [DataMember(Name = "lastModifiedBy", IsRequired = true, EmitDefaultValue = false)]
        public string LastModifiedBy { get; private set; }

        /// <summary>
        /// Returns false as LastModifiedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastModifiedBy()
        {
            return false;
        }

        /// <summary>
        /// The user to use as auth for the subscription
        /// </summary>
        /// <value>The user to use as auth for the subscription</value>
        [DataMember(Name = "useAsAuth", IsRequired = true, EmitDefaultValue = false)]
        public string UseAsAuth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MatchingPattern: ").Append(MatchingPattern).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  LastModifiedAt: ").Append(LastModifiedAt).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  UseAsAuth: ").Append(UseAsAuth).Append("\n");
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
            return this.Equals(input as Subscription);
        }

        /// <summary>
        /// Returns true if Subscription instances are equal
        /// </summary>
        /// <param name="input">Instance of Subscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Notifications == input.Notifications ||
                    this.Notifications != null &&
                    input.Notifications != null &&
                    this.Notifications.SequenceEqual(input.Notifications)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.MatchingPattern == input.MatchingPattern ||
                    (this.MatchingPattern != null &&
                    this.MatchingPattern.Equals(input.MatchingPattern))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.LastModifiedAt == input.LastModifiedAt ||
                    (this.LastModifiedAt != null &&
                    this.LastModifiedAt.Equals(input.LastModifiedAt))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.UseAsAuth == input.UseAsAuth ||
                    (this.UseAsAuth != null &&
                    this.UseAsAuth.Equals(input.UseAsAuth))
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
                if (this.Notifications != null)
                    hashCode = hashCode * 59 + this.Notifications.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MatchingPattern != null)
                    hashCode = hashCode * 59 + this.MatchingPattern.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.LastModifiedAt != null)
                    hashCode = hashCode * 59 + this.LastModifiedAt.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                if (this.UseAsAuth != null)
                    hashCode = hashCode * 59 + this.UseAsAuth.GetHashCode();
                return hashCode;
            }
        }

    }
}
