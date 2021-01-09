namespace UI
{
    partial class ConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.gbTheme = new System.Windows.Forms.GroupBox();
            this.rdService = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdQuantity = new System.Windows.Forms.CheckBox();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdButtons = new System.Windows.Forms.CheckBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdPrice = new System.Windows.Forms.CheckBox();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdYear = new System.Windows.Forms.CheckBox();
            this.rdModel = new System.Windows.Forms.CheckBox();
            this.rdId = new System.Windows.Forms.CheckBox();
            this.rdType = new System.Windows.Forms.CheckBox();
            this.rdManufactor = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbTheme.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTheme
            // 
            this.gbTheme.Controls.Add(this.rdService);
            this.gbTheme.Controls.Add(this.label5);
            this.gbTheme.Controls.Add(this.rdQuantity);
            this.gbTheme.Controls.Add(this.cbFont);
            this.gbTheme.Controls.Add(this.label3);
            this.gbTheme.Controls.Add(this.rdButtons);
            this.gbTheme.Controls.Add(this.cbColor);
            this.gbTheme.Controls.Add(this.label2);
            this.gbTheme.Controls.Add(this.rdPrice);
            this.gbTheme.Controls.Add(this.cbTheme);
            this.gbTheme.Controls.Add(this.label1);
            this.gbTheme.Controls.Add(this.rdYear);
            this.gbTheme.Controls.Add(this.rdModel);
            this.gbTheme.Controls.Add(this.rdId);
            this.gbTheme.Controls.Add(this.rdType);
            this.gbTheme.Controls.Add(this.rdManufactor);
            this.gbTheme.Location = new System.Drawing.Point(170, 12);
            this.gbTheme.Name = "gbTheme";
            this.gbTheme.Size = new System.Drawing.Size(274, 289);
            this.gbTheme.TabIndex = 0;
            this.gbTheme.TabStop = false;
            this.gbTheme.Text = "Cores e Tema";
            // 
            // rdService
            // 
            this.rdService.AutoSize = true;
            this.rdService.Location = new System.Drawing.Point(14, 256);
            this.rdService.Name = "rdService";
            this.rdService.Size = new System.Drawing.Size(100, 17);
            this.rdService.TabIndex = 19;
            this.rdService.Text = "Mostrar Serviço";
            this.rdService.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Exibição de Colunas:";
            // 
            // rdQuantity
            // 
            this.rdQuantity.AutoSize = true;
            this.rdQuantity.Location = new System.Drawing.Point(119, 233);
            this.rdQuantity.Name = "rdQuantity";
            this.rdQuantity.Size = new System.Drawing.Size(119, 17);
            this.rdQuantity.TabIndex = 17;
            this.rdQuantity.Text = "Mostrar Quantidade";
            this.rdQuantity.UseVisualStyleBackColor = true;
            // 
            // cbFont
            // 
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Items.AddRange(new object[] {
            "12",
            "13",
            "15",
            "17"});
            this.cbFont.Location = new System.Drawing.Point(160, 107);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(76, 21);
            this.cbFont.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tamanho da Fonte da Tabela";
            // 
            // rdButtons
            // 
            this.rdButtons.AutoSize = true;
            this.rdButtons.Location = new System.Drawing.Point(14, 233);
            this.rdButtons.Name = "rdButtons";
            this.rdButtons.Size = new System.Drawing.Size(97, 17);
            this.rdButtons.TabIndex = 16;
            this.rdButtons.Text = "Mostrar Botões";
            this.rdButtons.UseVisualStyleBackColor = true;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(88, 70);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(148, 21);
            this.cbColor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cor";
            // 
            // rdPrice
            // 
            this.rdPrice.AutoSize = true;
            this.rdPrice.Location = new System.Drawing.Point(119, 210);
            this.rdPrice.Name = "rdPrice";
            this.rdPrice.Size = new System.Drawing.Size(92, 17);
            this.rdPrice.TabIndex = 15;
            this.rdPrice.Text = "Mostrar Preço";
            this.rdPrice.UseVisualStyleBackColor = true;
            // 
            // cbTheme
            // 
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Items.AddRange(new object[] {
            "Claro",
            "Escuro"});
            this.cbTheme.Location = new System.Drawing.Point(88, 34);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(148, 21);
            this.cbTheme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tema principal";
            // 
            // rdYear
            // 
            this.rdYear.AutoSize = true;
            this.rdYear.Location = new System.Drawing.Point(14, 210);
            this.rdYear.Name = "rdYear";
            this.rdYear.Size = new System.Drawing.Size(83, 17);
            this.rdYear.TabIndex = 14;
            this.rdYear.Text = "Mostrar Ano";
            this.rdYear.UseVisualStyleBackColor = true;
            // 
            // rdModel
            // 
            this.rdModel.AutoSize = true;
            this.rdModel.Location = new System.Drawing.Point(14, 187);
            this.rdModel.Name = "rdModel";
            this.rdModel.Size = new System.Drawing.Size(99, 17);
            this.rdModel.TabIndex = 12;
            this.rdModel.Text = "Mostrar Modelo";
            this.rdModel.UseVisualStyleBackColor = true;
            // 
            // rdId
            // 
            this.rdId.AutoSize = true;
            this.rdId.Location = new System.Drawing.Point(14, 164);
            this.rdId.Name = "rdId";
            this.rdId.Size = new System.Drawing.Size(73, 17);
            this.rdId.TabIndex = 10;
            this.rdId.Text = "Mostrar Id";
            this.rdId.UseVisualStyleBackColor = true;
            // 
            // rdType
            // 
            this.rdType.AutoSize = true;
            this.rdType.Location = new System.Drawing.Point(119, 187);
            this.rdType.Name = "rdType";
            this.rdType.Size = new System.Drawing.Size(85, 17);
            this.rdType.TabIndex = 13;
            this.rdType.Text = "Mostrar Tipo";
            this.rdType.UseVisualStyleBackColor = true;
            // 
            // rdManufactor
            // 
            this.rdManufactor.AutoSize = true;
            this.rdManufactor.Location = new System.Drawing.Point(119, 164);
            this.rdManufactor.Name = "rdManufactor";
            this.rdManufactor.Size = new System.Drawing.Size(114, 17);
            this.rdManufactor.TabIndex = 11;
            this.rdManufactor.Text = "Mostrar Fabricante";
            this.rdManufactor.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(182, 307);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(121, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok!";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(309, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 439);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.Windows_Settings_app_icon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 343);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbTheme);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationForm";
            this.Text = "Preferências";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.gbTheme.ResumeLayout(false);
            this.gbTheme.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbTheme;
        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox rdId;
        private System.Windows.Forms.CheckBox rdModel;
        private System.Windows.Forms.CheckBox rdManufactor;
        private System.Windows.Forms.CheckBox rdType;
        private System.Windows.Forms.CheckBox rdYear;
        private System.Windows.Forms.CheckBox rdButtons;
        private System.Windows.Forms.CheckBox rdPrice;
        private System.Windows.Forms.CheckBox rdQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox rdService;
    }
}