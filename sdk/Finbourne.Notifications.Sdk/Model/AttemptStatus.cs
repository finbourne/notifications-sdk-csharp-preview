/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.300
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
    /// AttemptStatus
    /// </summary>
    [DataContract(Name = "AttemptStatus")]
    public partial class AttemptStatus : IEquatable<AttemptStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttemptStatus" /> class.
        /// </summary>
        /// <param name="result">Failed delivery / Successful delivery.</param>
        /// <param name="failureMessage">The failure message from attempting to deliver the message.</param>
        public AttemptStatus(string result = default(string), string failureMessage = default(string))
        {
            this.Result = result;
            this.FailureMessage = failureMessage;
        }

        /// <summary>
        /// Failed delivery / Successful delivery
        /// </summary>
        /// <value>Failed delivery / Successful delivery</value>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public string Result { get; set; }

        /// <summary>
        /// The failure message from attempting to deliver the message
        /// </summary>
        /// <value>The failure message from attempting to deliver the message</value>
        [DataMember(Name = "failureMessage", EmitDefaultValue = true)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttemptStatus {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  FailureMessage: ").Append(FailureMessage).Append("\n");
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
            return this.Equals(input as AttemptStatus);
        }

        /// <summary>
        /// Returns true if AttemptStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of AttemptStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttemptStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.FailureMessage == input.FailureMessage ||
                    (this.FailureMessage != null &&
                    this.FailureMessage.Equals(input.FailureMessage))
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
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.FailureMessage != null)
                    hashCode = hashCode * 59 + this.FailureMessage.GetHashCode();
                return hashCode;
            }
        }

    }
}
