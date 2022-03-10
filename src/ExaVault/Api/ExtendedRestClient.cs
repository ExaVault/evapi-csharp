using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExaVault.Api
{
    public class ExtendedRestClient : RestClient
    {
        private Uri _baseUrl;
        public Uri BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }

        public int _timeout;
        public int Timeout
        {
            get { return _timeout; }
            set { _timeout = value; }
        }

        public ExtendedRestClient(string baseUrl)
        {
            _baseUrl = new Uri(baseUrl);
        }
    }
}
