using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TsunnagaruConnect
{
    public partial class HomePage : Form
    {

        public HomePage(string log)
        {
            InitializeComponent();
            TxtNamaAkun.Text =log;
        }



        //Button LogOut---------------------------------------------------------------------------------
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LoginPage lgn = new LoginPage();
            lgn.Show();
            this.Hide();
        }

        //Button for opsiAdminForm---------------------------------------------------------------------

        OpsiAdmin opa;
        void opa_FormClosed(object sender, FormClosedEventArgs e)
        {
            opa = null;
        }
        private void BtnAdminOP_Click(object sender, EventArgs e)
        {
            if (opa == null) 
            {
                opa = new OpsiAdmin();
                opa.FormClosed += new FormClosedEventHandler(opa_FormClosed);
                opa.Show();
            }

            else
            {
                opa.Activate();

            }
        }

        //Button for FoundForm----------------------------------------------------------------------------

        FoundsForm fnds;
        void fnds_FormClosed(object sender, FormClosedEventArgs e)
        {
            fnds = null;
        }
        private void btnFound_Click(object sender, EventArgs e)
        {
            if (fnds == null) //jika formbarang belum muncul, maka
            {
                fnds = new FoundsForm();
                fnds.FormClosed += new FormClosedEventHandler(fnds_FormClosed);
                fnds.Show();
            }

            else
            {
                fnds.Activate();

            }
        }

        //Button for LostForm-------------------------------------------------------------------------------

        LostForm lst;
        void lst_FormClosed(object sender, FormClosedEventArgs e)
        {
            lst = null;
        }
        private void btnLost_Click(object sender, EventArgs e)
        {
            if (lst == null) //jika formbarang belum muncul, maka
            {
                lst = new LostForm();
                lst.FormClosed += new FormClosedEventHandler(lst_FormClosed);
                lst.Show();
            }

            else
            {
                lst.Activate();

            }
        }

        //Button for ListNTakeForm--------------------------------------------------------------------------
        
        ListNTakeForm LNT;
        void LNT_FormClosed(object sender, FormClosedEventArgs e)
        {
            LNT = null;
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            if (LNT == null) //jika formbarang belum muncul, maka
            {
                LNT = new ListNTakeForm();
                LNT.FormClosed += new FormClosedEventHandler(LNT_FormClosed);
                LNT.Show();
            }

            else
            {
                LNT.Activate();

            }
        }

        //Button for SettingDataFound--------------------------------------------------------------------------

        SettingData setdat;
        void setdat_FormClosed(object sender, FormClosedEventArgs e)
        {
            setdat = null;
        }
        private void btnAdminSetData_Click(object sender, EventArgs e)
        {
            if (setdat == null) //jika formbarang belum muncul, maka
            {
                setdat = new SettingData();
                setdat.FormClosed += new FormClosedEventHandler(setdat_FormClosed);
                setdat.Show();
            }

            else
            {
                setdat.Activate();

            }
        }
        //Button for SettingDataLost--------------------------------------------------------------------------
        SettingDataLost SetDatLost;
        void SetDatLost_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetDatLost = null;
        }
        private void BtnSetDatLost_Click(object sender, EventArgs e)
        {
            if (SetDatLost == null) //jika formbarang belum muncul, maka
            {
                SetDatLost = new SettingDataLost();
                SetDatLost.FormClosed += new FormClosedEventHandler(SetDatLost_FormClosed);
                SetDatLost.Show();
            }

            else
            {
                SetDatLost.Activate();

            }
        }
        //Button for SettingDataReport--------------------------------------------------------------------------
        DataReport Daport;
        void Daport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Daport = null;
        }
        private void BtnSetRep_Click(object sender, EventArgs e)
        {
            if (Daport == null) //jika formbarang belum muncul, maka
            {
                Daport = new DataReport();
                Daport.FormClosed += new FormClosedEventHandler(Daport_FormClosed);
                Daport.Show();
            }

            else
            {
                Daport.Activate();

            }
        }
        //======================================HomePage=================
        private void HomePage_Load(object sender, EventArgs e)
        {
            TxtNamaAkun.Enabled = false;
            if (ForLog.type == "A")
            {
                btnAccountSetting.Visible = true;
                btnAdminSetData.Visible = true;
                BtnSetDatLost.Visible = true;
                BtnSetRep.Visible = true;   
            }
            else if (ForLog.type == "U")
            {
                btnAccountSetting.Visible = false;
                btnAdminSetData.Visible= false;
                BtnSetDatLost.Visible = false;
                BtnSetRep.Visible = false;
            }
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
