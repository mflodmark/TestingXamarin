using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestingXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
		public ContactsPage ()
		{
			InitializeComponent ();

		    listView.ItemsSource = new List<Contact> {
		        new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" },
		        new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
		    };
        }
	}
}