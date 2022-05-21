/**************************************************************************
 *                                                                        *
 *  File:        RecordNotFoundException.cs                               *
 *  Creator:     Chiriac Dan-Constantin                                   *
 *  E-mail:      dan-constantin.chiriac@student.tuiasi.ro                 *      
 *  Description: This file contains an exception that will be thrown      *
 *  if a record of a table is not found.                                  *
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
    /// This class inherits the Exception base class. If a record from a table doesen't exists and someeone is trying to update it, this exception will be thrown.
    /// </summary>

    public class RecordNotFoundException : Exception
    {
        private string _message;

        /// <summary>
        /// Constructor without arguments. 
        /// </summary>
        public RecordNotFoundException()
        {
            _message = "The record was not found.";
        }
        /// <summary>
        /// Constructor with arguments.
        /// </summary>
        /// <param name="message"></param>
        public RecordNotFoundException(string message)
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
