using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace marvelReset.Common
{
    public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /* protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
         {
             PropertyChangedEventHandler handler = this.PropertyChanged;
             if (!handler.Equals(null))
             {
                 handler(this, new PropertyChangedEventArgs(propertyName));
             }
         }*/
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
