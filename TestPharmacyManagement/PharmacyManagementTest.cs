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

        [TestMethod]
        public void GetInstanceTest()
        {
            Assert.IsNotNull(ProxyActionManager.GetInstance());
        }

        [TestMethod]
        public void LoginTestIncorrectUser()
        {
            Assert.IsFalse(_proxyInstance.Login("dfnwef", "wgferufr"));
        }


        [TestMethod]
        public void LoginTestProperRights()
        {
            _proxyInstance.Login("admin", "admin");
            Assert.IsTrue(_proxyInstance.CurrentUser.Rights == -1);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void AddNewProductTestNegativeStock()
        {
            _proxyInstance.Login("farmacist1", "farmacist1");
            _proxyInstance.AddNewProduct(new Product(100000, "testProd", "testCategory", 33.5, -4));
            
        }

        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void AddNewProductTestAdmin()
        {
            _proxyInstance.Login("admin", "admin");
            _proxyInstance.AddNewProduct(new Product(100000, "testProd", "testCategory", 33.5, -4));

        }


        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void AddNewProductTestNegativePrice()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.AddNewProduct(new Product(3, "paracetamol2", "analgezice", -12, 4));
        }


        [TestMethod]
        [ExpectedException(typeof(RecordNotFoundException))]
        public void AddToStockTestInvalidID()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.AddToStock(-12, 20);
        }

        [TestMethod]
        public void GetProductsTestAdminQuery()
        {
            _proxyInstance.Login("admin", "admin");
            Assert.IsNull(_proxyInstance.GetProducts());
        }

        [TestMethod]
        [ExpectedException(typeof(RecordNotFoundException))]      
        public void SellProductTestInexistentID()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.SellProduct(234234, -3);
        }

        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void SellProductTestAdmin()
        {
            _proxyInstance.Login("admin", "admin");
            _proxyInstance.SellProduct(0, 3);
        }
        

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void AddUserTestInvalidOccupationCode()
        {
            _proxyInstance.Login("admin", "admin");
            _proxyInstance.AddUser("farmacist22", "farmacist22", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ConstraintViolatedException))]
        public void AddUserTestExistingUser()
        {
            _proxyInstance.Login("admin", "admin");
            _proxyInstance.AddUser("farmacist2", "farmacist2", 0);
        }

        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void UpdateUserPasswordTestPharmacistAttempt()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.UpdateUserPassword("farmacist1", "farmacist1", "farma1");
        }



        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void UpdateUserPasswordTestWrongOldPass()
        {
            _proxyInstance.Login("admin", "admin");
            _proxyInstance.UpdateUserPassword("farmacist1", "farmacist11", "farma1");
        }


        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void DeleteUserTest()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.DeleteUser("farmacist2");
        }


        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void DeleteUserTestAdminClear()
        {
            _proxyInstance.Login("admin", "admin");
            _proxyInstance.DeleteUser("admin");
        }

        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void GetUserTest()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.GetUser(0);
        }

        [TestMethod]
        [ExpectedException(typeof(RecordNotFoundException))]
        public void GetUserTest2()
        {
            _proxyInstance.Login("admin", "admin");
            Assert.IsNull(_proxyInstance.GetUser(-3));
           
        }

        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void GetUsersTest()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            _proxyInstance.GetUsers();
           
        }

        [TestMethod]
        public void RootAccessTest()
        {
            _proxyInstance.Login("farmacist2", "farmacist2");
            Assert.IsTrue(_proxyInstance.RootAccess()==false);
        }
    }
}
