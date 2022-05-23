/**************************************************************************
 *                                                                        *
 *  File:        RealActionManager.cs                                     *
 *  Copyright:   (c) 2022, Gabriela Ursachi                               *
 *  E-mail:      gabriela.ursachi@student.tuiasi.ro                       *
 *  Description: This file contains the implementation of Real Subject    *
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
using System.IO;
using System.Collections.Generic;
using System.Text;
using DataBaseManager;
using Exceptions.DataBaseExceptions;
using Exceptions.AccessRightsExceptions;

namespace PharmacyManagementDLL
{
    /// <summary>
    /// This class provides useful methods in the management of 
    /// a pharmacy and its staff.
    /// </summary>
    public class RealActionManager : IActionManager
    {
        private DB _dbInstance;

        
        /// <summary>
        /// Class constructor: sets database instance for later use
        /// in queries and database tables changes
        /// </summary>
        public RealActionManager()
        {
            _dbInstance=DB.GetInstance("IPpharma.db");
            _dbInstance.CreateTables();
        
        }

        /// <summary>
        /// Adds a new product to the database and returns operation status:
        /// succes(true) / failure(false) = product already exists.
        /// </summary> 
        /// <param name="newProduct">Product to be added</param>
        public void AddNewProduct(Product newProduct)
        {
            if (newProduct.Stock < 0)
            {
                throw new InvalidDataException("Stock cannot be less than zero");
            }
            if (newProduct.Price < 0)
            {
                throw new InvalidDataException("Price cannot be less than zero");
            }
            try
            {     
                _dbInstance.Insert(newProduct);
            }
            catch(ConstraintViolatedException exc)
            {
                throw new ConstraintViolatedException("The product with given barcode or name already exists!");
            }
            catch(InvalidStockException exc)
            {
                throw new InvalidStockException();            
            }

            
        }

        /// <summary>
        /// Sell product with the given barcode and returns failure(false) if the product doesn't exist
        /// or if it's insufficient stock.
        /// </summary>
        /// <param name="barcode">Unique identifier of product.</param>
        /// <param name="quantity">Product amount which will be sold. </param>
        public void SellProduct(int barcode, int quantity)
        {
            //verify if database contains a product with the given barcode
            Product product = _dbInstance.SelectProduct(barcode);
            if (product == null)
            {
                throw new RecordNotFoundException("This product doesn't exist.");
            }
            else
            {
                
                int newStock = product.Stock - quantity;
                Product updatedProduct = new Product(product.Id, product.Name, product.Category, product.Price, newStock);

                try
                {
                    _dbInstance.Update(updatedProduct);
                }
                catch (InvalidStockException exc)
                {
                    throw new InvalidStockException("Insufficient stock : only " + product.Stock + " products of this type.");
                }
               
            }

        }

        /// <summary>
        /// Update product stock in database and returns failure(false) if the new 
        /// stock value is not allowed due to database constraints.
        /// </summary>
        /// <param name="barcode">Unique identifier of product</param>
        /// <param name="quantity">Value to be added to the current stock. </param>    
        public void AddToStock(int barcode, int quantity)
        {

            //verify if database contains a product with the given barcode
            Product product = _dbInstance.SelectProduct(barcode);
            if (product == null)
            {
                throw new RecordNotFoundException("This product doesn' exist.Try to add a new product of this type.");
            }
            else
            {
                

                int newStock = product.Stock + quantity;
                Product updatedProduct = new Product(product.Id, product.Name, product.Category, product.Price, newStock);

                try
                {
                    _dbInstance.Update(updatedProduct);
                }
                catch (InvalidStockException exc)
                {
                    throw exc;
                }                
            }            
        }

        /// <summary>
        /// Update product price in database .
        /// </summary>
        /// <param name="barcode">Unique identifier of product</param>
        /// <param name="newPrice">Value to be updated for price attribute. </param>
        public void UpdateProductPrice(int barcode, double newPrice)
        {
            //verify if database contains a product with the given barcode
            Product product = _dbInstance.SelectProduct(barcode);
            if (product == null)
            {
                throw new RecordNotFoundException("This product doesn' exist.Try to add a new product of this type.");
            }
            else
            {
                if (newPrice < 0)
                {
                    throw new InvalidDataException("Price must be greater than zero.");
                }

                
                Product updatedProduct = new Product(product.Id, product.Name, product.Category, newPrice, product.Stock);
               _dbInstance.Update(updatedProduct);
                
                
            }
        }

        /// <summary>
        /// Queries database for obtain a list of all existing products.
        /// </summary>
        /// <returns>Products list from database.</returns>
        public List<Product> GetProducts()
        {
            return _dbInstance.SelectAllProducts();
        }

        /// <summary>
        /// Add new employee profile to database.
        /// </summary>
        /// <param name="username">Newly added username</param>
        /// /// <param name="password">Password for this profile</param>
        /// /// <param name="occupationCode">A specific code given to the user's function in pharmacy</param>
        public void AddUser(string username, string password, int occupationCode)
        {
            if((occupationCode!=Constants.AssistantPharmacist)&&(occupationCode != Constants.Pharmacist))
            {
                throw new InvalidDataException("Invalid occupational code.");
            }
            try
            {   
                string encryptedPass = Cryptography.HashString(password);
                int userID = _dbInstance.GetLastUserID()+1;
                User newUser = new User(userID, username, encryptedPass, occupationCode);
                _dbInstance.Insert(newUser);
            }
            catch (ConstraintViolatedException exc)
            {
                throw new ConstraintViolatedException("An user with this username already exists.");
            }
            
        }

        /// <summary>
        /// Modifies user password in database.
        /// </summary>
        /// <param name="username">Modified user's name.</param>
        /// <param name="oldPass">Old password for this account.</param>
        /// <param name="newPass">New password for this account.</param>
        public void UpdateUserPassword(string username, string oldPass, string newPass)
        {
            User existingUser = _dbInstance.SelectUser(username);
            if (existingUser == null)
            {
                throw new RecordNotFoundException("The given username is not specific for an existing user.");
            }
            else
            {
                //in baza de date este stocata parola criptata
                string oldPassEncrypted = Cryptography.HashString(oldPass);
                if (oldPassEncrypted != existingUser.Password)
                {
                    throw new InvalidDataException("Wrong old password inserted.");
                }
                else
                {
                    string newPassEncrypted = Cryptography.HashString(newPass);
                    existingUser.Password = newPassEncrypted;
                    _dbInstance.Update(existingUser);
                }
            }
        }

        /// <summary>
        /// Removes a user only if it exists.
        /// </summary>
        //// <param name="username">username of the user we want to remove</param>
        public void DeleteUser(string username)
        {
            User deletedUser = _dbInstance.SelectUser(username);
            if (deletedUser == null)
            {
                throw new RecordNotFoundException("Inexistent user");
            }
            if (deletedUser.Rights == -1)
            {
                throw new PermissionDeniedException("Root account can't be deleted!");
            }
            
             _dbInstance.DeleteUser(deletedUser.Id);
  
           
        }

        /// <summary>
        /// Gets info about a user with the given id.
        /// </summary>
        /// <param name="userID">ID of the user we want info about</param>
        /// <returns>Requested user or null if it doesn't exist.</returns>
        public User GetUser(int userID)
        {
            User resultedUser = _dbInstance.SelectUser(userID);
            if (resultedUser == null)
            {
                throw new RecordNotFoundException("Inexistent user.");
            }
            else
            {
                return resultedUser;
            }
            
        }

        /// <summary>
        /// Queries database to display all existing users.
        /// </summary>
        /// <returns>All existing users</returns>
        public List<User> GetUsers()
        {
            return _dbInstance.SelectAllUsers();
        }

  

    }
}
