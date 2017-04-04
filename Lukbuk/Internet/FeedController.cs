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
		private string url = "http://127.0.0.1/out.json";

		public async Task<IEnumerable> Get()
		{
			List<Feed> feeds = new List<Feed>();

			String feed = await url.GetStringAsync();

			JObject jobject = JObject.Parse(feed);

			JArray elements = (JArray)jobject["elements"];


			foreach (var item in elements.Children())
			{
				if (item["type"].Equals("lukbukimage"))
				{
					ImageGeneric image = new ImageGeneric()
					{
						type = "lukbukimage",
						image = item["image"],

					}
					feed.Image = item["images"]["standard_resolution"]["url"].ToString();
					feeds.Add(feed);
				}
			}

			return feeds;
		}
	}
}
