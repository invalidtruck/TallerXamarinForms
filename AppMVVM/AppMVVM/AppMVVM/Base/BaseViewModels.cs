using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMVVM.Base
{
    public class BaseViewModels : BaseViewModel
    {
        public INavigation navigation { get; private set; }
        public BaseViewModels(INavigation _navigation)
        {
            this.navigation = _navigation;
        }
    }
}
