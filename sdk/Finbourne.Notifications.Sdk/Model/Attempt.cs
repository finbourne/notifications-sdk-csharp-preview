/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.824
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
    /// Details of an attempt of delivery.
    /// </summary>
    [DataContract(Name = "Attempt")]
    public partial class Attempt : IEquatable<Attempt>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attempt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Attempt() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Attempt" /> class.
        /// </summary>
        /// <param name="attemptNumber">The attempt number of the delivery. (required).</param>
        /// <param name="attemptTime">The time that the delivery was attempted. (required).</param>
        /// <param name="status">status (required).</param>
        public Attempt(int attemptNumber = default(int), DateTimeOffset attemptTime = default(DateTimeOffset), AttemptStatus status = default(AttemptStatus))
        {
            this.AttemptNumber = attemptNumber;
            this.AttemptTime = attemptTime;
            // to ensure "status" is required (not null)
            this.Status = status ?? throw new ArgumentNullException("status is a required property for Attempt and cannot be null");
        }

        /// <summary>
        /// The attempt number of the delivery.
        /// </summary>
        /// <value>The attempt number of the delivery.</value>
        [DataMember(Name = "attemptNumber", IsRequired = true, EmitDefaultValue = true)]
        public int AttemptNumber { get; set; }

        /// <summary>
        /// The time that the delivery was attempted.
        /// </summary>
        /// <value>The time that the delivery was attempted.</value>
        [DataMember(Name = "attemptTime", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset AttemptTime { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public AttemptStatus Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attempt {\n");
            sb.Append("  AttemptNumber: ").Append(AttemptNumber).Append("\n");
            sb.Append("  AttemptTime: ").Append(AttemptTime).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Attempt);
        }

        /// <summary>
        /// Returns true if Attempt instances are equal
        /// </summary>
        /// <param name="input">Instance of Attempt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attempt input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttemptNumber == input.AttemptNumber ||
                    this.AttemptNumber.Equals(input.AttemptNumber)
                ) && 
                (
                    this.AttemptTime == input.AttemptTime ||
                    (this.AttemptTime != null &&
                    this.AttemptTime.Equals(input.AttemptTime))
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
                hashCode = hashCode * 59 + this.AttemptNumber.GetHashCode();
                if (this.AttemptTime != null)
                    hashCode = hashCode * 59 + this.AttemptTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }
}
