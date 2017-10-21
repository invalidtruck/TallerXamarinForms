using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMVVM.Model
{
    public class Item:ObservableObject
    {
        string _tarea = string.Empty;
        public string Tarea
        {
            get => _tarea;
            set => SetProperty(ref _tarea, value);
        }
    }
}
