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

			//Image backgroundImage = this.FindByName<Image>("background");


		}


		protected override async void OnAppearing()
		{
			IEnumerable response = await Internet.FeedController.Get("https://raw.githubusercontent.com/kingtomx/Lukbuk/master/out.json");
			App.Current.MainPage = new NavigationPage(new LukbukPageList((List<JToken>)response));
		}

	}
}
