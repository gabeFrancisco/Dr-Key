﻿using Business.Services;
using Domain.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;
using UI.Services;

namespace UI.Forms.Services
{
    public partial class ServiceForm : Form
    {
        //This integer stores the index of the selected row in services datagridview
        private int _index = 0;

        //This integer stores the ID of the actual selected service in the datagridview
        private int _id;

        //Service object that is selected by the datagrid
        private Service _service = null;

        //Services
        private ServicesService _servicesServices;

        public ServiceForm()
        {
            InitializeComponent();
            ThemeSetup.SetServiceForm(this);

            _servicesServices = new ServicesService();

            this.LoadGrid();
            this.SetTableConfig();

            if (_servicesServices.ReturnTable().Rows.Count > 0)
            {
                _id = Convert.ToInt32(dgvServices.Rows[0].Cells[0].Value.ToString());
                _service = _servicesServices.ReadService(_id);
                dgvServices.Rows[_index].Selected = true;

                this.LoadCard();
            }
        }

        public int GetIdByCell(DataGridViewCellEventArgs e)
        {
            _index = e.RowIndex;
            DataGridViewRow selectedRow = dgvServices.Rows[_index];
            return int.Parse(selectedRow.Cells[0].Value.ToString());
        }

        internal void SetTableConfig()
        {
            dgvServices.Columns[0].Visible = false;

            dgvServices.Columns[1].HeaderText = "Título";
            dgvServices.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvServices.Columns[2].HeaderText = "Descrição";
            dgvServices.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvServices.Columns[3].HeaderText = "Preço";
            dgvServices.Columns[3].Width = 150;
            dgvServices.Columns[3].DefaultCellStyle.Font = new Font("Verdana", 12, FontStyle.Regular);
            dgvServices.Columns[3].DefaultCellStyle.Format = "C2";
            dgvServices.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvServices.Columns[4].Visible = false;

            dgvServices.RowTemplate.Height = 25;
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.GetIdByCell(e);
                _service = _servicesServices.ReadService(_id);
                LoadCard();
            }
            catch(ArgumentOutOfRangeException) { }
        }

        internal void LoadCard()
        {
            if(_servicesServices.ReturnTable().Rows.Count >= 0)
            {
                Service service = _servicesServices.ReadService(_id);

                txtTitle.Text = service.Title;
                txtDescription.Text = service.Description;
                lbPrice.Text = "R$" + service.Price.ToString();
            }
            else
            {
                txtTitle.Clear();
                txtDescription.Clear();
                lbPrice.Text = null;
            }
        }

        internal void LoadGrid()
        {
            dgvServices.DataSource = _servicesServices.ReturnTable();
            dgvServices.Update();
        }

        private void btnUpdate_Click(object sender, EventArgs e) 
        { 
            this.LoadGrid();
            txtSearch.Clear();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            AddServiceForm addServiceForm = new AddServiceForm(this);
            addServiceForm.ShowDialog();
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            ShowService showService = new ShowService(this, true, _service);
            showService.ShowDialog();
        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ShowService showService = new ShowService(this, false, _service);
                showService.ShowDialog();
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show($"Você realmente deseja remover o servico - {_service.Title} ?",
                    "Remover serviço",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _servicesServices.DeleteService(_id);
                    MessageBox.Show("Serviço removido com sucesso!", "Concluído!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.LoadGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtSearch.Text))
                {
                    string search = txtSearch.Text;
                    dgvServices.DataSource = _servicesServices.SearchTable(search);
                }
                else
                {
                    this.LoadGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.btnSearch_Click(sender, e);
            }
        }

        private void pnToolBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}