using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkAPI
{
    public class HttpQuery
    {
        private string _uri;

        public HttpQuery(string url)
        {
            _uri = url;
        }

        public void AddKeyValuePair(string key, string value)
        {
            _uri +=@"?"+key+"="+value;
        }
    }
}
