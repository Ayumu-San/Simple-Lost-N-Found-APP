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
//input
//=====================================SELESAI===========================
namespace TsunnagaruConnect
{
public partial class SettingData : Form
{
private SqlCommand cmd;
private DataSet ds;
private SqlDataAdapter da;
private SqlDataReader dr;
Koneksi Konn = new Koneksi();


        public SettingData()
        {
            InitializeComponent();
        }
        string imgLocation = "";
        void Bersihkan()
        {
            Txt_Kode.Text = "";
            TxtNama.Text = "";
            Cmb_Box_Jenis.Text = "";
            TxtTempat.Text = "";
            TanggalPick.Text = "";
            TxtWaktu.Text = "";
            TxtDetail.Text = "";
            TxtUser.Text = "";
            PictBRG.ImageLocation = null;
            PictBRG.Image=null;
        }

        void NoOtomatis()//Function to order kode barang secara otomatis
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = Konn.Getconn();
            conn.Open();
            cmd = new SqlCommand("select IDBarang from TBL_FOUNDS where IDBarang in(select max(IDBarang) from TBL_FOUNDS) order by IDBarang desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IDBarang"].ToString().Length - 3, 3)) + 1;
                string kodeurutan = "000" + hitung;
                urutan = "BRG" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
            }
            else
            {
                urutan = "BRG001";
            }
            rd.Close();
            Txt_Kode.Enabled = false;
            Txt_Kode.Text = urutan;
            conn.Close();
        }
        //public FoundForm()
        //{
        //    InitializeComponent();
        //}
        void TampilReport()
        {
            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select* from TBL_Take", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Take");
                DataGridUser.DataSource = ds;
                DataGridUser.DataMember = "TBL_Take";
                DataGridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        void TampilBarang() //mengambil data barang pada database
            //untuk refresh agar data yang diinsert langsung muncul
        {
           
            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                //cmd = new SqlCommand("SELECT FotoBarang FROM TBL_Founds");
                //dr = cmd.ExecuteReader();
                cmd = new SqlCommand("Select* from TBL_FOUNDS", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_FOUNDS");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_FOUNDS";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                TampilReport();
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
        void CariBarang() //mengambil data barang pada database
                            //untuk refresh agar data yang diinsert langsung muncul
        {

            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select* from TBL_FOUNDS where IDBarang like '%"+ TxtSearchBrg.Text + "%' or namabarang like '%"+ TxtSearchBrg.Text +"%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_FOUNDS");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_FOUNDS";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        void CariUser() //mengambil data barang pada database
                          //untuk refresh agar data yang diinsert langsung muncul
        {

            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select* from TBL_Take where IDBrg like '%" + TxtSearchUser.Text + "%' or UserName like '%" + TxtSearchUser.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Take");
                DataGridUser.DataSource = ds;
                DataGridUser.DataMember = "TBL_Take";
                DataGridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        void MunculKomboJenis()
        {
            Cmb_Box_Jenis.Items.Add("HP");
            Cmb_Box_Jenis.Items.Add("Charger HP");
            Cmb_Box_Jenis.Items.Add("Charger Laptop");
            Cmb_Box_Jenis.Items.Add("Mouse");
            Cmb_Box_Jenis.Items.Add("Uang");
            Cmb_Box_Jenis.Items.Add("Dompet");
            Cmb_Box_Jenis.Items.Add("Kunci");
            Cmb_Box_Jenis.Items.Add("Helm");
            Cmb_Box_Jenis.Items.Add("Jam Tangan");
            Cmb_Box_Jenis.Items.Add("ATM");
            Cmb_Box_Jenis.Items.Add("KTP");
        }

        private void SettingData_Load(object sender, EventArgs e)
        {
            TxtNASD.Enabled = false;
            TxtNASD.Text = Username.uname;
            TampilBarang();
            Bersihkan();
            MunculKomboJenis();
            NoOtomatis();
        }


        private void Simpan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = MIFUNE-UEHR\\NIJIGASAKIHS; Initial Catalog =DBNyobaCRUD; Integrated Security = True");

            // Check if the form is empty
            if (Txt_Kode.Text.Trim() == "" || TxtNama.Text.Trim() == "" || Cmb_Box_Jenis.Text.Trim() == "" || TxtTempat.Text.Trim() == "" || TxtWaktu.Text.Trim() == "" || TxtDetail.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap !");
            }
            else // If the form is not empty
            {
                byte[] images = null;
                FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);

                try // Try to insert data into the database
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into TBL_Founds (IDBarang, NamaBarang, JenisBarang, TempatPenemuan, TanggalPenemuan, WaktuPenemuan, DetailBarang, NamaUser, FotoBarang) values (@IDBarang, @NamaBarang, @JenisBarang, @TempatPenemuan, @TanggalPenemuan, @WaktuPenemuan, @DtlBarang, @NamaUser, @FotoBarang)", conn);
                    cmd.Parameters.AddWithValue("@IDBarang", Txt_Kode.Text);
                    cmd.Parameters.AddWithValue("@NamaBarang", TxtNama.Text);
                    cmd.Parameters.AddWithValue("@JenisBarang", Cmb_Box_Jenis.Text);
                    cmd.Parameters.AddWithValue("@TempatPenemuan", TxtTempat.Text);
                    cmd.Parameters.AddWithValue("@TanggalPenemuan", TanggalPick.Text);
                    cmd.Parameters.AddWithValue("@WaktuPenemuan", TxtWaktu.Text);
                    cmd.Parameters.AddWithValue("@DtlBarang", TxtDetail.Text);
                    cmd.Parameters.AddWithValue("@NamaUser", TxtUser.Text);
                    cmd.Parameters.AddWithValue("@FotoBarang", images);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data berhasil! ");
                    Bersihkan();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    Txt_Kode.Text = row.Cells["IDBarang"].Value.ToString();
                    TxtNama.Text = row.Cells["NamaBarang"].Value.ToString();
                    Cmb_Box_Jenis.Text = row.Cells["JenisBarang"].Value.ToString();
                    TxtTempat.Text = row.Cells["TempatPenemuan"].Value.ToString();
                    TanggalPick.Text = row.Cells["TanggalPenemuan"].Value.ToString();
                    TxtWaktu.Text = row.Cells["WaktuPenemuan"].Value.ToString();
                    TxtDetail.Text = row.Cells["DetailBarang"].Value.ToString();
                    TxtUser.Text = row.Cells["NamaUser"].Value.ToString();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (Txt_Kode.Text.Trim() == "" || TxtNama.Text.Trim() == "" || Cmb_Box_Jenis.Text.Trim() == "" || TxtTempat.Text.Trim() == "" || TxtWaktu.Text.Trim() == "" || TxtDetail.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap !");
            }
            else
            {
                byte[] images = null;
                if (!string.IsNullOrEmpty(imgLocation))
                {
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(stream);
                    images = reader.ReadBytes((int)stream.Length);
                }

                using (SqlConnection conn = new SqlConnection("Data Source = MIFUNE-UEHR\\NIJIGASAKIHS; Initial Catalog =DBNyobaCRUD; Integrated Security = True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd;
                        if (images != null)
                        {
                            // Update the image along with other fields
                            cmd = new SqlCommand("UPDATE TBL_Founds SET NamaBarang = @NamaBarang, JenisBarang = @JenisBarang, TempatPenemuan = @TempatPenemuan, TanggalPenemuan = @TanggalPenemuan, WaktuPenemuan = @WaktuPenemuan, DetailBarang = @DetailBarang, NamaUser = @NamaUser, FotoBarang = @FotoBarang WHERE IDBarang = @IDBarang", conn);
                            cmd.Parameters.AddWithValue("@FotoBarang", images);
                        }
                        else
                        {
                            // Update only the non-image fields
                            cmd = new SqlCommand("UPDATE TBL_Founds SET NamaBarang = @NamaBarang, JenisBarang = @JenisBarang, TempatPenemuan = @TempatPenemuan, TanggalPenemuan = @TanggalPenemuan, WaktuPenemuan = @WaktuPenemuan, DetailBarang = @DetailBarang, NamaUser = @NamaUser WHERE IDBarang = @IDBarang", conn);
                        }

                        cmd.Parameters.AddWithValue("@NamaBarang", TxtNama.Text);
                        cmd.Parameters.AddWithValue("@JenisBarang", Cmb_Box_Jenis.Text);
                        cmd.Parameters.AddWithValue("@TempatPenemuan", TxtTempat.Text);
                        cmd.Parameters.AddWithValue("@TanggalPenemuan", TanggalPick.Text);
                        cmd.Parameters.AddWithValue("@WaktuPenemuan", TxtWaktu.Text);
                        cmd.Parameters.AddWithValue("@DetailBarang", TxtDetail.Text);
                        cmd.Parameters.AddWithValue("@NamaUser", TxtUser.Text);
                        cmd.Parameters.AddWithValue("@IDBarang", Txt_Kode.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Update Data berhasil!");
                        TampilBarang();
                        Bersihkan();
                        NoOtomatis();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update Data gagal: " + ex.Message);
                    }
                }
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin untuk menghapus barang? :"+ TxtNama.Text +" ?","Konfirmasi", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.Getconn();
                  {
                    cmd = new SqlCommand("Delete TBL_FOUNDS where IDBarang='" + Txt_Kode.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hapus  Data berhasil! ");
                    TampilBarang();
                    Bersihkan();
                    NoOtomatis();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Bersihkan();
            NoOtomatis();
        }

        private void TxtSearchBrg_TextChanged(object sender, EventArgs e)
        {
            CariBarang();
        }
        private void TxtSearchUser_TextChanged(object sender, EventArgs e)
        {
            CariUser();
        }
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                PictBRG.ImageLocation = imgLocation;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtNASD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//private void btnUpdate_Click(object sender, EventArgs e)
//{
//    // Check if all fields are filled
//    if (Txt_Kode.Text.Trim() == "" || TxtNama.Text.Trim() == "" || Cmb_Box_Jenis.Text.Trim() == "" || TxtTempat.Text.Trim() == "" || TanggalPick.Text.Trim() == "" || TxtWaktu.Text.Trim() == "" || TxtDetail.Text.Trim() == "" || TxtUser.Text.Trim() == "")
//    {
//        MessageBox.Show("Data belum lengkap !");
//    }
//    else
//    {
//        byte[] images = null;
//        if (!string.IsNullOrEmpty(imgLocation))
//        {
//            // Read the image file and convert it to byte array
//            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
//            BinaryReader reader = new BinaryReader(stream);
//            images = reader.ReadBytes((int)stream.Length);
//        }

//        // Get the database connection
//        using (SqlConnection conn = Konn.Getconn())
//        {
//            try
//            {
//                conn.Open();
//                // Create the update command
//                SqlCommand cmd = new SqlCommand("UPDATE TBL_Founds SET NamaBarang = @NamaBarang, JenisBarang = @JenisBarang, TempatPenemuan = @TempatPenemuan, TanggalPenemuan = @TanggalPenemuan, WaktuPenemuan = @WaktuPenemuan, DetailBarang = @DetailBarang, NamaUser = @NamaUser, FotoBarang = @FotoBarang WHERE IDBarang = @IDBarang", conn);
//                cmd.Parameters.AddWithValue("@NamaBarang", TxtNama.Text);
//                cmd.Parameters.AddWithValue("@JenisBarang", Cmb_Box_Jenis.Text);
//                cmd.Parameters.AddWithValue("@TempatPenemuan", TxtTempat.Text);
//                cmd.Parameters.AddWithValue("@TanggalPenemuan", TanggalPick.Text);
//                cmd.Parameters.AddWithValue("@WaktuPenemuan", TxtWaktu.Text);
//                cmd.Parameters.AddWithValue("@DetailBarang", TxtDetail.Text);
//                cmd.Parameters.AddWithValue("@NamaUser", TxtUser.Text);
//                cmd.Parameters.AddWithValue("@FotoBarang", images);
//                cmd.Parameters.AddWithValue("@IDBarang", Txt_Kode.Text);
//                cmd.ExecuteNonQuery();

//                MessageBox.Show("Update Data berhasil!");
//                TampilBarang();
//                Bersihkan();
//                NoOtomatis();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Update Data gagal: " + ex.Message);
//            }
//        }
//    }
//}

//private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
//{
//    try
//    {
//        DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
//        Txt_Kode.Text = row.Cells["IDBarang"].Value.ToString();
//        TxtNama.Text = row.Cells["NamaBarang"].Value.ToString();
//        Cmb_Box_Jenis.Text = row.Cells["JenisBarang"].Value.ToString();
//        TxtTempat.Text = row.Cells["TempatPenemuan"].Value.ToString();
//        TxtWaktu.Text = row.Cells["WaktuPenemuan"].Value.ToString();
//        Cmb_Status.Text = row.Cells["DetailBarang"].Value.ToString();
//        cmd = new SqlCommand("SELECT FotoBarang FROM TBL_Founds");
//        dr = cmd.ExecuteReader();
//        while (dr.Read()) ;
//        {
//            byte[] imageBytes = (byte[])dr["FotoBarang"];
//            Image image = byteArrayToImage(imageBytes);
//            dataGridView1.Rows.Add(image);
//        }
//        dr.Close();
//    }
//    catch (Exception X)
//    {
//        MessageBox.Show(X.ToString());
//    }
//}




//private void btnUpdate_Click(object sender, EventArgs e)
//{
//    // Check if all fields are filled
//    if (Txt_Kode.Text.Trim() == "" || TxtNama.Text.Trim() == "" || Cmb_Box_Jenis.Text.Trim() == "" || TxtTempat.Text.Trim() == "" || TxtWaktu.Text.Trim() == "" || TxtDetail.Text.Trim() == "" || TxtUser.Text.Trim() == "")
//    {
//        MessageBox.Show("Data belum lengkap !");
//    }
//    else
//    {
//        byte[] images = null;
//        if (!string.IsNullOrEmpty(imgLocation))
//        {
//            // Read the image file and convert it to byte array
//            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
//            BinaryReader reader = new BinaryReader(stream);
//            images = reader.ReadBytes((int)stream.Length);
//        }

//        // Get the database connection
//        using (SqlConnection conn = Konn.Getconn())
//        {
//            try
//            {
//                conn.Open();

//                // Create the update command
//                SqlCommand cmd = new SqlCommand("UPDATE TBL_Founds SET NamaBarang = @NamaBarang, JenisBarang = @JenisBarang, TempatPenemuan = @TempatPenemuan, TanggalPenemuan = @TanggalPenemuan, WaktuPenemuan = @WaktuPenemuan, DetailBarang = @StsBarang, FotoBarang = @FotoBarang, Pelapor = @user WHERE IDBarang = @IDBarang", conn);
//                cmd.Parameters.AddWithValue("@NamaBarang", TxtNama.Text);
//                cmd.Parameters.AddWithValue("@JenisBarang", Cmb_Box_Jenis.Text);
//                cmd.Parameters.AddWithValue("@TempatPenemuan", TxtTempat.Text);
//                cmd.Parameters.AddWithValue("@TanggalPenemuan", TanggalPick.Text);
//                cmd.Parameters.AddWithValue("@WaktuPenemuan", TxtWaktu.Text);
//                cmd.Parameters.AddWithValue("@StsBarang", TxtDetail.Text);
//                cmd.Parameters.AddWithValue("@FotoBarang", images);
//                cmd.Parameters.AddWithValue("@User", TxtUser.Text);
//                cmd.Parameters.AddWithValue("@IDBarang", Txt_Kode.Text);
//                cmd.ExecuteNonQuery();

//                MessageBox.Show("Update Data berhasil!");
//                TampilBarang();
//                Bersihkan();
//                NoOtomatis();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Update Data gagal: " + ex.Message);
//            }
//        }
//    }
//}


//private void Simpan_Click(object sender, EventArgs e)//button untuk menyimpan data
//{
//    SqlConnection conn = new SqlConnection("your connection string");
//    conn.Open();
//    //klo formnya kosong
//    if (Txt_Kode.Text.Trim() == "" || TxtNama.Text.Trim() == "" || Cmb_Box_Jenis.Text.Trim() == "" || TxtTempat.Text.Trim() == "" || TxtWaktu.Text.Trim() == "" || Cmb_Status.Text.Trim() == "")
//    {
//        MessageBox.Show("Data belum lengkap !");
//    }

//    else //klo isi
//    {
//        byte[] images = null;
//        FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
//        BinaryReader brs = new BinaryReader(streem);
//        images = brs.ReadBytes((int)streem.Length);
//        SqlConnection conn =Konn.Getconn();
//        try //buat nyoba klo ad yg salah dalam pengisian(tp gw masih gayakin/gk mudeng)
//        {
//            conn.Open();
//            cmd.CommandText = "insert into TBL_Founds (IDBarang, NamaBarang, JenisBarang, TempatPenemuan, WaktuPenemuan, DetailBarang, FotoBarang) values (@IDBarang, @NamaBarang, @JenisBarang, @TempatPenemuan, @WaktuPenemuan, @StsBarang, @FotoBarang)";
//            cmd.Parameters.AddWithValue("@IDBarang", Txt_Kode.Text);
//            cmd.Parameters.AddWithValue("@NamaBarang", TxtNama.Text);
//            cmd.Parameters.AddWithValue("@JenisBarang", Cmb_Box_Jenis.Text);
//            cmd.Parameters.AddWithValue("@TempatPenemuan", TxtTempat.Text);
//            cmd.Parameters.AddWithValue("@WaktuPenemuan", TxtWaktu.Text);
//            cmd.Parameters.AddWithValue("@StsBarang", Cmb_Status.Text);
//            cmd.Parameters.AddWithValue("@FotoBarang", images);

//            cmd.ExecuteNonQuery();
//            MessageBox.Show("Insert Data berhasil! ");
//            TampilBarang();
//            Bersihkan();
//            NoOtomatis();
//            conn.Close();
//        }
//        catch(Exception X)//kalau ada data yang tidak sesuai dengan protokol pada database, maka akan muncul x.ToString(tp gw masih gayakin/gk mudeng)
//        {
//            MessageBox.Show(X.ToString());
//        }


//    }

//}

