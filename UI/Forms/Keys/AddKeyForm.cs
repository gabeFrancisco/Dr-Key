using Domain.Entities;
using Repository.Contracts;
using Repository.Repositories;
using System;
using System.Windows.Forms;
using UI.Services;

namespace UI
{
    public partial class AddKeyForm : Form
    {
        static ManagerForm _managerForm;
        static IKeyRepository _keyRepository = new KeyRepository();
        static Key dto;
        public AddKeyForm(ManagerForm managerForm)
        {
            InitializeComponent();
            _managerForm = managerForm;

            ThemeSetup.SetAddKeyForm(this);
        }

        private void AddKeyForm_Load(object sender, EventArgs e) { }
        private void btnAddKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbManufactor != null
                  && cbType != null
                  && cbService != null
                  && !String.IsNullOrEmpty(txtModel.Text)
                  && !String.IsNullOrEmpty(txtYear.Text)
                  && !String.IsNullOrEmpty(txtButtons.Text)
                  && !String.IsNullOrEmpty(txtQte.Text)
                  && !String.IsNullOrEmpty(txtPrice.Text))
                {
                    string manufactor = cbManufactor.SelectedItem.ToString();
                    string type = cbType.Text;
                    string serviceType = cbService.Text;
                    string model = txtModel.Text;
                    string year = txtYear.Text;
                    string buttons = txtButtons.Text;
                    int qte = int.Parse(txtQte.Text);
                    decimal value = Convert.ToDecimal(txtPrice.Text);
                    string image = txtImage.Text;
                    string observation = txtObservation.Text;

                    dto = new Key
                    {
                        Manufactor = manufactor,
                        Type = type,
                        Model = model,
                        Year = year,
                        ServiceType = serviceType,
                        Buttons = buttons,
                        Quantity = qte,
                        Price = value,
                        Image = image,
                        Observation = observation
                    };


                    if (_keyRepository.IsDuplicated(dto) == false)
                    {
                        _keyRepository.Add(dto);

                        MessageBox.Show("Chave registrada com sucesso!");
                        _managerForm.UpdateKeyNumber();
                        _managerForm.LoadGrid();
                        this.Close();
                    }

                    else
                    {
                        if (MessageBox.Show("Esse modelo já existe na base de dados! \nVocê deseja registrar novamente?",
                                       "Nova chave",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _keyRepository.Add(dto);

                            MessageBox.Show("Chave registrada com sucesso!");
                            _managerForm.UpdateKeyNumber();
                            _managerForm.LoadGrid();
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos para continuar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPEG|*jpg|Bitmaps|*bmp|PNG|*png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string image = openFile.FileName.ToString();
                //_image = image.Replace("\\", "\\\\");
                txtImage.Text = image;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e) { }

        private void AddKeyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnAddKey_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show(
                    "Cancelar cadastro?",
                    "Sair",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
