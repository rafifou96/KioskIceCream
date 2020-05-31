using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ImageAnalyzer
    {
        private static readonly string iceCreamKeywords = "food ice-cream ice cream frozen dessert dessert glass cone";

        public static async Task<bool> ImageAnalyser(string imageURL)
        {
            string apiKey = "acc_ce41b5b562dc47d";
            string apiSecret = "f08f6bcfaf43c4dbfc37161ee44d466a";

            string basicAuthValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));

            var client = new RestClient("https://api.imagga.com/v2/tags");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", String.Format("Basic {0}", basicAuthValue));
            request.AddFile("image", imageURL);

            IRestResponse response = await client.ExecuteAsync(request);

            string result = response.Content;
            var obj = JObject.Parse(result);

            var queryKeywords = "";

            for (int i = 0; i < 5; i++)
                queryKeywords += obj["result"]["tags"][i]["tag"]["en"] + " ";

            var keywords = "food ice-cream ice frozen dessert dessert glass cone";

            var item_q = queryKeywords.Split();
            var item_keywords = keywords.Split();

            foreach (var item in item_q)
            {
                if (item_keywords.Contains(item))
                    return true;
            }

            return false;
        }


    }
}
