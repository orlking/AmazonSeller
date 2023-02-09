/* 
 * Selling Partner API for Catalog Items
 *
 * The Selling Partner API for Catalog Items provides programmatic access to information about items in the Amazon catalog.  For more information, refer to the [Catalog Items API Use Case Guide](doc:catalog-items-api-v2022-04-01-use-case-guide).
 *
 * OpenAPI spec version: 2022-04-01
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
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Amazon.SellingPartnerAPIAA.Clients.Client.SwaggerDateConverter;

namespace Amazon.SellingPartnerAPIAA.Clients.Models.Catalog
{
    /// <summary>
    /// Sales ranks of an Amazon catalog item for the indicated Amazon marketplace.
    /// </summary>
    [DataContract]
    public partial class ItemSalesRanksByMarketplace :  IEquatable<ItemSalesRanksByMarketplace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSalesRanksByMarketplace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemSalesRanksByMarketplace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSalesRanksByMarketplace" /> class.
        /// </summary>
        /// <param name="marketplaceId">Amazon marketplace identifier. (required).</param>
        /// <param name="classificationRanks">Sales ranks of an Amazon catalog item for an Amazon marketplace by classification..</param>
        /// <param name="displayGroupRanks">Sales ranks of an Amazon catalog item for an Amazon marketplace by website display group..</param>
        public ItemSalesRanksByMarketplace(string marketplaceId = default(string), List<ItemClassificationSalesRank> classificationRanks = default(List<ItemClassificationSalesRank>), List<ItemDisplayGroupSalesRank> displayGroupRanks = default(List<ItemDisplayGroupSalesRank>))
        {
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new InvalidDataException("marketplaceId is a required property for ItemSalesRanksByMarketplace and cannot be null");
            }
            else
            {
                this.MarketplaceId = marketplaceId;
            }
            this.ClassificationRanks = classificationRanks;
            this.DisplayGroupRanks = displayGroupRanks;
        }
        
        /// <summary>
        /// Amazon marketplace identifier.
        /// </summary>
        /// <value>Amazon marketplace identifier.</value>
        [DataMember(Name="marketplaceId", EmitDefaultValue=false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Sales ranks of an Amazon catalog item for an Amazon marketplace by classification.
        /// </summary>
        /// <value>Sales ranks of an Amazon catalog item for an Amazon marketplace by classification.</value>
        [DataMember(Name="classificationRanks", EmitDefaultValue=false)]
        public List<ItemClassificationSalesRank> ClassificationRanks { get; set; }

        /// <summary>
        /// Sales ranks of an Amazon catalog item for an Amazon marketplace by website display group.
        /// </summary>
        /// <value>Sales ranks of an Amazon catalog item for an Amazon marketplace by website display group.</value>
        [DataMember(Name="displayGroupRanks", EmitDefaultValue=false)]
        public List<ItemDisplayGroupSalesRank> DisplayGroupRanks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemSalesRanksByMarketplace {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  ClassificationRanks: ").Append(ClassificationRanks).Append("\n");
            sb.Append("  DisplayGroupRanks: ").Append(DisplayGroupRanks).Append("\n");
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
            return this.Equals(input as ItemSalesRanksByMarketplace);
        }

        /// <summary>
        /// Returns true if ItemSalesRanksByMarketplace instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemSalesRanksByMarketplace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemSalesRanksByMarketplace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) && 
                (
                    this.ClassificationRanks == input.ClassificationRanks ||
                    this.ClassificationRanks != null &&
                    this.ClassificationRanks.SequenceEqual(input.ClassificationRanks)
                ) && 
                (
                    this.DisplayGroupRanks == input.DisplayGroupRanks ||
                    this.DisplayGroupRanks != null &&
                    this.DisplayGroupRanks.SequenceEqual(input.DisplayGroupRanks)
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
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.ClassificationRanks != null)
                    hashCode = hashCode * 59 + this.ClassificationRanks.GetHashCode();
                if (this.DisplayGroupRanks != null)
                    hashCode = hashCode * 59 + this.DisplayGroupRanks.GetHashCode();
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
