using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestingXamarin.Models
{
    class ContactGroup: ObservableCollection<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public ContactGroup(string title, string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }
    }
}