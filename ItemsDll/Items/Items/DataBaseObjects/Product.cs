/**************************************************************************
 *                                                                        *
 *  File:        Product.cs                                               *
 *  Creator:     Chiriac Dan-Constantin                                   *
 *  E-mail:      dan-constantin.chiriac@student.tuiasi.ro                 *      
 *  Description: This file the data class for a product                   *
 *                                                                        *
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
    /// This is the data class for a product. Contains only the getters and setters for the private members of the class.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// The id of the product.
        /// </summary>
        private int _id;
        /// <summary>
        /// The name of the product.
        /// </summary>
        private string _name;
        /// <summary>
        /// The category of the product.
        /// </summary>
        private string _category;
        /// <summary>
        /// The price of the product.
        /// </summary>
        private double _price;
        /// <summary>
        /// The stock of the product.
        /// </summary>
        private int _stock;

        /// <summary>
        /// This is the constructor which initialize the private members.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        public Product(int id, string name, string category, double price, int stock)
        {
            this._id = id;
            this._name = name;
            this._category = category;
            this._price = price;
            this._stock = stock;
        }

        public int Id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }
        public string Category
        {
            set
            {
                _category = value;
            }
            get
            {
                return _category;
            }
        }
        public int Stock
        {
            set
            {
                _stock = value;
            }
            get
            {
                return _stock;

            }
        }
        public double Price
        {
            set
            {
                _price = value;
            }
            get
            {
                return _price;

            }
        }
        /// <summary>
        /// Return the members of the class in the form of a string.
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return _id + " " + _name + " " + _category + " " + _price + " " + _stock;
        }
    }
}
