using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TsunnagaruConnect
{
    public partial class Form2 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        Koneksi Konn = new Koneksi();
        public Form2()
        {
            InitializeComponent();
        }
        void TampilBarang() //mengambil data barang pada database
                            //untuk refresh agar data yang diinsert langsung muncul
        {

            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select* from TBL_FOUNDS", conn);
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
        private void Form2_Load(object sender, EventArgs e)
        {
            TampilBarang(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
