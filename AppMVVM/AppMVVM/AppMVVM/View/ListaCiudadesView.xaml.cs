using AppMVVM.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaCiudadesView : ContentPage
    {
        ListaCiudadesViewModel viewModel;
        public ListaCiudadesView()
        {
            InitializeComponent();
            viewModel = new ListaCiudadesViewModel(this.Navigation);
            BindingContext = viewModel;
        }

        async void Handle_ItemTapped(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}