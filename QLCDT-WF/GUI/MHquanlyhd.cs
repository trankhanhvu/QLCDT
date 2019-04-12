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
    public partial class MHquanlyhd : Form
    {
        string sosim;
        public MHquanlyhd()
        {
            InitializeComponent();
        }

        public MHquanlyhd(string giatrinhan):this()
        {
            sosim = giatrinhan;
        }

        private void MHquanlyhd_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            dshd.DataSource = HOADONBUS.LayDSHD(sosim);
            comboBoxthang.DataSource = HOADONBUS.LaydsThang(sosim);
            comboBoxthang.DisplayMember = "THANG";
            comboBoxthang.ValueMember = "THANG";

            comboBoxnam.DataSource = HOADONBUS.LaydsNam(sosim);
            comboBoxnam.DisplayMember = "NAM";
            comboBoxnam.ValueMember = "NAM";
        }

       

        private void dshd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dshd.CurrentRow.Index;         
            comboBoxtrangthai.Text = dshd.Rows[selected].Cells[4].Value.ToString();
            buttonupdate.Enabled = true;
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            if(comboBoxtrangthai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn trạng thái !!!", "Thông báo");
            }           
            else
            {
                int selected = dshd.CurrentRow.Index;
                HOADON update = new HOADON();
                update.IDSIM = dshd.Rows[selected].Cells[0].Value.ToString();
                update.THANG = int.Parse(dshd.Rows[selected].Cells[1].Value.ToString());
                update.NAM = int.Parse(dshd.Rows[selected].Cells[2].Value.ToString());
                update.TONGTIEN = double.Parse(dshd.Rows[selected].Cells[3].Value.ToString());
                update.TRANGTHAI = comboBoxtrangthai.Text;

                HOADONBUS.UpdateHD(update);
                LoadData();
                MessageBox.Show("Cập nhật thành công !!!", "Thông báo");
            }
            
        }

        private void comboBoxthang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dshd.DataSource = HOADONBUS.SeachHD(sosim, int.Parse(comboBoxthang.SelectedValue.ToString()), int.Parse(comboBoxnam.SelectedValue.ToString()));
        }

        private void comboBoxnam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dshd.DataSource = HOADONBUS.SeachHD(sosim, int.Parse(comboBoxthang.SelectedValue.ToString()), int.Parse(comboBoxnam.SelectedValue.ToString()));
        }

        private void buttonfilter_Click(object sender, EventArgs e)
        {
            if (comboBoxthang.Enabled == false && comboBoxnam.Enabled == false)
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
