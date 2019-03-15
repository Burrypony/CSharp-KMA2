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


    }

}
