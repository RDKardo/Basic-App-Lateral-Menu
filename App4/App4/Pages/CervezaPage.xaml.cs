using App4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CervezaPage : ContentPage
    {
        public CervezaPage()
        {
            InitializeComponent();
        }
        async void OnSave(object sender, EventArgs e)
        {
            var cerveza = (CervezaViewModel)BindingContext;
            MainPage.cervezas.Add(cerveza);
            await Navigation.PopAsync();
        }
    }
}