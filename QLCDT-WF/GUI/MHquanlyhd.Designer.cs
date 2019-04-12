namespace QLCDT_WF
{
    partial class MHquanlyhd
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
            this.label2 = new System.Windows.Forms.Label();
            this.dshd = new System.Windows.Forms.DataGridView();
            this.idsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxtrangthai = new System.Windows.Forms.ComboBox();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.comboBoxthang = new System.Windows.Forms.ComboBox();
            this.comboBoxnam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonfilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dshd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng  :";
            // 
            // dshd
            // 
            this.dshd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dshd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsim,
            this.thang,
            this.nam,
            this.tongtien,
            this.trangthai});
            this.dshd.Location = new System.Drawing.Point(133, 87);
            this.dshd.Name = "dshd";
            this.dshd.Size = new System.Drawing.Size(599, 150);
            this.dshd.TabIndex = 3;
            this.dshd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dshd_CellClick);
            // 
            // idsim
            // 
            this.idsim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idsim.DataPropertyName = "idsim";
            this.idsim.HeaderText = "IDSIM";
            this.idsim.Name = "idsim";
            // 
            // thang
            // 
            this.thang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thang.DataPropertyName = "thang";
            this.thang.HeaderText = "Tháng";
            this.thang.Name = "thang";
            // 
            // nam
            // 
            this.nam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nam.DataPropertyName = "nam";
            this.nam.HeaderText = "Năm";
            this.nam.Name = "nam";
            // 
            // tongtien
            // 
            this.tongtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            // 
            // trangthai
            // 
            this.trangthai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trạng thái";
            // 
            // comboBoxtrangthai
            // 
            this.comboBoxtrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtrangthai.FormattingEnabled = true;
            this.comboBoxtrangthai.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.comboBoxtrangthai.Location = new System.Drawing.Point(345, 265);
            this.comboBoxtrangthai.Name = "comboBoxtrangthai";
            this.comboBoxtrangthai.Size = new System.Drawing.Size(170, 21);
            this.comboBoxtrangthai.TabIndex = 7;
            // 
            // buttonupdate
            // 
            this.buttonupdate.Enabled = false;
            this.buttonupdate.Location = new System.Drawing.Point(385, 301);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(75, 23);
            this.buttonupdate.TabIndex = 8;
            this.buttonupdate.Text = "Cập nhật";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // comboBoxthang
            // 
            this.comboBoxthang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxthang.Enabled = false;
            this.comboBoxthang.FormattingEnabled = true;
            this.comboBoxthang.Location = new System.Drawing.Point(183, 52);
            this.comboBoxthang.Name = "comboBoxthang";
            this.comboBoxthang.Size = new System.Drawing.Size(121, 21);
            this.comboBoxthang.TabIndex = 9;
            this.comboBoxthang.SelectionChangeCommitted += new System.EventHandler(this.comboBoxthang_SelectionChangeCommitted);
            // 
            // comboBoxnam
            // 
            this.comboBoxnam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxnam.Enabled = false;
            this.comboBoxnam.FormattingEnabled = true;
            this.comboBoxnam.Location = new System.Drawing.Point(366, 52);
            this.comboBoxnam.Name = "comboBoxnam";
            this.comboBoxnam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxnam.TabIndex = 10;
            this.comboBoxnam.SelectionChangeCommitted += new System.EventHandler(this.comboBoxnam_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Năm  :";
            // 
            // buttonfilter
            // 
            this.buttonfilter.Location = new System.Drawing.Point(516, 52);
            this.buttonfilter.Name = "buttonfilter";
            this.buttonfilter.Size = new System.Drawing.Size(75, 23);
            this.buttonfilter.TabIndex = 12;
            this.buttonfilter.Text = "Lọc";
            this.buttonfilter.UseVisualStyleBackColor = true;
            this.buttonfilter.Click += new System.EventHandler(this.buttonfilter_Click);
            // 
            // MHquanlyhd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 339);
            this.Controls.Add(this.buttonfilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxnam);
            this.Controls.Add(this.comboBoxthang);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.comboBoxtrangthai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dshd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MHquanlyhd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.MHquanlyhd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dshd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dshd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxtrangthai;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.ComboBox comboBoxthang;
        private System.Windows.Forms.ComboBox comboBoxnam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonfilter;
    }
}