using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace WorkingWithJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //{
            //    "id": "110355660738", 
            //    "picture": {
            //        "data": {
            //            "url": "https://fbcdn-profile-a.akamaihd.net/hprofile-ak-prn2/1027085_12033235063_5234302342947_n.jpg", 
            //            "is_silhouette": false
            //        }
            //    }
            //}
            string json =
                "{  \"id\": \"110355660738\",   \"picture\": {    \"data\": {      \"url\": \"https://fbcdn-profile-a.akamaihd.net/hprofile-ak-prn2/1027085_12033235063_5234302342947_n.jpg\",       \"is_silhouette\": false    }  }}";

            JObject obj = JObject.Parse(json);
            //Console.WriteLine((string)obj.picture.data.url);

            var url = obj.Descendants().OfType<JProperty>()
                .First(p => p.Name == "url").Value.ToString();

            Console.WriteLine(url);
            Console.Read();
        }
    }
}
