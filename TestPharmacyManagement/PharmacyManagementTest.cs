using PharmacyManagementDLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exceptions.AccessRightsExceptions;
using Exceptions.DataBaseExceptions;
using Items.DataBaseObjects;

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
        [ExpectedException(typeof(ConstraintViolatedException))]
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
        [ExpectedException(typeof(ConstraintViolatedException))]
        public void AddNewProductTestNegativePrice()
        {
            _proxyInstance.Login("farmacist1", "farmacist1");
            _proxyInstance.AddNewProduct(new Product(1, "paracetamol", "analgezice", -5, 4));
        }


        [TestMethod]
        [ExpectedException(typeof(RecordNotFoundException))]
        public void AddToStockTestInvalidID()
        {
            _proxyInstance.Login("farmacist1", "farmacist1");
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
        public void SellProductTestInexistent()
        {
            _proxyInstance.Login("farmacist1", "farmacist1");
            _proxyInstance.SellProduct(234234, -3);
        }

        [TestMethod]
        [ExpectedException(typeof(ConstraintViolatedException))]
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
        public void UpdateUserPasswordTest()
        {
            //Assert.Fail();
        }

        [TestMethod]
        public void DeleteUserTest()
        {
            //Assert.Fail();
        }

        [TestMethod]
        public void GetUserTest()
        {
            //Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(PermissionDeniedException))]
        public void GetUsersTest()
        {
            _proxyInstance.Login("farmacist1", "farmacist1");
            _proxyInstance.GetUsers();
            //Assert.Fail();
        }

        [TestMethod]
        public void RootAccessTest()
        {
            _proxyInstance.Login("farmacist1", "farmacist1");
            Assert.IsTrue(_proxyInstance.RootAccess()==false);
        }
    }
}
