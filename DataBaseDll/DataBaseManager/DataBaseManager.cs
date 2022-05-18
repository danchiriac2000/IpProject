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


namespace DataBaseManager
{
    /// <summary>
    /// DB class. This is the sqlite database manager.
    /// </summary>
    public class DB
    {
        /// <summary>
        /// Private member used to retain the connection to the database.It is initialized in the constructor.
        /// </summary>
      
        private SQLiteConnection _connection;
        private static DB instance = null;
        /// <summary>
        /// This is the constructor for the database manager. This initializes the connection and check if the database has the right file extension. This constructor can throw an exception if 
        /// something goes wrong. It is private because the class is a singleton and need to be instantiated just once.
        /// </summary>
        /// <param name="dbName"></param>
        /// <exception cref="InvalidExtensionException"></exception>
        private DB(string dbName)
        {
            if (Path.GetExtension(dbName) != ".db")
            {
                throw new InvalidExtensionException();
            }
            _connection = new SQLiteConnection(String.Format("Data Source={0}; Version = 3; New = True; Compress = True; ", dbName));
            try
            {
                _connection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Method to get the global instance of the class.
        /// </summary>
        /// <param name="dbPath"></param>
        /// <returns></returns>
        public static DB GetInstance(string dbName)
        {
            if (instance == null)
            {
                instance = new DB(dbName);
            }
            //If the dbName is different from the path of the current connection, change it.
            if (dbName.Substring(0, dbName.Length - 3) != instance.Connection.DataSource)
            {
            
                instance.ChangeConnection(dbName);
            }
            return instance;
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
        /// This method change the connection of the database instance.
        /// </summary>
        /// <param name="dbName"></param>
        /// <exception cref="InvalidExtensionException"></exception>
        public void ChangeConnection(string dbName)
        {
            if (Path.GetExtension(dbName) != ".db")
            {
                throw new InvalidExtensionException();
            }
            _connection.Close();
            _connection = new SQLiteConnection(String.Format("Data Source={0}; Version = 3; New = True; Compress = True; ", dbName));
            try
            {
                _connection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                    "rights INT NOT NULL)";
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
            command.CommandText =String.Format("INSERT INTO users(id,username,password,rights) VALUES({0},'{1}','{2}',{3})",usr.Id,usr.Username,usr.Password,usr.Rights);
            command.ExecuteNonQuery();

        }
        /// <summary>
        /// This method add a new product to the database. If the id or the name is already in database, the method will throw an exception.
        /// </summary>
        /// <param name="prod"></param>
        /// <exception cref="UniqueException"></exception>
        public void Insert(Product prod)
        {
            if (prod.Stock < 0)
            {
                throw new InvalidStockException();
            }
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
                int rights = sqlite_datareader.GetInt32(3);
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
                int rights = sqlite_datareader.GetInt32(3);
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
        /// <summary>
        /// Because username is UK, get user by username is relevant.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public User SelectUser(string userName)
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("SELECT * FROM users where username='{0}'", userName);
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            User user = null;
            while (sqlite_datareader.Read())
            {
                int uid = sqlite_datareader.GetInt32(0);
                string username = sqlite_datareader.GetString(1);
                string password = sqlite_datareader.GetString(2);
                int rights = sqlite_datareader.GetInt32(3);
                user = new User(uid, username, password, rights);
            }
            return user;
        }

        /// <summary>
        /// Because name is UK, get product by name is relevant.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public Product SelectProduct(string name)
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("SELECT * FROM products where name='{0}'", name);
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            Product product = null;
            while (sqlite_datareader.Read())
            {
                int pid = sqlite_datareader.GetInt32(0);
                string productname = sqlite_datareader.GetString(1);
                string category = sqlite_datareader.GetString(2);
                double price = sqlite_datareader.GetDouble(3);
                int stock = sqlite_datareader.GetInt32(4);
                product = new Product(pid, productname, category, price, stock);

            }
            return product;
        }

        /// <summary>
        /// This method deletes an user from the database. if the id is not found, it will do nothing.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteUser(int id)
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("DELETE FROM users where id={0}", id);
            command.ExecuteNonQuery();

        }

        /// <summary>
        /// This method deletes a product from the database. if the id is not found, it will do nothing.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteProduct(int id)
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("DELETE FROM products where id={0}", id);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// This method deletes all users from the database.
        /// </summary>
        public void ClearUsers()
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("DELETE FROM users");
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// This method deletes all products from the database.
        /// </summary>
        public void ClearProducts()
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("DELETE FROM products");
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// This method will check if the user exists in the database. If It exists,it will update the record from the database with all modified members of the object.
        /// </summary>
        /// <param name="user"></param>
        public void Update(User user)
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("SELECT id FROM users WHERE id={0}",user.Id);
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            string id = "";
            while (sqlite_datareader.Read())
            {
                int myreader = sqlite_datareader.GetInt32(0);
                id += myreader;
            }
            if (id != "")
            {
                command = _connection.CreateCommand();
                command.CommandText = String.Format("UPDATE users" +
                    " SET username='{0}'," +
                    "password='{1}'," +
                    "rights={2}" +
                    " WHERE id={3}",user.Username,user.Password,user.Rights,user.Id);
                
                command.ExecuteNonQuery();
            }
            else
            {
                throw new RecordNotFoundException();
            
            }


        }
        /// <summary>
        /// This method will check if the product exists in the database. If It exists,it will update the record from the database with all modified members of the object.
        /// </summary>
        /// <param name="product"></param>
        public void Update(Product product)
        {
            if (product.Stock < 0)
            {
                throw new InvalidStockException();
            }
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("SELECT id FROM products WHERE id={0}", product.Id);
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            string id = "";
            while (sqlite_datareader.Read())
            {
                int myreader = sqlite_datareader.GetInt32(0);
                id += myreader;
            }
            if (id != "")
            {
                command = _connection.CreateCommand();
                command.CommandText = String.Format("UPDATE products" +
                    " SET name='{0}'," +
                    "category='{1}'," +
                    "price='{2}'," +
                    "stock={3}" +
                    " WHERE id={4}", product.Name,product.Category,product.Price,product.Stock,product.Id);

                command.ExecuteNonQuery();
            }
            else
            {
                throw new RecordNotFoundException();

            }


        }
        /// <summary>
        /// This method is used to get max id from users table. It is used for autoincrement:
        /// new User(GetLastUserId()+1,.....)
        /// </summary>
        /// <returns></returns>
        public int GetLastUserID()
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("SELECT MAX(id) FROM users");
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            int id = -1;
            if (sqlite_datareader.Read())
            {
                try
                {
                    int myreader = sqlite_datareader.GetInt32(0);
                    id = myreader;
                }
                catch
                {
                    id = -1;
                }
            }

            return id;
        }
        /// <summary>
        /// This method is used to get max id from products table. It is used for autoincrement:
        /// new Product(GetLastProductId()+1,.....)
        /// </summary>
        /// <returns></returns>
        public int GetLastProductID()
        {
            SQLiteCommand command;
            command = _connection.CreateCommand();
            command.CommandText = String.Format("SELECT MAX(id) FROM products");
            SQLiteDataReader sqlite_datareader = command.ExecuteReader();
            int id = -1;
            if (sqlite_datareader.Read())
            {
                try
                {
                    int myreader = sqlite_datareader.GetInt32(0);
                    id = myreader;
                }
                catch
                {
                    id = -1;
                }
            }

            return id;
        }
        
    }
}
