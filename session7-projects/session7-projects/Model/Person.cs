using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session7_projects.Model
{
    class Person : INotifyPropertyChanged
    {
        private string _firstName;
        
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
                OnPropertyChanged("FullName");
            }
        }
        
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
                OnPropertyChanged("FullName");
            }
        }

        private string _fullName;
        public string FullName
        {
            get { return _firstName + "  " + _lastName; }
            set
            {
                _fullName = value;
                OnPropertyChanged("FullName");
            }
        }

        public Person()
        {
            _firstName = "reza";
            _lastName = "sh";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
