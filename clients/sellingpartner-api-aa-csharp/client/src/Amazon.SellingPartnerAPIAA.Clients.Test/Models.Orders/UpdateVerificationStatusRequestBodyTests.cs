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
    ///  Class for testing UpdateVerificationStatusRequestBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UpdateVerificationStatusRequestBodyTests
    {
        // TODO uncomment below to declare an instance variable for UpdateVerificationStatusRequestBody
        //private UpdateVerificationStatusRequestBody instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UpdateVerificationStatusRequestBody
            //instance = new UpdateVerificationStatusRequestBody();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UpdateVerificationStatusRequestBody
        /// </summary>
        [Test]
        public void UpdateVerificationStatusRequestBodyInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UpdateVerificationStatusRequestBody
            //Assert.IsInstanceOfType<UpdateVerificationStatusRequestBody> (instance, "variable 'instance' is a UpdateVerificationStatusRequestBody");
        }


        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'ExternalReviewerId'
        /// </summary>
        [Test]
        public void ExternalReviewerIdTest()
        {
            // TODO unit test for the property 'ExternalReviewerId'
        }
        /// <summary>
        /// Test the property 'RejectionReasonId'
        /// </summary>
        [Test]
        public void RejectionReasonIdTest()
        {
            // TODO unit test for the property 'RejectionReasonId'
        }

    }

}