using System;
using System.IO;
using System.Net;

namespace JH_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            string feedOutput = GetFeed();
            Console.WriteLine(feedOutput);
            Console.ReadLine();
        }
        //BS; Initial step in this process is to get the twitter feed
        private static string GetFeed()
        {
            WebRequest getTweets = WebRequest.Create("https://api.twitter.com/2/tweets/sample/stream?ids=1362477424202579968-Pq4U9qPKs5l3qX6MwzM3I71laCBrMJ,G9d6c4mi8ZETl1X2RDtHxIj1BghqLtW9LTBWT8UiFiDMW") as HttpWebRequest;

            getTweets.Method = "GET";
            getTweets.Headers[HttpRequestHeader.Authorization] = "Bearer " + "AAAAAAAAAAAAAAAAAAAAANW4MwEAAAAArfnh6YVkgrhQth94Sjcaf7Yn1WM%3D2UlCcePfpsliQ0062qc2cyNXGNBUW4hoyjrlEVkvbf8SCv1U2Q"; 
            try
            {
                string respbody = null;
                //BS; In the GetResponse()function the resp stream is returning 4 errors
                using (Stream resp = getTweets.GetResponse().GetResponseStream())
                {
                    StreamReader respR = new StreamReader(resp);
                    respbody = respR.ReadToEnd();
                    return respbody;
                }

            }
            catch (Exception ex) 
            {
                //TODO
                return ex.ToString();
            }

        }

    }

}
