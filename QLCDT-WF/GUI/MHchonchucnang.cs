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
    public partial class Formchonchucnang : Form
    {
        public Formchonchucnang()
        {
            InitializeComponent();
        }

        private void buttondk_Click(object sender, EventArgs e)
        {
            //MHdangki dangki = new MHdangki();
            //dangki.Visible = true;

            MHdangki dk = new MHdangki();
            dk.ShowDialog();           
        }

        private void buttonqlkh_Click(object sender, EventArgs e)
        {
            MHquanlykh quanlykh = new MHquanlykh();
            quanlykh.ShowDialog();                  
        }

        private void buttontaofilelog_Click(object sender, EventArgs e)
        {
            CTSDBUS.TaoFileSIM();
            CTSDBUS.TaoFileLog();
            MessageBox.Show("Tạo file thành công !!!");                     
        }
            

        private void buttonsendmail_Click(object sender, EventArgs e)
        {
            HOADONBUS.SendMailTB();
            MessageBox.Show("Đã gửi mail cho các khách hàng chưa thanh toán !!!");
        }

        private void buttontongket_Click(object sender, EventArgs e)
        {
            HOADONBUS.Tongketthanghientai();
        }
    }
}
