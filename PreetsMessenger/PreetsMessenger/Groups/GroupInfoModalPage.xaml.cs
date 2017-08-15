using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PreetsMessenger.Groups
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GroupInfoModalPage : ContentPage
	{
        public string name { get; set; }
        public int numberOfMembers { get; set; }

		public GroupInfoModalPage (string name, int numberOfMembers)
		{
            this.name = name;
            this.numberOfMembers = numberOfMembers;
			InitializeComponent ();
		}
	}
}