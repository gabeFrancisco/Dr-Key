﻿using Domain.Entities;
using Repository.Contracts;
using Repository.Repositories;
using System;
using System.Windows.Forms;
using UI.Services;

namespace UI.Forms.Clients
{
    public partial class ClientForm : Form
    {
        //Repository object
        static IClientRepository _clientRepository = new ClientRepository();

        //Client object for global usage
        static Client _client;

        //Datagrid view row index
        static int _index;

        //Client global id
        static int _id;

        public ClientForm()
        {
            InitializeComponent();

            LoadGrid();

            dgvClient.Columns[0].Visible = false;

            dgvClient.Columns[1].HeaderText = "Nome";
            dgvClient.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvClient.Columns[2].HeaderText = "Telefone";
            dgvClient.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvClient.Columns[3].HeaderText = "Email";
            dgvClient.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvClient.Columns[4].Visible = false;
            dgvClient.Columns[5].Visible = false;
            dgvClient.Columns[6].Visible = false;
            dgvClient.Columns[7].Visible = false;
            dgvClient.Columns[8].Visible = false;

            dgvClient.Columns[9].Visible = false;

            dgvClient.Columns[10].HeaderText = "Data de Inscrição";
            dgvClient.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvClient.Columns[10].DisplayIndex = 3;

            dgvClient.Columns[11].Visible = false;
            dgvClient.Columns[11].HeaderText = "CPF/CNPJ";
            dgvClient.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvClient.Columns[12].Visible = false;

            ThemeSetup.SetClientForm(this);
        }
        public void LoadGrid()
        {
            dgvClient.DataSource = _clientRepository.ReturnTable();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm(this);
            addClientForm.ShowDialog();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Você tem certeza que deseja remover {_client.Name}? ",
                               "Remover Cliente",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _clientRepository.Remove(_id);
                    MessageBox.Show("Cliente removido com sucesso!");
                    this.LoadGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _index = e.RowIndex;
                DataGridViewRow selectedIndex = dgvClient.Rows[_index];
                _id = int.Parse(selectedIndex.Cells[0].Value.ToString());
                _client = _clientRepository.GetById(_id);
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        private void dgvClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _index = e.RowIndex;
                DataGridViewRow selectedIndex = dgvClient.Rows[_index];
                _id = int.Parse(selectedIndex.Cells[0].Value.ToString());

                _client = _clientRepository.GetById(_id);
                ShowClientForm showClientForm = new ShowClientForm(this, _client, false);
                showClientForm.ShowDialog();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            try
            {
                ShowClientForm showClientForm = new ShowClientForm(this, _client, true);
                showClientForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cliente para editar");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtSearchClient.Text))
                {
                    string search = txtSearchClient.Text;
                    dgvClient.DataSource = _clientRepository.SearchTable(search);
                }
                else
                {
                    this.LoadGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void txtSearchClient_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                this.btnSearch_Click(sender, e);
            }
            
        }
    }
}
