namespace BaiTapBuoiLyThuyetSo2
{
    partial class frm35
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
            this.lbDiaChi = new System.Windows.Forms.LinkLabel();
            this.lbTrangWeb = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(74, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ liên hệ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(75, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trang web:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(308, 46);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(270, 36);
            this.lbDiaChi.TabIndex = 1;
            this.lbDiaChi.TabStop = true;
            this.lbDiaChi.Text = "ctk45B@gmail.com";
            this.lbDiaChi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbDiaChi_LinkClicked);
            // 
            // lbTrangWeb
            // 
            this.lbTrangWeb.AutoSize = true;
            this.lbTrangWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangWeb.Location = new System.Drawing.Point(308, 133);
            this.lbTrangWeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTrangWeb.Name = "lbTrangWeb";
            this.lbTrangWeb.Size = new System.Drawing.Size(329, 36);
            this.lbTrangWeb.TabIndex = 1;
            this.lbTrangWeb.TabStop = true;
            this.lbTrangWeb.Text = "http://www.cnttk45B.net";
            this.lbTrangWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbTrangWeb_LinkClicked);
            // 
            // frm35
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 271);
            this.Controls.Add(this.lbTrangWeb);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm35";
            this.Text = "Bài tập 35";
            this.Load += new System.EventHandler(this.frm35_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lbDiaChi;
        private System.Windows.Forms.LinkLabel lbTrangWeb;
    }
}