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
using System.Reflection;

namespace Finbourne.Notifications.Sdk.Model
{
    /// <summary>
    /// Holds readonly information about a Finbourne.Notifications.WebApi.Dtos.Notifications.Notification
    /// </summary>
    [JsonConverter(typeof(NotificationTypeResponseJsonConverter))]
    [DataContract(Name = "NotificationTypeResponse")]
    public partial class NotificationTypeResponse : AbstractOpenAPISchema, IEquatable<NotificationTypeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTypeResponse" /> class
        /// with the <see cref="AmazonSqsNotificationTypeResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AmazonSqsNotificationTypeResponse.</param>
        public NotificationTypeResponse(AmazonSqsNotificationTypeResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTypeResponse" /> class
        /// with the <see cref="EmailNotificationTypeResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EmailNotificationTypeResponse.</param>
        public NotificationTypeResponse(EmailNotificationTypeResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTypeResponse" /> class
        /// with the <see cref="SmsNotificationTypeResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SmsNotificationTypeResponse.</param>
        public NotificationTypeResponse(SmsNotificationTypeResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTypeResponse" /> class
        /// with the <see cref="WebhookNotificationTypeResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WebhookNotificationTypeResponse.</param>
        public NotificationTypeResponse(WebhookNotificationTypeResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(AmazonSqsNotificationTypeResponse))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EmailNotificationTypeResponse))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SmsNotificationTypeResponse))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WebhookNotificationTypeResponse))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AmazonSqsNotificationTypeResponse, EmailNotificationTypeResponse, SmsNotificationTypeResponse, WebhookNotificationTypeResponse");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AmazonSqsNotificationTypeResponse`. If the actual instance is not `AmazonSqsNotificationTypeResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AmazonSqsNotificationTypeResponse</returns>
        public AmazonSqsNotificationTypeResponse GetAmazonSqsNotificationTypeResponse()
        {
            return (AmazonSqsNotificationTypeResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EmailNotificationTypeResponse`. If the actual instance is not `EmailNotificationTypeResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EmailNotificationTypeResponse</returns>
        public EmailNotificationTypeResponse GetEmailNotificationTypeResponse()
        {
            return (EmailNotificationTypeResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SmsNotificationTypeResponse`. If the actual instance is not `SmsNotificationTypeResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SmsNotificationTypeResponse</returns>
        public SmsNotificationTypeResponse GetSmsNotificationTypeResponse()
        {
            return (SmsNotificationTypeResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `WebhookNotificationTypeResponse`. If the actual instance is not `WebhookNotificationTypeResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of WebhookNotificationTypeResponse</returns>
        public WebhookNotificationTypeResponse GetWebhookNotificationTypeResponse()
        {
            return (WebhookNotificationTypeResponse)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationTypeResponse {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, NotificationTypeResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of NotificationTypeResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of NotificationTypeResponse</returns>
        public static NotificationTypeResponse FromJson(string jsonString)
        {
            NotificationTypeResponse newNotificationTypeResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNotificationTypeResponse;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AmazonSqsNotificationTypeResponse).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationTypeResponse = new NotificationTypeResponse(JsonConvert.DeserializeObject<AmazonSqsNotificationTypeResponse>(jsonString, NotificationTypeResponse.SerializerSettings));
                }
                else
                {
                    newNotificationTypeResponse = new NotificationTypeResponse(JsonConvert.DeserializeObject<AmazonSqsNotificationTypeResponse>(jsonString, NotificationTypeResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AmazonSqsNotificationTypeResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AmazonSqsNotificationTypeResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EmailNotificationTypeResponse).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationTypeResponse = new NotificationTypeResponse(JsonConvert.DeserializeObject<EmailNotificationTypeResponse>(jsonString, NotificationTypeResponse.SerializerSettings));
                }
                else
                {
                    newNotificationTypeResponse = new NotificationTypeResponse(JsonConvert.DeserializeObject<EmailNotificationTypeResponse>(jsonString, NotificationTypeResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EmailNotificationTypeResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EmailNotificationTypeResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SmsNotificationTypeResponse).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationTypeResponse = new NotificationTypeResponse(JsonConvert.DeserializeObject<SmsNotificationTypeResponse>(jsonString, NotificationTypeResponse.SerializerSettings));
                }
                else
                {
                    newNotificationTypeResponse = new NotificationTypeResponse(JsonConvert.DeserializeObject<SmsNotificationTypeResponse>(jsonString, NotificationTypeResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SmsNotificationTypeResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SmsNotificationTypeResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WebhookNotificationTypeResponse).GetProperty("AdditionalProperties") == null)
                {
                    newNotificationTypeResponse = new NotificationTypeResponse(JsonConvert.DeserializeObject<WebhookNotificationTypeResponse>(jsonString, NotificationTypeResponse.SerializerSettings));
                }
                else
                {
                    newNotificationTypeResponse = new NotificationTypeResponse(JsonConvert.DeserializeObject<WebhookNotificationTypeResponse>(jsonString, NotificationTypeResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WebhookNotificationTypeResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WebhookNotificationTypeResponse: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newNotificationTypeResponse;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotificationTypeResponse);
        }

        /// <summary>
        /// Returns true if NotificationTypeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationTypeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationTypeResponse input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for NotificationTypeResponse
    /// </summary>
    public class NotificationTypeResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NotificationTypeResponse).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return NotificationTypeResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}