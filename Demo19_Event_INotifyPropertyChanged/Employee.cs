using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo19_Event_INotifyPropertyChanged
{
    internal class Employee
        : System.ComponentModel.INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _Name = string.Empty;
        public string Name 
        { 
            get
            {
                return _Name;
            } 
            set
            {
                _Name = value;

                // check if event is subscribed
                if ( PropertyChanged != null)        
                {
                    // Raise the event.
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }


        #region System.ComponentModel.INotifyPropertyChanged members

        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion
    }
}
