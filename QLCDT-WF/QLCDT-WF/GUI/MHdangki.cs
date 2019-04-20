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
using QLCDT_WF.BUS;
using System.Text.RegularExpressions;


namespace QLCDT_WF
{
    public partial class MHdangki : Form
    {
        public MHdangki()
        {
            InitializeComponent();
        }

        private void buttondk_Click(object sender, EventArgs e)
        {
            string patchecksdt = (@"(\+84|0)\d{9,10}");
            bool checksdt = Regex.IsMatch(textBoxidsim.Text,patchecksdt);

            string patcheckcmnd = (@"[0-9]{9}");
            bool checkcmnd = Regex.IsMatch(textBoxcmnd.Text, patcheckcmnd);

            string patcheckemail = (@"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$");
            bool checkemail = Regex.IsMatch(textBoxemail.Text, patcheckemail);

            if (textBoxcmnd.Text == "" || textBoxtenkh.Text == "" || textBoxnghenghiep.Text == "" || textBoxchucvu.Text == "" || textBoxdiachi.Text == "" || textBoxidsim.Text == "" || textBoxemail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!!", "Thông báo !!!");
            }
            else
            if(checkcmnd == false)
            {
                MessageBox.Show("CMND không đúng định dạng !!! Vui lòng nhập lại .", "Thông báo !!!");
            }
            else
            if(checksdt == false)
            {
                MessageBox.Show("IDSIM không đúng định dạng !!! Vui lòng nhập lại .", "Thông báo !!!");
            }
            else
            if(checkemail == false)
            {
                MessageBox.Show("Email không hợp lệ !!! Vui lòng nhập lại .", "Thông báo !!!");
            }
            else
            {
                KHACHHANG thongtinkh = new KHACHHANG();
                thongtinkh.CMND = textBoxcmnd.Text;
                thongtinkh.TENKH = textBoxtenkh.Text;
                thongtinkh.NGHENGHIEP = textBoxnghenghiep.Text;
                thongtinkh.CHUCVU = textBoxchucvu.Text;
                thongtinkh.DIACHI = textBoxdiachi.Text;
                thongtinkh.EMAIL = textBoxemail.Text;

                SIM thongtinsim = new SIM();
                thongtinsim.IDSIM = textBoxidsim.Text;
                thongtinsim.CMND = textBoxcmnd.Text;               
                thongtinsim.TRANGTHAI = "Đã kích hoạt";

                KHACHHANGBUS.ThemKH(thongtinkh, thongtinsim);

                textBoxcmnd.Text = "";
                textBoxtenkh.Text = "";
                textBoxnghenghiep.Text = "";
                textBoxchucvu.Text = "";
                textBoxdiachi.Text = "";
                textBoxidsim.Text = "";
                textBoxemail.Text = "";
            }          
        }

        
        private void MHdangki_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
