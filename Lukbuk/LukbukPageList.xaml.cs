using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Lukbuk
{
	public partial class LukbukPageList : ContentPage
	{
		public LukbukPageList()
		{
			InitializeComponent();

			NavigationPage.SetTitleIcon(this, "logo.png");

			StackLayout content = new StackLayout()
			{
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Spacing = 0,
				Children = {
					new LukbukImage("lb1.jpg") {},
					new LukbukImage("lb2.jpg") {},
					new LukbukImage("lb3.jpg") {},
					new LukbukImage("lb4.jpg") {},
					new LukbukImage("1.jpg") {},
					new LukbukImage("2.jpg") {},
					new LukbukImage("3.jpg") {},
					new LukbukImage("1.jpg") {},
					new LukbukImage("2.jpg") {},
					new LukbukImage("3.jpg") {}
				}
			};

			ScrollView myScroll = this.FindByName<ScrollView>("myScroll");
			myScroll.Content = content;


		}
	}
}
