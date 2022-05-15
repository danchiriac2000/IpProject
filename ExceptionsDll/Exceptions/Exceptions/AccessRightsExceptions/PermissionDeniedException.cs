/**************************************************************************
 *                                                                        *
 *  File:        PermissionDeniedException.cs                             *
 *  Copyright:   (c) 2022, Gabriela Ursachi                               *
 *  E-mail:      gabriela.ursachi@student.tuiasi.ro                       *
 *  Description: This file contains the implementation of an              *
 *               access right exception                                  *
 *                                                                        *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.AccessRightsExceptions
{
    public class PermissionDeniedException : Exception
    {
        private string _message;

        /// <summary>
        /// Constructor without arguments. 
        /// </summary>
        public PermissionDeniedException()
        {
            _message = "You do not have access right for this action.";
        }

        /// <summary>
        /// Constructor with arguments.
        /// </summary>
        /// <param name="message"></param>
        public PermissionDeniedException(string message)
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
