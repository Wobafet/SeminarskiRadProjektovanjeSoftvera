using System;
using System.Runtime.Serialization;

namespace SeminarskiRadProjektovanjeSoftvera.Communications
{
    [Serializable]
    internal class LoginException : Exception
    {
        public LoginException()
        {
        }

        public LoginException(string message) : base(message)
        {
        }

      
    }
}