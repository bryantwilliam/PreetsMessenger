using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PreetsMessenger.Profile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileViewerPage : ContentPage
    {
        public ProfileViewerPage()
        {
            InitializeComponent();
        }

        private async void OnEditClicked()
        {
            await Navigation.PushModalAsync(new ProfileEditorModalPage());
        }
    }
}