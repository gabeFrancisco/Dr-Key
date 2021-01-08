using MySql.Data.MySqlClient;
using System;
using System.IO;

namespace Repository.DataAcess
{
    public class BackupData : DataObject
    {
        private string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\keydb.sql";
        private string exceptionPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\KeyFinderLog\error.txt";
        public BackupData() { }

        public string GetExceptionPath()
        {
            return this.exceptionPath;
        }

        public bool SaveDatabase()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
               
                MySqlBackup backup = new MySqlBackup(cmd);
                backup.ExportToFile(this.dbPath);
                conn.Close();

                return true;
            }
            catch(Exception ex)
            {
                string message = "Erro: " + ex.Message;
                StreamWriter writer = new StreamWriter(exceptionPath);
                writer.WriteLine(message);
                writer.Close();

                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool SaveDatabaseWithPath(string path)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                MySqlBackup backup = new MySqlBackup(cmd);
                backup.ExportToFile(path);
                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                string message = "Erro: " + ex.Message;
                StreamWriter writer = new StreamWriter(exceptionPath);
                writer.WriteLine(message);
                writer.Close();

                return false;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
