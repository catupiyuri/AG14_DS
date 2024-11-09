using MauiAppHotel.Models;
using MauiAppHotel.Views;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesApp;

        public ContratacaoHospedagem()
        {
            InitializeComponent();


            PropriedadesApp = (App)Application.Current;
            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);
            dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
            dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                Hospedagem h = new Hospedagem
                {
                    QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                    QntAdultos = Convert.ToInt32(stp_adultos.Value),
                    QntCriancas = Convert.ToInt32(stp_criancas.Value),
                    DataCheckIn = dtpck_checkin.Date,
                    DataCheckOut = dtpck_checkout.Date,
                };


                await Navigation.PushAsync(new HospedagemContratada()
                {
                    BindingContext = h
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime data_selecionada_checkin = ((DatePicker)sender).Date;
            dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
            dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
        }


        private async void GoToAboutAppPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutApp());
        }

        private async void GoToAboutHotelPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutHotel());
        }
    }
}