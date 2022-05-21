/**************************************************************************
 *                                                                        *
 *  File:        InvalidStockException.cs                                 *
 *  Creator:     Chiriac Dan-Constantin                                   *
 *  E-mail:      dan-constantin.chiriac@student.tuiasi.ro                 *      
 *  Description: This file contains an exception that will be thrown      *
 *  if the Stock of the products table is less than 0.                    *
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
    /// This class inherits the Exception base class. If the stock from products table is less than 0, this exception is thrown.
    /// </summary>

    public class InvalidStockException : Exception
    {
        private string _message;

        /// <summary>
        /// Constructor without arguments. 
        /// </summary>
        public InvalidStockException()
        {
            _message = "The stock can't be less than 0!";
        }
        /// <summary>
        /// Constructor with arguments.
        /// </summary>
        /// <param name="message"></param>
        public InvalidStockException(string message)
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
