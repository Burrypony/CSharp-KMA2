using System;

namespace Сhernysh01
{
    class BornValidation : Exception
    {
        private string _message;
        private DateTime? _birth;

        public BornValidation(string message, DateTime birth)
        {
            _message = message;
            _birth = birth;
        }

        public BornValidation(string message)
        {
            _message = message;
        }

        public BornValidation(DateTime birth) : this("You could not be born  in this time, so do not lie to me and set the present date of birth and not this one:", birth)
        {
        }

        public override string Message
        {
            get
            {
                if (_birth != null)
                {
                    return _message + " " + _birth;
                }
                return _message;
            }
        }
    }
}
