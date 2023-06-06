namespace TsunnagaruConnect
{
    partial class LoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNISLgn = new System.Windows.Forms.TextBox();
            this.txtNamaLgn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPasswordLgn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CMBRoleLgn = new System.Windows.Forms.ComboBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIS";
            // 
            // TxtNISLgn
            // 
            this.TxtNISLgn.Location = new System.Drawing.Point(44, 36);
            this.TxtNISLgn.Name = "TxtNISLgn";
            this.TxtNISLgn.Size = new System.Drawing.Size(193, 26);
            this.TxtNISLgn.TabIndex = 1;
            // 
            // txtNamaLgn
            // 
            this.txtNamaLgn.Location = new System.Drawing.Point(44, 90);
            this.txtNamaLgn.Name = "txtNamaLgn";
            this.txtNamaLgn.Size = new System.Drawing.Size(367, 26);
            this.txtNamaLgn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // TxtPasswordLgn
            // 
            this.TxtPasswordLgn.Location = new System.Drawing.Point(44, 145);
            this.TxtPasswordLgn.Name = "TxtPasswordLgn";
            this.TxtPasswordLgn.Size = new System.Drawing.Size(367, 26);
            this.TxtPasswordLgn.TabIndex = 5;
            this.TxtPasswordLgn.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Role";
            // 
            // CMBRoleLgn
            // 
            this.CMBRoleLgn.FormattingEnabled = true;
            this.CMBRoleLgn.Location = new System.Drawing.Point(44, 204);
            this.CMBRoleLgn.Name = "CMBRoleLgn";
            this.CMBRoleLgn.Size = new System.Drawing.Size(193, 28);
            this.CMBRoleLgn.TabIndex = 7;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(336, 256);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 31);
            this.BtnRefresh.TabIndex = 8;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(336, 293);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 31);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 356);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.CMBRoleLgn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPasswordLgn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamaLgn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNISLgn);
            this.Controls.Add(this.label1);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNISLgn;
        private System.Windows.Forms.TextBox txtNamaLgn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPasswordLgn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CMBRoleLgn;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnLogin;
    }
}