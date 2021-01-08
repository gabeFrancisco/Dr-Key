using Domain.Entities;
using Domain.Enums;
using Repository.DataAcess.SerialObjects;
using System;
using System.Drawing;
using System.Windows.Forms;
using UI.Forms.Clients;
using UI.Forms.Services;
using UI.Properties;

namespace UI.Services
{
    public static class ThemeSetup
    {
        static Configuration config = new Configuration();
        static ConfigData data = new ConfigData();

        public static void SetManagerForm(ManagerForm managerForm)
        {
            config = data.ReadData();
            if (config.Theme == Theme.DARK)
            {
                managerForm.BackColor = Color.DimGray;
                managerForm.ForeColor = Color.White;
                managerForm.dgvKey.BackgroundColor = Color.DimGray;
                managerForm.dgvKey.ForeColor = Color.White;
                managerForm.menuPanel.ForeColor = Color.White;
                managerForm.btnSearch.ForeColor = Color.Black;
                managerForm.dgvKey.RowsDefaultCellStyle.BackColor = Color.DimGray;
                managerForm.dgvKey.RowsDefaultCellStyle.ForeColor = Color.White;
                managerForm.dgvKey.GridColor = Color.Gray;
                managerForm.panelBar.BackgroundImage = Properties.Resources.BARDARK;
                managerForm.pnModel.ForeColor = Color.Black;
                managerForm.pnType.ForeColor = Color.Black;
                managerForm.pnYear.ForeColor = Color.Black;
                managerForm.pnQte.ForeColor = Color.Black;
                managerForm.pnButtons.ForeColor = Color.Black;
                managerForm.pnService.ForeColor = Color.Black;
                managerForm.pnValue.ForeColor = Color.Black;

                //Settings for the menu bar and icons
                managerForm.menuPanel.BackColor = Color.DarkGray;
                managerForm.menuStrip1.BackColor = Color.DarkGray;
                managerForm.menuStrip1.ForeColor = Color.White;

                managerForm.btnAddKey.BackColor = Color.DarkGray;
                managerForm.btnAddKey.ForeColor = Color.DarkGray;

                managerForm.btnEditKey.BackColor = Color.DarkGray;
                managerForm.btnEditKey.ForeColor = Color.DarkGray;

                managerForm.btnDeleteKey.BackColor = Color.DarkGray;
                managerForm.btnDeleteKey.ForeColor = Color.DarkGray;

                managerForm.btnAddQte.BackColor = Color.DarkGray;
                managerForm.btnAddQte.ForeColor = Color.DarkGray;

                managerForm.btnSubQte.BackColor = Color.DarkGray;
                managerForm.btnSubQte.ForeColor = Color.DarkGray;

                managerForm.btnClient.BackColor = Color.DarkGray;
                managerForm.btnClient.ForeColor = Color.DarkGray;

                managerForm.btnConfig.BackColor = Color.DarkGray;
                managerForm.btnConfig.ForeColor = Color.DarkGray;


                managerForm.btnUpdate.BackColor = Color.DarkGray;
                managerForm.btnUpdate.ForeColor = Color.DarkGray;

                managerForm.btnServices.BackColor = Color.DarkGray;
                managerForm.btnServices.ForeColor = Color.DarkGray;

                managerForm.lbManufactorType.ForeColor = Color.White;
                managerForm.lbSearchType.ForeColor = Color.White;
                managerForm.lbSearchService.ForeColor = Color.White;

                managerForm.pnDivider.BackColor = Color.LightGray;
            }

            else if (config.Theme == Theme.LIGHT)
            {
                managerForm.BackColor = Color.WhiteSmoke;
                managerForm.ForeColor = Color.Black;
               
                managerForm.dgvKey.BackgroundColor = Color.WhiteSmoke;
                managerForm.dgvKey.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                managerForm.dgvKey.RowsDefaultCellStyle.ForeColor = Color.Black;
                managerForm.dgvKey.GridColor = Color.LightGray;
                managerForm.panelBar.BackgroundImage = Properties.Resources.BARLIGHT;
                managerForm.lbSearchService.ForeColor = Color.Black;
                managerForm.lbSearchType.ForeColor = Color.Black;
                managerForm.lbManufactorType.ForeColor = Color.Black;

                managerForm.menuPanel.BackColor = Color.WhiteSmoke;
                managerForm.menuStrip1.BackColor = Color.WhiteSmoke;
                managerForm.menuStrip1.ForeColor = Color.Black;

                managerForm.btnAddKey.BackColor = Color.WhiteSmoke;
                managerForm.btnAddKey.ForeColor = Color.WhiteSmoke;

                managerForm.btnEditKey.BackColor = Color.WhiteSmoke;
                managerForm.btnEditKey.ForeColor = Color.WhiteSmoke;

                managerForm.btnDeleteKey.BackColor = Color.WhiteSmoke;
                managerForm.btnDeleteKey.ForeColor = Color.WhiteSmoke;


                managerForm.btnAddQte.BackColor = Color.WhiteSmoke;
                managerForm.btnAddQte.ForeColor = Color.WhiteSmoke;

                managerForm.btnSubQte.BackColor = Color.WhiteSmoke;
                managerForm.btnSubQte.ForeColor = Color.WhiteSmoke;

                managerForm.btnClient.BackColor = Color.WhiteSmoke;
                managerForm.btnClient.ForeColor = Color.WhiteSmoke;

                managerForm.btnConfig.BackColor = Color.WhiteSmoke;
                managerForm.btnConfig.ForeColor = Color.WhiteSmoke;

                managerForm.btnUpdate.BackColor = Color.WhiteSmoke;
                managerForm.btnUpdate.ForeColor = Color.WhiteSmoke;

                managerForm.btnServices.BackColor = Color.WhiteSmoke;
                managerForm.btnServices.ForeColor = Color.WhiteSmoke;

                managerForm.lbSearchService.ForeColor = Color.Black;
                managerForm.lbSearchType.ForeColor = Color.Black;
                managerForm.lbManufactorType.ForeColor = Color.Black;

                managerForm.pnDivider.BackColor = Color.DarkGray;
            }

            if(config.FontSize < 9)
            {
                config.FontSize = 10f;
            }
            foreach(DataGridViewColumn c in managerForm.dgvKey.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Verdana", config.FontSize, GraphicsUnit.Pixel);
            }

            managerForm.dgvKey.Columns[5].DefaultCellStyle.ForeColor = Color.DarkGreen;

            try
            {
                managerForm.dgvKey.RowsDefaultCellStyle.SelectionBackColor = Color.FromName(config.Color);
                managerForm.dgvKey.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromName(config.Color);
                managerForm.statusStrip1.BackColor = Color.FromName(config.Color);
                managerForm.statusStrip1.ForeColor = Color.Black;
                managerForm.btnSearch.BackColor = Color.FromName(config.Color);

                managerForm.dgvKey.Columns[0].Visible = config.ShowId;
                managerForm.dgvKey.Columns[1].Visible = config.ShowManufactor;
                managerForm.dgvKey.Columns[2].Visible = config.ShowModel;
                managerForm.dgvKey.Columns[3].Visible = config.ShowType;
                managerForm.dgvKey.Columns[4].Visible = config.ShowYear;
                managerForm.dgvKey.Columns[5].Visible = config.ShowPrice;
                managerForm.dgvKey.Columns[6].Visible = config.ShowButtons;
                managerForm.dgvKey.Columns[7].Visible = config.ShowQuantity;
                managerForm.dgvKey.Columns[8].Visible = config.ShowService;

                managerForm.pnModel.BackColor = Color.FromName(config.Color);
                managerForm.pnType.BackColor = Color.FromName(config.Color);
                managerForm.pnYear.BackColor = Color.FromName(config.Color);
                managerForm.pnQte.BackColor = Color.FromName(config.Color);
                managerForm.pnButtons.BackColor = Color.FromName(config.Color);
                managerForm.pnService.BackColor = Color.FromName(config.Color);
                managerForm.pnValue.BackColor = Color.FromName(config.Color);
            }
            catch (ArgumentOutOfRangeException) { }
        }

        public static void SetConfigurationForm(ConfigurationForm configForm)
        {
            config = data.ReadData();

            configForm.btnOk.BackColor = Color.FromName(config.Color);
            configForm.btnCancel.BackColor = Color.FromName(config.Color);

            if (config.Theme == Theme.DARK)
            {
                configForm.BackColor = Color.DimGray;
                configForm.ForeColor = Color.White;

                configForm.gbTheme.ForeColor = Color.White;
                configForm.gbExport.ForeColor = Color.White;

                configForm.btnOk.ForeColor = Color.Black;
                configForm.btnCancel.ForeColor = Color.Black;
            }
            
            else if(config.Theme == Theme.LIGHT)
            {
                configForm.BackColor = Color.WhiteSmoke;
                configForm.ForeColor = Color.Black;

                configForm.gbTheme.ForeColor = Color.Black;
                configForm.gbExport.ForeColor = Color.Black;

                configForm.btnOk.ForeColor = Color.Black;
                configForm.btnCancel.ForeColor = Color.Black;
            }
        }

        public static void SetKeyForm(KeyInfo keyForm)
        {
            config = data.ReadData();

            keyForm.panelId.BackColor = Color.FromName(config.Color);
            keyForm.panelManufactor.BackColor = Color.FromName(config.Color);
            keyForm.btnEdit.BackColor = Color.FromName(config.Color);
            keyForm.btnImage.BackColor = Color.FromName(config.Color);

            if(config.Theme == Theme.DARK)
            {
                keyForm.BackColor = Color.DimGray;
                keyForm.ForeColor = Color.White;

                keyForm.gbInformation.BackColor = Color.DimGray;
                keyForm.gbInformation.ForeColor = Color.White;

                keyForm.btnEdit.ForeColor = Color.Black;
                keyForm.btnCancel.ForeColor = Color.Black;
                keyForm.btnImage.ForeColor = Color.Black;
                keyForm.txtObservation.BackColor = Color.LightGray;

                keyForm.panelSide.BackgroundImage = Properties.Resources.BARDARK;
                keyForm.panelSide.BorderStyle = BorderStyle.FixedSingle;

            }
            else if(config.Theme == Theme.LIGHT)
            {
                keyForm.BackColor = Color.WhiteSmoke;
                keyForm.ForeColor = Color.Black;

                keyForm.gbInformation.BackColor = Color.WhiteSmoke;
                keyForm.gbInformation.ForeColor = Color.Black;

                keyForm.btnEdit.ForeColor = Color.Black;
                keyForm.btnCancel.ForeColor = Color.Black;
                keyForm.btnImage.ForeColor = Color.Black;
                keyForm.txtObservation.BackColor = Color.White;

                keyForm.panelSide.BackgroundImage = Properties.Resources.BARLIGHT;
                keyForm.panelSide.BorderStyle = BorderStyle.None;
            }
        }

        public static void SetAddKeyForm(AddKeyForm addKey)
        {
            config = data.ReadData();
            addKey.btnAddKey.BackColor = Color.FromName(config.Color);

            if(config.Theme == Theme.DARK)
            {
                addKey.BackColor = Color.DimGray;
                addKey.ForeColor = Color.White;

                addKey.gbNewKey.BackColor = Color.DimGray;
                addKey.gbNewKey.ForeColor = Color.White;
                addKey.btnAddKey.ForeColor = Color.Black;
                addKey.btnClose.ForeColor = Color.Black;

                addKey.txtObservation.BackColor = Color.LightGray;
            }
            else if(config.Theme == Theme.LIGHT)
            {
                addKey.BackColor = Color.WhiteSmoke;
                addKey.ForeColor = Color.Black;
               
                addKey.gbNewKey.BackColor = Color.WhiteSmoke;
                addKey.gbNewKey.ForeColor = Color.Black;
                addKey.btnAddKey.ForeColor = Color.Black;
                addKey.btnClose.ForeColor = Color.Black;

                addKey.txtObservation.BackColor = Color.White;
            }
        }

        public static void SetServiceForm(ServiceForm serviceForm)
        {
            if(config.Theme == Theme.DARK)
            {
                serviceForm.BackColor = Color.DimGray;
                serviceForm.ForeColor = Color.Black;

                serviceForm.btnAddService.BackColor = Color.DarkGray;
                serviceForm.btnAddService.ForeColor = Color.DarkGray;
                serviceForm.btnEditService.BackColor = Color.DarkGray;
                serviceForm.btnEditService.ForeColor = Color.DarkGray;
                serviceForm.btnDeleteService.BackColor = Color.DarkGray;
                serviceForm.btnDeleteService.ForeColor = Color.DarkGray;
                serviceForm.btnUpdate.BackColor = Color.DarkGray;
                serviceForm.btnUpdate.ForeColor = Color.DarkGray;
                serviceForm.pnToolBar.BackColor = Color.DarkGray;

                serviceForm.panelBar.BackgroundImage = Resources.BARDARK;

                serviceForm.dgvServices.BackgroundColor = Color.DimGray;
                serviceForm.dgvServices.ForeColor = Color.White;
                serviceForm.dgvServices.RowsDefaultCellStyle.BackColor = Color.DimGray;
                serviceForm.dgvServices.RowsDefaultCellStyle.ForeColor = Color.White;
                serviceForm.dgvServices.GridColor = Color.Gray;

                serviceForm.pnDivider.BackColor = Color.LightGray;
            }
            else if(config.Theme == Theme.LIGHT)
            {
                serviceForm.BackColor = Color.WhiteSmoke;
                serviceForm.ForeColor = Color.Black;

                serviceForm.btnAddService.BackColor = Color.WhiteSmoke;
                serviceForm.btnAddService.ForeColor = Color.WhiteSmoke; 
                serviceForm.btnEditService.BackColor = Color.WhiteSmoke;
                serviceForm.btnEditService.ForeColor = Color.WhiteSmoke; 
                serviceForm.btnDeleteService.BackColor = Color.WhiteSmoke;
                serviceForm.btnDeleteService.ForeColor = Color.WhiteSmoke; 
                serviceForm.pnToolBar.BackColor = Color.WhiteSmoke;
                serviceForm.btnUpdate.BackColor = Color.WhiteSmoke;
                serviceForm.btnUpdate.ForeColor = Color.WhiteSmoke;

                serviceForm.panelBar.BackgroundImage = Resources.BARLIGHT;

                serviceForm.dgvServices.BackgroundColor = Color.WhiteSmoke;
                serviceForm.dgvServices.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                serviceForm.dgvServices.RowsDefaultCellStyle.ForeColor = Color.Black;
                serviceForm.dgvServices.GridColor = Color.LightGray;

                serviceForm.pnDivider.BackColor = Color.DarkGray;
            }

            serviceForm.pnModel.BackColor = Color.FromName(config.Color);
            serviceForm.panel3.BackColor = Color.FromName(config.Color);
            serviceForm.panel4.BackColor = Color.FromName(config.Color);
            serviceForm.txtTitle.BackColor = Color.FromName(config.Color);
            serviceForm.txtDescription.BackColor = Color.FromName(config.Color);
            serviceForm.btnSearch.BackColor = Color.FromName(config.Color);

            try
            {
                serviceForm.dgvServices.RowsDefaultCellStyle.SelectionBackColor = Color.FromName(config.Color);
                serviceForm.dgvServices.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromName(config.Color);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SetClientForm(ClientForm clientForm)
        {
            config = data.ReadData();
            clientForm.dgvClient.RowsDefaultCellStyle.SelectionBackColor = Color.FromName(config.Color);
            clientForm.btnSearch.BackColor = Color.FromName(config.Color);

            if (config.Theme == Theme.DARK)
            {
                clientForm.groupBox1.ForeColor = Color.WhiteSmoke;
                clientForm.BackColor = Color.DimGray;
                clientForm.ForeColor = Color.White;
                clientForm.dgvClient.BackgroundColor = Color.DimGray;
                clientForm.dgvClient.ForeColor = Color.Black;
                clientForm.btnSearch.ForeColor = Color.Black;
            }
            else if (config.Theme == Theme.LIGHT)
            {
                clientForm.BackColor = Color.WhiteSmoke;
                clientForm.ForeColor = Color.Black;
                clientForm.dgvClient.BackgroundColor = Color.WhiteSmoke;
            }
        }

        public static void SetShowClientForm(ShowClientForm showClientForm)
        {
            config = data.ReadData();
            showClientForm.btnEdit.BackColor = Color.FromName(config.Color);

            if (config.Theme == Theme.DARK)
            {
                showClientForm.BackColor = Color.DimGray;
                showClientForm.ForeColor = Color.White;
                showClientForm.groupBox1.ForeColor = Color.White;
                showClientForm.groupBox1.BackColor = Color.DimGray;
                showClientForm.btnEdit.ForeColor = Color.Black;
                showClientForm.btnCancel.ForeColor = Color.Black;
            }

            else if (config.Theme == Theme.LIGHT)
            {
                showClientForm.BackColor = Color.WhiteSmoke;
                showClientForm.ForeColor = Color.Black;
                showClientForm.groupBox1.ForeColor = Color.Black;
                showClientForm.groupBox1.BackColor = Color.WhiteSmoke;
            }
        }
    }
}
