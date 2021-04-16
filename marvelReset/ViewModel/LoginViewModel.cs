using marvelReset.Command;
using marvelReset.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace marvelReset.ViewModel
{
    public class LoginViewModel : MainViewModelBase
    {
        private const string USUARIO = "PasionaAdmin";
        private const string CONTRASENYA = "marvel_21";

        public LoginViewModel(Frame navigation) : base(navigation)
        {

        }

        public override void Navigate()
        {
            Navigate(typeof(MainPage), this);//MainPage -> login
        }

        private string _userName;
        private string _password;
        private ICommand _loginCommand;

        public ICommand LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                {
                    _loginCommand = new CommandHandler(Validate);
                }
                return _loginCommand;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }


        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        private void Validate()
        {
            if (UserName == USUARIO && Password == CONTRASENYA)
            {
                //ListViewModel lstModel = new ListViewModel(_navigate);hace lo mismo que con MainViewModel
                MainViewModel mainVModel = new MainViewModel(_navigate);
            }
        }
    }
}
