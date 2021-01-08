using Domain.Entities;
using Domain.Entities.Security;
using Repository.DataAcess.SerialObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace Repository.DataAcess
{
    public class KeyData : DataObject
    {

        private static Key dto;
        private static int count;
        private static NumberFormatInfo nfi = new NumberFormatInfo();

        private static LoginData loginData = new LoginData();
        private static LoginMemory memory = loginData.ReadData();
        private int _user = memory.User.Id;
        private string globalUserId = $" where USER_ID =  {memory.User.Id}";


        public KeyData()
        {
            this.GetKeys();
        }

        public List<Key> GetKeys()
        {
            try
            {
                conn.Open();
                string strCommand = $"SELECT KEYID, MANUFACTOR, MODEL, KEYTYPE, KEYYEAR, PRICE, BUTTONS, QUANTITY, IMAGEPATH, OBSERVATION, SERVICETYPE FROM keylist" + globalUserId;
                Command = SetCommand(strCommand);
                DataReader = Command.ExecuteReader();

                List<Key> list = new List<Key>();

                while (DataReader.Read())
                {
                    int keyid = Convert.ToInt32(DataReader["KEYID"]);
                    string manufactor = Convert.ToString(DataReader["MANUFACTOR"]);
                    string model = Convert.ToString(DataReader["MODEL"]);
                    string type = Convert.ToString(DataReader["KEYTYPE"]);
                    string serviceType = Convert.ToString(DataReader["SERVICETYPE"]);
                    string year = Convert.ToString(DataReader["KEYYEAR"]);
                    decimal price = Convert.ToDecimal(DataReader["PRICE"]);
                    string buttons = Convert.ToString(DataReader["BUTTONS"]);
                    int qte = Convert.ToInt32(DataReader["QUANTITY"]);
                    string image = Convert.ToString(DataReader["IMAGEPATH"]);
                    string observation = Convert.ToString(DataReader["OBSERVATION"]);

                    Key key = new Key
                    {
                        Id = keyid,
                        Manufactor = manufactor,
                        Model = model,
                        Type = type,
                        ServiceType = serviceType,
                        Year = year,
                        Price = price,
                        Buttons = buttons,
                        Quantity = qte,
                        Image = image,
                        Observation = observation
                    };

                    list.Add(key);
                }
                return list;
            }
            finally
            {
                conn.Close();
            }
          
        }

        public DataTable ReturnTable()
        {
            try
            {
                conn.Open();

                string strCommand = "SELECT * FROM keylist" + globalUserId;
                DataTable dt = new DataTable();
                DataAdapter = SetAdapter(strCommand);
                DataAdapter.Fill(dt);

                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool IsDuplicated(Key key)
        {
            List<Key> list = this.GetKeys();
            if (list.Exists(x => x.Model.StartsWith(key.Model)))
            {
                return true;
            }
            else { return false; }
        }

        public void CreateKey(Key key)
        {
            try
            {
                nfi.NumberDecimalSeparator = ".";

                conn.Open();
                Command = SetCommand("INSERT INTO keylist VALUES (null, " +
                    "@manufactor, @model, @keytype, @keyyear, @price, @buttons, @quantity, @servicetype, @image, @observation, @userId)");

                Command.Parameters.AddWithValue("@manufactor", key.Manufactor);
                Command.Parameters.AddWithValue("@model", key.Model);
                Command.Parameters.AddWithValue("@keytype", key.Type.ToString());
                Command.Parameters.AddWithValue("@keyyear", key.Year);
                Command.Parameters.AddWithValue("@price", key.Price.ToString(nfi));
                Command.Parameters.AddWithValue("@buttons", key.Buttons);
                Command.Parameters.AddWithValue("@quantity", key.Quantity);
                Command.Parameters.AddWithValue("@image", key.Image);
                Command.Parameters.AddWithValue("@observation", key.Observation);
                Command.Parameters.AddWithValue("@servicetype", key.ServiceType);
                Command.Parameters.AddWithValue("@userId", _user);

                Command.ExecuteNonQuery();
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        public Key ReadKey(int id)
        {
            try
            {
                conn.Open();
                Command = SetCommand($"SELECT * FROM keylist WHERE KEYID = {id} && USER_ID = {_user}");
                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    int keyid = Convert.ToInt32(DataReader["KEYID"]);
                    string manufactor = Convert.ToString(DataReader["MANUFACTOR"]);
                    string model = Convert.ToString(DataReader["MODEL"]);
                    string type = Convert.ToString(DataReader["KEYTYPE"]);
                    string serviceType = Convert.ToString(DataReader["SERVICETYPE"]);
                    string year = Convert.ToString(DataReader["KEYYEAR"]);
                    decimal price = Convert.ToDecimal(DataReader["PRICE"]);
                    string buttons = Convert.ToString(DataReader["BUTTONS"]);
                    int qte = Convert.ToInt32(DataReader["QUANTITY"]);
                    string image = Convert.ToString(DataReader["IMAGEPATH"]);
                    string observation = Convert.ToString(DataReader["OBSERVATION"]);

                    dto = new Key
                    {
                        Id = id,
                        Manufactor = manufactor,
                        Model = model,
                        Type = type,
                        ServiceType = serviceType,
                        Year = year,
                        Price = price,
                        Buttons = buttons,
                        Quantity = qte,
                        Image = image,
                        Observation = observation
                    };
                }
                return dto;
            }

            finally
            {
                conn.Close();
            }
        }

        public void UpdateKey(Key key)
        {
                nfi.NumberDecimalSeparator = ".";

                conn.Open();
                Command = SetCommand("update keylist set manufactor = @manufactor," +
                    "model = @model," +
                    "keytype = @keytype," +
                    "keyyear = @keyyear," +
                    "price = @price," +
                    "buttons = @buttons," +
                    "quantity = @quantity," +
                    "imagepath = @imagepath," +
                    "observation = @observation," +
                    "servicetype = @servicetype where keyid = @keyid");

                Command.Parameters.AddWithValue("@manufactor", key.Manufactor);
                Command.Parameters.AddWithValue("@model", key.Model);
                Command.Parameters.AddWithValue("@keytype", key.Type);
                Command.Parameters.AddWithValue("@keyyear", key.Year);
                Command.Parameters.AddWithValue("@price", key.Price.ToString(nfi));
                Command.Parameters.AddWithValue("@buttons", key.Buttons);
                Command.Parameters.AddWithValue("@quantity", key.Quantity);
                Command.Parameters.AddWithValue("@imagepath", key.Image);
                Command.Parameters.AddWithValue("@observation", key.Observation);
                Command.Parameters.AddWithValue("@servicetype", key.ServiceType);
                Command.Parameters.AddWithValue("@keyid", key.Id);

                Command.ExecuteNonQuery();
        }

        public void DeleteKey(int id)
        {
            conn.Open();
            Command = SetCommand($"DELETE FROM keylist WHERE KEYID = {id}");
            Command.ExecuteNonQuery();
            conn.Close();
        }

        public int KeyNumbers()
        {
            conn.Open();
            Command = SetCommand("SELECT COUNT(*) AS 'TOTAL KEYS' FROM keylist" + globalUserId);
            DataReader = Command.ExecuteReader();

            while (DataReader.Read())
            {
                count = Convert.ToInt32(DataReader["TOTAL KEYS"]);
            }
            conn.Close();

            return count;
        }

        public DataTable SearchTable(string search)
        {
            conn.Open();
            DataTable dt = new DataTable();
            DataAdapter = SetAdapter($"SELECT * FROM keylist WHERE MODEL LIKE '{search}%' AND USER_ID = {_user}");
            DataAdapter.Fill(dt);
            conn.Close();

            return dt;
        }

        public DataTable Search(string manufactor, string type, string service)
        {
            conn.Open();
            DataTable dt = new DataTable();
            DataAdapter = SetAdapter($"SELECT * FROM keylist WHERE MANUFACTOR LIKE '{manufactor}%'" +
                $"AND KEYTYPE LIKE '{type}%'" +
                $"AND SERVICETYPE LIKE '{service}%' AND USER_ID = {_user}");
            DataAdapter.Fill(dt);
            conn.Close();

            return dt;
        }

        public void AddQuantity(Key key)
        {
            conn.Open();
            Command = SetCommand($"UPDATE keylist SET QUANTITY = {key.Quantity} WHERE KEYID = {key.Id}");
            Command.ExecuteNonQuery();
            conn.Close();
        }

        public void SubtractQuantity(Key key)
        {
            conn.Open();
            Command = SetCommand($"UPDATE keylist SET QUANTITY = {key.Quantity} WHERE KEYID = {key.Id}");
            Command.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateImage(int id)
        {
            conn.Open();
            Command = SetCommand($"UPDATE keylist SET IMAGEPATH = NULL WHERE KEYID = {id}");
            Command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
