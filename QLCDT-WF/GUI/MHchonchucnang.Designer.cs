namespace QLCDT_WF
{
    partial class Formchonchucnang
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
            this.buttondk = new System.Windows.Forms.Button();
            this.buttonqlkh = new System.Windows.Forms.Button();
            this.buttontaofilelog = new System.Windows.Forms.Button();
            this.buttonsendmail = new System.Windows.Forms.Button();
            this.buttontongket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttondk
            // 
            this.buttondk.Location = new System.Drawing.Point(83, 12);
            this.buttondk.Name = "buttondk";
            this.buttondk.Size = new System.Drawing.Size(129, 23);
            this.buttondk.TabIndex = 0;
            this.buttondk.Text = "Đăng kí SIM";
            this.buttondk.UseVisualStyleBackColor = true;
            this.buttondk.Click += new System.EventHandler(this.buttondk_Click);
            // 
            // buttonqlkh
            // 
            this.buttonqlkh.Location = new System.Drawing.Point(83, 50);
            this.buttonqlkh.Name = "buttonqlkh";
            this.buttonqlkh.Size = new System.Drawing.Size(129, 23);
            this.buttonqlkh.TabIndex = 1;
            this.buttonqlkh.Text = "Quản lý khách hàng";
            this.buttonqlkh.UseVisualStyleBackColor = true;
            this.buttonqlkh.Click += new System.EventHandler(this.buttonqlkh_Click);
            // 
            // buttontaofilelog
            // 
            this.buttontaofilelog.Location = new System.Drawing.Point(83, 128);
            this.buttontaofilelog.Name = "buttontaofilelog";
            this.buttontaofilelog.Size = new System.Drawing.Size(128, 23);
            this.buttontaofilelog.TabIndex = 3;
            this.buttontaofilelog.Text = "Tạo file log";
            this.buttontaofilelog.UseVisualStyleBackColor = true;
            this.buttontaofilelog.Click += new System.EventHandler(this.buttontaofilelog_Click);
            // 
            // buttonsendmail
            // 
            this.buttonsendmail.Location = new System.Drawing.Point(83, 169);
            this.buttonsendmail.Name = "buttonsendmail";
            this.buttonsendmail.Size = new System.Drawing.Size(128, 23);
            this.buttonsendmail.TabIndex = 5;
            this.buttonsendmail.Text = "Gửi mail thông báo";
            this.buttonsendmail.UseVisualStyleBackColor = true;
            this.buttonsendmail.Click += new System.EventHandler(this.buttonsendmail_Click);
            // 
            // buttontongket
            // 
            this.buttontongket.Location = new System.Drawing.Point(83, 89);
            this.buttontongket.Name = "buttontongket";
            this.buttontongket.Size = new System.Drawing.Size(128, 23);
            this.buttontongket.TabIndex = 6;
            this.buttontongket.Text = "Tính tiền tháng hiện tại";
            this.buttontongket.UseVisualStyleBackColor = true;
            this.buttontongket.Click += new System.EventHandler(this.buttontongket_Click);
            // 
            // Formchonchucnang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 217);
            this.Controls.Add(this.buttontongket);
            this.Controls.Add(this.buttonsendmail);
            this.Controls.Add(this.buttontaofilelog);
            this.Controls.Add(this.buttonqlkh);
            this.Controls.Add(this.buttondk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Formchonchucnang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form chọn chức năng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttondk;
        private System.Windows.Forms.Button buttonqlkh;
        private System.Windows.Forms.Button buttontaofilelog;
        private System.Windows.Forms.Button buttonsendmail;
        private System.Windows.Forms.Button buttontongket;
    }
}

