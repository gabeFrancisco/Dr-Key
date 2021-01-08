using Domain.Entities;
using Domain.Enums;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Repository.DataAcess.SerialObjects
{
    public class ConfigData
    {
        static string filename = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\configdata.bin";
        BinaryFormatter binaryFormatter;
        static FileStream fileStream;

        public Configuration ReadData()
        {
            try
            {
                fileStream = File.OpenRead(filename);
                binaryFormatter = new BinaryFormatter();
                Configuration config = (Configuration)binaryFormatter.Deserialize(fileStream);
                fileStream.Close();

                return config;
            }
            catch(IOException)
            {
                Configuration config = new Configuration(Theme.LIGHT, "LightGreen", 13f);
                this.SetData(config);
                return config;
            }
        }

        public void SetData(Configuration config)
        {
            fileStream = File.Create(filename);
            binaryFormatter = new BinaryFormatter();

            binaryFormatter.Serialize(fileStream, config);
            fileStream.Close();   
        }
    }
}
