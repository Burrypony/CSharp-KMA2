using System;
using System.ComponentModel;
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
        private DateTime _dob = DateTime.Now;


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
                OnPropertyChanged("IsProceedEnabled");
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
                OnPropertyChanged("StartDate");
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
                OnPropertyChanged("IsProceedEnabled");
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

        public string IsAdult
        {
            get
            {
                if ((DateTime.Today.Year - _dob.Year) >= 18)
                {
                    return "Is adult";
                }
                else
                {
                    return "Not adult";
                }
            }
        }

        public string IsBirthday
        {
            get
            {
                if ((DateTime.Today.Month == _dob.Month) && (DateTime.Today.Day == _dob.Day))
                {
                   return "HAPPY BIRTHDAY !!!!";
                }
                else
                {
                    return "I hope you have a birthday soon";
                }
            }
        }



        public bool IsProceedEnabled
        {
            get
            {
                return !string.IsNullOrEmpty(FirstName)&&!string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(Email);
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

        public async void ShowInfo(object obj)
        {
            await Task.Run((() =>
            {
                try
                {

                    _person = new Person(FirstName, LastName, Email, DOB);
                    OnPropertyChanged( "FirstName" );
                    OnPropertyChanged("LastName");
                    OnPropertyChanged("Email");
                    OnPropertyChanged("DOB");
                    OnPropertyChanged("IsAdult");
                    OnPropertyChanged("IsBirthday");
                    OnPropertyChanged("ChineseGoroscop");
                    OnPropertyChanged("WesternGoroscop");
                }
                catch (EmailValidaion e)
                {
                    MessageBox.Show(e.Message);
                }
                catch (BornValidation e)
                {
                    MessageBox.Show(e.Message);
                }
             }));
                }

}
}
