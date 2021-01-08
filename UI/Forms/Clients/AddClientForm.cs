using Domain.Entities;
using Repository.Contracts;
using Repository.Repositories;
using System;
using System.Windows.Forms;

namespace UI.Forms.Clients
{
    public partial class AddClientForm : Form
    {
        private Client _dto;
        private IClientRepository _clientRepository = new ClientRepository();
        private ClientForm _clientForm;
        public AddClientForm(ClientForm clientForm)
        {
            InitializeComponent();
            _clientForm = clientForm;
        }

        private void btnAddClient_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtName.Text)
                    && !String.IsNullOrEmpty(txtCPF_CNPJ.Text)
                    && !String.IsNullOrEmpty(txtPhone.Text))
                {
                    string name = txtName.Text;
                    string cpf_cnpj = txtCPF_CNPJ.Text;
                    string phone = txtPhone.Text;
                    string email = txtEmail.Text;
                    string adress = txtAdress.Text;
                    string number = txtNumber.Text;
                    string complement = txtComplement.Text;
                    string neighborhood = txtNeighborhood.Text;
                    string city = cbCity.Text;
                    string state = cbState.Text;

                    if (cpf_cnpj.Length == 11 || cpf_cnpj.Length == 14)
                    {
                        _dto = new Client(name, cpf_cnpj, phone, email, adress, number, complement, neighborhood, city, state, DateTime.Now);
                        _clientRepository.Add(_dto);

                        MessageBox.Show("Cliente cadastrado com sucesso!");
                        _clientForm.LoadGrid();
                        this.Close();
                    }
                    else
                    {
                        if (cpf_cnpj.Length < 11 || cpf_cnpj.Length > 11)
                        {
                            MessageBox.Show("Digite um CPF válido!");
                        }
                        else if (cpf_cnpj.Length > 11 && cpf_cnpj.Length < 14 && cpf_cnpj.Length > 14)
                        {
                            MessageBox.Show("Digite um CNPJ válido!");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Preencha todos os campos para cadastrar!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro no cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
