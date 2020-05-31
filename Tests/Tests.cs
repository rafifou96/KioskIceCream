using BE;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests
{

    public class MyClass
    {
        private const string URL = "https://api.nal.usda.gov/fdc/v1/foods/search?";
        private static string API_KEY = "h3oUFImEdGAWbh56qZBV9yGBWQZdNRxeVECXM81f";

        public static async Task<(double, double, double)> GetNutritionalInfo(string flavour)
        {
            using (var client = new HttpClient())
            {

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var builder = new UriBuilder(URL);
                builder.Query = "api_key=" + API_KEY + "&query=Ice Cream " + flavour + "&pageSize=300";

                HttpResponseMessage response = await client.GetAsync(builder.Uri);

                HttpContent content = response.Content;
                string result = await content.ReadAsStringAsync();
                var obj = JObject.Parse(result);

                Random r = new Random();


                var foodNutriments = obj["foods"][r.Next(0, 250)]["foodNutrients"] as JArray;

                var energy = (double)foodNutriments
                    .Where(nutriment => (nutriment as JObject)["nutrientNumber"].ToString() == "208")
                    .First()["value"];

                var fat = (double)foodNutriments
                    .Where(nutriment => (nutriment as JObject)["nutrientNumber"].ToString() == "204")
                    .First()["value"];

                var sugar = (double)foodNutriments
                    .Where(nutriment => (nutriment as JObject)["nutrientNumber"].ToString() == "269")
                    .First()["value"];

                return (energy, fat, sugar);
            }

        }
    }
    public class Tests
    {

        static async void TestLocation()
        {
            (double lat, double lng) = await Services.LocationHelper.GetLatLong("60 Rue du lt jean vigneux, saint gratien");
            Console.WriteLine($"{lat} {lng}");
        }

        static void Main1(string[] args)
        {
            //TestNutritional();

            //Thread thread = new Thread(ImaggaImage2);


            //AllIC(x => x.Description.Contains("fraise"));
            //Delete();
            //ImmagaURL2();

            //TestLocation();

            Console.ReadLine();
        }

        static async void Test()
        {
            bool r;
            r = await ImaggaImage2();
            Console.WriteLine(r);

           

            //var res = await Services.ImageAnalyzer.CheckImage(@"C:\Users\gabri\Desktop\2.jpg");
            //Console.WriteLine(res);
        }

        static async void TestNutritional()
        {
            Console.WriteLine("Enter a flavour: ");
            string ic = Console.ReadLine();

            var (energy, fat, sugar) = await MyClass.GetNutritionalInfo(ic);

            Console.WriteLine($"Energy {energy}\nFat {fat}\nSugar{sugar}");
        }



        

        static void ImmagaImage()
        {
            //    OpenFileDialog op = new OpenFileDialog
            //    {
            //        Title = "Select a brilliant picture",
            //        Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
            //       "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
            //       "Portable Network Graphic (*.png)|*.png"
            //    };

            //    string uri = "";
            //    if (op.ShowDialog() == true)
            //    {
            //        uri = op.FileName;
            //    }


            string apiKey = "acc_ce41b5b562dc47d";
            string apiSecret = "f08f6bcfaf43c4dbfc37161ee44d466a";
            string image = @"C:\Users\gabri\Desktop\f.jpg";

            string basicAuthValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));

            var client = new RestClient("https://api.imagga.com/v2/uploads");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", String.Format("Basic {0}", basicAuthValue));
            request.AddFile("image", image);

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            Console.ReadLine();
        }

        static void ImmagaURL()
        {

            string apiKey = "acc_ce41b5b562dc47d";
            string apiSecret = "f08f6bcfaf43c4dbfc37161ee44d466a";
            string imageUrl = "https://docs.imagga.com/static/images/docs/sample/japan-605234_1280.jpg";

            string basicAuthValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));

            var client = new RestClient("https://api.imagga.com/v2/tags");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("image_url", imageUrl);
            request.AddHeader("Authorization", String.Format("Basic {0}", basicAuthValue));

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            Console.ReadLine();
        }

        private static async Task<bool> ImaggaImage2()
        {
            string apiKey = "acc_ce41b5b562dc47d";
            string apiSecret = "f08f6bcfaf43c4dbfc37161ee44d466a";
            string image = @"C:\Users\gabri\Desktop\f.jpg";

            string basicAuthValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));

            var client = new RestClient("https://api.imagga.com/v2/tags");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", String.Format("Basic {0}", basicAuthValue));
            request.AddFile("image", image);

            IRestResponse response = await client.ExecuteAsync(request);
            // Console.WriteLine(response.Content);

            string result = response.Content;
            var obj = JObject.Parse(result);

            var queryKeywords = "";

            for (int i = 0; i < 5; i++)
                queryKeywords += obj["result"]["tags"][i]["tag"]["en"] + " ";

            var keywords = "food ice-cream ice frozen dessert dessert glass cone";

            var item_q = queryKeywords.Split();
            var item_keywords = keywords.Split();
            var OK = false;

            foreach (var item in item_q)
            {
                if (item_keywords.Contains(item))
                    OK = true;
            }

            Console.WriteLine(queryKeywords);
            Console.WriteLine(OK);
            return OK;
        }

        static void ImmagaURL2()
        {
            string apiKey = "acc_ce41b5b562dc47d";
            string apiSecret = "f08f6bcfaf43c4dbfc37161ee44d466a";
            string image = @"C:\Users\gabri\Desktop\f.jpg";
            string categorizerId = "nsfw_beta";

            string basicAuthValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));

            var client = new RestClient(String.Format("https://api.imagga.com/v2/categories/{0}", categorizerId));
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", String.Format("Basic {0}", basicAuthValue));
            request.AddFile("image", image);

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
