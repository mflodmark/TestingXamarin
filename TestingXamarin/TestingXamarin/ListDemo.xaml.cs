using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestingXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListDemo : ContentPage
	{
		// Observe will notify listview and update accordingly
		private ObservableCollection<ContactGroup> _contacts;

		public ListDemo ()
		{
			InitializeComponent ();

			//MyListView.ItemsSource = new List<Contact>()
			//{
			//	new Contact() {Name="Markus", ImageUrl = "http://lorempixel.com/100/100/people/1", },
			//	new Contact() {
   //                 Name ="Sandra",
   //                 ImageUrl = "http://lorempixel.com/100/100/people/2",
   //                 Status = "Hey, let's talk"}

			//};


			//_contacts = new ObservableCollection<ContactGroup>()
			//{
			//	new ContactGroup("M", "M")
			//	{
			//		new Contact() {Name = "Markus", ImageUrl = "http://lorempixel.com/100/100/people/1"}
			//	},

			//	new ContactGroup("S", "S")
			//	{
			//		new Contact()
			//		{
			//			Name = "Sandra",
			//			ImageUrl = "http://lorempixel.com/100/100/people/2",
			//			Status = "Hey, let's talk"
			//		}
			//	}
			//};

			_contacts = GetContactGroups();
			MyListView.ItemsSource = _contacts;
			

		}

		ObservableCollection<ContactGroup> GetContactGroups(string searchText = null)
		{
			var contactGroups = new ObservableCollection<ContactGroup>()
			{
				new ContactGroup("M", "M")
				{
					new Contact() {Name = "Markus", ImageUrl = "http://lorempixel.com/100/100/people/1"}
				},

				new ContactGroup("S", "S")
				{
					new Contact()
					{
						Name = "Sandra",
						ImageUrl = "http://lorempixel.com/100/100/people/2",
						Status = "Hey, let's talk"
					}
				}
			};

		    if (string.IsNullOrWhiteSpace(searchText)) { return contactGroups; }

		    var contacts = contactGroups.Where(x => x.Title == searchText.Substring(0, 1));

            return (ObservableCollection<ContactGroup>) contacts;
		}


		private void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var contact = e.SelectedItem as Contact;
			DisplayAlert("Selected", contact.Name, "OK");
		}

		private void MyListView_OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			//var contact = e.Item as Contact;
			//DisplayAlert("Selected", contact.Name, "OK");
		}

		private void Call_Clicked(object sender, EventArgs e)
		{
			var menuItem = sender as MenuItem;

			var contact = menuItem.CommandParameter as Contact;

			DisplayAlert("Call", contact.Name, "OK");
		}

		private void Delete_Clicked(object sender, EventArgs e)
		{
			var contact = (sender as MenuItem).CommandParameter as Contact;

			var sub = contact.Name.Substring(0, 1);
			
			var group = _contacts.First(x => x.Title == sub);

			group.Remove(contact);
		}

		private void ListView_OnRefreshing(object sender, EventArgs e)
		{
			MyListView.ItemsSource = GetContactGroups();
			MyListView.EndRefresh();
		}

		private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
		{
			MyListView.ItemsSource = GetContactGroups(e.NewTextValue);
		}
	}
}