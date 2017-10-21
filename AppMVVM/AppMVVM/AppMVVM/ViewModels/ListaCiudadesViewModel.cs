using AppMVVM.Base;
using AppMVVM.Model;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMVVM.ViewModels
{
    public class ListaCiudadesViewModel : BaseViewModels
    {
        public ObservableRangeCollection<Item> ItemsCollection { get; set; }
        public ListaCiudadesViewModel(INavigation _navigation) : base(_navigation)
        {
            Initilize();
        }
        void Initilize()
        {
            Title = "Listado";
            ItemsCollection = new ObservableRangeCollection<Item>();
            for (int i = 0; i < 10; i++)
                ItemsCollection.Add(new Item { Tarea = Guid.NewGuid().ToString() });
        }
    }
}
