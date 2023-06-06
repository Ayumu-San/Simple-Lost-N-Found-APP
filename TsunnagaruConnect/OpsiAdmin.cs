using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using TsunnagaruConnect;

namespace TsunnagaruConnect
{
    public partial class OpsiAdmin : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        Koneksi Konn = new Koneksi();

        public OpsiAdmin()
        {
            InitializeComponent();
        }
        void membersihkan()
        {
            TxtNIKOption.Text = "";
            txtNamaOption.Text = "";
            txtPasswordOption.Text = "";
            cmbKelasOption.Text = "";
            TxtJurusanOption.Text = "";
            txtLevelOption.Text = "";
        }
        //void NoOtomatis()//Function to order nis/nik akun secara otomatis
        //{
        //    long hitung;
        //    string urutan;
        //    SqlDataReader rd;
        //    SqlConnection conn = Konn.Getconn();
        //    conn.Open();
        //    cmd = new SqlCommand("select NISAkun from TBL_Account where NISAkun in(select max(NISAkun) from TBL_Account) order by NISAkun desc", conn);
        //    rd = cmd.ExecuteReader();
        //    rd.Read();
        //    if (rd.HasRows)
        //    {
        //        hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NISAkun"].ToString().Length - 3, 3)) + 1;
        //        string kodeurutan = "000" + hitung;
        //        urutan = "541" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
        //    }
        //    else
        //    {
        //        urutan = "001";
        //    }
        //    rd.Close();
        //    TxtNIKOption.Enabled = false;
        //    TxtNIKOption.Text = urutan;
        //    conn.Close();
        //}
        void NoOtomatis() // Fungsi untuk mengatur nomor pesanan secara otomatis
        {
            int hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = Konn.Getconn();
            conn.Open();
            cmd = new SqlCommand("SELECT NISAkun FROM TBL_Account WHERE NISAkun IN (SELECT MAX(NISAkun) FROM TBL_Account) ORDER BY NISAkun DESC", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                int existingNumber = Convert.ToInt32(rd[0].ToString().Substring(3));
                hitung = existingNumber + 1;
            }
            else
            {
                hitung = 0;
            }
            rd.Close();
            string kodeurutan = "000" + hitung;
            urutan = "541" + kodeurutan.Substring(kodeurutan.Length - 3, 3);

            TxtNIKOption.Enabled = false;
            TxtNIKOption.Text = urutan;
            conn.Close();
        }





        void TampilAkun() 
        {

            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select* from TBL_Account", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Account");
                DataGridAccount.DataSource = ds;
                DataGridAccount.DataMember = "TBL_Account";
                DataGridAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        void CariAkun() 
        {

            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select* from TBL_Account where IDBarang like '%" + TxtSearch.Text + "%' or namabarang like '%" + TxtSearch.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Account");
                DataGridAccount.DataSource = ds;
                DataGridAccount.DataMember = "TBL_Account";
                DataGridAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        void opsikelas()
        {
            cmbKelasOption.Items.Add("10");
            cmbKelasOption.Items.Add("11");
            cmbKelasOption.Items.Add("12");
            cmbKelasOption.Items.Add("0");
        }

        private void OpsiAdmin_Load(object sender, EventArgs e)
        {
            TxtNASD.Enabled = false;
            TxtNASD.Text = Username.uname;
            TampilAkun();
            membersihkan();
            opsikelas();
            NoOtomatis();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = MIFUNE-UEHR\\NIJIGASAKIHS; Initial Catalog =DBNyobaCRUD; Integrated Security = True");

            if (TxtNIKOption.Text.Trim() == "" || txtNamaOption.Text.Trim() == "" || txtPasswordOption.Text.Trim() == "" || cmbKelasOption.Text.Trim() == "" || TxtJurusanOption.Text.Trim() == "" || txtLevelOption.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap !");
            }
            else // If the form is not empty
            {
                try // Try to insert data into the database
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into TBL_Account (NISAkun, NamaAkun, PasswordAkun, KelasAKUN, JurusanAkun, LevelAkun) values (@NISAkun, @NamaAkun, @PasswordAkun, @KelasAKUN, @JurusanAkun, @LevelAkun)", conn);
                    cmd.Parameters.AddWithValue("@NISAkun", TxtNIKOption.Text);
                    cmd.Parameters.AddWithValue("@NamaAkun", txtNamaOption.Text);
                    cmd.Parameters.AddWithValue("@PasswordAkun", txtPasswordOption.Text);
                    cmd.Parameters.AddWithValue("@KelasAKUN", cmbKelasOption.Text);
                    cmd.Parameters.AddWithValue("@JurusanAkun", TxtJurusanOption.Text);
                    cmd.Parameters.AddWithValue("@LevelAkun", txtLevelOption.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data berhasil! ");
                    TampilAkun();
                    membersihkan();
                    NoOtomatis();
                }
                catch (Exception ex) // Catch any exception that may occur
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally // Close the connection to the database
                {
                    conn.Close();
                }
            }
        }

        private void DataGridAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DataGridAccount.Rows[e.RowIndex];
                string v = row.Cells["NISAkun"].Value.ToString();
                TxtNIKOption.Text = v;
                txtNamaOption.Text = row.Cells["NamaAkun"].Value.ToString();
                txtPasswordOption.Text = row.Cells["PasswordAkun"].Value.ToString();
                cmbKelasOption.Text = row.Cells["KelasAKUN"].Value.ToString();
                TxtJurusanOption.Text = row.Cells["JurusanAkun"].Value.ToString();
                txtLevelOption.Text = row.Cells["LevelAkun"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtNIKOption.Text.Trim() == "" || txtNamaOption.Text.Trim() == "" || txtPasswordOption.Text.Trim() == "" || cmbKelasOption.Text.Trim() == "" || TxtJurusanOption.Text.Trim() == "" || txtLevelOption.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap !");
            }

            else //klo isi
            {
                SqlConnection conn = Konn.Getconn();
                try //buat nyoba klo ad yg salah dalam pengisian(tp gw masih gayakin/gk mudeng)
                {
                    cmd = new SqlCommand("Update TBL_Account Set NamaAkun='" + txtNamaOption.Text + "', PasswordAkun='" + txtPasswordOption.Text + "', KelasAKUN='" + cmbKelasOption.Text + "', JurusanAkun='" + TxtJurusanOption.Text + "', LevelAkun='" + txtLevelOption.Text + "' where NISAkun='" + TxtNIKOption.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Data berhasil! ");
                    TampilAkun();
                    membersihkan();
                    NoOtomatis();

                }
                catch (Exception X)//kalau ada data yang tidak sesuai dengan protokol pada database, maka akan muncul x.ToString(tp gw masih gayakin/gk mudeng)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah mimin yakin untuk menghapus akun? :" + txtNamaOption.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.Getconn();
                {
                    cmd = new SqlCommand("Delete TBL_Account where NISAkun='" + TxtNIKOption.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hapus akun berhasil! ");
                    TampilAkun();
                    membersihkan();
                    NoOtomatis();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            membersihkan();
            NoOtomatis();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            CariAkun();
        }
    }
}
