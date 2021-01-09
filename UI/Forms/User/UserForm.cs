using System;
using System.Windows.Forms;
using Business.Login;
using Domain.Entities.Security;

namespace UI.Forms.User
{
    public partial class UserForm : Form
    {
        private readonly LoginMemory _memory;
        public UserForm()
        {
            InitializeComponent();
            LoginService.LoadData();
            _memory = LoginService._memory;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
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
