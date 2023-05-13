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
    /// Subscription that contains its list of notifications
    /// </summary>
    [DataContract(Name = "SubscriptionDetail")]
    public partial class SubscriptionDetail : IEquatable<SubscriptionDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDetail" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="displayName">The name of the subscription (required).</param>
        /// <param name="description">The summary of the services provided by the subscription.</param>
        /// <param name="status">The current status of the subscription (required).</param>
        /// <param name="matchingPattern">matchingPattern (required).</param>
        /// <param name="createdAt">The time at which the subscription was made (required).</param>
        /// <param name="userIdCreated">The user who made the subscription (required).</param>
        /// <param name="modifiedAt">The time at which the subscription was last modified (required).</param>
        /// <param name="userIdModified">The user who last modified the subscription (required).</param>
        public SubscriptionDetail(ResourceId id = default(ResourceId), string displayName = default(string), string description = default(string), string status = default(string), MatchingPattern matchingPattern = default(MatchingPattern), DateTimeOffset createdAt = default(DateTimeOffset), string userIdCreated = default(string), DateTimeOffset modifiedAt = default(DateTimeOffset), string userIdModified = default(string))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for SubscriptionDetail and cannot be null");
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for SubscriptionDetail and cannot be null");
            // to ensure "status" is required (not null)
            this.Status = status ?? throw new ArgumentNullException("status is a required property for SubscriptionDetail and cannot be null");
            // to ensure "matchingPattern" is required (not null)
            this.MatchingPattern = matchingPattern ?? throw new ArgumentNullException("matchingPattern is a required property for SubscriptionDetail and cannot be null");
            this.CreatedAt = createdAt;
            // to ensure "userIdCreated" is required (not null)
            this.UserIdCreated = userIdCreated ?? throw new ArgumentNullException("userIdCreated is a required property for SubscriptionDetail and cannot be null");
            this.ModifiedAt = modifiedAt;
            // to ensure "userIdModified" is required (not null)
            this.UserIdModified = userIdModified ?? throw new ArgumentNullException("userIdModified is a required property for SubscriptionDetail and cannot be null");
            this.Description = description;
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
        [DataMember(Name = "userIdCreated", IsRequired = true, EmitDefaultValue = false)]
        public string UserIdCreated { get; set; }

        /// <summary>
        /// The time at which the subscription was last modified
        /// </summary>
        /// <value>The time at which the subscription was last modified</value>
        [DataMember(Name = "modifiedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset ModifiedAt { get; set; }

        /// <summary>
        /// The user who last modified the subscription
        /// </summary>
        /// <value>The user who last modified the subscription</value>
        [DataMember(Name = "userIdModified", IsRequired = true, EmitDefaultValue = false)]
        public string UserIdModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MatchingPattern: ").Append(MatchingPattern).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UserIdCreated: ").Append(UserIdCreated).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  UserIdModified: ").Append(UserIdModified).Append("\n");
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
            return this.Equals(input as SubscriptionDetail);
        }

        /// <summary>
        /// Returns true if SubscriptionDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionDetail input)
        {
            if (input == null)
                return false;

            return 
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
                    this.UserIdCreated == input.UserIdCreated ||
                    (this.UserIdCreated != null &&
                    this.UserIdCreated.Equals(input.UserIdCreated))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
                ) && 
                (
                    this.UserIdModified == input.UserIdModified ||
                    (this.UserIdModified != null &&
                    this.UserIdModified.Equals(input.UserIdModified))
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
                if (this.UserIdCreated != null)
                    hashCode = hashCode * 59 + this.UserIdCreated.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.UserIdModified != null)
                    hashCode = hashCode * 59 + this.UserIdModified.GetHashCode();
                return hashCode;
            }
        }

    }
}
