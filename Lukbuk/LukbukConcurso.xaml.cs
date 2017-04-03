using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Lukbuk
{
	public partial class LukbukConcurso : ContentView
	{
		Image myImage = null;
		Label description = null;
		Label title = null;

		public LukbukConcurso()
		{
		}

		public LukbukConcurso(String image, String brand)
		{
			InitializeComponent();
			title = this.FindByName<Label>("Name");
			title.Text = brand;
			myImage = this.FindByName<Image>("actualImage");
			myImage.Source = ImageSource.FromFile(image);
			description = this.FindByName<Label>("myDescription");

		}

		void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
		{
		}


		void OnTapGestureRecognizerTapped(object sender, EventArgs args) {
			if (description.IsVisible)
			{
				description.IsVisible = false;
			}
			else
			{
				description.IsVisible = true;
			}
		}
	}
}
