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

namespace Lukbuk.Internet
{
	public class FeedController
	{
		
		public static async Task<IEnumerable> Get(string url)
		{
			List<JToken> objects = new List<JToken>();
			String feed = await url.GetStringAsync();
			JObject jobject = JObject.Parse(feed);
			JArray elements = (JArray)jobject["elements"];
			foreach (var item in elements.Children())
			{
				objects.Add(item);
			}
			return objects;
		}

		public static async Task<byte[]> GetImage(string url)
		{
			List<JToken> objects = new List<JToken>();
			byte[] image = await url.GetBytesAsync();
			return image;
		}

	}
}
