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
					content.Children.Add(new LukbukImage((string)item["image"], (string)item["title"], (string)item["description"]));
				}
				else if (type == "lukbukimagespecial")
				{
					content.Children.Add(new LukbukImageSpecial((string)item["image"], (string)item["title"], (string)item["description"]));
				}
				else
				{
					content.Children.Add(new LukbukConcurso((string)item["image"], (string)item["title"], (string)item["description"]));
				}
			}

			ScrollView myScroll = this.FindByName<ScrollView>("myScroll");
			myScroll.Content = content;


		}
	}
}
