using Domain.Entities;
using Repository.Contracts;
using Repository.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI.Forms.Services
{
    public partial class ShowService : Form
    {
        //Repository object to set alterations
        private readonly IServiceRepository _repository = new ServiceRepository();

        //Boolean var that stores the editing state
        private bool _isEdit = false;

        //Service object thats came from the ServiceForm to be showed in this form
        private Service _service = null;

        //Variable that stores the ServiceForm state
        private readonly ServiceForm _serviceForm = null;

        public ShowService(ServiceForm serviceForm, bool isEdit, Service service) 
        {
            InitializeComponent();
            _service = service;
            _serviceForm = serviceForm;

            if(isEdit == true)
            {
                btnEdit.Text = "Ok!";
                tmButtonColor.Enabled = true;
                this.EditMode(true);
            }
            else
            {
                btnEdit.Text = "Editar Serviço";
                this.EditMode(false);
            }

            txtTitle.Text = _service.Title;
            txtDescription.Text = _service.Description;
            txtPrice.Text = _service.Price.ToString();
        }

        private void EditMode(bool validation)
        {
            txtTitle.ReadOnly = validation ? false : true;
            txtDescription.ReadOnly = validation ? false : true;
            txtPrice.ReadOnly = validation ? false : true;
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (_isEdit == false)
                {
                    _isEdit = true;
                    btnEdit.Text = "Concluir edição!";

                    tmButtonColor.Enabled = true;
                    this.EditMode(true);
                }
                else
                {
                    if (!String.IsNullOrEmpty(txtTitle.Text)
                        && !String.IsNullOrEmpty(txtDescription.Text)
                        && !String.IsNullOrEmpty(txtPrice.Text))
                    {
                        string title = txtTitle.Text;
                        string description = txtDescription.Text;
                        decimal price = Convert.ToDecimal(txtPrice.Text);

                        Service service = new Service
                        {
                            Id = _service.Id,
                            Title = title,
                            Description = description,
                            Price = price
                        };

                        _repository.Update(service);

                        _serviceForm.LoadGrid();
                        _serviceForm.LoadCard();
                        _serviceForm.SetTableConfig();

                        tmButtonColor.Stop();
                        MessageBox.Show("Serviço editado com sucesso!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos para continuar!", "Aviso!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tmButtonColor_Tick(object sender, System.EventArgs e)
        {
            if(btnEdit.ForeColor == Color.Black)
            {
                btnEdit.ForeColor = Color.Tomato;
            }
            else
            {
                btnEdit.ForeColor = Color.Black;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_isEdit == false)
            {
                this.Close();
            }
            else if(_isEdit == true)
            {
                this.EditMode(false);

                txtTitle.Text = _service.Title;
                txtDescription.Text = _service.Description;
                txtPrice.Text = _service.Price.ToString();
               
                tmButtonColor.Stop();
                btnEdit.Text = "Editar Serviço";
                btnEdit.ForeColor = Color.Black;

                _isEdit = false;
            }
        }
    }
}
