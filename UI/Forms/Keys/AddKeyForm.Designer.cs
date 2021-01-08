namespace UI
{
    partial class AddKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddKeyForm));
            this.btnAddKey = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtButtons = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbManufactor = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbNewKey = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbNewKey.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddKey
            // 
            this.btnAddKey.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddKey.Location = new System.Drawing.Point(6, 378);
            this.btnAddKey.Name = "btnAddKey";
            this.btnAddKey.Size = new System.Drawing.Size(186, 23);
            this.btnAddKey.TabIndex = 10;
            this.btnAddKey.Text = "Nova Chave";
            this.btnAddKey.UseVisualStyleBackColor = false;
            this.btnAddKey.Click += new System.EventHandler(this.btnAddKey_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadImage.Location = new System.Drawing.Point(230, 238);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(34, 21);
            this.btnLoadImage.TabIndex = 9;
            this.btnLoadImage.Text = "...";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.Color.White;
            this.txtImage.Location = new System.Drawing.Point(79, 238);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(145, 20);
            this.txtImage.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Imagem";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(211, 205);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(53, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Valor R$";
            // 
            // txtQte
            // 
            this.txtQte.BackColor = System.Drawing.Color.White;
            this.txtQte.Location = new System.Drawing.Point(79, 205);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(72, 20);
            this.txtQte.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Quantidade";
            // 
            // txtButtons
            // 
            this.txtButtons.BackColor = System.Drawing.Color.White;
            this.txtButtons.Location = new System.Drawing.Point(203, 169);
            this.txtButtons.Name = "txtButtons";
            this.txtButtons.Size = new System.Drawing.Size(61, 20);
            this.txtButtons.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Botões";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.Location = new System.Drawing.Point(79, 169);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(72, 20);
            this.txtYear.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ano";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.White;
            this.txtModel.Location = new System.Drawing.Point(79, 136);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(185, 20);
            this.txtModel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Modelo";
            // 
            // cbManufactor
            // 
            this.cbManufactor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbManufactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManufactor.FormattingEnabled = true;
            this.cbManufactor.Items.AddRange(new object[] {
            "Chevrolet",
            "Fiat",
            "Volkswagen",
            "Ford",
            "Renault",
            "Peugeot",
            "Citroen",
            "Hyundai",
            "Kia",
            "Toyota",
            "Honda",
            "Jeep",
            "Audi",
            "Mercedes-Benz",
            "Suzuki",
            "Nissan",
            "Mitsubishi",
            "BMW",
            "Land Rover",
            "Lexus",
            "Volvo",
            "Mini",
            "Porsche",
            "Dodge",
            "Subaru",
            "Chery",
            "Alfa Romeo",
            "Yamaha",
            "Kawasaki",
            "Dafra",
            "Kasinski",
            "Triumph",
            "Ducati",
            "KTM",
            "Scania",
            "Iveco",
            "MAN",
            "Agrale"});
            this.cbManufactor.Location = new System.Drawing.Point(79, 35);
            this.cbManufactor.Name = "cbManufactor";
            this.cbManufactor.Size = new System.Drawing.Size(185, 21);
            this.cbManufactor.TabIndex = 1;
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Seca",
            "Cabo da Chave",
            "Canivete",
            "Presencial",
            "Capa",
            "Alarme"});
            this.cbType.Location = new System.Drawing.Point(79, 69);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(185, 21);
            this.cbType.TabIndex = 2;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fabricante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // gbNewKey
            // 
            this.gbNewKey.Controls.Add(this.label6);
            this.gbNewKey.Controls.Add(this.cbService);
            this.gbNewKey.Controls.Add(this.label1);
            this.gbNewKey.Controls.Add(this.txtObservation);
            this.gbNewKey.Controls.Add(this.btnClose);
            this.gbNewKey.Controls.Add(this.cbManufactor);
            this.gbNewKey.Controls.Add(this.txtButtons);
            this.gbNewKey.Controls.Add(this.label7);
            this.gbNewKey.Controls.Add(this.label8);
            this.gbNewKey.Controls.Add(this.btnAddKey);
            this.gbNewKey.Controls.Add(this.txtYear);
            this.gbNewKey.Controls.Add(this.label2);
            this.gbNewKey.Controls.Add(this.txtQte);
            this.gbNewKey.Controls.Add(this.btnLoadImage);
            this.gbNewKey.Controls.Add(this.label5);
            this.gbNewKey.Controls.Add(this.label3);
            this.gbNewKey.Controls.Add(this.label9);
            this.gbNewKey.Controls.Add(this.txtImage);
            this.gbNewKey.Controls.Add(this.txtModel);
            this.gbNewKey.Controls.Add(this.cbType);
            this.gbNewKey.Controls.Add(this.txtPrice);
            this.gbNewKey.Controls.Add(this.label10);
            this.gbNewKey.Controls.Add(this.label4);
            this.gbNewKey.Location = new System.Drawing.Point(170, 8);
            this.gbNewKey.Name = "gbNewKey";
            this.gbNewKey.Size = new System.Drawing.Size(285, 409);
            this.gbNewKey.TabIndex = 18;
            this.gbNewKey.TabStop = false;
            this.gbNewKey.Text = "Nova Chave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Serviço";
            // 
            // cbService
            // 
            this.cbService.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.FormattingEnabled = true;
            this.cbService.Items.AddRange(new object[] {
            "Confecção",
            "Cópia"});
            this.cbService.Location = new System.Drawing.Point(79, 102);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(185, 21);
            this.cbService.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Observações";
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(6, 290);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(272, 82);
            this.txtObservation.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(198, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Cancelar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 431);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // AddKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbNewKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddKeyForm";
            this.Text = "Nova Chave";
            this.Load += new System.EventHandler(this.AddKeyForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddKeyForm_KeyDown);
            this.gbNewKey.ResumeLayout(false);
            this.gbNewKey.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button btnAddKey;
        internal System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtButtons;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbManufactor;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.GroupBox gbNewKey;
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbService;
    }
}