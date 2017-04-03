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
					new LukbukImageSpecial("lb1.jpg", "Chocolate") {},
					new LukbukImage("lb2.jpg", "Kosiuko") {},
					new LukbukImage("lb3.jpg", "Rapsodia") {},
					new LukbukConcurso("lb4.jpg", "texto4") {},
					new LukbukImage("1.jpg", "texto5") {},
					new LukbukImage("2.jpg", "") {},
					new LukbukImageSpecial("3.jpg", "") {},
					new LukbukImage("1.jpg", "") {},
					new LukbukImage("2.jpg", "") {},
					new LukbukImage("3.jpg", "") {}
				}
			};

			ScrollView myScroll = this.FindByName<ScrollView>("myScroll");
			myScroll.Content = content;


		}
	}
}
