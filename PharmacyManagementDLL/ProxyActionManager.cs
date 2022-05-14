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

using Items.DataBaseObjects;
using System;
using System.Collections.Generic;
using System.Text;
using DataBaseManager;
using Exceptions.DataBaseExceptions;


namespace PharmacyManagementDLL
{
    public class ProxyActionManager : IActionManager
    {
        private RealActionManager _realActionManager;
        private User _currentUser;
        private Permissions _permissions;
        private DB _dbInstance;

        public ProxyActionManager()
        {
            _realActionManager = new RealActionManager();
            _currentUser = null;
            _permissions = new Permissions();
            // _dbInstance=DB.getInstance();
        }



        public bool AddNewProduct(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public bool AddToStock(int barcode, int quantity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public bool SellProduct(int barcode, int quantity)
        {
            throw new NotImplementedException();
        }

        //TODO
        public bool Login(string username, string password)
        {
            return true;
        }




        //TODO
        public void AddUser(User user)
        {
            try
            {
                _dbInstance.Insert(user);
            }
            catch(ConstraintViolatedException exc)
            {
                //MessageBox.Show("User already exists");
            }
            
        }

        //TODO
        public void UpdateUser(string username,User user)
        {

        }

        //TODO
        public void DeleteUser(string username)
        {

        }

        //TODO
        public List<User> GetUsers()
        {
            return new List<User>();
        }
        
    }
}
