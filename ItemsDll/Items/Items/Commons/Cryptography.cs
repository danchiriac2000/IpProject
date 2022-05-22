/**************************************************************************
 *                                                                        *
 *  File:        Cryptography.cs                                          *
 *  Copyright:   (c) 2022, Gabriela Ursachi                               *
 *  E-mail:      gabriela.ursachi@student.tuiasi.ro                       *
 *  Description: This file deals with password encryption                 *
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
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace Items.Commons
{
    /// <summary>
    /// This class is used for provide methods to securely store information to database.
    /// </summary>
    public class Cryptography
    {

        /// <summary>
        /// Returns the hash of a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string HashString(string str)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            byte[] buf = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
                buf[i] = (byte)str[i];
            byte[] result = sha.ComputeHash(buf);
            return Convert.ToBase64String(result);
        }
    }
}
