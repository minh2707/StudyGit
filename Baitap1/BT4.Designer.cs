namespace Baitap1
{
    partial class BT4
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXuatCacSoNguyenTo = new System.Windows.Forms.Button();
            this.btnXuatPhanTuLe = new System.Windows.Forms.Button();
            this.btnDemPhanTuChan = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnTinhTongMang = new System.Windows.Forms.Button();
            this.btnDemPhanTuLe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương Trình Thao Tác Với Mảng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Số Nguyên";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(167, 48);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(331, 20);
            this.txtInput.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(552, 45);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Location = new System.Drawing.Point(23, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Mảng";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(3, 20);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(245, 38);
            this.txtOutput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKQ);
            this.groupBox2.Location = new System.Drawing.Point(387, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 64);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tính toán";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(4, 20);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(235, 37);
            this.txtKQ.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXuatCacSoNguyenTo);
            this.groupBox3.Controls.Add(this.btnXuatPhanTuLe);
            this.groupBox3.Controls.Add(this.btnDemPhanTuChan);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnMinMax);
            this.groupBox3.Controls.Add(this.btnTinhTongMang);
            this.groupBox3.Controls.Add(this.btnDemPhanTuLe);
            this.groupBox3.Location = new System.Drawing.Point(23, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 155);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btnXuatCacSoNguyenTo
            // 
            this.btnXuatCacSoNguyenTo.Location = new System.Drawing.Point(355, 87);
            this.btnXuatCacSoNguyenTo.Name = "btnXuatCacSoNguyenTo";
            this.btnXuatCacSoNguyenTo.Size = new System.Drawing.Size(242, 28);
            this.btnXuatCacSoNguyenTo.TabIndex = 6;
            this.btnXuatCacSoNguyenTo.Text = "Xuất Các Số Nguyên Tố";
            this.btnXuatCacSoNguyenTo.UseVisualStyleBackColor = true;
            this.btnXuatCacSoNguyenTo.Click += new System.EventHandler(this.btnXuatCacSoNguyenTo_Click);
            // 
            // btnXuatPhanTuLe
            // 
            this.btnXuatPhanTuLe.Location = new System.Drawing.Point(355, 53);
            this.btnXuatPhanTuLe.Name = "btnXuatPhanTuLe";
            this.btnXuatPhanTuLe.Size = new System.Drawing.Size(242, 28);
            this.btnXuatPhanTuLe.TabIndex = 5;
            this.btnXuatPhanTuLe.Text = "Xuất Phần Tủ Lẻ";
            this.btnXuatPhanTuLe.UseVisualStyleBackColor = true;
            this.btnXuatPhanTuLe.Click += new System.EventHandler(this.btnXuatPhanTuLe_Click);
            // 
            // btnDemPhanTuChan
            // 
            this.btnDemPhanTuChan.Location = new System.Drawing.Point(355, 19);
            this.btnDemPhanTuChan.Name = "btnDemPhanTuChan";
            this.btnDemPhanTuChan.Size = new System.Drawing.Size(242, 28);
            this.btnDemPhanTuChan.TabIndex = 4;
            this.btnDemPhanTuChan.Text = "Đếm phần tử chẳn";
            this.btnDemPhanTuChan.UseVisualStyleBackColor = true;
            this.btnDemPhanTuChan.Click += new System.EventHandler(this.btnDemPhanTuChan_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(190, 121);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(242, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(6, 87);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(242, 28);
            this.btnMinMax.TabIndex = 2;
            this.btnMinMax.Text = "Tìm Min-Max của Mảng";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnTinhTongMang
            // 
            this.btnTinhTongMang.Location = new System.Drawing.Point(6, 53);
            this.btnTinhTongMang.Name = "btnTinhTongMang";
            this.btnTinhTongMang.Size = new System.Drawing.Size(242, 28);
            this.btnTinhTongMang.TabIndex = 1;
            this.btnTinhTongMang.Text = "Tính Tổng Mảng";
            this.btnTinhTongMang.UseVisualStyleBackColor = true;
            this.btnTinhTongMang.Click += new System.EventHandler(this.btnTinhTongMang_Click);
            // 
            // btnDemPhanTuLe
            // 
            this.btnDemPhanTuLe.Location = new System.Drawing.Point(6, 19);
            this.btnDemPhanTuLe.Name = "btnDemPhanTuLe";
            this.btnDemPhanTuLe.Size = new System.Drawing.Size(242, 28);
            this.btnDemPhanTuLe.TabIndex = 0;
            this.btnDemPhanTuLe.Text = "Đếm phần tử lẻ";
            this.btnDemPhanTuLe.UseVisualStyleBackColor = true;
            this.btnDemPhanTuLe.Click += new System.EventHandler(this.btnDemPhanTuLe_Click);
            // 
            // BT4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 329);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BT4";
            this.Text = "BT4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXuatCacSoNguyenTo;
        private System.Windows.Forms.Button btnXuatPhanTuLe;
        private System.Windows.Forms.Button btnDemPhanTuChan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnTinhTongMang;
        private System.Windows.Forms.Button btnDemPhanTuLe;
    }
}