﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications;
//
//    var orderStatusChangeNotification = OrderStatusChangeNotification.FromJson(jsonString);

namespace Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The root schema comprises the entire JSON document.
    /// </summary>
    public partial class OrderStatusChangeNotification
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("EventTime")]
        public string EventTime { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("NotificationMetadata")]
        public NotificationMetadataSchema NotificationMetadata { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("NotificationType")]
        public string NotificationType { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("NotificationVersion")]
        public string NotificationVersion { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("Payload")]
        public PayloadSchema Payload { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("PayloadVersion")]
        public string PayloadVersion { get; set; }
    }

    /// <summary>
    /// An explanation about the purpose of this instance.
    /// </summary>
    public partial class PayloadSchema
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("OrderStatusChangeNotification")]
        public OrderStatusChangeNotificationSchema OrderStatusChangeNotification { get; set; }
    }

    /// <summary>
    /// An explanation about the purpose of this instance.
    /// </summary>
    public partial class OrderStatusChangeNotificationSchema
    {
        /// <summary>
        /// An Amazon-defined order identifier in 3-7-7 format.
        /// </summary>
        [JsonProperty("AmazonOrderId")]
        public string AmazonOrderId { get; set; }

        /// <summary>
        /// The destination postal code.
        /// </summary>
        [JsonProperty("DestinationPostalCode")]
        public string DestinationPostalCode { get; set; }

        /// <summary>
        /// Fulfillment channel of the affected order, MFN or AFN.
        /// </summary>
        [JsonProperty("FulfillmentChannel")]
        public string FulfillmentChannel { get; set; }

        /// <summary>
        /// Amazon marketplace identifier of the affected order.
        /// </summary>
        [JsonProperty("MarketplaceId")]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The Amazon-defined order item identifier.
        /// </summary>
        [JsonProperty("OrderItemId")]
        public string OrderItemId { get; set; }

        /// <summary>
        /// The current order status. The possible values include UpComing, Pending, Unshipped,
        /// PartiallyShipped, PendingAvailability, Canceled, InvoiceUnconfirmed, Shipped, and
        /// Unfulfillable.
        /// </summary>
        [JsonProperty("OrderStatus")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// The purchase date of the order in Epoch time.
        /// </summary>
        [JsonProperty("PurchaseDate")]
        public long? PurchaseDate { get; set; }

        /// <summary>
        /// The number of items in the order.
        /// </summary>
        [JsonProperty("Quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The selling partner identifier.
        /// </summary>
        [JsonProperty("SellerId")]
        public string SellerId { get; set; }

        /// <summary>
        /// The seller-specific SKU identifier for an item.
        /// </summary>
        [JsonProperty("SellerSKU")]
        public string SellerSku { get; set; }

        /// <summary>
        /// The unique identifier of the supply source.
        /// </summary>
        [JsonProperty("SupplySourceId")]
        public string SupplySourceId { get; set; }
    }

    public partial class OrderStatusChangeNotification
    {
        public static OrderStatusChangeNotification FromJson(string json) => JsonConvert.DeserializeObject<OrderStatusChangeNotification>(json, Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications.Converter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this OrderStatusChangeNotification self) => JsonConvert.SerializeObject(self, Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications.Converter.Settings);
    }
}