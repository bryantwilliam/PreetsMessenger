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
    public partial class ProfileEditorModalPage : ContentPage
    {
        public ProfileEditorModalPage()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked()
        {
            // TODO save to profile
            throw new NotImplementedException();
        }
    }
}