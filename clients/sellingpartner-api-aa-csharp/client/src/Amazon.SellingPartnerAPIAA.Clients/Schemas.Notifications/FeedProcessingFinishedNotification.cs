﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications;
//
//    var feedProcessingFinishedNotification = FeedProcessingFinishedNotification.FromJson(jsonString);

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
    public partial class FeedProcessingFinishedNotification
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("eventTime")]
        public string EventTime { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("notificationMetadata")]
        public NotificationMetadata NotificationMetadata { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("notificationType")]
        public string NotificationType { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("notificationVersion")]
        public string NotificationVersion { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("payload")]
        public Payload Payload { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("payloadVersion")]
        public string PayloadVersion { get; set; }
    }

    /// <summary>
    /// An explanation about the purpose of this instance.
    /// </summary>
    public partial class Payload
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("feedProcessingFinishedNotification")]
        public FeedProcessingFinishedNotificationClass FeedProcessingFinishedNotification { get; set; }
    }

    /// <summary>
    /// An explanation about the purpose of this instance.
    /// </summary>
    public partial class FeedProcessingFinishedNotificationClass
    {
        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("feedId")]
        public string FeedId { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("feedType")]
        public string FeedType { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("processingStatus")]
        public ProcessingStatus ProcessingStatus { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("resultFeedDocumentId", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultFeedDocumentId { get; set; }

        /// <summary>
        /// An explanation about the purpose of this instance.
        /// </summary>
        [JsonProperty("sellerId")]
        public string SellerId { get; set; }
    }

    public partial class FeedProcessingFinishedNotification
    {
        public static FeedProcessingFinishedNotification FromJson(string json) => JsonConvert.DeserializeObject<FeedProcessingFinishedNotification>(json, Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications.Converter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this FeedProcessingFinishedNotification self) => JsonConvert.SerializeObject(self, Amazon.SellingPartnerAPIAA.Clients.Schemas.Notifications.Converter.Settings);
    }
}