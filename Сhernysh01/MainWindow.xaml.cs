using System.Windows;
using System.Windows.Controls;

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
        /*private void CalculateAge( DateTime dob )
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
        }*/

        private async void MonthlyCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            // DateTime selectedDate = (DateTime)DOB_Calendar.SelectedDate;
            // await Task.Run( () => CalculateAge(selectedDate) );

            // CalculateAge((DateTime)DOB_Calendar.SelectedDate);
        }
       

    }

}
