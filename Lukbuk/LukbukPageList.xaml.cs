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

			StackLayout content = new StackLayout()
			{
				Orientation = StackOrientation.Vertical,
				Spacing = 50,
				Children = {
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {},
					new LukbukImage() {}
				}
			};

			ScrollView myScroll = this.FindByName<ScrollView>("myScroll");
			myScroll.Content = content;


		}
	}
}
