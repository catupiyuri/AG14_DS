using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace MauiAppHotel.Views
{
    public partial class AboutHotel : ContentPage
    {
        public AboutHotel()
        {
            InitializeComponent();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void OnMapLinkTapped(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.google.com.br/maps/place/Xique-Xique,+BA,+47400-000/@-10.8263362,-42.7600963,14z/data=!3m1!4b1!4m6!3m5!1s0x765921521a3a289:0xd0bc236aee3dda01!8m2!3d-10.8233884!4d-42.7249305!16s%2Fg%2F11bxfw99yk?hl=pt-BR&entry=ttu&g_ep=EgoyMDI0MTEwNi4wIKXMDSoASAFQAw%3D%3D");
            await Launcher.OpenAsync(uri);
        }
    }
}
