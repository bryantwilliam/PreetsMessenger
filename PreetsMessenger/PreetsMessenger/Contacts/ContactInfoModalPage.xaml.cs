using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PreetsMessenger.Contacts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactInfoModalPage : ContentPage
	{
        public string name { get; set; }
        public string mobile { get; set; }
        public string imageSource { get; set; }

        public ContactInfoModalPage (string name, string mobile)
		{
            this.name = name;
            this.mobile = mobile;
            this.imageSource = "http://lorempixel.com/200/200/people";

            InitializeComponent ();
		}
	}
}