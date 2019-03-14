using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Сhernysh01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OutputAge( int age )
        {
            Dispatcher.BeginInvoke(new ThreadStart(() => tbSettingText.Text ="Your age is:" + age.ToString()));
        }

        private void OutputWesternSign(string sign)
        {
            Dispatcher.BeginInvoke(new ThreadStart(() => WesternGoroscop.Text = "Your Western sing is:" + sign.ToString()));
        }

        private void OutputChineseSign(string sign)
        {
            Dispatcher.BeginInvoke(new ThreadStart(() => ChineseGoroscop.Text = "Your Chinese sing is :" + sign));
        }

        private void CalculateAge( DateTime dob )
        {
            DateTime currentDate = DateTime.Today;
            int currentMonth = currentDate.Month;
            int currentDay = currentDate.Day;
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime selectedDate = dob;
            int selectedDay = selectedDate.Day;
            TimeSpan span = currentDate - selectedDate;
            if((currentMonth == selectedDate.Month)&&(currentDay == selectedDay))
            {
                MessageBox.Show("HAPPY BIRTHDAY !!!!");
            }
            if(span.Ticks < 0)
            {
                MessageBox.Show("You are not born yet, dont`t try to fool me");
                return;
            }
   
            int years = (zeroTime + span).Year - 1;

            if (years > 135)
            {
                MessageBox.Show("You are too old for this, please choose your corect date of birth");
                return;
            }
        }

        private async void MonthlyCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = (DateTime)DOB_Calendar.SelectedDate;
            await Task.Run( () => CalculateAge(selectedDate) );

            // CalculateAge((DateTime)DOB_Calendar.SelectedDate);
        }

        private string GetWesternSign(DateTime dateOfBirth)
        {
            if (dateOfBirth.Month == 1)
            {
                if (dateOfBirth.Day > 20)
                {
                    return "Aquarius";
                }
                else
                {
                    return "Caprion";
                }
            }
            else if (dateOfBirth.Month == 2)
            {
                if (dateOfBirth.Day > 20)
                {
                    return "Fish";

                }
                else
                {
                    return "Aquarius";
                }
            }
            else if (dateOfBirth.Month == 3)
            {
                if (dateOfBirth.Day > 20)
                {
                    return "Aries";
                }
                else
                {
                    return "Fish";
                }
            }
            else if (dateOfBirth.Month == 4)
            {
                if (dateOfBirth.Day > 20)
                {
                    return "Taurus";
                }
                else
                {
                    return "Aries";
                }

            }
            else if (dateOfBirth.Month == 5)
            {
                if (dateOfBirth.Day > 20)
                {
                    return "Twin";
                }
                else
                {
                    return "Taurus";
                }
            }
            else if (dateOfBirth.Month == 6)
            {
                if (dateOfBirth.Day > 21)
                {
                    return "Cancer";
                }
                else
                {
                    return "Twin";
                }

            }
            else if (dateOfBirth.Month == 7)
            {
                if (dateOfBirth.Day > 22)
                {
                    return "Lion";
                }
                else
                {
                    return "Cancer";
                }
            }
            else if (dateOfBirth.Month == 8)
            {
                if (dateOfBirth.Day > 23)
                {
                    return "Virgo";
                }
                else
                {
                    return "Lion";
                }
            }
            else if (dateOfBirth.Month == 9)
            {
                if (dateOfBirth.Day > 22)
                {
                    return "Libra";
                }
                else
                {
                    return "Virgo";
                }
            }
            else if (dateOfBirth.Month == 10)
            {
                if (dateOfBirth.Day > 23)
                {
                    return "Scorpio";
                }
                else
                {
                    return "Libra";
                }
            }
            else if (dateOfBirth.Month == 11)
            {
                if (dateOfBirth.Day > 22)
                {
                    return "Sagittarius";
                }
                else
                {
                    return "Scorpio";
                }
            }
            else if (dateOfBirth.Month == 12)
            {
                if (dateOfBirth.Day > 21)
                {
                    return "Capricorn";
                }
                else
                {
                    return "Sagittarius";
                }
            }
            else
            {
                return "Error";
            }
        }

    }

}
