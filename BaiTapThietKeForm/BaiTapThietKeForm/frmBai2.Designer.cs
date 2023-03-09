namespace BaiTapThietKeForm
{
    partial class frmBai2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnChonHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 437);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hàng hoá:";
            // 
            // btnChonHang
            // 
            this.btnChonHang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonHang.Location = new System.Drawing.Point(218, 113);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(142, 45);
            this.btnChonHang.TabIndex = 1;
            this.btnChonHang.Text = "Chọn hàng >";
            this.btnChonHang.UseCompatibleTextRendering = true;
            this.btnChonHang.UseVisualStyleBackColor = false;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.listBox2);
            this.panel3.Controls.Add(this.lblSoTien);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnTinhTien);
            this.panel3.Controls.Add(this.btnBoHang);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(385, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 437);
            this.panel3.TabIndex = 1;
            // 
            // btnBoHang
            // 
            this.btnBoHang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoHang.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBoHang.Location = new System.Drawing.Point(8, 113);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(149, 45);
            this.btnBoHang.TabIndex = 1;
            this.btnBoHang.Text = "< Bỏ hàng";
            this.btnBoHang.UseCompatibleTextRendering = true;
            this.btnBoHang.UseVisualStyleBackColor = false;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(115, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Danh sách hàng hoá:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(88, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Các mặt hàng khách mua:";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnTinhTien.Location = new System.Drawing.Point(123, 241);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(111, 45);
            this.btnTinhTien.TabIndex = 1;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseCompatibleTextRendering = true;
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng tiền thanh toán: ";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSoTien.Location = new System.Drawing.Point(211, 398);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(23, 25);
            this.lblSoTien.TabIndex = 0;
            this.lblSoTien.Text = "0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Chuột ",
            "Bàn phím",
            "Máy in",
            "USB Kingmax"});
            this.listBox1.Location = new System.Drawing.Point(4, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 164);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(163, 72);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(239, 144);
            this.listBox2.TabIndex = 2;
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "Bán hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnBoHang;
        private System.Windows.Forms.Label label10;
    }
}