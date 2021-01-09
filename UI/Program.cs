using Domain.Entities.Security;
using System;
using System.Windows.Forms;
using UI.Forms.Login;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                RunLoginScreen();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message + "\n" + ex.StackTrace 
                    + "\n\nCódigo da Exceção: " + ex.GetType().ToString(),
                    "Erro de Inicialização",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
              );
            }
          
        }

        public static void RunLoginScreen()
        {
            DialogResult result;
            using (LoginScreen loginScreen = new LoginScreen())
                result = loginScreen.ShowDialog();

            if (result == DialogResult.OK)
            {
                Application.Run(new ManagerForm());
            }
        }

        public static void RunLoginScreenWithManager(ManagerForm managerForm)
        {
            DialogResult result;
            using (LoginScreen loginScreen = new LoginScreen(managerForm))
                result = loginScreen.ShowDialog();

            if (result == DialogResult.OK)
            {
                Application.Run(new ManagerForm());
            }
        }
    }
}
