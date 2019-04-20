using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCDT_WF.BUS;

namespace QLCDT_WF
{
    public partial class MHquanlyctsd : Form
    {
        string sosim;
        public MHquanlyctsd()
        {
            InitializeComponent();
            
        }

        public MHquanlyctsd(string giatrinhan):this()
        {
            sosim = giatrinhan;
        }

        private void MHquanlyctsd_Load(object sender, EventArgs e)
        {
            dsctsd.DataSource = CTSDBUS.LayDSCTSD(sosim);

            comboBoxthang.DataSource = CTSDBUS.LaydsThang(sosim);
            comboBoxthang.DisplayMember = "THANG";
            comboBoxthang.ValueMember = "THANG";

            comboBoxnam.DataSource = CTSDBUS.LaydsNam(sosim);
            comboBoxnam.DisplayMember = "NAM";
            comboBoxnam.ValueMember = "NAM";
        }

        void LoadData()
        {
            dsctsd.DataSource = CTSDBUS.LayDSCTSD(sosim);

            
        }



        private void comboBoxthang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            dsctsd.DataSource = CTSDBUS.SearchCTSD(int.Parse(comboBoxthang.SelectedValue.ToString()), int.Parse(comboBoxnam.SelectedValue.ToString()),sosim);
        }

        private void comboBoxnam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            dsctsd.DataSource = CTSDBUS.SearchCTSD(int.Parse(comboBoxthang.SelectedValue.ToString()), int.Parse(comboBoxnam.SelectedValue.ToString()),sosim);
        }

        private void buttonfilter_Click(object sender, EventArgs e)
        {
            
            if(comboBoxthang.Enabled == false && comboBoxnam.Enabled == false)
            {
                comboBoxthang.Enabled = true;
                comboBoxnam.Enabled = true;
            }
            else
            {
                comboBoxthang.Enabled = false;
                comboBoxnam.Enabled = false;
            }
        }
    }
}
