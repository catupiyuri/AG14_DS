using Microsoft.Maui.Controls; 
using Microsoft.Maui; 

namespace MauiAppHotel.Views
{
    public partial class AboutApp : ContentPage
    {
        public AboutApp()
        {
            InitializeComponent();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); 
        }
    }
}
