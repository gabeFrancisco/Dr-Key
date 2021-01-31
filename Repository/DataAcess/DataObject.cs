using Domain.Exceptions;
using MySql.Data.MySqlClient;

namespace Repository.DataAcess
{
    public abstract class DataObject
    {
        /// <summary>
        /// This property is common to all children of DataObject. 
        /// You can choose witch connection you want
        /// </summary>
        protected MySqlConnection Connection = new MySqlConnection (Connections[0]);

        private static readonly string[] Connections = new string[3]
        {
            "Server=mysql.drkey.kinghost.net;User=drkey;Password=drkey38712;Database=drkey;",
            "Server=localhost;User=root;Password=1234;Database=keyfinder;",
            "Server=mysql.test;User=test;Password=test;Database=test;",
        };

        protected static MySqlCommand Command = null;
        protected static MySqlCommandBuilder CommandBuilder = null;
        protected static MySqlDataReader DataReader = null;
        protected static MySqlDataAdapter DataAdapter = null;

        /// <summary>
        /// Returns a new MySqlCommand instance with the connection inheritance and command as a parameter.
        /// </summary>
        protected MySqlCommand SetCommand(string command)
        {
            try
            {
                return new MySqlCommand(command, this.Connection);
            }
            catch (MySqlException)
            {
                throw new ConnectionException();
            }
        }

        /// <summary>
        /// Returns a new MySqlDataAdapter instance with the connection inheritance and command as a parameter.
        /// </summary>
        protected MySqlDataAdapter SetAdapter(string command)
        {
            try
            {
                return new MySqlDataAdapter(command, this.Connection);
            }
            catch (MySqlException)
            {
                throw new ConnectionException();
            }
        }
    }
}
