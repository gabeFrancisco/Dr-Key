using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.SerialObjects;
using DTO.Entities;

namespace KeyFinder_v1._2
{
    public partial class SelectDatabaseForm : Form
    {
        static DatabaseList databaseList = new DatabaseList();
        static DAL.DataObject dataObject = new DAL.DataObject();
        static DbClass dbClass = new DbClass();
        public SelectDatabaseForm()
        {
            InitializeComponent();

            try
            {
                databaseList.ReturnDatabaseList();

                //An foreach loop to populate the listview
                foreach (DbClass db in dbClass.DbList)
                {
                    listDb.Items.Add(db.DbName);
                }
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("Você precisa criar um novo banco de dados para poder selecionar");
            }
        }

        private void listDb_Click(object sender, EventArgs e)
        {
            dbClass = dbClass.DbList.Find(x => x.DbName == listDb.SelectedItem.ToString());
            lbDate.Text = dbClass.DbCreationDate.ToLongDateString();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dbClass = dbClass.DbList.Find(x => x.DbName == listDb.SelectedItem.ToString());
            dataObject.SetDatabase(dbClass);

            if (MessageBox.Show($"Você ter certeza que deseja carregar o banco de dados {dbClass.DbName}?",
                "Aviso de altereação de dados",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //To program........
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewDatabaseForm newDatabase = new NewDatabaseForm();
            newDatabase.ShowDialog();
        }
    }
}
