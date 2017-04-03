using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace Cultivo
{
	public class FeedController
	{
		private string url = "https://api.instagram.com/v1/users/self/media/recent/?access_token=1097017695.1677ed0.8c7090e475284d87be8600a669b31859";

		public async Task<IEnumerable> Get()
		{
			List<Feed> feeds = new List<Feed>();

			String instagram = await url.GetStringAsync();

			JObject jobject = JObject.Parse(instagram);

			JArray data = (JArray)jobject["data"];


			foreach (var item in data.Children())
			{
				Feed feed = new Feed();

				feed.Image = item["images"]["standard_resolution"]["url"].ToString();
				feeds.Add(feed);
			}

			return feeds;
		}
	}
}
