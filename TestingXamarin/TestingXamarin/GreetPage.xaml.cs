using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestingXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();

		    MySlider.Value = 0.5;

		    // Layout with code dynamically
		    //Content = new Label()
		    //{
		    //    HorizontalOptions = LayoutOptions.Center,
		    //    VerticalOptions = LayoutOptions.Center,
		    //    Text = "Hello world!"
		    //};
		}


	    //private void Button_OnClicked(object sender, EventArgs e)
	    //{
	    //    DisplayAlert("Title", "Hello world", "OK");
	    //}


	}
}