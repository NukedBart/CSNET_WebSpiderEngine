using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace WebSpiderEngine
{
    public class Request
    {
        private HttpStatusCode stat;
        private string text;
        private Stream raw;
        public Request(HttpStatusCode pose, string content, Stream rawcontent)
        {
            stat = pose;
            text = content;
            raw = rawcontent;
        }
        public string Text()
        {
            return text;
        }
        public HttpStatusCode Status()
        {
            return stat;
        }
        public Stream Raw()
        {
            return raw;
        }
    }
}
