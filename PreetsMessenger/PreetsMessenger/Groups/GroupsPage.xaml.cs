using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PreetsMessenger.Groups
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GroupsPage : ContentPage
	{
		public GroupsPage ()
		{
            ObservableCollection<GroupInfoModalPage> groups = new ObservableCollection<GroupInfoModalPage>();
            groups.Add(new GroupInfoModalPage("Marketing", 23));
            groups.Add(new GroupInfoModalPage("Auctioning People", 18));
            groups.Add(new GroupInfoModalPage("group example", 2));
            groups.Add(new GroupInfoModalPage("group example", 2));
            groups.Add(new GroupInfoModalPage("group example", 2));
            groups.Add(new GroupInfoModalPage("group example", 2));
            groups.Add(new GroupInfoModalPage("group example", 2));
            groups.Add(new GroupInfoModalPage("group example", 2));
            groups.Add(new GroupInfoModalPage("group example", 2));
            groups.Add(new GroupInfoModalPage("group example", 2));
            groups.Add(new GroupInfoModalPage("group example", 2));

            InitializeComponent ();

            groupsList.ItemsSource = groups;
        }
	}
}