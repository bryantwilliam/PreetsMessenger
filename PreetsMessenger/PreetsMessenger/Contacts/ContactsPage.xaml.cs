using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PreetsMessenger.Contacts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
		public ContactsPage ()
		{
            ObservableCollection<ContactInfoModalPage> groups = new ObservableCollection<ContactInfoModalPage>();
            groups.Add(new ContactInfoModalPage("Bob", "022 321 3213"));
            groups.Add(new ContactInfoModalPage("William", "022 321 3213"));
            groups.Add(new ContactInfoModalPage("Preet", "022 321 3213"));
            groups.Add(new ContactInfoModalPage("Sarah", "022 321 3213"));
            groups.Add(new ContactInfoModalPage("Andy", "022 321 3213"));
            groups.Add(new ContactInfoModalPage("Heather", "022 321 3213"));
            groups.Add(new ContactInfoModalPage("Bob", "12345"));
            groups.Add(new ContactInfoModalPage("Bob", "022 321 3213"));
            groups.Add(new ContactInfoModalPage("Bob", "4124115125"));
            groups.Add(new ContactInfoModalPage("Bob", "022 321 3213"));

            InitializeComponent ();

            contactsList.ItemsSource = groups;
        }
	}
}