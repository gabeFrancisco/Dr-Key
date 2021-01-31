using Domain.Entities;
using Domain.Entities.Security;
using MySql.Data.MySqlClient;
using Repository.DataAcess.SerialObjects;
using System;
using System.Data;

namespace Repository.DataAcess
{
    public class ServiceData : DataObject
    {
        private Service _service;
        private static LoginData loginData = new LoginData();
        private static LoginMemory memory = loginData.ReadData();
        private int _user = memory.User.Id;
        private string globalUserId = $" where USER_ID =  {memory.User.Id}";
        public DataTable ReturnTable()
        {
            try
            {
                this.Connection.Open();

                string strCommand = "SELECT * FROM services" + globalUserId;
                DataTable dt = new DataTable();
                DataAdapter = SetAdapter(strCommand);
                DataAdapter.Fill(dt);

                return dt;
            }
            finally
            {
                this.Connection.Close();
            }
        }

        public void CreateService(Service service)
        {
            try
            {
                this.Connection.Open();
                Command = SetCommand($"insert into services values (null, " +
                    $"@title, @description, @price, @user_id)");

                Command.Parameters.AddWithValue("@title", service.Title);
                Command.Parameters.AddWithValue("@description", service.Description);
                Command.Parameters.AddWithValue("@price", service.Price);
                Command.Parameters.AddWithValue("@user_id", _user);

                Command.ExecuteNonQuery();
            }
            finally
            {
                this.Connection.Close();
            }
        }

        public Service ReadService(int id)
        {
            try
            {
                this.Connection.Open();
                string strCommand = $"SELECT * FROM services WHERE SERVICEID = {id}";
                Command = SetCommand(strCommand);
                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    int serviceId = Convert.ToInt32(DataReader["serviceid"]);
                    string title = Convert.ToString(DataReader["title"]);
                    string description = Convert.ToString(DataReader["description"]);
                    decimal price = Convert.ToDecimal(DataReader["price"]);

                    _service = new Service
                    {
                        Id = serviceId,
                        Title = title,
                        Description = description,
                        Price = price
                    };
                }
                return _service;
            }
            finally
            {
                this.Connection.Close();
            }
        }

        public void UpdateService(Service service)
        {
            try
            {
                this.Connection.Open();
                Command = SetCommand("update services set " +
                    "title = @title, " +
                    "description = @description, " +
                    "price = @price where serviceid = @serviceid");

                Command.Parameters.AddWithValue("@title", service.Title);
                Command.Parameters.AddWithValue("@description", service.Description);
                Command.Parameters.AddWithValue("@price", service.Price);
                Command.Parameters.AddWithValue("@serviceid", service.Id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                this.Connection.Close();
            }

        }

        public void DeleteService(int id)
        {
            try
            {
                this.Connection.Open();
                Command = SetCommand($"delete from services where serviceid = @id");

                Command.Parameters.AddWithValue("@id", id);
                Command.ExecuteNonQuery();
            }
            finally
            {
                this.Connection.Close();
            }
        }

        public DataTable SearchTable(string search)
        {
            try
            {
                this.Connection.Open();
                DataTable dt = new DataTable();
                DataAdapter = SetAdapter($"select * from services where title like '{search}%' and user_id = " + _user);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(DataAdapter);
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
