using Xamarin.Forms;

namespace Lukbuk
{
	public partial class LukbukPage : ContentPage
	{
		public LukbukPage()
		{
			InitializeComponent();
		}


		protected override void OnAppearing()
		{
			App.Current.MainPage = new NavigationPage(new LukbukPageList());
		}

	}
}
