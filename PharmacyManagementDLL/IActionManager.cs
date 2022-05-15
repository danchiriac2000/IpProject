﻿/**************************************************************************
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
    /// <summary>
    /// This interface contains specific methods for actions that can take 
    /// place in a pharmacy ; these methods will be implemented in subclasses. 
    /// </summary>
    public interface IActionManager
    {

        /// <summary>
        /// Adds a new product to the existing ones.
        /// </summary> 
        /// <param name="newProduct">Product to be added</param>     
        public void AddNewProduct(Product newProduct);

        /// <summary>
        /// Sell products to clients.
        /// </summary>
        /// <param name="barcode">Unique identifier of product.</param>
        /// <param name="quantity">Product amount which will be sold. </param>
        public void SellProduct(int barcode, int quantity);

        /// <summary>
        /// Update product stock in database .
        /// </summary>
        /// <param name="barcode">Unique identifier of product</param>
        /// <param name="quantity">Value to be added to the current stock. </param>
        public void AddToStock(int barcode,int quantity);           

        /// <summary>
        /// Queries for obtain a list of all existing products.
        /// </summary>
        /// <returns>All existing products.</returns>
        public List<Product> GetProducts();

        /// <summary>
        /// Add new employee profile to database.
        /// </summary>
        /// <param name="username">Newly added username</param>
        /// /// <param name="password">Password for this profile</param>
        /// /// <param name="occupationCode">A specific code given to the user's function in pharmacy</param>  
        public void AddUser(string username,string password,int occupationCode);

        /// <summary>
        /// Modifies user password in database.
        /// </summary>
        /// <param name="userID">Modified userID.</param>
        /// <param name="oldPass">Old password for this account.</param>
        /// <param name="newPass">New password for this account.</param>
        public void UpdateUserPassword(int userID,string oldPass,string newPass);

        /// <summary>
        /// Gets info about a user with the given id
        /// </summary>
        /// <param name="userID">ID of the user we want info about</param>
        /// <returns>Requested user or null if it doesn't exist.</returns>
        public User GetUser(int userID);

        /// <summary>
        /// Removes a user only if it exists.
        /// </summary>
        /// <param name="userID">ID of the user we want to remove</param>
        public void DeleteUser(int userID);

        /// <summary>
        /// Queries database to display all existing users.
        /// </summary>
        /// <returns>All existing users</returns>
        public List<User> GetUsers();







    }
}
