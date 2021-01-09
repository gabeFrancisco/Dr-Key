using Domain.Entities;
using Business.Login;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UI.Forms.Clients;
using UI.Forms.Services;
using UI.Forms.User;
using UI.Services;
using Business.Services;

namespace UI
{
    public partial class ManagerForm : Form
    {
        //Repository object

        //The id of the selected key in the datagridview
        static int _keyid;
        
        //The index of th datagrid
        static int _index;

        //Static variables that handle the filter
        static string _searchManufactor;
        static string _searchType;
        static string _searchService;
        private KeyService _keyService;

        public ManagerForm()
        {
            InitializeComponent();   
        }

        //Use this function for methods that will load after the inicialization
        
        /*
            When the form is started, it's load it's default configuration to show the
            data in the datagridview. This ables the table to set cell or row size, title
            and other setting for the datagridview
        */
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            LoginService.LoadData();
            tsUser.Text = LoginService._memory.User.UserName.ToString();
            _keyService = new KeyService();
            
            #region-COLUMNS STYLE
            
            //dgvKey.RowTemplate.Height = 25;
            this.LoadGrid();

            dgvKey.Columns[0].HeaderText = "ID";
            dgvKey.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKey.Columns[0].DefaultCellStyle.Format = "D4";
            dgvKey.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvKey.Columns[1].HeaderText = "Fabricante";
            dgvKey.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvKey.Columns[2].HeaderText = "Modelo";
            dgvKey.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvKey.Columns[3].HeaderText = "Tipo";
            dgvKey.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvKey.Columns[4].HeaderText = "Ano";
            dgvKey.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvKey.Columns[5].HeaderText = "Preço";
            dgvKey.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvKey.Columns[5].DefaultCellStyle.Format = "C2";
            dgvKey.Columns[5].DisplayIndex = 10;
            dgvKey.Columns[5].DefaultCellStyle.Font = new Font("Verdana", 12, FontStyle.Regular);

            dgvKey.Columns[6].HeaderText = "Botões";
            dgvKey.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKey.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvKey.Columns[7].HeaderText = "Qte.";
            dgvKey.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKey.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvKey.Columns[10].Visible = false;
            dgvKey.Columns[9].Visible = false;

            dgvKey.Columns[8].HeaderText = "Serviço";
            dgvKey.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvKey.Columns[11].Visible = false;

            if (_keyService.ReturnTable().Rows.Count > 0)
            {
                dgvKey.Rows[_index].Selected = true;
                this.UpdateKeyNumber();
                _keyid = Convert.ToInt32(dgvKey.Rows[0].Cells[0].Value.ToString());
                this.LoadCard();
            }
            #endregion
            ThemeSetup.SetManagerForm(this);
        }

        // This function reloads the datagridview every time is called
        public void LoadGrid()
        {
            dgvKey.DataSource = _keyService.ReturnTable();
            //SaveDb();
        }

        public int GetIdByCell(DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedIndex = dgvKey.Rows[index];
            return int.Parse(selectedIndex.Cells[0].Value.ToString());
        }
        
        // When this function is called, it opens the KeyInfo windows
        // If the key image path is registered but the image cannot be found, it ignores
        // the exception to avoid the program from crashing
        private void dgvKey_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KeyInfo keyInfo = new KeyInfo(this, _keyService.ReadKey(this.GetIdByCell(e)),false);
                keyInfo.ShowDialog();
            }
            catch(FileNotFoundException) 
            { 
                _keyService.UpdateImage(_keyid); 
                this.dgvKey_CellDoubleClick(sender, e);
            }
            catch(ArgumentOutOfRangeException) { }
            catch(Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        //Delete key function block
        private void btnDeleteKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (tsKeys.Text != "...")
                {
                    if (MessageBox.Show($"Você realmente deseja remover a chave número - {tsKeys.Text} ?",
                      "Remover Chave",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _keyService.DeleteKey(_keyid);
                        MessageBox.Show($"A chave {tsKeys.Text} foi removida com sucesso!",
                            "Remover Chave",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.LoadGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma chave para continuar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        //Updates the total number of the keys in the repository
        //to the string in the botton toolbar
        public void UpdateKeyNumber()
        {
            tsNKeys.Text = Convert.ToString(_keyService.GetTotalKeyNumbers());
        }

         
        //When a cell is clicked, it searches for the cell index and key id
        //to load the Key Card. All the data of the key is setted by the _keyid variable
        private void dgvKey_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = this.GetIdByCell(e);
                Key key = _keyService.ReadKey(id);
                _keyid = id;

                tsKeys.Text = id.ToString("D4") + " - " + key.Model;

                LoadCard();
            }
            catch { }
        }
       
       //Configuration form loader from menu strip
        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configurationForm = new ConfigurationForm(this);
            configurationForm.ShowDialog();
        }

        // THis event searches for a key in repository that matches the string
        // in the search text box. 
        // If the text box is empty, the grid is loaded to the default data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtSearch.Text))
                {
                    string search = txtSearch.Text;
                    dgvKey.DataSource = _keyService.SearchTable(search);
                }
                else
                {
                    this.LoadGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        #region Search

        //This methdos loads the key datagrid with a filter applied to 
        //the key type when the index of the combo box is selected
        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _searchType = cbSearchType.Text;
                this.dgvKey.DataSource = _keyService.SearchFilter(_searchManufactor, _searchType, _searchService);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        //Same things with this, but with key manufactor
        private void cbSearchManufactor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _searchManufactor = cbSearchManufactor.Text;
                this.dgvKey.DataSource = _keyService.SearchFilter(_searchManufactor, _searchType, _searchService);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        //Same with Service type
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _searchService = cbServiceType.Text;
                this.dgvKey.DataSource = _keyService.SearchFilter(_searchManufactor, _searchType, _searchService);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        #endregion

        private void sobreOProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        //Loads the AddKeyForm
        private void btnAddKey_Click(object sender, EventArgs e)
        {
            AddKeyForm addKeyForm = new AddKeyForm(this);
            addKeyForm.ShowDialog();
        }

        //Loads the KeyInfoForm
        private void btnEditKey_Click(object sender, EventArgs e)
        {
            try
            {
                KeyInfo keyInfo = new KeyInfo(this, _keyService.ReadKey(_keyid), true);
                keyInfo.EditMode(true);
                keyInfo.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Selecione uma chave para editar");
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e) { }

        private void button6_Click(object sender, EventArgs e)
        {
            ConfigurationForm config = new ConfigurationForm(this);
            config.ShowDialog();
        }

        private void novaChaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddKeyForm addKeyForm = new AddKeyForm(this);
            addKeyForm.ShowDialog();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "<Pending>")]
        private void editarChaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                KeyInfo keyInfo = new KeyInfo(this, _keyService.ReadKey(_keyid), true);
                keyInfo.ShowDialog();
                keyInfo.btnEdit_Click(null, e);
                keyInfo.EditMode(true);
            }
            catch
            {
                MessageBox.Show("Selecione uma chave para editar");
            }
        }

        //*****************DEPRECATED! - USAGE ONLY FOR LOCAL DATABASE*******************//

        //This function saves the database every time the grid is loaded
        //If an error is occurred, it returns an message and save the error on a txt file in C:
        //private void SaveDb()
        //{
        //    BackupData backup = new BackupData();
        //    backup.SaveDatabase();

        //    if(backup.SaveDatabase() == true)
        //    {
        //        tsDbSave.Text = "Salvo!";
        //    }
        //    else if(backup.SaveDatabase() == false)
        //    {
        //        MessageBox.Show($"Ocorreu um erro na sua base de dados!" +
        //            "\n Log de analise salvo em: " + backup.GetExceptionPath(),
        //            "Erro do Banco de Dados",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //        tsDbSave.Text = "Erro na sua base de dados! Verifique!";
        //    }
        //    else
        //    {
        //        tsDbSave.Text = "...";
        //    }
        //}

        //***********************************DEPRECATED***********************************//

        private void toolStripStatusLabel1_Click(object sender, EventArgs e) { }

        private void apagarChaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnDeleteKey_Click(sender, e);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.btnSearch_Click(sender, e);
            }
        }

        //This loads the card at the left of the window
        public void LoadCard()
        {
            try
            {
                Key key = _keyService.ReadKey(_keyid);

                BrandLoader.LoadBrandImage(pctManufactor, key.Manufactor);
                lbModel.Text = key.Model;
                lbType.Text = key.Type;
                lbYear.Text = key.Year;
                lbButtons.Text = key.Buttons.ToString();
                lbQte.Text = key.Quantity.ToString();
                lbServiceType.Text = key.ServiceType;
                lbValue.Text = "R$" + key.Price.ToString("f2");
            }
            catch (Exception) { }
          
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                KeyInfo keyInfo = new KeyInfo(this, _keyService.ReadKey(_keyid), true);
                keyInfo.ShowDialog();
                keyInfo.btnEdit_Click(null, e);
                keyInfo.EditMode(true);
            }
            catch
            {
                MessageBox.Show("Selecione uma chave para editar");
            }
        }

        private void btnAddQte_Click(object sender, EventArgs e)
        {
            try
            {
                Key key = _keyService.ReadKey(_keyid);
                key.AddQuantity();
                _keyService.AddQuantity(key);
                LoadGrid();
                LoadCard();
            }
            catch
            {
                MessageBox.Show("Selecione uma chave para alterar quantidade!");    
            }
        }

        private void btnSubQte_Click(object sender, EventArgs e)
        {
            try
            {
                Key key = _keyService.ReadKey(_keyid);
                key.SubtractQuantity();
                _keyService.SubtractQuantity(key);
                LoadGrid();
                LoadCard();
            }
            catch
            {
                MessageBox.Show("Selecione uma chave para alterar quantidade!");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
            cbSearchType.Text = null;
            cbSearchManufactor.Text = null;
            cbServiceType.Text = null;
            txtSearch.Text = null;
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.ShowDialog();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que deseja sair?", "Aviso de Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginService.SaveUserState(false);
                this.Close();
            }
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }
    }
}
