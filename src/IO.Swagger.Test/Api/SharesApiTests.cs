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
    ///  Class for testing SharesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SharesApiTests
    {
        private SharesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SharesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SharesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SharesApi
            //Assert.IsInstanceOfType(typeof(SharesApi), instance, "instance is a SharesApi");
        }

        /// <summary>
        /// Test AddShare
        /// </summary>
        [Test]
        public void AddShareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string evApiKey = null;
            //string evAccessToken = null;
            //Body16 body = null;
            //var response = instance.AddShare(evApiKey, evAccessToken, body);
            //Assert.IsInstanceOf<ShareResponse> (response, "response is ShareResponse");
        }
        /// <summary>
        /// Test CompleteDirectSend
        /// </summary>
        [Test]
        public void CompleteDirectSendTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string evApiKey = null;
            //string evAccessToken = null;
            //int? id = null;
            //var response = instance.CompleteDirectSend(evApiKey, evAccessToken, id);
            //Assert.IsInstanceOf<ShareResponse> (response, "response is ShareResponse");
        }
        /// <summary>
        /// Test DeleteShareById
        /// </summary>
        [Test]
        public void DeleteShareByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string evApiKey = null;
            //string evAccessToken = null;
            //var response = instance.DeleteShareById(id, evApiKey, evAccessToken);
            //Assert.IsInstanceOf<EmptyResponse> (response, "response is EmptyResponse");
        }
        /// <summary>
        /// Test GetShareById
        /// </summary>
        [Test]
        public void GetShareByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string evApiKey = null;
            //string evAccessToken = null;
            //string include = null;
            //var response = instance.GetShareById(id, evApiKey, evAccessToken, include);
            //Assert.IsInstanceOf<ShareResponse> (response, "response is ShareResponse");
        }
        /// <summary>
        /// Test ListShares
        /// </summary>
        [Test]
        public void ListSharesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string evApiKey = null;
            //string evAccessToken = null;
            //int? offset = null;
            //int? limit = null;
            //string scope = null;
            //string sort = null;
            //string type = null;
            //string include = null;
            //string name = null;
            //string recipient = null;
            //string message = null;
            //string username = null;
            //string search = null;
            //var response = instance.ListShares(evApiKey, evAccessToken, offset, limit, scope, sort, type, include, name, recipient, message, username, search);
            //Assert.IsInstanceOf<ShareCollectionResponse> (response, "response is ShareCollectionResponse");
        }
        /// <summary>
        /// Test UpdateShareById
        /// </summary>
        [Test]
        public void UpdateShareByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body17 body = null;
            //string evApiKey = null;
            //string evAccessToken = null;
            //int? id = null;
            //var response = instance.UpdateShareById(body, evApiKey, evAccessToken, id);
            //Assert.IsInstanceOf<ShareResponse> (response, "response is ShareResponse");
        }
    }

}