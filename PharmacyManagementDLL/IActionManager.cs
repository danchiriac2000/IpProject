/**************************************************************************
 *                                                                        *
 *  File:        IActionManager.cs                                        *
 *  Copyright:   (c) 2022, Gabriela Ursachi                               *
 *  E-mail:      gabriela.ursachi@student.tuiasi.ro                       *
 *  Description: This file contains a generic Manager definition.         *
 *               It also defines the Subject from Proxy Pattern .         *
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
using Items.DataBaseObjects;

namespace PharmacyManagementDLL
{
    public interface IActionManager
    {

        /// <summary>
        /// Adds a new product to the existing ones.
        /// </summary> 
        /// <param name="newProduct">Product to be added</param>
        /// <returns>Status of operation</returns>
        public bool AddNewProduct(Product newProduct);


        /// <summary>
        /// Sell products to clients.
        /// </summary>
        /// <param name="barcode">Unique identifier of product.</param>
        /// <param name="quantity">Product amount which will be sold. </param>
        /// <returns>Status of operation</returns>
        public bool SellProduct(int barcode, int quantity);


        /// <summary>
        /// Update product stock in database .
        /// </summary>
        /// <param name="barcode">Unique identifier of product</param>
        /// <param name="quantity">Value to be added to the current stock. </param>
        /// <returns>Status of operation</returns>
        public bool AddToStock(int barcode,int quantity);   
        

        /// <summary>
        /// Queries for obtain a list of all existing products.
        /// </summary>
        /// <returns>All existing products.</returns>
        public List<Product> GetProducts();

    }
}
