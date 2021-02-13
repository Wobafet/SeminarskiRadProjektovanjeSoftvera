using System;
using System.Runtime.Serialization;

namespace SeminarskiRadProjektovanjeSoftvera.Communications
{
    [Serializable]
    internal class AddException : Exception
    {
        public AddException()
        {
        }

        public AddException(string message) : base(message)
        {
        }

        
    }
}