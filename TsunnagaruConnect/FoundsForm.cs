using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//SUDAH RAMPUNG[TERVERTIVIKASI]//
namespace TsunnagaruConnect
{
    public partial class FoundsForm : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        Koneksi Konn = new Koneksi();
        public FoundsForm()
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
            TxtWaktu.Text = "";
            TxtDetail.Text = "";
            PictBRG.ImageLocation = null;
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
        void MunculKombo()
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
        private void FoundsForm_Load(object sender, EventArgs e)
        {
            TxtNASF.Enabled = false;
            TxtNASF.Text = Username.uname;
            Bersihkan();
            MunculKombo();
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
                    cmd.Parameters.AddWithValue("@TanggalPenemuan",TanggalPick.Text);
                    cmd.Parameters.AddWithValue("@WaktuPenemuan", TxtWaktu.Text);
                    cmd.Parameters.AddWithValue("@DtlBarang", TxtDetail.Text);
                    cmd.Parameters.AddWithValue("@NamaUser", TxtNASF.Text);
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
    }
}
