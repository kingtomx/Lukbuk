using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Lukbuk
{
	public partial class LukbukPage : ContentPage
	{
		public LukbukPage()
		{
			InitializeComponent();
		}


		protected override async void OnAppearing()
		{
			IEnumerable response = await Internet.FeedController.Get("http://127.0.0.1/out.json");

			foreach (JToken item in response)
			{
				item["binimage"] = await Internet.FeedController.GetImage(item["image"].ToString());
			}

			App.Current.MainPage = new NavigationPage(new LukbukPageList());
		}

	}
}
