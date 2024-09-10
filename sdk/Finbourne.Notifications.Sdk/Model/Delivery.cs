/*
 * FINBOURNE Notifications API
 *
 * ### Introduction   # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"711\">711</a>|Subscription already exists|  | | <a name=\"712\">712</a>|Could not find subscription|  | | <a name=\"713\">713</a>|Notification already exists|  | | <a name=\"714\">714</a>|Could not find notification|  | | <a name=\"734\">734</a>|Email address is incorrectly formatted.|  | | <a name=\"740\">740</a>|Event type was missing|  | | <a name=\"741\">741</a>|Unknown event type|  | | <a name=\"747\">747</a>|Duplicate sort field used.|  | | <a name=\"748\">748</a>|Defined template attributes failure.|  | | <a name=\"749\">749</a>|Operation on wrong notification type.|  | | <a name=\"759\">759</a>|Invalid configuration item path|  | | <a name=\"760\">760</a>|Invalid configuration set type|  | | <a name=\"761\">761</a>|Invalid webhook HTTP content|  | | <a name=\"762\">762</a>|A failure occured when making a webhook request|  | | <a name=\"776\">776</a>|Delivery already exists|  | | <a name=\"777\">777</a>|Delivery not found|  | | <a name=\"779\">779</a>|Invalid message content|  | | <a name=\"794\">794</a>|Cannot modify the existing subscription.|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"884\">884</a>|Missing licence to access feature.|  | | <a name=\"885\">885</a>|Error sending to AWS SQS.|  | 
 *
 * The version of the OpenAPI document: 0.1.1047
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
    /// Delivery
    /// </summary>
    [DataContract(Name = "Delivery")]
    public partial class Delivery : IEquatable<Delivery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Delivery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Delivery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Delivery" /> class.
        /// </summary>
        /// <param name="id">The identifier of the delivery. (required).</param>
        /// <param name="eventId">The identifier of the associated event. (required).</param>
        /// <param name="subscriptionId">subscriptionId (required).</param>
        /// <param name="notificationId">The identifier of the associated notification. (required).</param>
        /// <param name="deliveryChannel">The delivery channel of the message. (required).</param>
        /// <param name="messageDetails">The Details of the delivery message as JSON string. (required).</param>
        /// <param name="attempts">A list of all the delivery attempts made for this message. (required).</param>
        public Delivery(Guid id = default(Guid), string eventId = default(string), ResourceId subscriptionId = default(ResourceId), string notificationId = default(string), string deliveryChannel = default(string), string messageDetails = default(string), List<Attempt> attempts = default(List<Attempt>))
        {
            this.Id = id;
            // to ensure "eventId" is required (not null)
            this.EventId = eventId ?? throw new ArgumentNullException("eventId is a required property for Delivery and cannot be null");
            // to ensure "subscriptionId" is required (not null)
            this.SubscriptionId = subscriptionId ?? throw new ArgumentNullException("subscriptionId is a required property for Delivery and cannot be null");
            // to ensure "notificationId" is required (not null)
            this.NotificationId = notificationId ?? throw new ArgumentNullException("notificationId is a required property for Delivery and cannot be null");
            // to ensure "deliveryChannel" is required (not null)
            this.DeliveryChannel = deliveryChannel ?? throw new ArgumentNullException("deliveryChannel is a required property for Delivery and cannot be null");
            // to ensure "messageDetails" is required (not null)
            this.MessageDetails = messageDetails ?? throw new ArgumentNullException("messageDetails is a required property for Delivery and cannot be null");
            // to ensure "attempts" is required (not null)
            this.Attempts = attempts ?? throw new ArgumentNullException("attempts is a required property for Delivery and cannot be null");
        }

        /// <summary>
        /// The identifier of the delivery.
        /// </summary>
        /// <value>The identifier of the delivery.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The identifier of the associated event.
        /// </summary>
        /// <value>The identifier of the associated event.</value>
        [DataMember(Name = "eventId", IsRequired = true, EmitDefaultValue = false)]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "subscriptionId", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId SubscriptionId { get; set; }

        /// <summary>
        /// The identifier of the associated notification.
        /// </summary>
        /// <value>The identifier of the associated notification.</value>
        [DataMember(Name = "notificationId", IsRequired = true, EmitDefaultValue = false)]
        public string NotificationId { get; set; }

        /// <summary>
        /// The delivery channel of the message.
        /// </summary>
        /// <value>The delivery channel of the message.</value>
        [DataMember(Name = "deliveryChannel", IsRequired = true, EmitDefaultValue = false)]
        public string DeliveryChannel { get; set; }

        /// <summary>
        /// The Details of the delivery message as JSON string.
        /// </summary>
        /// <value>The Details of the delivery message as JSON string.</value>
        [DataMember(Name = "messageDetails", IsRequired = true, EmitDefaultValue = false)]
        public string MessageDetails { get; set; }

        /// <summary>
        /// A list of all the delivery attempts made for this message.
        /// </summary>
        /// <value>A list of all the delivery attempts made for this message.</value>
        [DataMember(Name = "attempts", IsRequired = true, EmitDefaultValue = false)]
        public List<Attempt> Attempts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Delivery {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
            sb.Append("  DeliveryChannel: ").Append(DeliveryChannel).Append("\n");
            sb.Append("  MessageDetails: ").Append(MessageDetails).Append("\n");
            sb.Append("  Attempts: ").Append(Attempts).Append("\n");
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
            return this.Equals(input as Delivery);
        }

        /// <summary>
        /// Returns true if Delivery instances are equal
        /// </summary>
        /// <param name="input">Instance of Delivery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Delivery input)
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
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.NotificationId == input.NotificationId ||
                    (this.NotificationId != null &&
                    this.NotificationId.Equals(input.NotificationId))
                ) && 
                (
                    this.DeliveryChannel == input.DeliveryChannel ||
                    (this.DeliveryChannel != null &&
                    this.DeliveryChannel.Equals(input.DeliveryChannel))
                ) && 
                (
                    this.MessageDetails == input.MessageDetails ||
                    (this.MessageDetails != null &&
                    this.MessageDetails.Equals(input.MessageDetails))
                ) && 
                (
                    this.Attempts == input.Attempts ||
                    this.Attempts != null &&
                    input.Attempts != null &&
                    this.Attempts.SequenceEqual(input.Attempts)
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
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.NotificationId != null)
                    hashCode = hashCode * 59 + this.NotificationId.GetHashCode();
                if (this.DeliveryChannel != null)
                    hashCode = hashCode * 59 + this.DeliveryChannel.GetHashCode();
                if (this.MessageDetails != null)
                    hashCode = hashCode * 59 + this.MessageDetails.GetHashCode();
                if (this.Attempts != null)
                    hashCode = hashCode * 59 + this.Attempts.GetHashCode();
                return hashCode;
            }
        }

    }
}
