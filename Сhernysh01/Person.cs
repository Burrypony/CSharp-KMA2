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

        public string WesternSign
        {
            get
            {
                if (DOB.Month == 1)
                {
                    if (DOB.Day > 20)
                    {
                        return "Aquarius";
                    }
                    else
                    {
                        return "Caprion";
                    }
                }
                else if (DOB.Month == 2)
                {
                    if (DOB.Day > 20)
                    {
                        return "Fish";

                    }
                    else
                    {
                        return "Aquarius";
                    }
                }
                else if (DOB.Month == 3)
                {
                    if (DOB.Day > 20)
                    {
                        return "Aries";
                    }
                    else
                    {
                        return "Fish";
                    }
                }
                else if (DOB.Month == 4)
                {
                    if (DOB.Day > 20)
                    {
                        return "Taurus";
                    }
                    else
                    {
                        return "Aries";
                    }

                }
                else if (DOB.Month == 5)
                {
                    if (DOB.Day > 20)
                    {
                        return "Twin";
                    }
                    else
                    {
                        return "Taurus";
                    }
                }
                else if (DOB.Month == 6)
                {
                    if (DOB.Day > 21)
                    {
                        return "Cancer";
                    }
                    else
                    {
                        return "Twin";
                    }

                }
                else if (DOB.Month == 7)
                {
                    if (DOB.Day > 22)
                    {
                        return "Lion";
                    }
                    else
                    {
                        return "Cancer";
                    }
                }
                else if (DOB.Month == 8)
                {
                    if (DOB.Day > 23)
                    {
                        return "Virgo";
                    }
                    else
                    {
                        return "Lion";
                    }
                }
                else if (DOB.Month == 9)
                {
                    if (DOB.Day > 22)
                    {
                        return "Libra";
                    }
                    else
                    {
                        return "Virgo";
                    }
                }
                else if (DOB.Month == 10)
                {
                    if (DOB.Day > 23)
                    {
                        return "Scorpio";
                    }
                    else
                    {
                        return "Libra";
                    }
                }
                else if (DOB.Month == 11)
                {
                    if (DOB.Day > 22)
                    {
                        return "Sagittarius";
                    }
                    else
                    {
                        return "Scorpio";
                    }
                }
                else if (DOB.Month == 12)
                {
                    if (DOB.Day > 21)
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
