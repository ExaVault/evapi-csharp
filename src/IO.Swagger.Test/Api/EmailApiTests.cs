/* 
 * ExaVault API
 *
 * See our API reference documentation at https://www.exavault.com/developer/api-docs/
 *
 * OpenAPI spec version: 2.0
 * Contact: support@exavault.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing EmailApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EmailApiTests
    {
        private EmailApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EmailApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EmailApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EmailApi
            //Assert.IsInstanceOfType(typeof(EmailApi), instance, "instance is a EmailApi");
        }

        /// <summary>
        /// Test SendReferralEmail
        /// </summary>
        [Test]
        public void SendReferralEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string evApiKey = null;
            //string evAccessToken = null;
            //Body15 body = null;
            //var response = instance.SendReferralEmail(evApiKey, evAccessToken, body);
            //Assert.IsInstanceOf<EmptyResponse> (response, "response is EmptyResponse");
        }
        /// <summary>
        /// Test SendWelcomeEmail
        /// </summary>
        [Test]
        public void SendWelcomeEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string evApiKey = null;
            //string evAccessToken = null;
            //string username = null;
            //var response = instance.SendWelcomeEmail(evApiKey, evAccessToken, username);
            //Assert.IsInstanceOf<EmptyResponse> (response, "response is EmptyResponse");
        }
    }

}