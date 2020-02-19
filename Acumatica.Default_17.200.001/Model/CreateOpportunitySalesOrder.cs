/* 
 * Default/17.200.001
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Acumatica.RESTClient.Model;
using System.ComponentModel.DataAnnotations;


namespace Acumatica.Default_17_200_001.Model
{
    /// <summary>
    /// CreateOpportunitySalesOrder
    /// </summary>
    [DataContract]
    public partial class CreateOpportunitySalesOrder :  IEquatable<CreateOpportunitySalesOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOpportunitySalesOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOpportunitySalesOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOpportunitySalesOrder" /> class.
        /// </summary>
        /// <param name="entity">entity (required).</param>
        /// <param name="parameters">parameters (required).</param>
        public CreateOpportunitySalesOrder(Opportunity entity = default(Opportunity), CreateOpportunitySalesOrderParameters parameters = default(CreateOpportunitySalesOrderParameters))
        {
            // to ensure "entity" is required (not null)
            if (entity == null)
            {
                throw new InvalidDataException("entity is a required property for CreateOpportunitySalesOrder and cannot be null");
            }
            else
            {
                this.Entity = entity;
            }
            // to ensure "parameters" is required (not null)
            if (parameters == null)
            {
                throw new InvalidDataException("parameters is a required property for CreateOpportunitySalesOrder and cannot be null");
            }
            else
            {
                this.Parameters = parameters;
            }
        }
        
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public Opportunity Entity { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public CreateOpportunitySalesOrderParameters Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOpportunitySalesOrder {\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOpportunitySalesOrder);
        }

        /// <summary>
        /// Returns true if CreateOpportunitySalesOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateOpportunitySalesOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOpportunitySalesOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    (this.Parameters != null &&
                    this.Parameters.Equals(input.Parameters))
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
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
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

}