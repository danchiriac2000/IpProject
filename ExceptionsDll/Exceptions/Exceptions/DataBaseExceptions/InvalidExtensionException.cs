using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.DataBaseExceptions
{
    /// <summary>
    /// This class inherits the Exception base class. If the extension of the database file is not ".db", this exception will be throwned.
    /// </summary>
    public class InvalidExtensionException : Exception
    {

        private string _message;

        /// <summary>
        /// Constructor without arguments. 
        /// </summary>
        public InvalidExtensionException()
        {
            _message = "Extension is invalid!";
        }
        /// <summary>
        /// Constructor with arguments.
        /// </summary>
        /// <param name="message"></param>
        public InvalidExtensionException(string message)
        {
            this._message = message;
        }
        /// <summary>
        /// Get property for _message variable.
        /// </summary>
        public string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
