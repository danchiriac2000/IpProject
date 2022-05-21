/**************************************************************************
 *                                                                        *
 *  File:        DBTests.cs                                               *
 *  Creator:     Chiriac Dan-Constantin                                   *
 *  E-mail:      dan-constantin.chiriac@student.tuiasi.ro                 *      
 *  Description: This file contain all the tests for the database.        *
 *                                                                        *
 *                                                                        *
 **************************************************************************/


using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataBaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;
using Exceptions.DataBaseExceptions;
using System.IO;
using System.Data.SQLite;
using Items.DataBaseObjects;

namespace DataBaseManager.Tests
{ 
    [TestClass()]
    public class DBTests
    {
        /// <summary>
        /// Function that tests if the InvalidExtensionException is thrown. 
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidExtensionException))]
      
        public void GetInstanceTest()
        {
            DB dataBaseObject = DB.GetInstance("nume.dbb");
        }
        /// <summary>
        /// Function that tests if the database is created, if the GetInstance function is called with the right parameters.
        /// </summary>
        [TestMethod()]
        public void GetInstanceTest2()
        {
            bool exist = false;
            File.Delete("randomDataBase1.db");
            DB dataBaseObject = DB.GetInstance("randomDataBase1.db");
            if (File.Exists("randomDataBase1.db")){
                exist = true;
            }
            Assert.AreEqual(exist, true);

        }
        /// <summary>
        /// Function that tests if the tables are created.
        /// </summary>
        [TestMethod()]
        public void CreateTablesTest()
        {
            bool ok = true;
            File.Delete("randomDataBase.db");
            DB dataBaseObject = DB.GetInstance("randomDataBase.db");
            //Call CreateTable method.
            dataBaseObject.CreateTables();
            SQLiteConnection conn = dataBaseObject.Connection;
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='USERS'";
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            string userTableName = "";
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                userTableName += myreader;
            }
            if (userTableName == "")
            {
                ok = false;
            }
            command = conn.CreateCommand();
            command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='PRODUCTS'";
            sqlite_datareader = command.ExecuteReader();
            string productTableName = "";
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                productTableName += myreader;
            }
            if (productTableName == "")
            {
                ok = false;
            }
            Assert.AreEqual(ok, true);

        }

        /// <summary>
        /// To test the insert method, we must select the user from the database. This can be done with the Select method.
        /// Also, in order to not overwrite the id, the user is deleted first.
        /// In conclusion, all three of these functions can be tested in the same test method.
        /// </summary>
        [TestMethod]
        public void InsertSelectDeleteUserTest()
        {

            DB dataBaseObject = DB.GetInstance("randomDataBase2.db");
            //Delete user with the id first.
            dataBaseObject.DeleteUser(0);
            User u1 = new User(0, "user2000", "1234", 0);
            dataBaseObject.Insert(u1);
            User u2 = dataBaseObject.SelectUser(0);
            bool ok = false;
            if(u1.Id==u2.Id && u1.Username==u2.Username && u1.Password==u2.Password && u1.Rights == u2.Rights)
            {
                ok = true;
            }
            Assert.AreEqual(true, ok);
            
        }
        /// <summary>
        /// This function tests if the ConstraintViolatedException is thrown if two users with the same id are inserted.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ConstraintViolatedException))]
        public void InsertExceptionTest()
        {

            DB dataBaseObject = DB.GetInstance("randomDataBase2.db");
            dataBaseObject.DeleteUser(0);
            dataBaseObject.Insert(new User(0, "user1000", "123", 0));
            dataBaseObject.Insert(new User(0, "user2000", "123", 0));

        }
        /// <summary>
        /// This function tests if the ConstraintViolatedException is thrown if two users with the same username are inserted.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ConstraintViolatedException))]
        public void InsertExceptionTest2()
        {

            DB dataBaseObject = DB.GetInstance("randomDataBase2.db");
            dataBaseObject.DeleteUser(100);
            dataBaseObject.DeleteUser(101);
            dataBaseObject.Insert(new User(100, "user1000", "123", 0));
            dataBaseObject.Insert(new User(101, "user1000", "123", 0));

        }
        /// <summary>
        /// To test the insert method, we must select the product from the database. This can be done with the Select method.
        /// Also, in order to not overwrite the id, the product is deleted first.
        /// In conclusion, all three of these functions can be tested in the same test method.
        /// </summary>
        [TestMethod]
        public void InsertSelectDeleteProductTest()
        {

            DB dataBaseObject = DB.GetInstance("randomDataBase2.db");
            dataBaseObject.DeleteProduct(0);
            Product p1 = new Product(0,"product1","antibiotics",100,100);
            dataBaseObject.Insert(p1);
            Product p2 = dataBaseObject.SelectProduct(0);
            bool ok = false;
            if (p1.Id == p2.Id && p1.Name == p2.Name && p1.Category == p2.Category && p1.Price == p2.Price && p1.Stock==p2.Stock)
            {
                ok = true;
            }
            Assert.AreEqual(true, ok);

        }
        /// <summary>
        /// This function tests if the ConstraintViolatedException is thrown if two products with the same id are inserted.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ConstraintViolatedException))]
        public void InsertExceptionTest3()
        {

            DB dataBaseObject = DB.GetInstance("randomDataBase2.db");
            dataBaseObject.DeleteProduct(0);
            dataBaseObject.Insert(new Product(0, "prod2", "antibiotics", 100,101));
            dataBaseObject.Insert(new Product(0, "prod200", "antibiotics", 100, 101));

        }
        /// <summary>
        /// This function tests if the ConstraintViolatedException is thrown if two products with the same name are inserted.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ConstraintViolatedException))]
        public void InsertExceptionTest4()
        {

            DB dataBaseObject = DB.GetInstance("randomDataBase2.db");
            dataBaseObject.DeleteProduct(100);
            dataBaseObject.DeleteProduct(101);
            dataBaseObject.Insert(new Product(100, "prod2", "antibiotics", 100, 101));
            dataBaseObject.Insert(new Product(101, "prod2", "antibiotics", 100, 101));
        }
        /// <summary>
        /// This functions tests if all users are selected from the database. Some users needs to be inserted, but first,
        /// the users table must be cleared to not overwrite the id or the username, so ClearUsers is tested to.
        /// </summary>

        [TestMethod]
        public void SelectClearAllUsersTest()
        {
            DB dataBaseObject = DB.GetInstance("randomDataBase2.db");
            dataBaseObject.ClearUsers();
            List<User> users = new List<User>();
            users.Add(new User(0, "user0", "1234", 0));
            users.Add(new User(1, "user1", "1234", 0));
            users.Add(new User(2, "user2", "1234", 0));
            foreach(User u in users)
            {
                dataBaseObject.Insert(u);
            }
            List<User> usersFromDb = dataBaseObject.SelectAllUsers();
            bool ok = true;
            for(int i = 0; i < users.Count; i++)
            {
                if(users[i].Id!=usersFromDb[i].Id || users[i].Username!=usersFromDb[i].Username || users[i].Password!=usersFromDb[i].Password
                 || users[i].Rights != usersFromDb[i].Rights)
                {
                    ok = false;
                }
            }
            Assert.AreEqual(ok, true);
            

        }
        /// <summary>
        /// This functions tests if all products are selected from the database. Some products needs to be inserted, but first,
        /// the products table must be cleared to not overwrite the id or the name, so ClearProducts is tested to.
        /// </summary>

        [TestMethod]
        public void SelectClearAllProductsTest()
        {
            DB dataBaseObject = DB.GetInstance("randomDataBase2.db");
            dataBaseObject.ClearProducts();
            List<Product> products = new List<Product>();
            products.Add(new Product(100, "prod0", "antibiotics", 100, 101));
            products.Add(new Product(101, "prod1", "antibiotics", 100, 101));
            products.Add(new Product(102, "prod2", "antibiotics", 100, 101));
            foreach (Product p in products)
            {
                dataBaseObject.Insert(p);
            }
            List<Product> productsFromDb = dataBaseObject.SelectAllProducts();
            bool ok = true;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id != productsFromDb[i].Id || products[i].Name != productsFromDb[i].Name || products[i].Category != productsFromDb[i].Category
                 || products[i].Price != productsFromDb[i].Price || products[i].Stock!=productsFromDb[i].Stock)
                {
                    ok = false;
                }
            }
            Assert.AreEqual(ok, true);
        }
        /// <summary>
        /// This function tests if an user is updated.
        /// </summary>
        [TestMethod]
        public void UpdateUserTest()
        {
            DB dataBaseObject = DB.GetInstance("randomDataBase2.db");
            dataBaseObject.ClearUsers();
            User u = new User(0, "UserName", "1234", 1);
            dataBaseObject.Insert(u);
            u.Username = "Dani";
            u.Password = "5678";
            dataBaseObject.Update(u);
            User selectedUser = dataBaseObject.SelectUser(0);
            bool ok = false;
            if(selectedUser.Id==0 && selectedUser.Username=="Dani" && selectedUser.Password=="5678" && selectedUser.Rights == 1)
            {
                ok = true;
            }
            Assert.AreEqual(ok, true);
            
           
        }
        /// <summary>
        /// This function tests if a product is updated.
        /// </summary>
        [TestMethod]
        public void UpdateProductTest()
        {
            DB dataBaseObject = DB.GetInstance("randomDataBase2.db");
            dataBaseObject.ClearProducts();
            Product p = new Product(0, "Aulin", "Dont Know", 100, 101) ;
            dataBaseObject.Insert(p);
            p.Name = "Paracetamol";
            int oldStock = p.Stock;
            p.Stock = p.Stock+100; 
            dataBaseObject.Update(p);
            Product selectedProduct = dataBaseObject.SelectProduct(0);
            bool ok = false;
            if (selectedProduct.Id == 0 && selectedProduct.Name == "Paracetamol" && selectedProduct.Category == "Dont Know" && selectedProduct.Price == 100&&
                selectedProduct.Stock==oldStock+100)
            {
                ok = true;
            }
            Assert.AreEqual(ok, true);

        }
        /// <summary>
        /// Test if Update method throw a RecordNotFoundException exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(RecordNotFoundException))]
        public void UpdateTestRecordNotFound()
        {
            DB dataBaseObject = DB.GetInstance("randomDataBase2.db");
            dataBaseObject.ClearProducts();
            Product p = new Product(0, "Aulin", "Dont Know", 100, 101);
            dataBaseObject.Insert(p);
            p.Name = "Paracetamol";
            int oldStock = p.Stock;
            p.Stock = p.Stock + 100;
            //Cause exception.
            p.Id = 100;
            dataBaseObject.Update(p);
            Product selectedProduct = dataBaseObject.SelectProduct(0);
            bool ok = false;
            if (selectedProduct.Id == 0 && selectedProduct.Name == "Paracetamol" && selectedProduct.Category == "Dont Know" && selectedProduct.Price == 100 &&
                selectedProduct.Stock == oldStock + 100)
            {
                ok = true;
            }
            Assert.AreEqual(ok, true);

        }
        /// <summary>
        /// Test if Update method throw a InvalidStockException exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidStockException))]
        public void UpdateTestInvalidStock()
        {
            DB dataBaseObject = DB.GetInstance("randomDataBase2.db");
            dataBaseObject.ClearProducts();
            Product p = new Product(0, "Aulin", "Dont Know", 100, 101);
            dataBaseObject.Insert(p);
            p.Name = "Paracetamol";
            //Cause exception
            p.Stock = p.Stock -102;
            dataBaseObject.Update(p);

        }

        /// <summary>
        /// This function tests if the autoincrement works.
        /// </summary>
        [TestMethod]
        public void TestAutoIncrement()
        {
            DB dataBaseObject = DB.GetInstance("randomDataBase3.db");
            dataBaseObject.CreateTables();
            dataBaseObject.ClearProducts();
            dataBaseObject.ClearUsers();
            dataBaseObject.Insert(new User(dataBaseObject.GetLastUserID() + 1, "user1", "1234", -1));
            dataBaseObject.Insert(new User(dataBaseObject.GetLastUserID() + 1, "user2", "1234", -1));
            dataBaseObject.Insert(new Product(dataBaseObject.GetLastProductID() + 1, "prod1", "antibiotics",100,101));
            dataBaseObject.Insert(new Product(dataBaseObject.GetLastProductID() + 1, "prod2", "antibiotics", 100, 101));
            List<User> users = dataBaseObject.SelectAllUsers();
            List<Product> products = dataBaseObject.SelectAllProducts();
            Assert.AreEqual(users[0].Id, 0);
            Assert.AreEqual(users[1].Id, 1);
            Assert.AreEqual(products[0].Id, 0);
            Assert.AreEqual(products[1].Id, 1);


        }



    }
}