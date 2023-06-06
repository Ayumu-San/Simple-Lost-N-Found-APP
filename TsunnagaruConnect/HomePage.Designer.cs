namespace TsunnagaruConnect
{
    partial class HomePage
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
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.btnFound = new System.Windows.Forms.Button();
            this.btnLost = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAccountSetting = new System.Windows.Forms.Button();
            this.LblWlcom = new System.Windows.Forms.Label();
            this.btnAdminSetData = new System.Windows.Forms.Button();
            this.TxtNamaAkun = new System.Windows.Forms.TextBox();
            this.BtnSetDatLost = new System.Windows.Forms.Button();
            this.BtnSetRep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(713, 44);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(75, 34);
            this.BtnLogOut.TabIndex = 11;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btnFound
            // 
            this.btnFound.Location = new System.Drawing.Point(264, 98);
            this.btnFound.Name = "btnFound";
            this.btnFound.Size = new System.Drawing.Size(276, 41);
            this.btnFound.TabIndex = 12;
            this.btnFound.Text = "Found";
            this.btnFound.UseVisualStyleBackColor = true;
            this.btnFound.Click += new System.EventHandler(this.btnFound_Click);
            // 
            // btnLost
            // 
            this.btnLost.Location = new System.Drawing.Point(264, 145);
            this.btnLost.Name = "btnLost";
            this.btnLost.Size = new System.Drawing.Size(276, 41);
            this.btnLost.TabIndex = 13;
            this.btnLost.Text = "Lost";
            this.btnLost.UseVisualStyleBackColor = true;
            this.btnLost.Click += new System.EventHandler(this.btnLost_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(264, 192);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(276, 41);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "List n Take";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAccountSetting
            // 
            this.btnAccountSetting.Location = new System.Drawing.Point(264, 239);
            this.btnAccountSetting.Name = "btnAccountSetting";
            this.btnAccountSetting.Size = new System.Drawing.Size(276, 41);
            this.btnAccountSetting.TabIndex = 15;
            this.btnAccountSetting.Text = "Account Setting";
            this.btnAccountSetting.UseVisualStyleBackColor = true;
            this.btnAccountSetting.Click += new System.EventHandler(this.BtnAdminOP_Click);
            // 
            // LblWlcom
            // 
            this.LblWlcom.AutoSize = true;
            this.LblWlcom.Location = new System.Drawing.Point(526, 15);
            this.LblWlcom.Name = "LblWlcom";
            this.LblWlcom.Size = new System.Drawing.Size(121, 20);
            this.LblWlcom.TabIndex = 16;
            this.LblWlcom.Text = "Welcome back! ";
            // 
            // btnAdminSetData
            // 
            this.btnAdminSetData.Location = new System.Drawing.Point(264, 286);
            this.btnAdminSetData.Name = "btnAdminSetData";
            this.btnAdminSetData.Size = new System.Drawing.Size(276, 41);
            this.btnAdminSetData.TabIndex = 17;
            this.btnAdminSetData.Text = "Setting Data Found";
            this.btnAdminSetData.UseVisualStyleBackColor = true;
            this.btnAdminSetData.Click += new System.EventHandler(this.btnAdminSetData_Click);
            // 
            // TxtNamaAkun
            // 
            this.TxtNamaAkun.Location = new System.Drawing.Point(653, 12);
            this.TxtNamaAkun.Name = "TxtNamaAkun";
            this.TxtNamaAkun.Size = new System.Drawing.Size(135, 26);
            this.TxtNamaAkun.TabIndex = 18;
            this.TxtNamaAkun.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnSetDatLost
            // 
            this.BtnSetDatLost.Location = new System.Drawing.Point(264, 333);
            this.BtnSetDatLost.Name = "BtnSetDatLost";
            this.BtnSetDatLost.Size = new System.Drawing.Size(276, 41);
            this.BtnSetDatLost.TabIndex = 19;
            this.BtnSetDatLost.Text = "Setting Data Lost";
            this.BtnSetDatLost.UseVisualStyleBackColor = true;
            this.BtnSetDatLost.Click += new System.EventHandler(this.BtnSetDatLost_Click);
            // 
            // BtnSetRep
            // 
            this.BtnSetRep.Location = new System.Drawing.Point(264, 380);
            this.BtnSetRep.Name = "BtnSetRep";
            this.BtnSetRep.Size = new System.Drawing.Size(276, 41);
            this.BtnSetRep.TabIndex = 20;
            this.BtnSetRep.Text = "Setting Data Report";
            this.BtnSetRep.UseVisualStyleBackColor = true;
            this.BtnSetRep.Click += new System.EventHandler(this.BtnSetRep_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSetRep);
            this.Controls.Add(this.BtnSetDatLost);
            this.Controls.Add(this.TxtNamaAkun);
            this.Controls.Add(this.btnAdminSetData);
            this.Controls.Add(this.LblWlcom);
            this.Controls.Add(this.btnAccountSetting);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnLost);
            this.Controls.Add(this.btnFound);
            this.Controls.Add(this.BtnLogOut);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button btnFound;
        private System.Windows.Forms.Button btnLost;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAccountSetting;
        private System.Windows.Forms.Label LblWlcom;
        private System.Windows.Forms.Button btnAdminSetData;
        public System.Windows.Forms.TextBox TxtNamaAkun;
        private System.Windows.Forms.Button BtnSetDatLost;
        private System.Windows.Forms.Button BtnSetRep;
    }
}