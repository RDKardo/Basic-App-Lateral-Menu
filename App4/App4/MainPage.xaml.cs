using App4.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public static
            List<CervezaViewModel>
             cervezas = new List<CervezaViewModel>()
            {
                new CervezaViewModel(){ Name  ="Minerva Verde", Brand = "Minerva", Style="Stout"},
                new CervezaViewModel(){ Name  ="Vickychelada",Brand ="Victoria",Style ="Lager"}
            };

        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = null;
            listView.ItemsSource = cervezas;
        } 
        async void OnNew(object sender,EventArgs e)
        {
            await Navigation.PushAsync(new Pages.CervezaPage
            {
                BindingContext = new CervezaViewModel()
            });
        }
    }
}
