using Domain.Entities;
using Domain.Entities.Security;
using MySql.Data.MySqlClient;
using Repository.DataAcess.SerialObjects;
using System;
using System.Data;

namespace Repository.DataAcess
{
    public sealed class ClientData : DataObject
    {
        static Client _dto;

        private static LoginData loginData = new LoginData();
        private static LoginMemory memory = loginData.ReadData();
        private int _user = memory.User.Id;
        private string globalUserId = $" where USER_ID =  {memory.User.Id}";
        public DataTable ReturnTable()
        {
            try
            {
                this.Connection.Open();

                string cmd = "SELECT * FROM client" + globalUserId;
                DataTable dt = new DataTable();
                DataAdapter = SetAdapter(cmd);
                DataAdapter.Fill(dt);

                return dt;
            }
            finally
            {
                this.Connection.Close();
            }
        }

        public void CreateClient(Client client)
        {
            try
            {
                this.Connection.Open();
                Command = SetCommand("insert into client values (null, " +
                    "@name, @phone, @email, @adress, @number, @complement, @neighborhood, @city, @state, @signdate, @cpf_cnpj, @user_id)");

                Command.Parameters.AddWithValue("@name", client.Name);
                Command.Parameters.AddWithValue("@phone", client.Phone);
                Command.Parameters.AddWithValue("@email", client.Email);
                Command.Parameters.AddWithValue("@adress", client.Adress);
                Command.Parameters.AddWithValue("@number", client.Number);
                Command.Parameters.AddWithValue("@complement", client.Complement);
                Command.Parameters.AddWithValue("@neighborhood", client.Neighborhood);
                Command.Parameters.AddWithValue("@city", client.City);
                Command.Parameters.AddWithValue("@state", client.State);
                Command.Parameters.AddWithValue("@signdate", client.SignDate.ToString());
                Command.Parameters.AddWithValue("@cpf_cnpj", client.CPF_CNPJ);
                Command.Parameters.AddWithValue("@user_id", _user);

                Command.ExecuteNonQuery();
            }
            finally
            {
                this.Connection.Close();
            }
        }

        public Client ReadClient(int id)
        {
            try
            {
                Connection.Open();
                Command = SetCommand($"select * from client where clientid = {id}");
                MySqlDataReader dr = Command.ExecuteReader();

                while (dr.Read())
                {
                    int clientId = Convert.ToInt32(dr["clientid"]);
                    string name = Convert.ToString(dr["name"]);
                    string cpf_cnpj = Convert.ToString(dr["cpf_cnpj"]);
                    string phone = Convert.ToString(dr["phone"]);
                    string email = Convert.ToString(dr["email"]);
                    string adress = Convert.ToString(dr["adress"]);
                    string number = Convert.ToString(dr["number"]);
                    string complement = Convert.ToString(dr["complement"]);
                    string neighborhood = Convert.ToString(dr["neighborhood"]);
                    string city = Convert.ToString(dr["city"]);
                    string state = Convert.ToString(dr["state"]);
                    DateTime signDate = Convert.ToDateTime(dr["signdate"]);

                    _dto = new Client(clientId, name, cpf_cnpj, phone, email, adress, number, complement,
                        neighborhood, city, state, signDate);
                }
                return _dto;
            }
            finally
            {
                Connection.Close();
            }
        }

        public void UpdateClient(Client client)
        {
            try 
            {
                this.Connection.Open();
                Command = SetCommand(
                   "update client set " +
                   "name = @name," +
                   "phone = @phone," +
                   "email = @email," +
                   "adress = @adress," +
                   "number = @number," +
                   "complement = @complement," +
                   "neighborhood = @neighborhood," +
                   "city = @city," +
                   "state = @state," +
                   "signdate = @signdate," +
                   "cpf_cnpj = @cpf_cnpj where clientid = @clientid"
               );

                Command.Parameters.AddWithValue("@name", client.Name);
                Command.Parameters.AddWithValue("@phone", client.Phone);
                Command.Parameters.AddWithValue("@email", client.Email);
                Command.Parameters.AddWithValue("@adress", client.Adress);
                Command.Parameters.AddWithValue("@number", client.Number);
                Command.Parameters.AddWithValue("@complement", client.Complement);
                Command.Parameters.AddWithValue("@neighborhood", client.Neighborhood);
                Command.Parameters.AddWithValue("@city", client.City);
                Command.Parameters.AddWithValue("@state", client.State);
                Command.Parameters.AddWithValue("@signdate", client.SignDate.ToString());
                Command.Parameters.AddWithValue("@cpf_cnpj", client.CPF_CNPJ);
                Command.Parameters.AddWithValue("@clientid", client.Id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void DeleteClient(int id)
        {
            try
            {
                Connection.Open();
                Command = SetCommand("delete from client where clientid = @id");

                Command.Parameters.AddWithValue("@id", id);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Connection.Close();
            }
        }

        public DataTable SearchTable(string search)
        {
            try
            {
                this.Connection.Open();
                DataTable dt = new DataTable();
                DataAdapter = SetAdapter($"select * from client where name like '{search}%' and user_id = " + _user);
                DataAdapter.Fill(dt);

                return dt;
            }
            finally
            {
                this.Connection.Close();
            }
        }
    }
}
