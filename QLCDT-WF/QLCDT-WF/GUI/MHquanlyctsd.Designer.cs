namespace QLCDT_WF
{
    partial class MHquanlyctsd
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
            this.dsctsd = new System.Windows.Forms.DataGridView();
            this.idsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxthang = new System.Windows.Forms.ComboBox();
            this.comboBoxnam = new System.Windows.Forms.ComboBox();
            this.buttonfilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsctsd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CHI TIẾT SỬ DỤNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng :";
            // 
            // dsctsd
            // 
            this.dsctsd.AllowUserToAddRows = false;
            this.dsctsd.AllowUserToDeleteRows = false;
            this.dsctsd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsctsd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsim,
            this.tgbd,
            this.tgkt,
            this.thanhtien});
            this.dsctsd.Location = new System.Drawing.Point(122, 78);
            this.dsctsd.Name = "dsctsd";
            this.dsctsd.ReadOnly = true;
            this.dsctsd.Size = new System.Drawing.Size(659, 160);
            this.dsctsd.TabIndex = 3;
            // 
            // idsim
            // 
            this.idsim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idsim.DataPropertyName = "idsim";
            this.idsim.HeaderText = "IDSIM";
            this.idsim.Name = "idsim";
            this.idsim.ReadOnly = true;
            // 
            // tgbd
            // 
            this.tgbd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tgbd.DataPropertyName = "tgbd";
            this.tgbd.HeaderText = "Thời gian bắt đầu";
            this.tgbd.Name = "tgbd";
            this.tgbd.ReadOnly = true;
            // 
            // tgkt
            // 
            this.tgkt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tgkt.DataPropertyName = "tgkt";
            this.tgkt.HeaderText = "Thời gian kết thúc";
            this.tgkt.Name = "tgkt";
            this.tgkt.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm :";
            // 
            // comboBoxthang
            // 
            this.comboBoxthang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxthang.Enabled = false;
            this.comboBoxthang.FormattingEnabled = true;
            this.comboBoxthang.Location = new System.Drawing.Point(179, 41);
            this.comboBoxthang.Name = "comboBoxthang";
            this.comboBoxthang.Size = new System.Drawing.Size(121, 21);
            this.comboBoxthang.TabIndex = 5;
            this.comboBoxthang.SelectionChangeCommitted += new System.EventHandler(this.comboBoxthang_SelectionChangeCommitted);
            // 
            // comboBoxnam
            // 
            this.comboBoxnam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxnam.Enabled = false;
            this.comboBoxnam.FormattingEnabled = true;
            this.comboBoxnam.Location = new System.Drawing.Point(372, 41);
            this.comboBoxnam.Name = "comboBoxnam";
            this.comboBoxnam.Size = new System.Drawing.Size(140, 21);
            this.comboBoxnam.TabIndex = 6;
            this.comboBoxnam.SelectionChangeCommitted += new System.EventHandler(this.comboBoxnam_SelectionChangeCommitted);
            // 
            // buttonfilter
            // 
            this.buttonfilter.Location = new System.Drawing.Point(540, 41);
            this.buttonfilter.Name = "buttonfilter";
            this.buttonfilter.Size = new System.Drawing.Size(75, 23);
            this.buttonfilter.TabIndex = 7;
            this.buttonfilter.Text = "Lọc";
            this.buttonfilter.UseVisualStyleBackColor = true;
            this.buttonfilter.Click += new System.EventHandler(this.buttonfilter_Click);
            // 
            // MHquanlyctsd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 283);
            this.Controls.Add(this.buttonfilter);
            this.Controls.Add(this.comboBoxnam);
            this.Controls.Add(this.comboBoxthang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dsctsd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MHquanlyctsd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi tiết sử dụng";
            this.Load += new System.EventHandler(this.MHquanlyctsd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsctsd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dsctsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgbd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxthang;
        private System.Windows.Forms.ComboBox comboBoxnam;
        private System.Windows.Forms.Button buttonfilter;
    }
}