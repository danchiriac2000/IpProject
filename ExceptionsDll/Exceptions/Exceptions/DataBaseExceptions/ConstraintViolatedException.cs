/**************************************************************************
 *                                                                        *
 *  File:        ConstraintViolatedException.cs                           *
 *  Creator:     Chiriac Dan-Constantin                                   *
 *  E-mail:      dan-constantin.chiriac@student.tuiasi.ro                 *      
 *  Description: This file contains an exception that will be thrown      *
 *  if a constraint is violated.                                          *
 *                                                                        *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.DataBaseExceptions
{

    /// <summary>
    /// This class inherits the Exception base class. If the unique or the primary key constraint is violated, this exception will be thrown.
    /// </summary>
    public class ConstraintViolatedException : Exception
    {
        private string _message;

        /// <summary>
        /// Constructor without arguments. 
        /// </summary>
        public ConstraintViolatedException()
        {
            _message = "Unique/Primary constraint violated. ";
        }
        /// <summary>
        /// Constructor with arguments.
        /// </summary>
        /// <param name="message"></param>
        public ConstraintViolatedException(string message)
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
