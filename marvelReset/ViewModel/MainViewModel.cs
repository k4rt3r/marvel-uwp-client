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

        /*****************************************************/ //LOAD DATA
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
            List<CharacterModel> info = apiRequest.GetCharactersM(0);

            _datos = info.Select(characterDto => new CharacterModel()
            {
                Id = characterDto.Id,
                Description = characterDto.Description,
                Image = characterDto.Image,
                Name = characterDto.Name
            }).ToList();

            Character = new ObservableCollection<CharacterModel>(info);
            lastIndex = info.Count();
        }


        /*****************************************************/ //STARTS WITH
        private ICommand _searchWithCommand;

        public ICommand SearchWithCommand
        {
            get
            {
                if (_searchWithCommand == null)
                {
                    _searchWithCommand = new CommandHandler(SearchWith);
                }
                return _searchWithCommand;
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
            List<CharacterModel> charactersShown;
            if (string.IsNullOrEmpty(Name))
            {//reset/vacio
                charactersShown = apiRequest.GetCharactersM(0);
            }
            else
            {//campo lleno
                charactersShown = apiRequest.SearchCharactersWithM(Name);
            }
            _datos.AddRange(charactersShown.Select(characterDto => new CharacterModel()
            {
                Id = characterDto.Id,
                Description = characterDto.Description,
                Image = characterDto.Image,
                Name = characterDto.Name
            }).ToList());

            Character = new ObservableCollection<CharacterModel>(_datos);
            lastIndex = _datos.Count;
        }


        /*****************************************************/ //SHOW ALL CHARACTERS
        private ICommand _moreCommand;

        public ICommand MoreCommand
        {
            get
            {
                if (_moreCommand == null)
                {
                    _moreCommand = new CommandHandler(ShowMoreData);
                }
                return _moreCommand;
            }
        }
        private async void ShowMoreData()
        {
            List<CharacterModel> infoShown;
            if (string.IsNullOrEmpty(Name))
            {
                infoShown = apiRequest.GetCharactersM(lastIndex);
            }
            else
            {
                infoShown = apiRequest.SearchCharactersWithM(Name);
            }

            _datos.AddRange(infoShown.Select(characterDto => new CharacterModel()
            {
                Id = characterDto.Id,
                Description = characterDto.Description,
                Image = characterDto.Image,
                Name = characterDto.Name
            }).ToList());

            Character = new ObservableCollection<CharacterModel>(_datos);
            lastIndex = _datos.Count;
        }
    }
}