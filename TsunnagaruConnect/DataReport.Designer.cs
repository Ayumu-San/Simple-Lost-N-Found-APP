namespace TsunnagaruConnect
{
    partial class DataReport
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
            this.DataViewTake = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataViewReport = new System.Windows.Forms.DataGridView();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtKode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCfm = new System.Windows.Forms.Button();
            this.TxtIDLaporan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSearchLNT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewTake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataViewTake
            // 
            this.DataViewTake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewTake.Location = new System.Drawing.Point(13, 166);
            this.DataViewTake.Name = "DataViewTake";
            this.DataViewTake.RowHeadersWidth = 62;
            this.DataViewTake.RowTemplate.Height = 28;
            this.DataViewTake.Size = new System.Drawing.Size(275, 456);
            this.DataViewTake.TabIndex = 0;
            this.DataViewTake.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewTake_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Take List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Report List";
            // 
            // DataViewReport
            // 
            this.DataViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewReport.Location = new System.Drawing.Point(366, 166);
            this.DataViewReport.Name = "DataViewReport";
            this.DataViewReport.RowHeadersWidth = 62;
            this.DataViewReport.RowTemplate.Height = 28;
            this.DataViewReport.Size = new System.Drawing.Size(277, 456);
            this.DataViewReport.TabIndex = 3;
            this.DataViewReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewReport_CellClick);
            this.DataViewReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewReport_CellContentClick);
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(110, 42);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(239, 26);
            this.TxtUser.TabIndex = 4;
            // 
            // TxtKode
            // 
            this.TxtKode.Location = new System.Drawing.Point(110, 74);
            this.TxtKode.Name = "TxtKode";
            this.TxtKode.Size = new System.Drawing.Size(180, 26);
            this.TxtKode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Barang";
            // 
            // BtnCfm
            // 
            this.BtnCfm.Location = new System.Drawing.Point(538, 90);
            this.BtnCfm.Name = "BtnCfm";
            this.BtnCfm.Size = new System.Drawing.Size(105, 31);
            this.BtnCfm.TabIndex = 8;
            this.BtnCfm.Text = "Confirm";
            this.BtnCfm.UseVisualStyleBackColor = true;
            this.BtnCfm.Click += new System.EventHandler(this.BtnCfm_Click);
            // 
            // TxtIDLaporan
            // 
            this.TxtIDLaporan.Location = new System.Drawing.Point(110, 10);
            this.TxtIDLaporan.Name = "TxtIDLaporan";
            this.TxtIDLaporan.Size = new System.Drawing.Size(180, 26);
            this.TxtIDLaporan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Laporan";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(538, 127);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(105, 31);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSearchLNT);
            this.groupBox1.Location = new System.Drawing.Point(379, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 65);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian Kode/Nama Barang";
            // 
            // TxtSearchLNT
            // 
            this.TxtSearchLNT.Location = new System.Drawing.Point(7, 25);
            this.TxtSearchLNT.Name = "TxtSearchLNT";
            this.TxtSearchLNT.Size = new System.Drawing.Size(252, 26);
            this.TxtSearchLNT.TabIndex = 0;
            // 
            // DataReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(663, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtIDLaporan);
            this.Controls.Add(this.BtnCfm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKode);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.DataViewReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataViewTake);
            this.Name = "DataReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataReport";
            this.Load += new System.EventHandler(this.DataReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewTake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataViewTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataViewReport;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtKode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCfm;
        private System.Windows.Forms.TextBox TxtIDLaporan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSearchLNT;
    }
}