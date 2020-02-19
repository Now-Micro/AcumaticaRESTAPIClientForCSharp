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
    /// StockItemVendorDetail
    /// </summary>
    [DataContract]
    public partial class StockItemVendorDetail : Entity,  IEquatable<StockItemVendorDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockItemVendorDetail" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="addLeadTimeDays">addLeadTimeDays.</param>
        /// <param name="currencyID">currencyID.</param>
        /// <param name="_default">_default.</param>
        /// <param name="eOQ">eOQ.</param>
        /// <param name="lastVendorPrice">lastVendorPrice.</param>
        /// <param name="leadTimeDays">leadTimeDays.</param>
        /// <param name="location">location.</param>
        /// <param name="lotSize">lotSize.</param>
        /// <param name="maxOrderQty">maxOrderQty.</param>
        /// <param name="minOrderFrequencyInDays">minOrderFrequencyInDays.</param>
        /// <param name="minOrderQty">minOrderQty.</param>
        /// <param name="_override">_override.</param>
        /// <param name="purchaseUnit">purchaseUnit.</param>
        /// <param name="recordID">recordID.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="vendorID">vendorID.</param>
        /// <param name="vendorName">vendorName.</param>
        /// <param name="warehouse">warehouse.</param>
        public StockItemVendorDetail(BooleanValue active = default(BooleanValue), ShortValue addLeadTimeDays = default(ShortValue), StringValue currencyID = default(StringValue), BooleanValue _default = default(BooleanValue), DecimalValue eOQ = default(DecimalValue), DecimalValue lastVendorPrice = default(DecimalValue), ShortValue leadTimeDays = default(ShortValue), StringValue location = default(StringValue), DecimalValue lotSize = default(DecimalValue), DecimalValue maxOrderQty = default(DecimalValue), IntValue minOrderFrequencyInDays = default(IntValue), DecimalValue minOrderQty = default(DecimalValue), BooleanValue _override = default(BooleanValue), StringValue purchaseUnit = default(StringValue), IntValue recordID = default(IntValue), StringValue subitem = default(StringValue), StringValue vendorID = default(StringValue), StringValue vendorName = default(StringValue), StringValue warehouse = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Active = active;
            this.AddLeadTimeDays = addLeadTimeDays;
            this.CurrencyID = currencyID;
            this.Default = _default;
            this.EOQ = eOQ;
            this.LastVendorPrice = lastVendorPrice;
            this.LeadTimeDays = leadTimeDays;
            this.Location = location;
            this.LotSize = lotSize;
            this.MaxOrderQty = maxOrderQty;
            this.MinOrderFrequencyInDays = minOrderFrequencyInDays;
            this.MinOrderQty = minOrderQty;
            this.Override = _override;
            this.PurchaseUnit = purchaseUnit;
            this.RecordID = recordID;
            this.Subitem = subitem;
            this.VendorID = vendorID;
            this.VendorName = vendorName;
            this.Warehouse = warehouse;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public BooleanValue Active { get; set; }

        /// <summary>
        /// Gets or Sets AddLeadTimeDays
        /// </summary>
        [DataMember(Name="AddLeadTimeDays", EmitDefaultValue=false)]
        public ShortValue AddLeadTimeDays { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public StringValue CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name="Default", EmitDefaultValue=false)]
        public BooleanValue Default { get; set; }

        /// <summary>
        /// Gets or Sets EOQ
        /// </summary>
        [DataMember(Name="EOQ", EmitDefaultValue=false)]
        public DecimalValue EOQ { get; set; }

        /// <summary>
        /// Gets or Sets LastVendorPrice
        /// </summary>
        [DataMember(Name="LastVendorPrice", EmitDefaultValue=false)]
        public DecimalValue LastVendorPrice { get; set; }

        /// <summary>
        /// Gets or Sets LeadTimeDays
        /// </summary>
        [DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
        public ShortValue LeadTimeDays { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public StringValue Location { get; set; }

        /// <summary>
        /// Gets or Sets LotSize
        /// </summary>
        [DataMember(Name="LotSize", EmitDefaultValue=false)]
        public DecimalValue LotSize { get; set; }

        /// <summary>
        /// Gets or Sets MaxOrderQty
        /// </summary>
        [DataMember(Name="MaxOrderQty", EmitDefaultValue=false)]
        public DecimalValue MaxOrderQty { get; set; }

        /// <summary>
        /// Gets or Sets MinOrderFrequencyInDays
        /// </summary>
        [DataMember(Name="MinOrderFrequencyInDays", EmitDefaultValue=false)]
        public IntValue MinOrderFrequencyInDays { get; set; }

        /// <summary>
        /// Gets or Sets MinOrderQty
        /// </summary>
        [DataMember(Name="MinOrderQty", EmitDefaultValue=false)]
        public DecimalValue MinOrderQty { get; set; }

        /// <summary>
        /// Gets or Sets Override
        /// </summary>
        [DataMember(Name="Override", EmitDefaultValue=false)]
        public BooleanValue Override { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseUnit
        /// </summary>
        [DataMember(Name="PurchaseUnit", EmitDefaultValue=false)]
        public StringValue PurchaseUnit { get; set; }

        /// <summary>
        /// Gets or Sets RecordID
        /// </summary>
        [DataMember(Name="RecordID", EmitDefaultValue=false)]
        public IntValue RecordID { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets VendorID
        /// </summary>
        [DataMember(Name="VendorID", EmitDefaultValue=false)]
        public StringValue VendorID { get; set; }

        /// <summary>
        /// Gets or Sets VendorName
        /// </summary>
        [DataMember(Name="VendorName", EmitDefaultValue=false)]
        public StringValue VendorName { get; set; }

        /// <summary>
        /// Gets or Sets Warehouse
        /// </summary>
        [DataMember(Name="Warehouse", EmitDefaultValue=false)]
        public StringValue Warehouse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StockItemVendorDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AddLeadTimeDays: ").Append(AddLeadTimeDays).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  EOQ: ").Append(EOQ).Append("\n");
            sb.Append("  LastVendorPrice: ").Append(LastVendorPrice).Append("\n");
            sb.Append("  LeadTimeDays: ").Append(LeadTimeDays).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LotSize: ").Append(LotSize).Append("\n");
            sb.Append("  MaxOrderQty: ").Append(MaxOrderQty).Append("\n");
            sb.Append("  MinOrderFrequencyInDays: ").Append(MinOrderFrequencyInDays).Append("\n");
            sb.Append("  MinOrderQty: ").Append(MinOrderQty).Append("\n");
            sb.Append("  Override: ").Append(Override).Append("\n");
            sb.Append("  PurchaseUnit: ").Append(PurchaseUnit).Append("\n");
            sb.Append("  RecordID: ").Append(RecordID).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  VendorID: ").Append(VendorID).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
            sb.Append("  Warehouse: ").Append(Warehouse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as StockItemVendorDetail);
        }

        /// <summary>
        /// Returns true if StockItemVendorDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of StockItemVendorDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockItemVendorDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && base.Equals(input) && 
                (
                    this.AddLeadTimeDays == input.AddLeadTimeDays ||
                    (this.AddLeadTimeDays != null &&
                    this.AddLeadTimeDays.Equals(input.AddLeadTimeDays))
                ) && base.Equals(input) && 
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && base.Equals(input) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && base.Equals(input) && 
                (
                    this.EOQ == input.EOQ ||
                    (this.EOQ != null &&
                    this.EOQ.Equals(input.EOQ))
                ) && base.Equals(input) && 
                (
                    this.LastVendorPrice == input.LastVendorPrice ||
                    (this.LastVendorPrice != null &&
                    this.LastVendorPrice.Equals(input.LastVendorPrice))
                ) && base.Equals(input) && 
                (
                    this.LeadTimeDays == input.LeadTimeDays ||
                    (this.LeadTimeDays != null &&
                    this.LeadTimeDays.Equals(input.LeadTimeDays))
                ) && base.Equals(input) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && base.Equals(input) && 
                (
                    this.LotSize == input.LotSize ||
                    (this.LotSize != null &&
                    this.LotSize.Equals(input.LotSize))
                ) && base.Equals(input) && 
                (
                    this.MaxOrderQty == input.MaxOrderQty ||
                    (this.MaxOrderQty != null &&
                    this.MaxOrderQty.Equals(input.MaxOrderQty))
                ) && base.Equals(input) && 
                (
                    this.MinOrderFrequencyInDays == input.MinOrderFrequencyInDays ||
                    (this.MinOrderFrequencyInDays != null &&
                    this.MinOrderFrequencyInDays.Equals(input.MinOrderFrequencyInDays))
                ) && base.Equals(input) && 
                (
                    this.MinOrderQty == input.MinOrderQty ||
                    (this.MinOrderQty != null &&
                    this.MinOrderQty.Equals(input.MinOrderQty))
                ) && base.Equals(input) && 
                (
                    this.Override == input.Override ||
                    (this.Override != null &&
                    this.Override.Equals(input.Override))
                ) && base.Equals(input) && 
                (
                    this.PurchaseUnit == input.PurchaseUnit ||
                    (this.PurchaseUnit != null &&
                    this.PurchaseUnit.Equals(input.PurchaseUnit))
                ) && base.Equals(input) && 
                (
                    this.RecordID == input.RecordID ||
                    (this.RecordID != null &&
                    this.RecordID.Equals(input.RecordID))
                ) && base.Equals(input) && 
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) && 
                (
                    this.VendorID == input.VendorID ||
                    (this.VendorID != null &&
                    this.VendorID.Equals(input.VendorID))
                ) && base.Equals(input) && 
                (
                    this.VendorName == input.VendorName ||
                    (this.VendorName != null &&
                    this.VendorName.Equals(input.VendorName))
                ) && base.Equals(input) && 
                (
                    this.Warehouse == input.Warehouse ||
                    (this.Warehouse != null &&
                    this.Warehouse.Equals(input.Warehouse))
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
                int hashCode = base.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.AddLeadTimeDays != null)
                    hashCode = hashCode * 59 + this.AddLeadTimeDays.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.EOQ != null)
                    hashCode = hashCode * 59 + this.EOQ.GetHashCode();
                if (this.LastVendorPrice != null)
                    hashCode = hashCode * 59 + this.LastVendorPrice.GetHashCode();
                if (this.LeadTimeDays != null)
                    hashCode = hashCode * 59 + this.LeadTimeDays.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.LotSize != null)
                    hashCode = hashCode * 59 + this.LotSize.GetHashCode();
                if (this.MaxOrderQty != null)
                    hashCode = hashCode * 59 + this.MaxOrderQty.GetHashCode();
                if (this.MinOrderFrequencyInDays != null)
                    hashCode = hashCode * 59 + this.MinOrderFrequencyInDays.GetHashCode();
                if (this.MinOrderQty != null)
                    hashCode = hashCode * 59 + this.MinOrderQty.GetHashCode();
                if (this.Override != null)
                    hashCode = hashCode * 59 + this.Override.GetHashCode();
                if (this.PurchaseUnit != null)
                    hashCode = hashCode * 59 + this.PurchaseUnit.GetHashCode();
                if (this.RecordID != null)
                    hashCode = hashCode * 59 + this.RecordID.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.VendorID != null)
                    hashCode = hashCode * 59 + this.VendorID.GetHashCode();
                if (this.VendorName != null)
                    hashCode = hashCode * 59 + this.VendorName.GetHashCode();
                if (this.Warehouse != null)
                    hashCode = hashCode * 59 + this.Warehouse.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}