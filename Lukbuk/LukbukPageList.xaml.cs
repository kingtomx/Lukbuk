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
				if (item["type"].Equals("lukbukimage"))
				{
					content.Children.Add(new LukbukImage());
				}
				else if (item["type"].Equals("lukbukimagespecial"))
				{
					content.Children.Add(new LukbukImageSpecial());
				}
				else
				{
					content.Children.Add(new LukbukConcurso());
				}
			}

			ScrollView myScroll = this.FindByName<ScrollView>("myScroll");
			myScroll.Content = content;


		}
	}
}
