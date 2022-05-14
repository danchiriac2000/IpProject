/**************************************************************************
 *                                                                        *
 *  File:        DataBaseManager.cs                                       *
 *  Creator:     Chiriac Dan-Constantin                                     *
 *  E-mail:      dan-constantin.chiriac@student.tuiasi.ro                 *      
 *  Description: This file contain the management for the database.       *
 *                                                                        *
 *                                                                        *
 **************************************************************************/




using Exceptions.DataBaseExceptions;
using Items.DataBaseObjects;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseManager
{
    /// <summary>
    /// DB class. This is the sqlite database manager.
    /// </summary>
    public class DB
    {
        /// <summary>
        /// Private member used to retain the connection to the database. Is initialized in the constructor.
        /// </summary>
        private SQLiteConnection _connection;
   
        /// <summary>
        /// This is the constructor for the database manager. This initializes the connection and check if the database has the right file extension. This constructor can throw an exception if 
        /// something goes wrong.
        /// </summary>
        /// <param name="dbPath"></param>
        /// <exception cref="InvalidExtensionException"></exception>
        public DB(string dbPath)
        {
            if (Path.GetExtension(dbPath) != ".db")
            {
                throw new InvalidExtensionException();
            }
            _connection = new SQLiteConnection(String.Format("Data Source={0}; Version = 3; New = True; Compress = True; ", dbPath));
            try
            {
                _connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// The getter for the connection. It is necessary if the main application wants to use commmands on the database.
        /// </summary>
        public SQLiteConnection Connection
        {
            get
            {
                return _connection;
            }
        }
    
        /// <summary>
        /// This method creates the users and the products tables.
        /// </summary>
        public void CreateTables()
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            //Check if the table already exists.
            command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='USERS'";
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            string userTableName = "";
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                userTableName += myreader;
            }
            //If the table was found, will not try to create the same table again.
            if (userTableName == "")
            {

                string usersTableCreate = "CREATE TABLE USERS  (id INT PRIMARY KEY," +
                    "username VARCHAR2(40) UNIQUE," +
                    "password VARCHAR2(40) NOT NULL," +
                    "rights VARCHAR2(15) NOT NULL)";
                command = _connection.CreateCommand();
                command.CommandText = usersTableCreate;
                command.ExecuteNonQuery();
            }
            else
            {
                //Do nothing.....
            }
            command = _connection.CreateCommand();
            command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='USERS'";
            sqlite_datareader = command.ExecuteReader();
            string productsTableName = "";
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                productsTableName += myreader;
            }
            if (userTableName == "")
            {

                string productsTableCreate = "CREATE TABLE PRODUCTS  (id INT PRIMARY KEY," +
                    "name VARCHAR2(40) UNIQUE," +
                    "category VARCHAR2(40)," +
                    "price DOUBLE," +
                    "stock INT" +
                    ")";
                command = _connection.CreateCommand();
                command.CommandText = productsTableCreate;
                command.ExecuteNonQuery();
            }
            else
            {
                //Do nothing...
            }

        }
        /// <summary>
        /// This method add a new user to the database. If the id or the username is already in database, the method will throw an exception.
        /// </summary>
        /// <param name="usr"></param>
        /// <exception cref="UniqueException"></exception>
        public void Insert(User usr)
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText =String.Format("SELECT id FROM users WHERE id={0}",usr.Id);
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            string id = "";
            while (sqlite_datareader.Read())
            {
                int myreader = sqlite_datareader.GetInt32(0);
                id += myreader;
            }
            if (id != "")
            {
                throw new ConstraintViolatedException();
            }
         
            command = _connection.CreateCommand();
            command.CommandText = String.Format("SELECT username FROM users WHERE username='{0}'", usr.Username);
            string username = "";
            sqlite_datareader = command.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                username += myreader;
            }
            if (username != "")
            {
                throw new ConstraintViolatedException();
            }
            command = _connection.CreateCommand();
            command.CommandText =String.Format("INSERT INTO users(id,username,password,rights) VALUES({0},'{1}','{2}','{3}')",usr.Id,usr.Username,usr.Password,usr.Rights);
            command.ExecuteNonQuery();

        }
        /// <summary>
        /// This method add a new product to the database. If the id or the name is already in database, the method will throw an exception.
        /// </summary>
        /// <param name="prod"></param>
        /// <exception cref="UniqueException"></exception>
        public void Insert(Product prod)
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("SELECT id FROM products WHERE id={0}",prod.Id);
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            string id = "";
            while (sqlite_datareader.Read())
            {
                int myreader = sqlite_datareader.GetInt32(0);
                id += myreader;
            }
            if (id != "")
            {
                throw new ConstraintViolatedException();
            }

            command = _connection.CreateCommand();
            command.CommandText = String.Format("SELECT name FROM products WHERE name='{0}'", prod.Name);
            string username = "";
            sqlite_datareader = command.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                username += myreader;
            }
            if (username != "")
            {
                throw new ConstraintViolatedException();
            }
            command = _connection.CreateCommand();
            command.CommandText = String.Format("INSERT INTO products(id,name,category,price,stock) VALUES({0},'{1}','{2}',{3},{4})", prod.Id, prod.Name,prod.Category,prod.Price,prod.Stock);
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// This method is used to return all users from the database.
        /// </summary>
        /// <returns>Return a List of Users</returns>
        public List<User> SelectAllUsers()
        {
            List<User> users = new List<User>();
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM users";
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string username = sqlite_datareader.GetString(1);
                string password = sqlite_datareader.GetString(2);
                string rights = sqlite_datareader.GetString(3);
                User usr = new User(id, username, password, rights);
                users.Add(usr);
            }
            return users;


        }
        /// <summary>
        /// This method is used to return all products from the database.
        /// </summary>
        /// <returns>Return a List of Products</returns>
        public List<Product> SelectAllProducts()
        {
            List<Product> products = new List<Product>();
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM products";
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string name = sqlite_datareader.GetString(1);
                string category = sqlite_datareader.GetString(2);
                double price = sqlite_datareader.GetDouble(3);
                int stock = sqlite_datareader.GetInt32(4);
                Product product = new Product(id, name, category, price,stock);
                products.Add(product);
            }
            return products;

        }
        /// <summary>
        /// This method returns an user with the given id. If the id is not found in the table, the method will return a null object.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User SelectUser(int id)
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("SELECT * FROM users where id={0}",id);
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            User user = null;
            while (sqlite_datareader.Read())
            {
                int uid = sqlite_datareader.GetInt32(0);
                string username = sqlite_datareader.GetString(1);
                string password = sqlite_datareader.GetString(2);
                string rights = sqlite_datareader.GetString(3);
                user = new User(uid, username, password, rights);
            }
            return user;
        }
        /// <summary>
        /// This method returns a product with the given id. If the id is not found in the table, the method will return a null object.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product SelectProduct(int id)
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("SELECT * FROM products where id={0}", id);
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            Product product = null;
            while (sqlite_datareader.Read())
            {
                int pid = sqlite_datareader.GetInt32(0);
                string name = sqlite_datareader.GetString(1);
                string category = sqlite_datareader.GetString(2);
                double price = sqlite_datareader.GetDouble(3);
                int stock = sqlite_datareader.GetInt32(4);
                product = new Product(id, name, category, price, stock);
             
            }
            return product;
        }
    }
}
