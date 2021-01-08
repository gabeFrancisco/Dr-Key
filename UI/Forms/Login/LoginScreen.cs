using Domain.Exceptions;
using Repository.DataAcess;
using Services.Login;
using System;
using System.Windows.Forms;

namespace UI.Forms.Login
{
    public partial class LoginScreen : Form
    {
        private readonly ManagerForm _managerForm = new ManagerForm();
        public LoginScreen()
        {
            InitializeComponent();
        }

        public LoginScreen(ManagerForm managerForm)
        {
            InitializeComponent();
            _managerForm = managerForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtUser.Text) || !String.IsNullOrEmpty(txtPassword.Text))
                {
                    try
                    {
                        string user = txtUser.Text;
                        string password = txtPassword.Text;

                        LoginService.VerifyLogin(user, password);
                         
                        if(chbKeepConn.CheckState == CheckState.Checked)
                        {
                            LoginService.SaveUserState(true);
                        }
                           
                        else
                        {
                            LoginService.SaveUserState(false);
                        }

                        DialogResult = DialogResult.OK;
                        this.Dispose();
                        
                    }
                    catch(InvalidUserException)
                    {
                        MessageBox.Show("Usuário ou senhas incorretos!\nDigite novamente!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos para continuar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message + "\n" + ex.StackTrace
                    + "\n\nCódigo da Exceção: " + ex.GetType().ToString(),
                    "Erro de Inicialização",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
              );
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            LoginService.LoadData();

            if (LoginService._memory.IsLoginSaved == true)
            {
                DialogResult = DialogResult.OK;
            }

            this.Focus();

            if (_managerForm != null)
            {
                _managerForm.Visible = false;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_managerForm != null)
            {
                _managerForm.Close();
            }
            
        }
    }
}
