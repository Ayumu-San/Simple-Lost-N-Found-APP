using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TsunnagaruConnect;

namespace TsunnagaruConnect
{       
    public partial class LoginPage : Form
    {

        private SqlCommand cmd;
        DataSet ds;
        private SqlDataAdapter da;              
        private SqlDataReader rd;
        Koneksi Konn = new Koneksi();


        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            MunculOpsi();
        }

        void MunculOpsi()
        {
            CMBRoleLgn.Items.Add("Admin");
            CMBRoleLgn.Items.Add("User");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtNISLgn.Text.Trim() == "" || txtNamaLgn.Text.Trim() == "" || TxtPasswordLgn.Text.Trim() == "" || CMBRoleLgn.Text.Trim() == "")
            {
                MessageBox.Show("Data akun belum lengkap!");
            }
            else
            {
                SqlConnection conn = Konn.Getconn();
                conn.Open();

                string levelAkun = CMBRoleLgn.Text.Trim();
                string query = "SELECT * FROM TBL_Account WHERE NISAkun = @NIS AND NamaAkun = @Nama AND PasswordAkun = @Password";

                if (levelAkun == "Admin")
                {
                    query += " AND LevelAkun = 'Admin'";
                }
                else if (levelAkun == "User")
                {
                    query += " AND LevelAkun = 'User'";
                }
                else
                {
                    MessageBox.Show("Level akun tidak valid!");
                    return;
                }

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NIS", TxtNISLgn.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNamaLgn.Text);
                cmd.Parameters.AddWithValue("@Password", TxtPasswordLgn.Text);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        if (levelAkun == "Admin")
                        {
                            ForLog.type = "A";
                        }
                        else if (levelAkun == "User")
                        {
                            ForLog.type = "U";
                        }

                        Username.uname = txtNamaLgn.Text;
                        string log = txtNamaLgn.Text;
                        HomePage homepeeji = new HomePage(log);
                        this.Hide();
                        homepeeji.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kombinasi NIS, Nama, dan Password tidak cocok/valid untuk role akun " + levelAkun);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan dalam pengambilan data: " + ex.Message);
                }
            }
        }
    }
}
