using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TsunnagaruConnect
{
    public partial class ListNTakeForm : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        Koneksi Konn = new Koneksi();
        public ListNTakeForm()
        {
            InitializeComponent();
        }

        private void ListNTakeForm_Load(object sender, EventArgs e)
        {
            Tutup();
            IDReportOtomatis();
            IDtakeOtomatis();
            TampilBarangLost();
            TampilBarangFound();
            TxtNALNT.Text = Username.uname;
        }
        private void TxtSearchLNT_TextChanged(object sender, EventArgs e)
        {
            CariBarangFound();
            CariBarangLost();
        }

        void Bersihkan()
        {
            Txt_Kode.Text = "";
            TxtNama.Text = "";
            txtJenis.Text = "";
            TxtTempat.Text = "";
            TanggalPicak.Text = "";
            TxtWaktu.Text = "";
            TxtDetail.Text = "";
            PictBRG.ImageLocation = null;
        }
        void Tutup()
        {
            Txt_Kode.Enabled = false;
            TxtNALNT.Enabled = false;
            TxtNama.Enabled = false;
            txtJenis.Enabled = false;
            TxtTempat.Enabled = false;
            TanggalPicak.Enabled = false;
            TxtWaktu.Enabled = false;
            TxtDetail.Enabled = false;
            TxtPemilik.Enabled = false;
            TxtIDtake.Enabled = false;
            TxtIDReport.Enabled = false;
        }
        void IDtakeOtomatis()//Function to order kode barang secara otomatis
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = Konn.Getconn();
            conn.Open();
            cmd = new SqlCommand("select IDTake from TBL_Take where IDTake in(select max(IDTake) from TBL_Take) order by IDTake desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IDTake"].ToString().Length - 3, 3)) + 1;
                string kodeurutan = "000" + hitung;
                urutan = "Tke" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
            }
            else
            {
                urutan = "Tke001";
            }
            rd.Close();
            TxtIDtake.Enabled = false;
            TxtIDtake.Text = urutan;
            conn.Close();
        }
        void IDReportOtomatis()//Function to order kode barang secara otomatis
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = Konn.Getconn();
            conn.Open();
            cmd = new SqlCommand("select IDReport from TBL_Report where IDReport in(select max(IDReport) from TBL_Report) order by IDReport desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IDReport"].ToString().Length - 3, 3)) + 1;
                string kodeurutan = "000" + hitung;
                urutan = "Rpt" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
            }
            else
            {
                urutan = "Rpt001";
            }
            rd.Close();
            TxtIDReport.Enabled = false;
            TxtIDReport.Text = urutan;
            conn.Close();
        }
        void TampilBarangFound() //mengambil data barang pada database
                                 //untuk refresh agar data yang diinsert langsung muncul
        {
            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_Founds", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Founds");
                dataGridFOUND.DataSource = ds;
                dataGridFOUND.DataMember = "TBL_Founds";
                dataGridFOUND.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                cmd = new SqlCommand("Select * from TBL_Losts", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
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
        void TampilBarangLost() //mengambil data barang pada database
                                //untuk refresh agar data yang diinsert langsung muncul
        {
            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_Losts", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Losts");
                dataGridLOST.DataSource = ds;
                dataGridLOST.DataMember = "TBL_Losts";
                dataGridLOST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                cmd = new SqlCommand("Select * from TBL_Losts", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
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
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        void CariBarangFound() //mengambil data barang pada database
                               //untuk refresh agar data yang diinsert langsung muncul
        {

            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select* from TBL_FOUNDS where IDBarang like '%" + TxtSearchLNT.Text + "%' or namabarang like '%" + TxtSearchLNT.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_FOUNDS");
                dataGridFOUND.DataSource = ds;
                dataGridFOUND.DataMember = "TBL_FOUNDS";
                dataGridFOUND.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        void CariBarangLost() //mengambil data barang pada database
                              //untuk refresh agar data yang diinsert langsung muncul
        {

            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select* from TBL_Losts where IDBarang like '%" + TxtSearchLNT.Text + "%' or namabarang like '%" + TxtSearchLNT.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Losts");
                dataGridLOST.DataSource = ds;
                dataGridLOST.DataMember = "TBL_Losts";
                dataGridLOST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        //=========================FOUND==============================================
        private void dataGridLNT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridFOUND.Rows[e.RowIndex];
                    Txt_Kode.Text = row.Cells["IDBarang"].Value.ToString();
                    TxtNama.Text = row.Cells["NamaBarang"].Value.ToString();
                    txtJenis.Text = row.Cells["JenisBarang"].Value.ToString();
                    TxtTempat.Text = row.Cells["TempatPenemuan"].Value.ToString();
                    TanggalPicak.Text = row.Cells["TanggalPenemuan"].Value.ToString();
                    TxtWaktu.Text = row.Cells["WaktuPenemuan"].Value.ToString();
                    TxtDetail.Text = row.Cells["DetailBarang"].Value.ToString();
                    TxtPemilik.Text = "";

                    string idBarang = row.Cells["IDBarang"].Value.ToString();
                    using (SqlConnection connection = new SqlConnection("Data Source = MIFUNE-UEHR\\NIJIGASAKIHS; Initial Catalog =DBNyobaCRUD; Integrated Security = True"))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("SELECT FotoBarang FROM TBL_Founds WHERE IDBarang = @ID", connection);
                        cmd.Parameters.AddWithValue("@ID", idBarang);
                        byte[] imageBytes = (byte[])cmd.ExecuteScalar();
                        if (imageBytes != null)
                        {
                            Image image = byteArrayToImage(imageBytes);
                            PictBRG.Image = image;
                        }
                        else
                        {
                            // Handle the case when no image is found for the selected row
                            PictBRG.Image = null; // Clear the PictureBox
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //===========================LOST===========================================
        private void dataGridLOST_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridLOST.Rows[e.RowIndex];
                    Txt_Kode.Text = row.Cells["IDBarang"].Value.ToString();
                    TxtNama.Text = row.Cells["NamaBarang"].Value.ToString();
                    txtJenis.Text = row.Cells["JenisBarang"].Value.ToString();
                    TxtTempat.Text = row.Cells["TempatTerakhir"].Value.ToString();
                    TanggalPicak.Text = row.Cells["Tanggal"].Value.ToString();
                    TxtWaktu.Text = row.Cells["WaktuHilang"].Value.ToString();
                    TxtDetail.Text = row.Cells["DetailBarang"].Value.ToString();
                    TxtPemilik.Text = row.Cells["Pemilik"].Value.ToString();

                    string idBarang = row.Cells["IDBarang"].Value.ToString();
                    using (SqlConnection connection = new SqlConnection("Data Source = MIFUNE-UEHR\\NIJIGASAKIHS; Initial Catalog =DBNyobaCRUD; Integrated Security = True"))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("SELECT FotoBarang FROM TBL_Losts WHERE IDBarang = @ID", connection);
                        cmd.Parameters.AddWithValue("@ID", idBarang);
                        byte[] imageBytes = (byte[])cmd.ExecuteScalar();
                        if (imageBytes != null)
                        {
                            Image image = byteArrayToImage(imageBytes);
                            PictBRG.Image = image;
                        }
                        else
                        {
                            // Handle the case when no image is found for the selected row
                            PictBRG.Image = null; // Clear the PictureBox
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //===========================TAKE BUTTON===============================
        private void btnTake_Click(object sender, EventArgs e)
        {
            if (TxtNALNT.Text.Trim() == "" || Txt_Kode.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap!");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source = MIFUNE-UEHR\\NIJIGASAKIHS; Initial Catalog =DBNyobaCRUD; Integrated Security = True");
                try // Try to insert data into the database
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into TBL_Take (IDTake, UserName, IDBrg) values (@IDTake, @UserName, @IDBrg)", conn);
                    cmd.Parameters.AddWithValue("@IDTake", TxtIDtake.Text);
                    cmd.Parameters.AddWithValue("@IDBrg", Txt_Kode.Text);
                    cmd.Parameters.AddWithValue("@UserName", TxtNALNT.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Laporan pengambilan berhasil terkirim!");
                    Bersihkan();
                    IDtakeOtomatis();
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (TxtNALNT.Text.Trim() == "" || Txt_Kode.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap!");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source = MIFUNE-UEHR\\NIJIGASAKIHS; Initial Catalog =DBNyobaCRUD; Integrated Security = True");
                try // Try to insert data into the database
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into TBL_Report (IDReport, Pemilik, IDBarang) values (@IDReport, @Pemilik, @IDBarang)", conn);
                    cmd.Parameters.AddWithValue("@IDReport", TxtIDReport.Text);
                    cmd.Parameters.AddWithValue("@IDBarang", Txt_Kode.Text);
                    cmd.Parameters.AddWithValue("@Pemilik", TxtNALNT.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Laporan penemuan berhasil terkirim!");
                    Bersihkan();
                    IDReportOtomatis();
                    
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

        private void TxtIDReport_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        //====================================Report Button================================
    }
}
