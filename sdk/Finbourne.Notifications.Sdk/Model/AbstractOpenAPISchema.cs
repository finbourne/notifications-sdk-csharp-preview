/*
 * FINBOURNE Notifications API
 *
 * ### Introduction   # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"711\">711</a>|Subscription already exists|  | | <a name=\"712\">712</a>|Could not find subscription|  | | <a name=\"713\">713</a>|Notification already exists|  | | <a name=\"714\">714</a>|Could not find notification|  | | <a name=\"734\">734</a>|Email address is incorrectly formatted.|  | | <a name=\"740\">740</a>|Event type was missing|  | | <a name=\"741\">741</a>|Unknown event type|  | | <a name=\"747\">747</a>|Duplicate sort field used.|  | | <a name=\"748\">748</a>|Defined template attributes failure.|  | | <a name=\"749\">749</a>|Operation on wrong notification type.|  | | <a name=\"759\">759</a>|Invalid configuration item path|  | | <a name=\"760\">760</a>|Invalid configuration set type|  | | <a name=\"761\">761</a>|Invalid webhook HTTP content|  | | <a name=\"762\">762</a>|A failure occured when making a webhook request|  | | <a name=\"776\">776</a>|Delivery already exists|  | | <a name=\"777\">777</a>|Delivery not found|  | | <a name=\"779\">779</a>|Invalid message content|  | | <a name=\"794\">794</a>|Cannot modify the existing subscription.|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"884\">884</a>|Missing licence to access feature.|  | | <a name=\"885\">885</a>|Error sending to AWS SQS.|  | 
 *
 * The version of the OpenAPI document: 0.1.1056
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Finbourne.Notifications.Sdk.Model
{
    /// <summary>
    ///  Abstract base class for oneOf, anyOf schemas in the OpenAPI specification
    /// </summary>
    public abstract partial class AbstractOpenAPISchema
    {
        /// <summary>
        ///  Custom JSON serializer
        /// </summary>
        static public readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            MissingMemberHandling = MissingMemberHandling.Error,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        /// <summary>
        ///  Custom JSON serializer for objects with additional properties
        /// </summary>
        static public readonly JsonSerializerSettings AdditionalPropertiesSerializerSettings = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        /// <summary>
        /// Gets or Sets the actual instance
        /// </summary>
        public abstract Object ActualInstance { get; set; }

        /// <summary>
        /// Gets or Sets IsNullable to indicate whether the instance is nullable
        /// </summary>
        public bool IsNullable { get; protected set; }

        /// <summary>
        /// Gets or Sets the schema type, which can be either `oneOf` or `anyOf`
        /// </summary>
        public string SchemaType { get; protected set; }

        /// <summary>
        /// Converts the instance into JSON string.
        /// </summary>
        public abstract string ToJson();
    }
}
