using marvelReset.Command;
using marvelReset.Dtos;
using marvelReset.Model;
using marvelReset.ViewModel.Base;
using marvelReset.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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

        //Tiene id, icon y title
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

        /*****************************************************/ //SHOW ALL DATA
        private List<CharacterModel> _datos;
        private int lastIndex = 0;

        private ObservableCollection<CharacterModel> _characters;

        public ObservableCollection<CharacterModel> Character
        {
            get { return _characters; }
            set
            {
                _characters = value;
                OnPropertyChanged();
            }
        }

        public async void LoadData()//HANDLER == NULL
        {
            var info = apiRequest.GetCharacters(0);

            _datos = info.Select(characterDto => new CharacterModel()
            {
                Id = characterDto.id,
                Description = characterDto.description,
                Image = characterDto.thumbnail.path,
                Name = characterDto.name
            }).ToList();

            Character = new ObservableCollection<CharacterModel>(_datos);
            lastIndex = _datos.Count();
        }

        /*****************************************************/ //STARTS WITH

        private ICommand _searchWithCommand;

        public ICommand SearchWithCommand
        {
            get
            {
                return _searchWithCommand ?? new CommandHandler(SearchWith);
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private async void SearchWith()//SEARCH WITH
        {
            List<Character> charactersShown;
            if (string.IsNullOrEmpty(Name))
            {
                charactersShown = apiRequest.GetCharacters(25, 0); //PORQUE PONEN 1 EN OFFSET¿?
            }
            else
            {
                charactersShown = apiRequest.SearchCharactersWith(Name, 25, 0);
            }

        }


        /*****************************************************/ //SHOW ALL CHARACTERS

        private ICommand _moreCommand;

        public ICommand MoreCommand
        {
            get
            {
                return _moreCommand ?? new CommandHandler(ShowMoreData);
            }
        }

        private async void ShowMoreData()//APLICAR PARÁMETROS DE LA API EN LA LLAMADA
        {
            List<Character> infoShown;
            if (string.IsNullOrEmpty(Name))
            {
                infoShown = apiRequest.GetCharacters(100, lastIndex);
            }
            else
            {
                infoShown = apiRequest.SearchCharactersWith(Name, 25, 1);
            }

            _datos.AddRange(infoShown.Select(characterDto => new CharacterModel()
            {
                Id = characterDto.id,
                Description = characterDto.description,
                Image = characterDto.thumbnail.path,
                Name = characterDto.name
            }).ToList());

            Character = new ObservableCollection<CharacterModel>(_datos);
            lastIndex = _datos.Count;
        }
    }
}
