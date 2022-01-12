using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyChangeExample.ViewModels
{
    public class PersonViewModel : ObservableObject
    {
        private string _name;

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                    return "Unknow";
                return _name;
            }
            set { 
                _name = value;
                OnPropertyChanged("Name");

            }
        }

    }
}
