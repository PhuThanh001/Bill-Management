namespace HoaDonTienDien
{
    partial class frmKHNN
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
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbQuocTich = new System.Windows.Forms.Label();
            this.lbSoluong = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(12, 56);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(50, 20);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "MaKH";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(12, 89);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(56, 20);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ Tên";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(12, 123);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(57, 20);
            this.lbDiaChi.TabIndex = 2;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbQuocTich
            // 
            this.lbQuocTich.AutoSize = true;
            this.lbQuocTich.Location = new System.Drawing.Point(12, 165);
            this.lbQuocTich.Name = "lbQuocTich";
            this.lbQuocTich.Size = new System.Drawing.Size(75, 20);
            this.lbQuocTich.TabIndex = 3;
            this.lbQuocTich.Text = "Quốc Tịch";
            // 
            // lbSoluong
            // 
            this.lbSoluong.AutoSize = true;
            this.lbSoluong.Location = new System.Drawing.Point(12, 202);
            this.lbSoluong.Name = "lbSoluong";
            this.lbSoluong.Size = new System.Drawing.Size(72, 20);
            this.lbSoluong.TabIndex = 4;
            this.lbSoluong.Text = "Số Lượng";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(12, 246);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(63, 20);
            this.lbDonGia.TabIndex = 5;
            this.lbDonGia.Text = "Đơn Giá";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(128, 49);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(270, 27);
            this.txtMaKH.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(128, 82);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(270, 27);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(128, 116);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(270, 27);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Location = new System.Drawing.Point(131, 158);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(270, 27);
            this.txtQuocTich.TabIndex = 9;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(131, 199);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(270, 27);
            this.txtSoluong.TabIndex = 10;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(128, 239);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(270, 27);
            this.txtDonGia.TabIndex = 11;
            // 
            // frmKHNN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 339);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtQuocTich);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.lbSoluong);
            this.Controls.Add(this.lbQuocTich);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbMaKH);
            this.Name = "frmKHNN";
            this.Text = "frmKHnuocngoai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbQuocTich;
        private System.Windows.Forms.Label lbSoluong;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtDonGia;
    }
}