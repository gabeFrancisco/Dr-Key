using Repository.DataAcess.SerialObjects;
using System;
using System.Windows.Forms;
using Domain.Entities.Security;

namespace UI.Forms.User
{
    public partial class UserForm : Form
    {
        private LoginData _loginData;
        private LoginMemory _memory;

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            _loginData = new LoginData();
            _memory = _loginData.ReadData();
            this.LoadData();
        }

        private void LoadData()
        {
            txtUsername.Text = _memory.User.UserName;
            txtName.Text = _memory.User.Name;
            txtSurname.Text = _memory.User.Surname;
            txtEmail.Text = _memory.User.Email;
            txtPhone.Text = _memory.User.Phone;
            txtDate.Text = _memory.User.SignDate.ToString("d");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
