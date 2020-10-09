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
    ///  Class for testing ActivityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ActivityApiTests
    {
        private ActivityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ActivityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ActivityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ActivityApi
            //Assert.IsInstanceOfType(typeof(ActivityApi), instance, "instance is a ActivityApi");
        }

        /// <summary>
        /// Test GetSessionLogs
        /// </summary>
        [Test]
        public void GetSessionLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string evApiKey = null;
            //string evAccessToken = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string ipAddress = null;
            //string userName = null;
            //string path = null;
            //string type = null;
            //int? offset = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetSessionLogs(evApiKey, evAccessToken, startDate, endDate, ipAddress, userName, path, type, offset, limit, sort);
            //Assert.IsInstanceOf<SessionActivityResponse> (response, "response is SessionActivityResponse");
        }
        /// <summary>
        /// Test GetWebhookLogs
        /// </summary>
        [Test]
        public void GetWebhookLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string evApiKey = null;
            //string evAccessToken = null;
            //string _event = null;
            //int? statusCode = null;
            //string path = null;
            //string username = null;
            //int? offset = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetWebhookLogs(evApiKey, evAccessToken, _event, statusCode, path, username, offset, limit, sort);
            //Assert.IsInstanceOf<WebhooksActivityResponse> (response, "response is WebhooksActivityResponse");
        }
    }

}