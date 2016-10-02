using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace BootCampTwitterSearch
{
	public class TweetHelper
	{

		static string API = "https://morning-wildwood-22288.herokuapp.com/search";


		public static async System.Threading.Tasks.Task<List<Tweet>> Search(string SearchTerm)
		{

			var client = new HttpClient();

			var searchAPI = $"{API}/{SearchTerm}";

			var json = await client.GetStringAsync(searchAPI);
			var model = JsonConvert.DeserializeObject<List<Tweet>>(json.ToString());

			return model;

		}
	}
}
