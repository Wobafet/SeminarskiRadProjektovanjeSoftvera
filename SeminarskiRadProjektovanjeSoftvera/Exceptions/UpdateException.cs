using System;
using System.Runtime.Serialization;

namespace SeminarskiRadProjektovanjeSoftvera.Communications
{
    [Serializable]
    internal class UpdateException : Exception
    {
        public UpdateException()
        {
        }

        public UpdateException(string message) : base(message)
        {
        }

      
    }
}