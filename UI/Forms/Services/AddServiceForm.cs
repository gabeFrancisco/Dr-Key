using Business.Services;
using Domain.Entities;
using System;
using System.Windows.Forms;

namespace UI.Forms.Services
{
    public partial class AddServiceForm : Form
    {
        //Service repository database variable
        private readonly ServicesService _servicesService;
        
        //Variable thats stores the ServiceForm state. It's used to update
        //its datagridview when a new service is created!
        private ServiceForm _serviceForm;

        public AddServiceForm(ServiceForm serviceForm)
        {
            InitializeComponent();
            _servicesService = new ServicesService();
            _serviceForm = serviceForm;
        }

        private void btnNewService_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(txtTitle.Text)
                    && !String.IsNullOrEmpty(txtDescription.Text)
                    && !String.IsNullOrEmpty(txtPrice.Text))
                {
                    string title = txtTitle.Text;
                    string description = txtDescription.Text;
                    decimal price = Convert.ToDecimal(txtPrice.Text);

                    Service service = new Service
                    {
                        Title = title,
                        Description = description,
                        Price = price
                    };

                    _servicesService.CreateService(service);

                    _serviceForm.LoadGrid();
                    _serviceForm.SetTableConfig();

                    MessageBox.Show("Serviço registrado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos para continuar!", "Aviso!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
