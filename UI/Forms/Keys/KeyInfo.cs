using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Services;
using Domain.Entities;
using Domain.Enums;
using UI.Services;

namespace UI
{
    public partial class KeyInfo : Form
    {
        //Object that stores the state of the ManagerForm
        static ManagerForm _managerForm;

        //Global Key object for this form
        private Key _dto;

        //Stores a boolean value that indicates the editing state
        static bool _isEdit = false;

        //Repository object
        static KeyService _keyService;

        public KeyInfo()
        {
            InitializeComponent();
        }

        public KeyInfo(ManagerForm manager, Key dto, bool isEdit)
        {
            InitializeComponent();
            _keyService = new KeyService();

            _managerForm = manager;
            _dto = dto;
            _isEdit = isEdit;

            if(_isEdit == true)
            {
                btnEdit.Text = "Ok!";
                this.tmButtonColor.Enabled = true;
                this.EditMode(true);
            }
            else
            {
                btnEdit.Text = "Editar Chave";
                this.EditMode(false);
            }

            ThemeSetup.SetKeyForm(this);

            this.EditMode(false);

            lbId.Text = dto.Id.ToString("D4");
            lbManufactor.Text = dto.Manufactor;
            txtModel.Text = dto.Model;
            cbType.Text = dto.Type.ToString();
            cbService.Text = dto.ServiceType.ToString();
            txtYear.Text = dto.Year;
            txtButtons.Text = dto.Buttons.ToString();
            txtQte.Text = dto.Quantity.ToString();
            txtValue.Text = dto.Price.ToString();
            txtImage.Text = dto.Image;
            txtObservation.Text = dto.Observation;

            string manufactor = dto.Manufactor;
            LoadImage();

            if(_dto.Image == null)
            {
                lbImage.Visible = false;
            }

            BrandLoader.LoadBrandImage(pctManufactor, manufactor);
        }

        public void EditMode(bool validation)
        {
            txtModel.ReadOnly = validation ? false : true;
            txtYear.ReadOnly = validation ? false : true;
            txtButtons.ReadOnly = validation ? false : true;
            txtQte.ReadOnly = validation ? false : true;
            txtValue.ReadOnly = validation ? false : true;
            txtImage.ReadOnly = validation ? false : true;
            cbType.Enabled = validation ? true : false;
            cbService.Enabled = validation ? true : false;
            btnImage.Enabled = validation ? true : false;
            txtObservation.ReadOnly = validation ? false : true;
        }

        internal void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(_isEdit == false)
                {
                    _isEdit = true;
                    btnEdit.Text = "Concluir Edição!";

                    tmButtonColor.Enabled = true;
                    this.EditMode(true);
                }
                else
                {
                    if (cbType != null
                      && cbService != null
                      && !String.IsNullOrEmpty(txtModel.Text)
                      && !String.IsNullOrEmpty(txtYear.Text)
                      && !String.IsNullOrEmpty(txtQte.Text)
                      && !String.IsNullOrEmpty(txtValue.Text))
                    {
                        int id = Convert.ToInt32(lbId.Text);
                        string manufactor = lbManufactor.Text;
                        string model = txtModel.Text;
                        string type = cbType.Text;
                        string serviceType = cbService.Text;
                        string year = txtYear.Text;
                        decimal price = Convert.ToDecimal(txtValue.Text);
                        string buttons = txtButtons.Text;
                        int qte = Convert.ToInt32(txtQte.Text);
                        string observation = txtObservation.Text;
                        string image = txtImage.Text;
                        string slash_image = image.Replace("\\", "\\\\");

                        Key dto = new Key
                        {
                            Id = id,
                            Manufactor = manufactor,
                            Model = model,
                            Type = type,
                            ServiceType = serviceType,
                            Year = year,
                            Price = price,
                            Buttons = buttons,
                            Quantity = qte,
                            Image = slash_image,
                            Observation = observation
                        };

                        _keyService.UpdateKey(dto);

                        MessageBox.Show("Chave editada com sucesso!",
                            "Atualização de chave",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        _managerForm.LoadGrid();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(_isEdit == false)
            {
                this.Close();
            }
            else if(_isEdit == true)
            {
                this.EditMode(false);


                lbId.Text = _dto.Id.ToString("D4");
                lbManufactor.Text = _dto.Manufactor;
                txtModel.Text = _dto.Model;
                cbType.SelectedItem = _dto.Type.ToString();
                cbService.SelectedItem = _dto.ServiceType.ToString();
                txtYear.Text = _dto.Year;
                txtButtons.Text = _dto.Buttons.ToString();
                txtQte.Text = _dto.Quantity.ToString();
                txtValue.Text = _dto.Price.ToString();
                txtImage.Text = _dto.Image;
                txtObservation.Text = _dto.Observation;

                tmButtonColor.Stop();
                btnEdit.ForeColor = Color.Black;
                btnEdit.Text = "Editar Chave";

                _isEdit = false;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPEG|*jpg|Bitmaps|*bmp|PNG|*png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string image = openFile.FileName.ToString();
                txtImage.Text = image;
            }
            LoadImage();
        }

        private void KeyInfo_Load(object sender, EventArgs e) { }

        private void LoadImage()
        {
            try
            {
                pctImage.Image = Image.FromFile(txtImage.Text);
                pctImage.SizeMode = PictureBoxSizeMode.Zoom;
                lbImage.Visible = false;
            }
            catch(ArgumentException) 
            {
                lbImage.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _keyService.AddQuantity(_dto);
                _dto = _keyService.ReadKey(Convert.ToInt32(lbId.Text));
                txtQte.Text = _dto.Quantity.ToString();
                _managerForm.LoadGrid();
                _managerForm.LoadCard();
            }
            catch
            {
                MessageBox.Show("Selecione uma chave para alterar quantidade!");
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                _dto = _keyService.ReadKey(Convert.ToInt32(lbId.Text));
                txtQte.Text = _dto.Quantity.ToString();
                _managerForm.LoadGrid();
                _managerForm.LoadCard();
            }
            catch
            {
                MessageBox.Show("Selecione uma chave para alterar quantidade!");
            }
        }

        private void tmButtonColor_Tick(object sender, EventArgs e)
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
    }
}
