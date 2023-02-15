/* 
 * Selling Partner API for Orders
 *
 * The Selling Partner API for Orders helps you programmatically retrieve order information. These APIs let you develop fast, flexible, custom applications in areas like order synchronization, order research, and demand-based decision support tools.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Models.Orders;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Orders.Test
{
    /// <summary>
    ///  Class for testing OrderItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class OrderItemTests
    {
        // TODO uncomment below to declare an instance variable for OrderItem
        //private OrderItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of OrderItem
            //instance = new OrderItem();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderItem
        /// </summary>
        [Test]
        public void OrderItemInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" OrderItem
            //Assert.IsInstanceOfType<OrderItem> (instance, "variable 'instance' is a OrderItem");
        }


        /// <summary>
        /// Test the property 'ASIN'
        /// </summary>
        [Test]
        public void ASINTest()
        {
            // TODO unit test for the property 'ASIN'
        }
        /// <summary>
        /// Test the property 'SellerSKU'
        /// </summary>
        [Test]
        public void SellerSKUTest()
        {
            // TODO unit test for the property 'SellerSKU'
        }
        /// <summary>
        /// Test the property 'OrderItemId'
        /// </summary>
        [Test]
        public void OrderItemIdTest()
        {
            // TODO unit test for the property 'OrderItemId'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'QuantityOrdered'
        /// </summary>
        [Test]
        public void QuantityOrderedTest()
        {
            // TODO unit test for the property 'QuantityOrdered'
        }
        /// <summary>
        /// Test the property 'QuantityShipped'
        /// </summary>
        [Test]
        public void QuantityShippedTest()
        {
            // TODO unit test for the property 'QuantityShipped'
        }
        /// <summary>
        /// Test the property 'ProductInfo'
        /// </summary>
        [Test]
        public void ProductInfoTest()
        {
            // TODO unit test for the property 'ProductInfo'
        }
        /// <summary>
        /// Test the property 'PointsGranted'
        /// </summary>
        [Test]
        public void PointsGrantedTest()
        {
            // TODO unit test for the property 'PointsGranted'
        }
        /// <summary>
        /// Test the property 'ItemPrice'
        /// </summary>
        [Test]
        public void ItemPriceTest()
        {
            // TODO unit test for the property 'ItemPrice'
        }
        /// <summary>
        /// Test the property 'ShippingPrice'
        /// </summary>
        [Test]
        public void ShippingPriceTest()
        {
            // TODO unit test for the property 'ShippingPrice'
        }
        /// <summary>
        /// Test the property 'ItemTax'
        /// </summary>
        [Test]
        public void ItemTaxTest()
        {
            // TODO unit test for the property 'ItemTax'
        }
        /// <summary>
        /// Test the property 'ShippingTax'
        /// </summary>
        [Test]
        public void ShippingTaxTest()
        {
            // TODO unit test for the property 'ShippingTax'
        }
        /// <summary>
        /// Test the property 'ShippingDiscount'
        /// </summary>
        [Test]
        public void ShippingDiscountTest()
        {
            // TODO unit test for the property 'ShippingDiscount'
        }
        /// <summary>
        /// Test the property 'ShippingDiscountTax'
        /// </summary>
        [Test]
        public void ShippingDiscountTaxTest()
        {
            // TODO unit test for the property 'ShippingDiscountTax'
        }
        /// <summary>
        /// Test the property 'PromotionDiscount'
        /// </summary>
        [Test]
        public void PromotionDiscountTest()
        {
            // TODO unit test for the property 'PromotionDiscount'
        }
        /// <summary>
        /// Test the property 'PromotionDiscountTax'
        /// </summary>
        [Test]
        public void PromotionDiscountTaxTest()
        {
            // TODO unit test for the property 'PromotionDiscountTax'
        }
        /// <summary>
        /// Test the property 'PromotionIds'
        /// </summary>
        [Test]
        public void PromotionIdsTest()
        {
            // TODO unit test for the property 'PromotionIds'
        }
        /// <summary>
        /// Test the property 'CODFee'
        /// </summary>
        [Test]
        public void CODFeeTest()
        {
            // TODO unit test for the property 'CODFee'
        }
        /// <summary>
        /// Test the property 'CODFeeDiscount'
        /// </summary>
        [Test]
        public void CODFeeDiscountTest()
        {
            // TODO unit test for the property 'CODFeeDiscount'
        }
        /// <summary>
        /// Test the property 'IsGift'
        /// </summary>
        [Test]
        public void IsGiftTest()
        {
            // TODO unit test for the property 'IsGift'
        }
        /// <summary>
        /// Test the property 'ConditionNote'
        /// </summary>
        [Test]
        public void ConditionNoteTest()
        {
            // TODO unit test for the property 'ConditionNote'
        }
        /// <summary>
        /// Test the property 'ConditionId'
        /// </summary>
        [Test]
        public void ConditionIdTest()
        {
            // TODO unit test for the property 'ConditionId'
        }
        /// <summary>
        /// Test the property 'ConditionSubtypeId'
        /// </summary>
        [Test]
        public void ConditionSubtypeIdTest()
        {
            // TODO unit test for the property 'ConditionSubtypeId'
        }
        /// <summary>
        /// Test the property 'ScheduledDeliveryStartDate'
        /// </summary>
        [Test]
        public void ScheduledDeliveryStartDateTest()
        {
            // TODO unit test for the property 'ScheduledDeliveryStartDate'
        }
        /// <summary>
        /// Test the property 'ScheduledDeliveryEndDate'
        /// </summary>
        [Test]
        public void ScheduledDeliveryEndDateTest()
        {
            // TODO unit test for the property 'ScheduledDeliveryEndDate'
        }
        /// <summary>
        /// Test the property 'PriceDesignation'
        /// </summary>
        [Test]
        public void PriceDesignationTest()
        {
            // TODO unit test for the property 'PriceDesignation'
        }
        /// <summary>
        /// Test the property 'TaxCollection'
        /// </summary>
        [Test]
        public void TaxCollectionTest()
        {
            // TODO unit test for the property 'TaxCollection'
        }
        /// <summary>
        /// Test the property 'SerialNumberRequired'
        /// </summary>
        [Test]
        public void SerialNumberRequiredTest()
        {
            // TODO unit test for the property 'SerialNumberRequired'
        }
        /// <summary>
        /// Test the property 'IsTransparency'
        /// </summary>
        [Test]
        public void IsTransparencyTest()
        {
            // TODO unit test for the property 'IsTransparency'
        }
        /// <summary>
        /// Test the property 'IossNumber'
        /// </summary>
        [Test]
        public void IossNumberTest()
        {
            // TODO unit test for the property 'IossNumber'
        }
        /// <summary>
        /// Test the property 'StoreChainStoreId'
        /// </summary>
        [Test]
        public void StoreChainStoreIdTest()
        {
            // TODO unit test for the property 'StoreChainStoreId'
        }
        /// <summary>
        /// Test the property 'DeemedResellerCategory'
        /// </summary>
        [Test]
        public void DeemedResellerCategoryTest()
        {
            // TODO unit test for the property 'DeemedResellerCategory'
        }
        /// <summary>
        /// Test the property 'BuyerInfo'
        /// </summary>
        [Test]
        public void BuyerInfoTest()
        {
            // TODO unit test for the property 'BuyerInfo'
        }
        /// <summary>
        /// Test the property 'BuyerRequestedCancel'
        /// </summary>
        [Test]
        public void BuyerRequestedCancelTest()
        {
            // TODO unit test for the property 'BuyerRequestedCancel'
        }
        /// <summary>
        /// Test the property 'ItemApprovalContext'
        /// </summary>
        [Test]
        public void ItemApprovalContextTest()
        {
            // TODO unit test for the property 'ItemApprovalContext'
        }
        /// <summary>
        /// Test the property 'SerialNumbers'
        /// </summary>
        [Test]
        public void SerialNumbersTest()
        {
            // TODO unit test for the property 'SerialNumbers'
        }

    }

}