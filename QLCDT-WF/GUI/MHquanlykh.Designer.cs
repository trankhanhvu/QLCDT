namespace QLCDT_WF
{
    partial class MHquanlykh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dskh = new System.Windows.Forms.DataGridView();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykichhoat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxtenkh = new System.Windows.Forms.TextBox();
            this.textBoxnghenghiep = new System.Windows.Forms.TextBox();
            this.textBoxchucvu = new System.Windows.Forms.TextBox();
            this.textBoxdiachi = new System.Windows.Forms.TextBox();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.buttonsuathongtin = new System.Windows.Forms.Button();
            this.buttonxemctsd = new System.Windows.Forms.Button();
            this.buttonxemhd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxtrangthaisim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dskh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // dskh
            // 
            this.dskh.AllowUserToAddRows = false;
            this.dskh.AllowUserToDeleteRows = false;
            this.dskh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dskh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMND,
            this.tenkh,
            this.nghenghiep,
            this.chucvu,
            this.diachi,
            this.email,
            this.idsim,
            this.ngaykichhoat,
            this.trangthai});
            this.dskh.Location = new System.Drawing.Point(97, 65);
            this.dskh.Name = "dskh";
            this.dskh.ReadOnly = true;
            this.dskh.Size = new System.Drawing.Size(852, 188);
            this.dskh.TabIndex = 1;
            this.dskh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dskh_CellClick);
            // 
            // CMND
            // 
            this.CMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMND.DataPropertyName = "cmnd";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // tenkh
            // 
            this.tenkh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenkh.DataPropertyName = "tenkh";
            this.tenkh.HeaderText = "Tên Khách Hàng";
            this.tenkh.Name = "tenkh";
            this.tenkh.ReadOnly = true;
            // 
            // nghenghiep
            // 
            this.nghenghiep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nghenghiep.DataPropertyName = "nghenghiep";
            this.nghenghiep.HeaderText = "Nghề Nghiệp";
            this.nghenghiep.Name = "nghenghiep";
            this.nghenghiep.ReadOnly = true;
            // 
            // chucvu
            // 
            this.chucvu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.HeaderText = "Chức Vụ";
            this.chucvu.Name = "chucvu";
            this.chucvu.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // idsim
            // 
            this.idsim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idsim.DataPropertyName = "idsim";
            this.idsim.HeaderText = "IDSIM";
            this.idsim.Name = "idsim";
            this.idsim.ReadOnly = true;
            // 
            // ngaykichhoat
            // 
            this.ngaykichhoat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaykichhoat.DataPropertyName = "ngaykichhoat";
            this.ngaykichhoat.HeaderText = "Ngày kích hoạt";
            this.ngaykichhoat.Name = "ngaykichhoat";
            this.ngaykichhoat.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nghề Nghiệp :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chức Vụ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa Chỉ :";
            // 
            // textBoxtenkh
            // 
            this.textBoxtenkh.Enabled = false;
            this.textBoxtenkh.Location = new System.Drawing.Point(372, 270);
            this.textBoxtenkh.Name = "textBoxtenkh";
            this.textBoxtenkh.Size = new System.Drawing.Size(199, 20);
            this.textBoxtenkh.TabIndex = 6;
            // 
            // textBoxnghenghiep
            // 
            this.textBoxnghenghiep.Enabled = false;
            this.textBoxnghenghiep.Location = new System.Drawing.Point(372, 299);
            this.textBoxnghenghiep.Name = "textBoxnghenghiep";
            this.textBoxnghenghiep.Size = new System.Drawing.Size(199, 20);
            this.textBoxnghenghiep.TabIndex = 7;
            // 
            // textBoxchucvu
            // 
            this.textBoxchucvu.Enabled = false;
            this.textBoxchucvu.Location = new System.Drawing.Point(372, 325);
            this.textBoxchucvu.Name = "textBoxchucvu";
            this.textBoxchucvu.Size = new System.Drawing.Size(199, 20);
            this.textBoxchucvu.TabIndex = 8;
            // 
            // textBoxdiachi
            // 
            this.textBoxdiachi.Enabled = false;
            this.textBoxdiachi.Location = new System.Drawing.Point(372, 351);
            this.textBoxdiachi.Name = "textBoxdiachi";
            this.textBoxdiachi.Size = new System.Drawing.Size(199, 20);
            this.textBoxdiachi.TabIndex = 9;
            // 
            // buttonupdate
            // 
            this.buttonupdate.Enabled = false;
            this.buttonupdate.Location = new System.Drawing.Point(496, 453);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(75, 23);
            this.buttonupdate.TabIndex = 11;
            this.buttonupdate.Text = "Cập Nhật";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên Khách Hàng :";
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(195, 36);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(165, 20);
            this.textBoxsearch.TabIndex = 13;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            // 
            // buttonsuathongtin
            // 
            this.buttonsuathongtin.Location = new System.Drawing.Point(372, 453);
            this.buttonsuathongtin.Name = "buttonsuathongtin";
            this.buttonsuathongtin.Size = new System.Drawing.Size(92, 23);
            this.buttonsuathongtin.TabIndex = 14;
            this.buttonsuathongtin.Text = "Sửa thông tin";
            this.buttonsuathongtin.UseVisualStyleBackColor = true;
            this.buttonsuathongtin.Click += new System.EventHandler(this.buttonsuathongtin_Click);
            // 
            // buttonxemctsd
            // 
            this.buttonxemctsd.Location = new System.Drawing.Point(969, 75);
            this.buttonxemctsd.Name = "buttonxemctsd";
            this.buttonxemctsd.Size = new System.Drawing.Size(92, 23);
            this.buttonxemctsd.TabIndex = 15;
            this.buttonxemctsd.Text = "Xem CTSD";
            this.buttonxemctsd.UseVisualStyleBackColor = true;
            this.buttonxemctsd.Click += new System.EventHandler(this.buttonxemctsd_Click);
            // 
            // buttonxemhd
            // 
            this.buttonxemhd.Location = new System.Drawing.Point(1083, 75);
            this.buttonxemhd.Name = "buttonxemhd";
            this.buttonxemhd.Size = new System.Drawing.Size(92, 23);
            this.buttonxemhd.TabIndex = 16;
            this.buttonxemhd.Text = "Xem hóa đơn";
            this.buttonxemhd.UseVisualStyleBackColor = true;
            this.buttonxemhd.Click += new System.EventHandler(this.buttonxemhd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email  :";
            // 
            // textBoxemail
            // 
            this.textBoxemail.Enabled = false;
            this.textBoxemail.Location = new System.Drawing.Point(372, 383);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(199, 20);
            this.textBoxemail.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Trạng thái Sim  :";
            // 
            // comboBoxtrangthaisim
            // 
            this.comboBoxtrangthaisim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtrangthaisim.Enabled = false;
            this.comboBoxtrangthaisim.FormattingEnabled = true;
            this.comboBoxtrangthaisim.Items.AddRange(new object[] {
            "Đã kích hoạt",
            "Chặn"});
            this.comboBoxtrangthaisim.Location = new System.Drawing.Point(372, 415);
            this.comboBoxtrangthaisim.Name = "comboBoxtrangthaisim";
            this.comboBoxtrangthaisim.Size = new System.Drawing.Size(199, 21);
            this.comboBoxtrangthaisim.TabIndex = 20;
            // 
            // MHquanlykh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 497);
            this.Controls.Add(this.comboBoxtrangthaisim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonxemhd);
            this.Controls.Add(this.buttonxemctsd);
            this.Controls.Add(this.buttonsuathongtin);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.textBoxdiachi);
            this.Controls.Add(this.textBoxchucvu);
            this.Controls.Add(this.textBoxnghenghiep);
            this.Controls.Add(this.textBoxtenkh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dskh);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MHquanlykh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.MHquanlykh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dskh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dskh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxtenkh;
        private System.Windows.Forms.TextBox textBoxnghenghiep;
        private System.Windows.Forms.TextBox textBoxchucvu;
        private System.Windows.Forms.TextBox textBoxdiachi;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Button buttonsuathongtin;
        private System.Windows.Forms.Button buttonxemctsd;
        private System.Windows.Forms.Button buttonxemhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghenghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykichhoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxtrangthaisim;
    }
}