using System;
using System.Runtime.Serialization;

namespace SeminarskiRadProjektovanjeSoftvera.Controller
{
    [Serializable]
    internal class ValidationException : Exception
    {
        public ValidationException()
        {
        }

        public ValidationException(string message) : base(message)
        {
        }

      
    }
}