using Domain.Entities;
using Repository.Contracts;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Services;

namespace UI.Forms.Clients
{
    public partial class ShowClientForm : Form
    {
        static ClientForm _clientForm;
        static IClientRepository _clientRepository = new ClientRepository();
        static Client _dto;
        static int _id;

        private bool _isEdited;
        public ShowClientForm(ClientForm clientForm, Client client, bool isEdited)
        {
            InitializeComponent();
            ThemeSetup.SetShowClientForm(this);

            _clientForm = clientForm;
            _dto = client;
            _isEdited = isEdited;
            _id = client.Id;

            if (isEdited == true)
            {
                btnEdit.Text = "Concluir Edição!";
                tmButtonColor.Enabled = true;
                this.EditMode(true);
            }
            else
            {
                btnEdit.Text = "Editar Cliente";
                this.EditMode(false);
            }

            this.LoadData();

            if (mkCPF_CNPJ.TextLength <= 11)
            {
                mkCPF_CNPJ.Mask = "000.000.000-00";
            }
            else
            {
                mkCPF_CNPJ.Mask = "00.000.000/0000-00";
            }
        }

        private void ShowClientForm_Load(object sender, EventArgs e) { }

        public void EditMode(bool validation)
        {
            txtName.ReadOnly = validation ? false : true;
            mkCPF_CNPJ.ReadOnly = validation ? false : true;
            txtPhone.ReadOnly = validation ? false : true;
            txtEmail.ReadOnly = validation ? false : true;
            txtAdress.ReadOnly = validation ? false : true;
            txtNumber.ReadOnly = validation ? false : true;
            cbCity.Enabled = validation ? true : false;
            cbState.Enabled = validation ? true : false;
            txtComplement.ReadOnly = validation ? false : true;
            txtNeighborhood.ReadOnly = validation ? false : true;
            btnCancel.Enabled = validation ? true : false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _isEdited = true;
            this.EditMode(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.EditMode(false);
            this.LoadData();
        }

        //This function loads the data from the database to the textboxes
        //Check if the property will be setted if a new data type is added
        private void LoadData()
        {
            txtName.Text = _dto.Name;
            mkCPF_CNPJ.Text = _dto.CPF_CNPJ;
            txtPhone.Text = _dto.Phone;
            txtEmail.Text = _dto.Email;
            txtAdress.Text = _dto.Adress;
            txtNumber.Text = _dto.Number;
            txtComplement.Text = _dto.Complement;
            txtNeighborhood.Text = _dto.Neighborhood;
            cbCity.Text = _dto.City;
            cbState.Text = _dto.State;
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_isEdited == false)
                {
                    _isEdited = true;
                    btnEdit.Text = "Concluir edição!";
                    mkCPF_CNPJ.Mask = null;

                    tmButtonColor.Enabled = true;
                    this.EditMode(true);
                }
                else
                {
                    if (!String.IsNullOrEmpty(txtName.Text)
                   && !String.IsNullOrEmpty(mkCPF_CNPJ.Text)
                   && !String.IsNullOrEmpty(txtPhone.Text))
                    {
                        string name = txtName.Text;
                        string cpf_cnpj = mkCPF_CNPJ.Text;
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
                            _dto = new Client(_id, name, cpf_cnpj, phone, email, adress, number, complement, neighborhood, city, state, DateTime.Now);
                            _clientRepository.Update(_dto);

                            MessageBox.Show("Cliente editado com sucesso!");
                            _clientForm.LoadGrid();
                            this.Close();
                        }
                        else
                        {
                            if (cpf_cnpj.Length < 11 || cpf_cnpj.Length  < 14)
                            {
                                MessageBox.Show("Digite um CPF válido!");
                            }
                            else if (cpf_cnpj.Length > 11 && cpf_cnpj.Length < 14 && cpf_cnpj.Length > 14)
                            {
                                MessageBox.Show("Digite um CNPJ válido!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message,
                    "Erro da edição",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void tmButtonColor_Tick(object sender, EventArgs e)
        {
            if (btnEdit.ForeColor == Color.Black)
            {
                btnEdit.ForeColor = Color.Tomato;
            }
            else
            {
                btnEdit.ForeColor = Color.Black;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (_isEdited == false)
            {
                this.Close();
            }
            else if (_isEdited == true)
            {
                this.EditMode(false);

                this.LoadData();

                tmButtonColor.Stop();
                btnEdit.Text = "Editar Cliente";
                btnEdit.ForeColor = Color.Black;

                _isEdited = false;
            }
        }
    }
}
