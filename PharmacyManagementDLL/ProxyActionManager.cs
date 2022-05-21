/**************************************************************************
 *                                                                        *
 *  File:        ProxyActionManager.cs                                    *
 *  Copyright:   (c) 2022, Gabriela Ursachi                               *
 *  E-mail:      gabriela.ursachi@student.tuiasi.ro                       *
 *  Description: This file contains the implementation of Proxy class     *
 *                  from Proxy Pattern                                    *
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

using Items.Commons;
using Items.DataBaseObjects;
using System;
using System.Collections.Generic;
using System.Text;
using DataBaseManager;
using Exceptions.DataBaseExceptions;
using Exceptions.AccessRightsExceptions;
using System.IO;

namespace PharmacyManagementDLL
{
    /// <summary>
    /// This class acts as a protection proxy between those who will use the 
    /// application and the various actions it provides in the context of
    /// pharmacy management. It is also a singleton class for use in different views with the same values.
    /// </summary>
    public class ProxyActionManager : IActionManager
    {
        private DB _dbInstance;
        private RealActionManager _realActionManager;
        private User _currentUser;
        private Permissions _permissions;
        private static ProxyActionManager _instance=null;

        /// <summary>
        /// Class constructor: it initializes all its members for later use
        /// </summary>
        private ProxyActionManager()
        {
            _dbInstance = DB.GetInstance("IPpharma.db");
            _realActionManager = new RealActionManager();
            _currentUser = null;
            _permissions = new Permissions();
        }

        /// <summary>
        /// It creates a new instance of proxy only if it hasn't been already created.
        /// </summary>
        /// <returns>ProxyActionManager singleton instance</returns>
        public static ProxyActionManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ProxyActionManager();
            }

            return _instance;
        }

        public User CurrentUser
        {
            get
            {
                return _currentUser;
            }
        }

        /// <summary>
        /// Verifies username and password and provides access to app
        /// only to those who are registered in the users database.
        /// </summary>
        /// <param name="username">Account username</param>
        /// <param name="password">Account password</param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            List<User> users = _dbInstance.SelectAllUsers();
            foreach (User user in users)
            {
                if (user.Username.Equals(username))
                {
                    if (user.Password.Equals(Cryptography.HashString(password)))
                    {
                        _currentUser = user;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Adds a new product to the database only if registered user has this right.
        /// </summary> 
        /// <param name="newProduct">Product to be added</param>
        public void AddNewProduct(Product newProduct)
        {
            bool hasAccess = true;
            try
            {
                //gives access only to thosewho are Pharmacists
                if (_permissions.RightsList(_currentUser.Rights).Contains(Constants.ModifyProductsDBRight))
                {
                    _realActionManager.AddNewProduct(newProduct);
                }
                else
                {
                    hasAccess = false;
                }
            }
            //forwards exceptions for display a suggestive message on GUI
            catch (ConstraintViolatedException exc)
            {
                throw exc;
            }
            catch (InvalidStockException exc)
            {
                throw exc;
            }

            if (!hasAccess)
            {
                throw new PermissionDeniedException();
            }
        }

        /// <summary>
        /// Lets only those who have modify access right to increase/decrease product stock.
        /// </summary>
        /// <param name="barcode">Unique identifier of product</param>
        /// <param name="quantity">Value to be added to the current stock. </param>   
        public void AddToStock(int barcode, int quantity)
        {
            bool hasAccess = true;
            try
            {
                //gives access only to thosewho are Pharmacists
                if (_permissions.RightsList(_currentUser.Rights).Contains(Constants.ModifyProductsDBRight))
                {
                    _realActionManager.AddToStock(barcode, quantity);
                }
                else
                {
                    hasAccess = false;
                }
            }
            catch (RecordNotFoundException exc)
            {
                throw exc;
            }
            catch (InvalidStockException exc)
            {
                throw exc;
            }


            if (!hasAccess)
            {
                throw new PermissionDeniedException();
            }
        }

        /// <summary>
        /// Transmit Product list only to those who have viewProducts right.
        /// </summary>
        /// <returns>Products list from database.</returns>
        public List<Product> GetProducts()
        {
            if (_permissions.RightsList(_currentUser.Rights).Contains(Constants.ViewProductsRight))
            {
                return _realActionManager.GetProducts();
            }
            return null;
        }

        /// <summary>
        /// Gives access to sell products only to those who have SellRight.
        /// </summary>
        /// <param name="barcode">Unique identifier of product.</param>
        /// <param name="quantity">Product amount which will be sold. </param>
        public void SellProduct(int barcode, int quantity)
        {
            bool hasAccess = true;
            try
            {
                if (_permissions.RightsList(_currentUser.Rights).Contains(Constants.SellRight))
                {
                    _realActionManager.SellProduct(barcode, quantity);
                }
                else
                {
                    hasAccess = false;
                }
            }
            catch (RecordNotFoundException exc)
            {
                throw exc;
            }
            catch (InvalidStockException exc)
            {
                throw exc;
            }


            if (!hasAccess)
            {
                throw new PermissionDeniedException();
            }

        }

        /// <summary>
        /// Lets currentUser to add new employee profile to database only if he has this right
        /// </summary>
        /// <param name="username">Newly added username</param>
        /// /// <param name="password">Password for this profile</param>
        /// /// <param name="occupationCode">A specific code given to the user's function in pharmacy</param>
        public void AddUser(string username, string password, int occupationCode)
        {
            bool hasAccess = true;
            try
            {
                if (_permissions.RightsList(_currentUser.Rights).Contains(Constants.ModifyUsersDBRight) && occupationCode!=Constants.Admin)
                {
                    _realActionManager.AddUser(username, password, occupationCode);
                }
                else
                {
                    hasAccess = false;
                }
            }
            catch (ConstraintViolatedException exc)
            {
                throw exc;
            }

            if (!hasAccess)
            {
                throw new PermissionDeniedException();
            }
        }

        /// <summary>
        /// Lets only those with modify users db right to modify user password in database
        /// </summary>
        /// <param name="username">Modified user's name.</param>
        /// <param name="oldPass">Old password for this account.</param>
        /// <param name="newPass">New password for this account.</param>
        public void UpdateUserPassword(string username, string oldPass, string newPass)
        {
            bool hasAccess = true;
            try
            {
                if (_permissions.RightsList(_currentUser.Rights).Contains(Constants.ModifyUsersDBRight))
                {
                    _realActionManager.UpdateUserPassword(username, oldPass, newPass);
                }
                else
                {
                    hasAccess = false;
                }
            }
            catch (RecordNotFoundException exc)
            {
                throw exc;
            }
            catch (InvalidDataException exc)
            {
                throw exc;
            }

            if (!hasAccess)
            {
                throw new PermissionDeniedException();
            }
        }

        /// <summary>
        /// Lets only those with modify users db right to remove a user ;
        /// </summary>
        /// <param name="username">username of the user we want to remove</param>
        public void DeleteUser(string username)
        {
            bool hasAccess = true;

            if (_permissions.RightsList(_currentUser.Rights).Contains(Constants.ModifyUsersDBRight))
            {
                _realActionManager.DeleteUser(username);
            }
            else
            {
                hasAccess = false;
            }


            if (!hasAccess)
            {
                throw new PermissionDeniedException();
            }
        }

        /// <summary>
        /// Gets info about a user only to those who have view users right.
        /// </summary>
        /// <param name="userID">ID of the user we want info about</param>
        /// <returns>Requested user or null if it doesn't exist.</returns>
        public User GetUser(int userID)
        {
            User searchedUser = null;

            if (_permissions.RightsList(_currentUser.Rights).Contains(Constants.ViewUsersRight))
            {
                searchedUser = _realActionManager.GetUser(userID);
                return searchedUser;
            }
            else
            {
                throw new PermissionDeniedException();
            }
        }

        /// <summary>
        /// Queries database to display all existing users only if current user has 'view users right'
        /// </summary>
        /// <returns>All existing users</returns>
        public List<User> GetUsers()
        {
            if (_permissions.RightsList(_currentUser.Rights).Contains(Constants.ViewUsersRight))
            {
                return _realActionManager.GetUsers();
            }
            else
            {
                throw new PermissionDeniedException();
            }
        }

        /// <summary>
        /// Transmits information about the current status of the user.
        /// </summary>
        /// <returns></returns>
        public bool RootAccess()
        {
            return _currentUser.Rights == -1;
        }



    }
}
