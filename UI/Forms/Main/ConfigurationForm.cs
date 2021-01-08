using Domain.Dictionaries;
using Domain.Entities;
using Domain.Enums;
using Repository.DataAcess;
using Repository.DataAcess.SerialObjects;
using System;
using System.Linq;
using System.Windows.Forms;
using UI.Services;

namespace UI
{
    public partial class ConfigurationForm : Form
    {
        static Configuration config = new Configuration();
        static ConfigData data = new ConfigData();
        static ManagerForm _manager;
        static ThemeColors colors = new ThemeColors();
        static MainTheme mainTheme = new MainTheme();

        public ConfigurationForm(ManagerForm manager)
        {
            InitializeComponent();

            ThemeSetup.SetConfigurationForm(this);

            BindingSource colorBs = new BindingSource(colors.Color, null);
            cbColor.DataSource = colorBs;
            cbColor.DisplayMember = "Key";
            cbColor.ValueMember = "Value";

            BindingSource themeBs = new BindingSource(mainTheme.Theme, null);
            cbTheme.DataSource = themeBs;
            cbTheme.DisplayMember = "Key";
            cbColor.ValueMember = "Value";

            config = data.ReadData();
            cbFont.Text = config.FontSize.ToString();

            rdId.Checked = config.ShowId;
            rdManufactor.Checked = config.ShowManufactor;
            rdModel.Checked = config.ShowModel;
            rdPrice.Checked = config.ShowPrice;
            rdQuantity.Checked = config.ShowQuantity;
            rdType.Checked = config.ShowType;
            rdYear.Checked = config.ShowYear;
            rdButtons.Checked = config.ShowButtons;
            rdService.Checked = config.ShowService;

            _manager = manager;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(cbTheme.Text) && !String.IsNullOrEmpty(cbColor.Text))
                {
                    config.Theme = (Theme)Enum.Parse(typeof(Theme), cbTheme.SelectedIndex.ToString());
                    config.Color = cbColor.SelectedValue.ToString();
                    config.FontSize = float.Parse(cbFont.Text);

                    config.ShowId = rdId.Checked;
                    config.ShowManufactor = rdManufactor.Checked;
                    config.ShowModel = rdModel.Checked;
                    config.ShowPrice = rdPrice.Checked;
                    config.ShowQuantity = rdQuantity.Checked;
                    config.ShowType = rdType.Checked;
                    config.ShowYear = rdYear.Checked;
                    config.ShowButtons = rdButtons.Checked;
                    config.ShowService = rdService.Checked;

                    data.SetData(config);

                    ThemeSetup.SetManagerForm(_manager);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e) 
        {
            cbTheme.Text = mainTheme.Theme.FirstOrDefault(x => x.Value == config.Theme).Key;
            cbColor.Text = colors.Color.FirstOrDefault(x => x.Value == config.Color).Key;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SQL Files|*sql";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveFileDialog.FileName.ToString() + ".sql";
                    BackupData backupData = new BackupData();
                    backupData.SaveDatabaseWithPath(path);

                    MessageBox.Show("Banco de dados exportado com sucesso em " +
                        "\n" + path, "Êxito", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }
    }
}
