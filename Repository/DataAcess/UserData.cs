using Domain.Entities;
using Domain.Entities.Security;
using Domain.Exceptions;
using Repository.DataAcess.SerialObjects;
using System;

namespace Repository.DataAcess
{
    public class UserData : DataObject
    {
        static LoginData loginData = new LoginData();
        public bool VerifyUser(string username, string password)
        {  
            User userInstance;
               
            userInstance = this.ReadUser(username);
            if(userInstance == null)
            {
                throw new InvalidUserException();
            }
                
            Hash hash = new Hash();
            string hashPassword = hash.VerifyPassword(password);
            if(hashPassword != userInstance.Password)
            {
                throw new InvalidUserException();
            }

            LoginMemory loginMemory = new LoginMemory
            {
                User = userInstance
            };

            loginData.SetData(loginMemory);
                
            return true;
        }

        public User ReadUser(string username)
        {
            try
            {
                this.Connection.Open();
                Command = SetCommand($"select * from user where username = '{username}'");
                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    int userid = Convert.ToInt32(DataReader["iduser"]);
                    string user = Convert.ToString(DataReader["username"]);
                    string pass = Convert.ToString(DataReader["password"]);
                    string name = Convert.ToString(DataReader["name"]);
                    string surname = Convert.ToString(DataReader["surname"]);
                    string phone = Convert.ToString(DataReader["phone"]);
                    DateTime signDate = Convert.ToDateTime(DataReader["signdate"]);
                    string email = Convert.ToString(DataReader["email"]);

                    User userInstance = new User
                    {
                        Id = userid,
                        UserName = user,
                        Password = pass,
                        Name = name,
                        Surname = surname,
                        Phone = phone,
                        SignDate = signDate,
                        Email = email
                    };
                    return userInstance;
                }
                return null;
            }
            finally
            {
                this.Connection.Close();
            }
        }
    }
}
