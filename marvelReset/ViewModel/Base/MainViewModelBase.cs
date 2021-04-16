using marvelReset.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace marvelReset.ViewModel.Base
{//clase personaje tambien publica!!
    public abstract class MainViewModelBase : NotifyPropertyChanged
    {
        protected Frame _navigate;

        protected MainViewModelBase(Frame navigation)
        {
            _navigate = navigation;
            Navigate();
        }

        public abstract void Navigate();

        protected void Navigate(Type viewType, object context)
        {
            _navigate.Navigate(viewType);
            var element = _navigate.Content as FrameworkElement; //casteo implícito
            if (element != null)
            {
                element.DataContext = context;  //se da contexto
            }
        }
    }
}
