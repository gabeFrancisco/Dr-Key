namespace UI.Forms.Services
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.pnModel = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnEditService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelBar = new System.Windows.Forms.Panel();
            this.gpService = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvServices = new System.Windows.Forms.DataGridViewDoubleBuffered();
            this.pnModel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelBar.SuspendLayout();
            this.gpService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteService.BackgroundImage")));
            this.btnDeleteService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteService.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteService.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDeleteService.Location = new System.Drawing.Point(98, 19);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(40, 34);
            this.btnDeleteService.TabIndex = 55;
            this.btnDeleteService.UseVisualStyleBackColor = false;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // pnModel
            // 
            this.pnModel.BackColor = System.Drawing.Color.LightGreen;
            this.pnModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnModel.Controls.Add(this.txtTitle);
            this.pnModel.Controls.Add(this.lbTitle);
            this.pnModel.Location = new System.Drawing.Point(0, 93);
            this.pnModel.Name = "pnModel";
            this.pnModel.Size = new System.Drawing.Size(218, 58);
            this.pnModel.TabIndex = 51;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(43, 16);
            this.lbTitle.TabIndex = 45;
            this.lbTitle.Text = "Título:";
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsReturn = true;
            this.txtTitle.BackColor = System.Drawing.Color.LightGreen;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(3, 18);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(197, 32);
            this.txtTitle.TabIndex = 46;
            this.txtTitle.Text = "...";
            // 
            // btnEditService
            // 
            this.btnEditService.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditService.BackgroundImage")));
            this.btnEditService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditService.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEditService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditService.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEditService.Location = new System.Drawing.Point(52, 19);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(39, 34);
            this.btnEditService.TabIndex = 54;
            this.btnEditService.UseVisualStyleBackColor = false;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddService.BackgroundImage")));
            this.btnAddService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAddService.Location = new System.Drawing.Point(6, 19);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(39, 34);
            this.btnAddService.TabIndex = 53;
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 215);
            this.panel3.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Descrição:";
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.BackColor = System.Drawing.Color.LightGreen;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(2, 18);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(200, 137);
            this.txtDescription.TabIndex = 45;
            this.txtDescription.Text = "...";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGreen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lbPrice);
            this.panel4.Location = new System.Drawing.Point(0, 394);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 25);
            this.panel4.TabIndex = 52;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(43, 2);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(20, 17);
            this.lbPrice.TabIndex = 38;
            this.lbPrice.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Preço:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(415, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 56;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdate.Location = new System.Drawing.Point(144, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(38, 34);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.LightGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(584, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 25);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelBar
            // 
            this.panelBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBar.Controls.Add(this.panel4);
            this.panelBar.Controls.Add(this.pictureBox1);
            this.panelBar.Controls.Add(this.panel3);
            this.panelBar.Controls.Add(this.pnModel);
            this.panelBar.Location = new System.Drawing.Point(-1, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(218, 454);
            this.panelBar.TabIndex = 53;
            // 
            // gpService
            // 
            this.gpService.Controls.Add(this.btnSearch);
            this.gpService.Controls.Add(this.dgvServices);
            this.gpService.Controls.Add(this.txtSearch);
            this.gpService.Controls.Add(this.btnUpdate);
            this.gpService.Controls.Add(this.btnAddService);
            this.gpService.Controls.Add(this.btnEditService);
            this.gpService.Controls.Add(this.btnDeleteService);
            this.gpService.Location = new System.Drawing.Point(223, 12);
            this.gpService.Name = "gpService";
            this.gpService.Size = new System.Drawing.Size(699, 430);
            this.gpService.TabIndex = 55;
            this.gpService.TabStop = false;
            this.gpService.Text = "Lista de Serviços";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeColumns = false;
            this.dgvServices.AllowUserToResizeRows = false;
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServices.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvServices.Location = new System.Drawing.Point(6, 59);
            this.dgvServices.MultiSelect = false;
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(687, 365);
            this.dgvServices.TabIndex = 54;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);
            this.dgvServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellDoubleClick);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.gpService);
            this.Controls.Add(this.panelBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServiceForm";
            this.Text = "Serviços";
            this.pnModel.ResumeLayout(false);
            this.pnModel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelBar.ResumeLayout(false);
            this.gpService.ResumeLayout(false);
            this.gpService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.DataGridViewDoubleBuffered dgvServices;
        internal System.Windows.Forms.Button btnDeleteService;
        internal System.Windows.Forms.Panel pnModel;
        internal System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbTitle;
        internal System.Windows.Forms.Button btnEditService;
        internal System.Windows.Forms.Button btnAddService;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.GroupBox gpService;
    }
}