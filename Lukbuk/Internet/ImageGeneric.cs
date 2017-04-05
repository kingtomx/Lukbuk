using System;
namespace Lukbuk.Internet
{
public class ImageGeneric
	{
		public string type { get; set; }
		public string image { get; set; }
		public string title { get; set; }
		public string description { get; set; }
		public ImageUrl[] url { get; set; }
	}
}

public class ImageUrl
{
		public string general { get; set; }
		public ImageItem[] items { get; set; }
}

public class ImageItem
{
		public string name { get; set; }
		public string price { get; set; }
		public string currency { get; set; }
		public string url { get; set; }
		public string description { get; set; }
}
