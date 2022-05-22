/**************************************************************************
 *                                                                        *
 *  File:        PharmacyManagementTest.cs                                *
 *  Copyright:   (c) 2022, Gabriela Ursachi                               *
 *  E-mail:      gabriela.ursachi@student.tuiasi.ro                       *
 *  Description: This file contains unit testing module for               *
 *                  Pharmacy Management DLL                               *
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

using PharmacyManagementDLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exceptions.AccessRightsExceptions;
using Exceptions.DataBaseExceptions;
using Items.DataBaseObjects;
using System.IO;

namespace TestPharmacyManagement
{
    [TestClass]
    public class PharmacyManagementTest
    {
        private ProxyActionManager _proxyInstance = ProxyActionManager.GetInstance();

        /// <summary>
        /// Function that tests whether the proxy instance is always successful.
        /// </summary>
        [TestMethod]
        public void GetInstanceTest()
        {
            Assert.IsNotNull(ProxyActionManager.GetInstance());
        }

        /// <summary>
        /// Function  that tests if a inexistent user can use the application.
        /// </summary>
        [TestMethod]
        public void LoginTestIncorrectUser()
        {
            Assert.IsFalse(_proxyInstance.Login("dfnwef", "wgferufr"));
        }

        /// <summary>
        /// Function that tests if admin gets it's correct rights after login.
        /// </summary>
        [TestMethod]
        public void LoginTestProperRights()
        {
            _proxyInstance.Login("admin", "admin");
            Assert.IsTrue(_proxyInstance.CurrentUser.Rights == -1);
        }

        /// <summary>
        /// Function that tests if it's thrown an exception when app user try to 
        /// introduce to product stock a negative value.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void AddNewProductTestNegativeStock()
        {
            _proxyInstance.Login("farmacist1", "farmacist1");
            _proxyInstance.AddNewProduct(new Product(100000, "testProd", "testCategory", 33.5, -4));
            
        }

        /// <summary>
        /// Function that tests if product insert action it's in accordance with the logged user right.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void AddNewProductTestAdmin()
        {
            _proxyInstance.Login("admin", "admin");
            _proxyInstance.AddNewProduct(new Product(100000, "testProd", "testCategory", 33.5, -4));

        }

        /// <summary>
        /// Function that tests if it's thrown an exception when user tries to add a negative
        /// value for quantity attribute in database.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void AddNewProductTestNegativePrice()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.AddNewProduct(new Product(3, "paracetamol2", "analgezice", -12, 4));
        }

        /// <summary>
        /// Function that tests if update stock action cannot be done for an inexistent product barcode.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(RecordNotFoundException))]
        public void AddToStockTestInvalidID()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.AddToStock(-12, 20);
        }

        /// <summary>
        /// Function that tests if get products returns null value for users 
        /// without this access right.
        /// </summary>
        [TestMethod]
        public void GetProductsTestAdminQuery()
        {
            _proxyInstance.Login("admin", "admin");
            Assert.IsNull(_proxyInstance.GetProducts());
        }

        /// <summary>
        /// Function that tests that an attempt to sell a non-existent product 
        /// will throw an exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(RecordNotFoundException))]      
        public void SellProductTestInexistentID()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.SellProduct(234234, -3);
        }

        /// <summary>
        /// Function that tests that admin has no access right for product selling.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void SellProductTestAdmin()
        {
            _proxyInstance.Login("admin", "admin");
            _proxyInstance.SellProduct(0, 3);
        }

        /// <summary>
        /// Function that tests whether the attempt to introduce a new user
        /// in the database is always done with a valid occupational code.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void AddUserTestInvalidOccupationCode()
        {
            _proxyInstance.Login("admin", "admin");
            _proxyInstance.AddUser("farmacist22", "farmacist22", 5);
        }

        /// <summary>
        /// Function that tests if it's thrown a specific exception for override user attempt.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ConstraintViolatedException))]
        public void AddUserTestExistingUser()
        {
            _proxyInstance.Login("admin", "admin");
            _proxyInstance.AddUser("farmacist2", "farmacist2", 0);
        }

        /// <summary>
        /// Function that tests if it's thrown an exception for permission right when a user different from
        /// admin tries to update another user's password in database.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void UpdateUserPasswordTestPharmacistAttempt()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.UpdateUserPassword("farmacist1", "farmacist1", "farma1");
        }

        /// <summary>
        /// Function that tests that it's impossible for admin to change user password 
        /// if the old password is unknown.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void UpdateUserPasswordTestWrongOldPass()
        {
            _proxyInstance.Login("admin", "admin");
            _proxyInstance.UpdateUserPassword("farmacist1", "farmacist11", "farma1");
        }

        /// <summary>
        /// Function that tests if it's thrown an exception for permission right when a user different from
        /// admin tries to delete another user in database.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void DeleteUserTest()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.DeleteUser("farmacist2");
        }

        /// <summary>
        /// Function that tests  that the administrator account cannot be deleted, even
        /// if the administrator tries to do so himself.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void DeleteUserTestAdminClear()
        {
            _proxyInstance.Login("admin", "admin");
            _proxyInstance.DeleteUser("admin");
        }

        /// <summary>
        /// Function that tests that an user different from admin can't queries to
        /// find information about the other app users.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void GetUserTest()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.GetUser(0);
        }

        /// <summary>
        /// Function that tests if the query of a non-existent user ID will throw a certain exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(RecordNotFoundException))]
        public void GetUserTest2()
        {
            _proxyInstance.Login("admin", "admin");
            Assert.IsNull(_proxyInstance.GetUser(-3));
           
        }

        /// <summary>
        /// Functions that tests that a regular user cannot view information about all other users
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void GetUsersTest()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.GetUsers();
           
        }

        /// <summary>
        /// Function that tests whether or not a regular user has root access.
        /// </summary>
        [TestMethod]
        public void RootAccessTest()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            Assert.IsTrue(_proxyInstance.RootAccess()==false);
        }
    }
}
