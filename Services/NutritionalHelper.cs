using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NutritionalHelper
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

                var foodNutriments = obj["foods"][r.Next(0, 5)]["foodNutrients"] as JArray;

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


        /* Energy = 208 (KCal)
           Protein = 203 (g)
           Fat = 204 (g) */

    }
}
