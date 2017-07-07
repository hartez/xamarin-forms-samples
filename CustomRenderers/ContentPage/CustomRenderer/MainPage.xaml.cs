using System;
using Xamarin.Forms;

namespace CustomRenderer
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

		async void OnTakePhotoButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new CameraPage ());
		}

		private void GcButton_OnClicked(object sender, EventArgs e)
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}
}

