namespace TsunnagaruConnect
{
    partial class OpsiAdmin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.DataGridAccount = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNIKOption = new System.Windows.Forms.TextBox();
            this.txtNamaOption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordOption = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtJurusanOption = new System.Windows.Forms.TextBox();
            this.txtLevelOption = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKelasOption = new System.Windows.Forms.ComboBox();
            this.TxtNASD = new System.Windows.Forms.TextBox();
            this.LblWlcom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSearch);
            this.groupBox1.Location = new System.Drawing.Point(577, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 65);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian ID/Nama Akun";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(7, 25);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(344, 26);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 367);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 38);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(12, 411);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(109, 38);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 38);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(12, 286);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(109, 39);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // DataGridAccount
            // 
            this.DataGridAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAccount.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGridAccount.Location = new System.Drawing.Point(127, 286);
            this.DataGridAccount.Name = "DataGridAccount";
            this.DataGridAccount.RowHeadersWidth = 62;
            this.DataGridAccount.RowTemplate.Height = 28;
            this.DataGridAccount.Size = new System.Drawing.Size(807, 276);
            this.DataGridAccount.TabIndex = 12;
            this.DataGridAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAccount_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "NIS";
            // 
            // TxtNIKOption
            // 
            this.TxtNIKOption.Location = new System.Drawing.Point(127, 108);
            this.TxtNIKOption.Name = "TxtNIKOption";
            this.TxtNIKOption.Size = new System.Drawing.Size(115, 26);
            this.TxtNIKOption.TabIndex = 19;
            // 
            // txtNamaOption
            // 
            this.txtNamaOption.Location = new System.Drawing.Point(127, 140);
            this.txtNamaOption.Name = "txtNamaOption";
            this.txtNamaOption.Size = new System.Drawing.Size(399, 26);
            this.txtNamaOption.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nama";
            // 
            // txtPasswordOption
            // 
            this.txtPasswordOption.Location = new System.Drawing.Point(127, 172);
            this.txtPasswordOption.Name = "txtPasswordOption";
            this.txtPasswordOption.Size = new System.Drawing.Size(402, 26);
            this.txtPasswordOption.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kelas";
            // 
            // TxtJurusanOption
            // 
            this.TxtJurusanOption.Location = new System.Drawing.Point(252, 204);
            this.TxtJurusanOption.Name = "TxtJurusanOption";
            this.TxtJurusanOption.Size = new System.Drawing.Size(161, 26);
            this.TxtJurusanOption.TabIndex = 25;
            // 
            // txtLevelOption
            // 
            this.txtLevelOption.Location = new System.Drawing.Point(127, 236);
            this.txtLevelOption.Name = "txtLevelOption";
            this.txtLevelOption.Size = new System.Drawing.Size(115, 26);
            this.txtLevelOption.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Level Akun";
            // 
            // cmbKelasOption
            // 
            this.cmbKelasOption.FormattingEnabled = true;
            this.cmbKelasOption.Location = new System.Drawing.Point(127, 204);
            this.cmbKelasOption.Name = "cmbKelasOption";
            this.cmbKelasOption.Size = new System.Drawing.Size(121, 28);
            this.cmbKelasOption.TabIndex = 28;
            // 
            // TxtNASD
            // 
            this.TxtNASD.Location = new System.Drawing.Point(805, 32);
            this.TxtNASD.Name = "TxtNASD";
            this.TxtNASD.Size = new System.Drawing.Size(123, 26);
            this.TxtNASD.TabIndex = 32;
            // 
            // LblWlcom
            // 
            this.LblWlcom.AutoSize = true;
            this.LblWlcom.Location = new System.Drawing.Point(813, 9);
            this.LblWlcom.Name = "LblWlcom";
            this.LblWlcom.Size = new System.Drawing.Size(121, 20);
            this.LblWlcom.TabIndex = 31;
            this.LblWlcom.Text = "Welcome back! ";
            // 
            // OpsiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 574);
            this.Controls.Add(this.TxtNASD);
            this.Controls.Add(this.cmbKelasOption);
            this.Controls.Add(this.LblWlcom);
            this.Controls.Add(this.txtLevelOption);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtJurusanOption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPasswordOption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamaOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNIKOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.DataGridAccount);
            this.Name = "OpsiAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpsiAdmin";
            this.Load += new System.EventHandler(this.OpsiAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView DataGridAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNIKOption;
        private System.Windows.Forms.TextBox txtNamaOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordOption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtJurusanOption;
        private System.Windows.Forms.TextBox txtLevelOption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKelasOption;
        private System.Windows.Forms.TextBox TxtNASD;
        private System.Windows.Forms.Label LblWlcom;
    }
}