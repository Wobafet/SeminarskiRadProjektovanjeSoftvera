using System;
using System.Runtime.Serialization;

namespace SeminarskiRadProjektovanjeSoftvera.Communications
{
    [Serializable]
    internal class DeleteException : Exception
    {
        public DeleteException()
        {
        }

        public DeleteException(string message) : base(message)
        {
        }

      
    }
}