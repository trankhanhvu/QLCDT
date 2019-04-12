using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLCDT_WF.BUS;
using System.Text.RegularExpressions;

namespace QLCDT_WF
{
    public partial class MHquanlykh : Form
    {
        public MHquanlykh()
        {
            InitializeComponent();
        }

        private void MHquanlykh_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            /*
            var db = new QLCDTEntities();
            var listkh = (from a in db.KHACHHANGs
                       join b in db.SIMs on a.CMND equals b.CMND
                       select new
                       {
                           CMND = a.CMND,
                           TENKH = a.TENKH,
                           NGHENGHIEP = a.NGHENGHIEP,
                           CHUCVU = a.CHUCVU,
                           DIACHI = a.DIACHI,
                           IDSIM = b.IDSIM,
                           NGAYKICHHOAT = b.NGAYKICHHOAT
                       }).ToList(); */
            dskh.DataSource = KHACHHANGBUS.LayDSKH();         
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            string patcheckemail = (@"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$");
            bool checkemail = Regex.IsMatch(textBoxemail.Text, patcheckemail);

            if (textBoxtenkh.Text == "" || textBoxnghenghiep.Text == "" || textBoxchucvu.Text == "" || textBoxdiachi.Text == "" || textBoxemail.Text == "" || comboBoxtrangthaisim.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!!", "Thông báo");
            }
            else
            if(checkemail == false)
            {
                MessageBox.Show("Email không hợp lệ !!! Vui lòng nhập lại", "Thông báo");
            }          
            else
            {
               
                int selectedrow = dskh.CurrentRow.Index;
                KHACHHANG thongtinsua = new KHACHHANG();
                thongtinsua.CMND = dskh.Rows[selectedrow].Cells[0].Value.ToString();
                thongtinsua.TENKH = textBoxtenkh.Text;
                thongtinsua.NGHENGHIEP = textBoxnghenghiep.Text;
                thongtinsua.CHUCVU = textBoxchucvu.Text;
                thongtinsua.DIACHI = textBoxdiachi.Text;
                thongtinsua.EMAIL = textBoxemail.Text;
                KHACHHANGBUS.UpdateKH(thongtinsua);

                SIM thongtinsua2 = new SIM();
                thongtinsua2.IDSIM = dskh.Rows[selectedrow].Cells[6].Value.ToString();
                thongtinsua2.TRANGTHAI = comboBoxtrangthaisim.Text;
                SIMBUS.UpdateSIM(thongtinsua2);

                LoadData();
                MessageBox.Show("Cập nhật thành công !!!", "Thông báo");

                textBoxtenkh.Enabled = false;
                textBoxnghenghiep.Enabled = false;
                textBoxchucvu.Enabled = false;
                textBoxdiachi.Enabled = false;
                textBoxemail.Enabled = false;
                buttonupdate.Enabled = false;
                comboBoxtrangthaisim.Enabled = false;
                buttonsuathongtin.Enabled = true;
            }
            
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            dskh.DataSource = KHACHHANGBUS.SearchKH(textBoxsearch.Text);          
        }

        private void dskh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrow = dskh.CurrentRow.Index;
            textBoxtenkh.Text = dskh.Rows[selectedrow].Cells[1].Value.ToString();
            textBoxnghenghiep.Text = dskh.Rows[selectedrow].Cells[2].Value.ToString();
            textBoxchucvu.Text = dskh.Rows[selectedrow].Cells[3].Value.ToString();
            textBoxdiachi.Text = dskh.Rows[selectedrow].Cells[4].Value.ToString();
            textBoxemail.Text = dskh.Rows[selectedrow].Cells[5].Value.ToString();
            comboBoxtrangthaisim.Text = dskh.Rows[selectedrow].Cells[7].Value.ToString();
        }

        private void buttonsuathongtin_Click(object sender, EventArgs e)
        {
            textBoxtenkh.Enabled = true;
            textBoxnghenghiep.Enabled = true;
            textBoxchucvu.Enabled = true;
            textBoxdiachi.Enabled = true;
            textBoxemail.Enabled = true;
            buttonupdate.Enabled = true;
            comboBoxtrangthaisim.Enabled = true;
            buttonsuathongtin.Enabled = false;
        }

        private void buttonxemctsd_Click(object sender, EventArgs e)
        {
            int selectedrow = dskh.CurrentRow.Index;
            string sim = dskh.Rows[selectedrow].Cells[6].Value.ToString();
            MHquanlyctsd ctsd = new MHquanlyctsd(sim);
            ctsd.ShowDialog();
            
        }

        private void buttonxemhd_Click(object sender, EventArgs e)
        {
            int selectedrow = dskh.CurrentRow.Index;
            string sim = dskh.Rows[selectedrow].Cells[6].Value.ToString();
            MHquanlyhd qlhd = new MHquanlyhd(sim);
            qlhd.ShowDialog();
        }

        
    }
}
