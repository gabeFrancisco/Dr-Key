using MySql.Data.MySqlClient;

namespace Repository.DataAcess
{
    public abstract class DataObject
    {
        protected MySqlConnection conn = new MySqlConnection (Connections[0]);

        private static readonly string[] Connections = new string[2]
        {
            "Server=mysql.keyfinder.kinghost.net;User=keyfinder;Password=keyfinder38712;Database=keyfinder;",
            "Server=localhost;User=root;Password=1234;Database=keyfinder;"
        };

        protected static MySqlCommand Command = null;
        protected static MySqlCommandBuilder CommandBuilder = null;
        protected static MySqlDataReader DataReader = null;
        protected static MySqlDataAdapter DataAdapter = null;

        protected MySqlCommand SetCommand(string command)
        {
            return new MySqlCommand(command, this.conn);
        }

        protected MySqlDataAdapter SetAdapter(string command)
        {
            return new MySqlDataAdapter(command, this.conn);
        }
    }
}
