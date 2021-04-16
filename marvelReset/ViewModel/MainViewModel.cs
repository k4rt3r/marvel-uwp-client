using marvelReset.Model;
using marvelReset.ViewModel.Base;
using marvelReset.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace marvelReset.ViewModel
{
    public class MainViewModel : MainViewModelBase
    {
        public MainViewModel(Frame navigation) : base(navigation)
        {

        }

        public override void Navigate()
        {
            Navigate(typeof(charGrid), this);

            //LoadData();
        }

        //lista dinamica de tipo que tiene id, icon y title
        private ObservableCollection<MenuItemModel> _menuList;
        public ObservableCollection<MenuItemModel> MenuList
        {
            get { return _menuList; }
            set
            {
                _menuList = value;
                OnPropertyChanged();
            }
        }

        //private ICommand _showOptionCommand;

        //public ICommand ShowOptionCommand
        //{
        //    get
        //    {
        //        _showOptionCommand = new CommandHandler<MenuItemModel>(LoadPage);
        //        return _showOptionCommand;
        //    }

        //}

        //private void LoadPage(MenuItemModel item)
        //{
        //    switch (item.Id)
        //    {
        //        case 1:
        //            var vm = new ListViewModel(Frame);

        //            break;

        //    }
        //}

        //private void LoadData()
        //{
        //    MenuList = new ObservableCollection<MenuItemModel>(new List<MenuItemModel>()
        //    {
        //        new MenuItemModel()
        //        {
        //            Id = 1,
        //            Icon = "",
        //            Title = "Buscar"
        //        }
        //    });
        //}
    }
}
