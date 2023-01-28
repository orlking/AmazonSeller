/* 
 * Selling Partner API for Feeds
 *
 * The Selling Partner API for Feeds lets you upload data to Amazon on behalf of a selling partner.
 *
 * OpenAPI spec version: 2021-06-30
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Amazon.SellingPartnerAPIAA.Client.Model
{
    /// <summary>
    /// Response schema.
    /// </summary>
    [DataContract]
    public partial class GetFeedsResponse : IEquatable<GetFeedsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeedsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFeedsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeedsResponse" /> class.
        /// </summary>
        /// <param name="feeds">The feeds. (required).</param>
        /// <param name="nextToken">Returned when the number of results exceeds pageSize. To get the next page of results, call the getFeeds operation with this token as the only parameter..</param>
        public GetFeedsResponse(FeedList feeds = default(FeedList), string nextToken = default(string))
        {
            // to ensure "feeds" is required (not null)
            if (feeds == null)
            {
                throw new InvalidDataException("feeds is a required property for GetFeedsResponse and cannot be null");
            }
            else
            {
                this.Feeds = feeds;
            }
            this.NextToken = nextToken;
        }

        /// <summary>
        /// The feeds.
        /// </summary>
        /// <value>The feeds.</value>
        [DataMember(Name = "feeds", EmitDefaultValue = false)]
        public FeedList Feeds { get; set; }

        /// <summary>
        /// Returned when the number of results exceeds pageSize. To get the next page of results, call the getFeeds operation with this token as the only parameter.
        /// </summary>
        /// <value>Returned when the number of results exceeds pageSize. To get the next page of results, call the getFeeds operation with this token as the only parameter.</value>
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFeedsResponse {\n");
            sb.Append("  Feeds: ").Append(Feeds).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
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
            return this.Equals(input as GetFeedsResponse);
        }

        /// <summary>
        /// Returns true if GetFeedsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFeedsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFeedsResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Feeds == input.Feeds ||
                    (this.Feeds != null &&
                    this.Feeds.Equals(input.Feeds))
                ) &&
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
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
                if (this.Feeds != null)
                    hashCode = hashCode * 59 + this.Feeds.GetHashCode();
                if (this.NextToken != null)
                    hashCode = hashCode * 59 + this.NextToken.GetHashCode();
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