using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Xamarin.Forms;

namespace Lukbuk
{
	public partial class LukbukPageList : ContentPage
	{
		public LukbukPageList()
		{
		}

		public LukbukPageList(List<JToken> elements)
		{
			InitializeComponent();

			NavigationPage.SetTitleIcon(this, "logo.png");

			ToolbarItems.Add(new ToolbarItem("Menu", "load.png", () =>
			{
				App.Current.MainPage = new NavigationPage(new LukbukPage());
			}));


			StackLayout content = new StackLayout()
			{
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Spacing = 0
			};
			foreach (JToken item in elements)
			{

				string type = (string)item["type"];

				if (type == "lukbukimage")
				{
					content.Children.Add(new LukbukImage((string)item["image"], (string)item["title"], (string)item["description"], (string)item["url"]["general"]));
				}
				else if (type == "lukbukimagespecial")
				{
					content.Children.Add(new LukbukImageSpecial((string)item["image"], (string)item["title"], (string)item["description"], (string)item["url"]));
				}
				else
				{
					content.Children.Add(new LukbukConcurso((string)item["image"], (string)item["title"], (string)item["description"], (string)item["url"]));
				}
			}

			ScrollView myScroll = this.FindByName<ScrollView>("myScroll");
			myScroll.Content = content;


		}
	}
}
