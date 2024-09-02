/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.1038
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
    /// A matching pattern object
    /// </summary>
    [DataContract(Name = "MatchingPattern")]
    public partial class MatchingPattern : IEquatable<MatchingPattern>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchingPattern" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchingPattern() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchingPattern" /> class.
        /// </summary>
        /// <param name="eventType">The type of event to subscribe to. The list of available event types can be discovered  by calling the ‘List available EventTypes’ API endpoint. (required).</param>
        /// <param name="filter">A filter on the event. See https://support.lusid.com/filtering-results-from-lusid for more information. If not provided, all events will be matched.</param>
        public MatchingPattern(string eventType = default(string), string filter = default(string))
        {
            // to ensure "eventType" is required (not null)
            this.EventType = eventType ?? throw new ArgumentNullException("eventType is a required property for MatchingPattern and cannot be null");
            this.Filter = filter;
        }

        /// <summary>
        /// The type of event to subscribe to. The list of available event types can be discovered  by calling the ‘List available EventTypes’ API endpoint.
        /// </summary>
        /// <value>The type of event to subscribe to. The list of available event types can be discovered  by calling the ‘List available EventTypes’ API endpoint.</value>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// A filter on the event. See https://support.lusid.com/filtering-results-from-lusid for more information. If not provided, all events will be matched
        /// </summary>
        /// <value>A filter on the event. See https://support.lusid.com/filtering-results-from-lusid for more information. If not provided, all events will be matched</value>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public string Filter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchingPattern {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
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
            return this.Equals(input as MatchingPattern);
        }

        /// <summary>
        /// Returns true if MatchingPattern instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchingPattern to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchingPattern input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
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
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                return hashCode;
            }
        }

    }
}
