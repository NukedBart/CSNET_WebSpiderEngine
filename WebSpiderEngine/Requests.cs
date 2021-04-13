using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace WebSpiderEngine
{
    public class Requests
    {
        // Get() Usage:
        //  url: Well, just url to send a request to
        // if everything was correct you will get a Request like this:
        // Request:
        //  stat = OK;
        //  text = "<html>\r\n<head>\r\n<title>test</title>\r\n</head>\r\n<body>\r\n<p id="article-090255673">This is an article.</p>\r\n</body>\r\n</html>"
        //  raw = Stream stream
        public Request Get(string url)
        {
            string html = string.Empty;
            //string aurl = @url;
            HttpWebResponse response = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException we)
            {
                response = (HttpWebResponse)we.Response;
            }

            Stream stream = (response != null) ? response.GetResponseStream() : null;
            StreamReader reader = (stream != null) ? new StreamReader(stream) : null;
            {
                html = (reader != null) ? reader.ReadToEnd() : "No Response Raw Content.";
            }

            return (response == null) ?
                new Request(HttpStatusCode.BadRequest, html, stream)
                : new Request(response.StatusCode, html, stream);
        }
    }
}
