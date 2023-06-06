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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace TsunnagaruConnect
{
    public partial class DataReport : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        Koneksi Konn = new Koneksi();

        void BersihkanReport()
        {
            TxtIDLaporan.Text = "";
            TxtKode.Text = "";
            TxtUser.Text = "";
        }
        public DataReport()
        {
            InitializeComponent();
        }

        void TampilTake() //mengambil data barang pada database
                            //untuk refresh agar data yang diinsert langsung muncul
        {

            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select* from TBL_Take", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Take");
                DataViewTake.DataSource = ds;
                DataViewTake.DataMember = "TBL_Take";
                DataViewTake.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        void TampilReport() //mengambil data barang pada database
                          //untuk refresh agar data yang diinsert langsung muncul
        {

            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select* from TBL_Report", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Report");
                DataViewReport.DataSource = ds;
                DataViewReport.DataMember = "TBL_Report";
                DataViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        void CariTake() //mengambil data barang pada database
                          //untuk refresh agar data yang diinsert langsung muncul
        {

            SqlConnection conn = Konn.Getconn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select* from TBL_Take where IDTake like '%" + TxtSearchLNT.Text + "%' or UserName like '%" + TxtSearchLNT.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Take");
                DataViewTake.DataSource = ds;
                DataViewTake.DataMember = "TBL_Take";
                DataViewTake.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        private void DataReport_Load(object sender, EventArgs e)
        {
            TampilTake();
            TampilReport();
        }

        private void DataViewTake_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DataViewTake.Rows[e.RowIndex];
                TxtIDLaporan.Text = row.Cells["IDTake"].Value.ToString();
                TxtUser.Text = row.Cells["UserName"].Value.ToString();
                TxtKode.Text = row.Cells["IDBrg"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }
        private void TxtSearchLNT_TextChanged(object sender, EventArgs e)
        {
            CariTake();
        }
        private void BtnCfm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin untuk menkonfirmasi : " + TxtIDLaporan.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.Getconn();
                {
                    cmd = new SqlCommand("Delete TBL_Take where IDTake='" + TxtIDLaporan.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Konfirmasi laporan berhasil! ");
                    BersihkanReport();
                    TampilReport();
                    TampilTake();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin untuk menghapus laporan: " + TxtIDLaporan.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.Getconn();
                {
                    cmd = new SqlCommand("Delete TBL_Report where IDReport='" + TxtIDLaporan.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Penghapusan laporan berhasil! ");
                    BersihkanReport();
                    TampilReport();
                    TampilTake();
                }
            }
        }

        private void DataViewReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DataViewReport.Rows[e.RowIndex];
                TxtIDLaporan.Text = row.Cells["IDReport"].Value.ToString();
                TxtUser.Text = row.Cells["Pemilik"].Value.ToString();
                TxtKode.Text = row.Cells["IDBarang"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void DataViewReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
