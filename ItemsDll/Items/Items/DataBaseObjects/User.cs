using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items.DataBaseObjects
{
    /// <summary>
    /// This is the data class for an user. Contains only the getters and setters for the private members of the class.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The id of the user.
        /// </summary>
        private int _id;
        /// <summary>
        /// The username of the user.
        /// </summary>
        private string _username;
        /// <summary>
        /// The password of the user.
        /// </summary>
        private string _password;
        /// <summary>
        /// The rights of the user.
        /// </summary>
        private string _rights;
        /// <summary>
        /// This is the constructor which initialize the variables.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="rights"></param>
        public User(int id, string username, string password, string rights)
        {
            this._id = id;
            this._password = password;
            this._username = username;
            this._rights = rights;
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public string Rights
        {
            get
            {
                return _rights;
            }
            set
            {
                _rights = value;
            }
        }
        /// <summary>
        /// Return the members of the class in the form of a single string.
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return _id + " " + _username + " " + _password + " " + _rights;
        }
    }
}
