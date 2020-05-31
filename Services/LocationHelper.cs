using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LocationHelper
    {
		private static string APIKey = "AvTzJZt1E6MHYLyNIogfiPuVFKl5THAE_BCqdscIzXMx_GSDwpOdYUPjBY4vw241";

		public static async Task<(double, double)> GetLatLong(string address)
		{
			using (var client = new HttpClient())
			{
				var response = await client.GetAsync("http://dev.virtualearth.net/REST/v1/Locations?key=" + APIKey + "&query=" + address);
				var content = response.Content;

				var result = await content.ReadAsStringAsync();
				var json = JObject.Parse(result);

				var resourceSets = json["resourceSets"] as JArray;
				var resources = resourceSets[0]["resources"];

				var coordinates = resources[0]["point"]["coordinates"] as JArray;
				return ((double)coordinates[0], (double)coordinates[1]);
			}
		}
	}
}
