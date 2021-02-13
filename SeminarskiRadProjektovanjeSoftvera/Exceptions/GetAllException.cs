using System;
using System.Runtime.Serialization;

namespace SeminarskiRadProjektovanjeSoftvera.Communications
{
    [Serializable]
    internal class GetAllException : Exception
    {
        public GetAllException()
        {
        }

        public GetAllException(string message) : base(message)
        {
        }

      
    }
}