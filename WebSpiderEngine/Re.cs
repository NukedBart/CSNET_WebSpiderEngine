using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WebSpiderEngine
{
    public class Re
    {
        // Find() Usage: 
        //  pattern: search pattern, example: "<p id="article-090255673">(?<key1>.*?)</p>"
        //  target: target to match with the pattern, example: "<p id="article-090255673">This is an article.</p>"
        //  keys: How much data you want to add to the array, example: 1
        //      notice: keys are related to the pattern, if your pattern looks like this, you should use keys = 2 :
        //      "<p id="article-(?<key2>.*?)">(?<key1>.*?)</p>"
        //  if the above argument is correct, Find() should return a string array looks like this:
        //  m = { "This is an article" }
        public string[] Find(string pattern, string target, int keys)
        {
            List<string> result = new List<string>();
            MatchCollection match = Regex.Matches(target, pattern, options: RegexOptions.Multiline);

            for (int i = 1; i <= keys; i++)
            {
                result.AddRange(from Match item in match select item.Groups[("key" + i.ToString())].Value);
            }
            return result.ToArray();
        }
    }
}
