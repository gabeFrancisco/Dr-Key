using Domain.Entities.Security;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Repository.DataAcess.SerialObjects
{
    public class LoginData
    {
        static string filename = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\login.bin";
        BinaryFormatter binaryFormater;
        static FileStream fileStream;

        public LoginMemory ReadData()
        {
            try
            {
                fileStream = File.OpenRead(filename);
                binaryFormater = new BinaryFormatter();
                LoginMemory memory = (LoginMemory)binaryFormater.Deserialize(fileStream);
                fileStream.Close();

                return memory;
            }
            catch(Exception ex)
            {
                fileStream.Close();
                throw new Exception(ex.Message + ex.StackTrace);
            }
           
        }

        public void SetData(LoginMemory memory)
        {
            fileStream = File.Create(filename);
            binaryFormater = new BinaryFormatter();

            binaryFormater.Serialize(fileStream, memory);
            fileStream.Close();
        }


    }
}
