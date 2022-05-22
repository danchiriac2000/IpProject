/**************************************************************************
 *                                                                        *
 *  File:        ValidProducts.cs                                         *
 *  Copyright:   (c) 2022, Gabriela Ursachi                               *
 *  E-mail:      gabriela.ursachi@student.tuiasi.ro                       *
 *  Description: This file deals with management of valid products        *
 *               in database table.                                       *
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

namespace Items.DataBaseObjects
{
    /// <summary>
    /// Class used to retain associations between product categories and
    /// certain commercial products for each category.
    /// The purpose of singleton pattern implementation is to assure that 
    /// reading information from file is made only once, even if they are
    /// used in many contexts.
    /// </summary>
    public class ValidProducts
    {

        private Dictionary<String, List<String>> _products = new Dictionary<String, List<String>>();
        private static ValidProducts _instance;
     
        /// <summary>
        /// Class contructor: it initializes the used data structure with all info read from file.
        /// </summary>
        private ValidProducts()
        {

            String[] lines = System.IO.File.ReadAllLines(@"ValidProducts.txt");
            foreach(String line in lines)
            {
                String[] elements = line.Split(':');
                String category = elements[0];

                String[] products = elements[1].Split(',');

                _products.Add(category, products.ToList());

            }

        }

        /// <summary>
        /// This method ensures that it is only one instance of this class throughout
        /// the project.The reason for a single instance is that the same information 
        /// is not often read from the same file, if it has already been read.
        /// </summary>
        /// <returns>Class instance.</returns>
        public static ValidProducts GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ValidProducts();
            }

            return _instance;
        }

        public Dictionary<String, List<String>> Products
        {
            get
            {
                return _products;
            }
        }




    }
}
