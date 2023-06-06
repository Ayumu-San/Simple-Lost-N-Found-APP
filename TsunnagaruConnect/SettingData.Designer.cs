namespace TsunnagaruConnect
{
    partial class SettingData
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Simpan = new System.Windows.Forms.Button();
            this.Txt_Kode = new System.Windows.Forms.TextBox();
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSearchBrg = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.PictBRG = new System.Windows.Forms.PictureBox();
            this.Cmb_Box_Jenis = new System.Windows.Forms.ComboBox();
            this.TxtWaktu = new System.Windows.Forms.TextBox();
            this.TxtTempat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNASD = new System.Windows.Forms.TextBox();
            this.LblWlcom = new System.Windows.Forms.Label();
            this.TxtDetail = new System.Windows.Forms.TextBox();
            this.TanggalPick = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.DataGridUser = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtSearchUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictBRG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUser)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(16, 486);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(757, 552);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jenis Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tempat Ditemukan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Waktu Ditemukan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Detail Barang";
            // 
            // Simpan
            // 
            this.Simpan.Location = new System.Drawing.Point(17, 439);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(107, 39);
            this.Simpan.TabIndex = 7;
            this.Simpan.Text = "Simpan";
            this.Simpan.UseVisualStyleBackColor = true;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Txt_Kode
            // 
            this.Txt_Kode.Location = new System.Drawing.Point(12, 32);
            this.Txt_Kode.Name = "Txt_Kode";
            this.Txt_Kode.Size = new System.Drawing.Size(98, 26);
            this.Txt_Kode.TabIndex = 1;
            // 
            // TxtNama
            // 
            this.TxtNama.Location = new System.Drawing.Point(124, 32);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(416, 26);
            this.TxtNama.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(131, 439);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 38);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(246, 439);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(109, 38);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(361, 439);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 38);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSearchBrg);
            this.groupBox1.Location = new System.Drawing.Point(689, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 65);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian Kode/Nama Barang";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtSearchBrg
            // 
            this.TxtSearchBrg.Location = new System.Drawing.Point(7, 25);
            this.TxtSearchBrg.Name = "TxtSearchBrg";
            this.TxtSearchBrg.Size = new System.Drawing.Size(344, 26);
            this.TxtSearchBrg.TabIndex = 0;
            this.TxtSearchBrg.TextChanged += new System.EventHandler(this.TxtSearchBrg_TextChanged);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBrowse.Location = new System.Drawing.Point(842, 302);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(193, 35);
            this.BtnBrowse.TabIndex = 13;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // PictBRG
            // 
            this.PictBRG.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PictBRG.Location = new System.Drawing.Point(842, 115);
            this.PictBRG.Name = "PictBRG";
            this.PictBRG.Size = new System.Drawing.Size(193, 191);
            this.PictBRG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictBRG.TabIndex = 14;
            this.PictBRG.TabStop = false;
            // 
            // Cmb_Box_Jenis
            // 
            this.Cmb_Box_Jenis.FormattingEnabled = true;
            this.Cmb_Box_Jenis.Location = new System.Drawing.Point(124, 84);
            this.Cmb_Box_Jenis.Name = "Cmb_Box_Jenis";
            this.Cmb_Box_Jenis.Size = new System.Drawing.Size(272, 28);
            this.Cmb_Box_Jenis.TabIndex = 15;
            // 
            // TxtWaktu
            // 
            this.TxtWaktu.Location = new System.Drawing.Point(342, 190);
            this.TxtWaktu.Name = "TxtWaktu";
            this.TxtWaktu.Size = new System.Drawing.Size(111, 26);
            this.TxtWaktu.TabIndex = 27;
            // 
            // TxtTempat
            // 
            this.TxtTempat.Location = new System.Drawing.Point(124, 138);
            this.TxtTempat.Name = "TxtTempat";
            this.TxtTempat.Size = new System.Drawing.Size(212, 26);
            this.TxtTempat.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(890, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Foto Barang";
            // 
            // TxtNASD
            // 
            this.TxtNASD.Location = new System.Drawing.Point(912, 32);
            this.TxtNASD.Name = "TxtNASD";
            this.TxtNASD.Size = new System.Drawing.Size(123, 26);
            this.TxtNASD.TabIndex = 30;
            this.TxtNASD.TextChanged += new System.EventHandler(this.TxtNASD_TextChanged);
            // 
            // LblWlcom
            // 
            this.LblWlcom.AutoSize = true;
            this.LblWlcom.Location = new System.Drawing.Point(920, 9);
            this.LblWlcom.Name = "LblWlcom";
            this.LblWlcom.Size = new System.Drawing.Size(121, 20);
            this.LblWlcom.TabIndex = 29;
            this.LblWlcom.Text = "Welcome back! ";
            // 
            // TxtDetail
            // 
            this.TxtDetail.Location = new System.Drawing.Point(124, 242);
            this.TxtDetail.Multiline = true;
            this.TxtDetail.Name = "TxtDetail";
            this.TxtDetail.Size = new System.Drawing.Size(641, 89);
            this.TxtDetail.TabIndex = 57;
            // 
            // TanggalPick
            // 
            this.TanggalPick.Location = new System.Drawing.Point(124, 190);
            this.TanggalPick.Name = "TanggalPick";
            this.TanggalPick.Size = new System.Drawing.Size(212, 26);
            this.TanggalPick.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Pelapor";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(124, 357);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(329, 26);
            this.TxtUser.TabIndex = 62;
            // 
            // DataGridUser
            // 
            this.DataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUser.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGridUser.Location = new System.Drawing.Point(779, 486);
            this.DataGridUser.Name = "DataGridUser";
            this.DataGridUser.RowHeadersWidth = 62;
            this.DataGridUser.RowTemplate.Height = 28;
            this.DataGridUser.Size = new System.Drawing.Size(267, 552);
            this.DataGridUser.TabIndex = 63;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtSearchUser);
            this.groupBox2.Location = new System.Drawing.Point(689, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 65);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pencarian Kode/Nama User";
            // 
            // TxtSearchUser
            // 
            this.TxtSearchUser.Location = new System.Drawing.Point(7, 25);
            this.TxtSearchUser.Name = "TxtSearchUser";
            this.TxtSearchUser.Size = new System.Drawing.Size(344, 26);
            this.TxtSearchUser.TabIndex = 0;
            this.TxtSearchUser.TextChanged += new System.EventHandler(this.TxtSearchUser_TextChanged);
            // 
            // SettingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1058, 1050);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DataGridUser);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TanggalPick);
            this.Controls.Add(this.TxtDetail);
            this.Controls.Add(this.TxtNASD);
            this.Controls.Add(this.LblWlcom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtWaktu);
            this.Controls.Add(this.TxtTempat);
            this.Controls.Add(this.Cmb_Box_Jenis);
            this.Controls.Add(this.PictBRG);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.TxtNama);
            this.Controls.Add(this.Txt_Kode);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SettingData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Data C# DB SQL SERVER";
            this.Load += new System.EventHandler(this.SettingData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictBRG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUser)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Simpan;
        private System.Windows.Forms.TextBox Txt_Kode;
        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSearchBrg;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.PictureBox PictBRG;
        private System.Windows.Forms.ComboBox Cmb_Box_Jenis;
        private System.Windows.Forms.TextBox TxtWaktu;
        private System.Windows.Forms.TextBox TxtTempat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNASD;
        private System.Windows.Forms.Label LblWlcom;
        private System.Windows.Forms.TextBox TxtDetail;
        private System.Windows.Forms.TextBox TanggalPick;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.DataGridView DataGridUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtSearchUser;
    }
}

