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

using Items.DataBaseObjects;
using System;
using System.Collections.Generic;
using System.Text;
using DataBaseManager;
using Exceptions.DataBaseExceptions;

namespace PharmacyManagementDLL
{
    public class RealActionManager : IActionManager
    {
        private DB _dbInstance;

        

        public RealActionManager()
        {
            // _dbInstance=DB.getInstance();
        }


        /// <summary>
        /// Adds a new product to the database and returns operation status:
        /// succes(true) / failure(false) = product already exists.
        /// </summary> 
        /// <param name="newProduct">Product to be added</param>
        /// <returns>Status of operation</returns>
        public bool AddNewProduct(Product newProduct)
        {
            try
            {
                _dbInstance.Insert(newProduct);
            }
            catch(ConstraintViolatedException exc)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Sell product with the given barcode and returns failure(false) if the product doesn't exist
        /// or if it's insufficient stock.
        /// </summary>
        /// <param name="barcode">Unique identifier of product.</param>
        /// <param name="quantity">Product amount which will be sold. </param>
        /// <returns>Status of operation</returns>
        public bool SellProduct(int barcode, int quantity)
        {
            //verify if database contains a product with the given barcode
            Product product = _dbInstance.SelectProduct(barcode);
            if (product == null)
            {
                return false;
            }
            else
            {
                int newStock = product.Stock - quantity;
                Product updatedProduct = new Product(product.Id, product.Name, product.Category, product.Price, newStock);

                try
                {
                    _dbInstance.Update(updatedProduct);
                }
                catch (ConstraintViolatedException exc)
                {
                    return false;
                }

                return true;
            }

        }


        /// <summary>
        /// Update product stock in database and returns failure(false) if the new 
        /// stock value is not allowed due to database constraints.
        /// </summary>
        /// <param name="barcode">Unique identifier of product</param>
        /// <param name="quantity">Value to be added to the current stock. </param>
        /// <returns>Status of operation</returns>
        public bool AddToStock(int barcode, int quantity)
        {
            //verify if database contains a product with the given barcode
            Product product = _dbInstance.SelectProduct(barcode);
            if (product == null)
            {
                return false;
            }
            else
            {
                int newStock = product.Stock + quantity;
                Product updatedProduct = new Product(product.Id, product.Name, product.Category, product.Price, newStock);

                try
                {
                    _dbInstance.Update(updatedProduct);
                }
                catch (ConstraintViolatedException exc)
                {
                    return false;
                }

                return true;
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

  


    }
}
