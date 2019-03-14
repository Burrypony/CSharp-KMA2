using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сhernysh01
{
    public class Person
    {
        private string _firstname;
        private string _lastname;
        private string _email;
        private DateTime _dob;

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
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

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                // check value
                // if value is ok _email = value
                // else raise Exception
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
                // check value
                // if value is ok _email = value
                // else raise Exception
            }
        }

        public bool IsAdult
        {
            get
            {
                // insert age check
                // DOB
                return false;
            }
        }

        public string ChineeseSign
        {
            get
            {
                string[] znakiZadiaka = new[] { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };
                return znakiZadiaka[(DOB.Year - 1876) % 12];
            }
        }

        public Person( string firstname, string lastname, string email, DateTime dob )
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            DOB = dob;
        }

        public Person(string firstname, string lastname, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
        }

        public Person(string firstname, string lastname, DateTime dob)
        {
            FirstName = firstname;
            LastName = lastname;
            DOB = dob;
        }

    }
}
