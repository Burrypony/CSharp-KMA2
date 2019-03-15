using System;

namespace Сhernysh01
{
    class EmailValidaion: Exception
    {
        private string _message;


        public EmailValidaion(string message)
        {
          _message = message;
        }


        public override string Message
        {
            get
            {
                return _message + ".Right your email like joeschmoe@mydomain.com";
            }
        }
    }
}
