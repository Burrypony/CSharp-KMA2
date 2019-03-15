using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Сhernysh01
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Person _person;

        private string _firstname;
        private string _lastname;
        private string _email;
        private DateTime _dob;

        private readonly string _chineseGoroscop;
        private readonly string _westernGoroscop;


        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
                OnPropertyChanged("IsProceedEnabled");
            }
        }

        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return _dob;
            }
            set
            {
                _dob = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public string ChineseGoroscop
        {
            get
            {
                return _person == null ? "" : _person.ChineeseSign;
            }
        }

        public string WesternGoroscop
        {
            get
            {
                return _person == null ? "" : _person.WesternSign;
            }
        }

        public bool IsProceedEnabled
        {
            get
            {
                return !string.IsNullOrEmpty(FirstName)&&!string.IsNullOrEmpty(LastName)&&!string.IsNullOrEmpty(Email);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private ICommand m_ProceedCommand;
        public ICommand ProceedCommand
        {
            get
            {
                return m_ProceedCommand;
            }
            set
            {
                m_ProceedCommand = value;
            }
        }

        public MainViewModel()
        {
            ProceedCommand = new RelayCommand(new Action<object>(ShowInfo));
        }

        public void ShowInfo(object obj)
        {
            _person = new Person(FirstName, LastName, Email, DOB);
            // MessageBox.Show( FirstName );
            OnPropertyChanged( "FirstName" );
            OnPropertyChanged("LastName");
            OnPropertyChanged("Email");
            /* OnPropertyChanged("ChineseGoroscop");
             OnPropertyChanged("WesternGoroscop");*/
        }

    }
}
