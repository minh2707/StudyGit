namespace Baitap1
{
    partial class BT2
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
            this.lblnhapso = new System.Windows.Forms.Label();
            this.txtNhapso = new System.Windows.Forms.TextBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKetthuc = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChandau = new System.Windows.Forms.Button();
            this.btnLecuoi = new System.Windows.Forms.Button();
            this.btnXoachon = new System.Windows.Forms.Button();
            this.btnXoadau = new System.Windows.Forms.Button();
            this.btnXoacuoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnhapso
            // 
            this.lblnhapso.AutoSize = true;
            this.lblnhapso.Location = new System.Drawing.Point(11, 13);
            this.lblnhapso.Name = "lblnhapso";
            this.lblnhapso.Size = new System.Drawing.Size(85, 13);
            this.lblnhapso.TabIndex = 0;
            this.lblnhapso.Text = "Nhap so nguyen";
            // 
            // txtNhapso
            // 
            this.txtNhapso.Location = new System.Drawing.Point(145, 9);
            this.txtNhapso.Name = "txtNhapso";
            this.txtNhapso.Size = new System.Drawing.Size(306, 20);
            this.txtNhapso.TabIndex = 1;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(0, 53);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(284, 407);
            this.lst1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoacuoi);
            this.groupBox1.Controls.Add(this.btnXoadau);
            this.groupBox1.Controls.Add(this.btnXoachon);
            this.groupBox1.Controls.Add(this.btnLecuoi);
            this.groupBox1.Controls.Add(this.btnChandau);
            this.groupBox1.Controls.Add(this.btnTang2);
            this.groupBox1.Location = new System.Drawing.Point(287, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 404);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuc nang";
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKetthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetthuc.Location = new System.Drawing.Point(73, 474);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(456, 53);
            this.btnKetthuc.TabIndex = 9;
            this.btnKetthuc.Text = "Ket thuc";
            this.btnKetthuc.UseVisualStyleBackColor = true;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(484, 9);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(87, 28);
            this.btnCapnhat.TabIndex = 2;
            this.btnCapnhat.Text = "Cap Nhat";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang2.Location = new System.Drawing.Point(29, 25);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(254, 40);
            this.btnTang2.TabIndex = 3;
            this.btnTang2.Text = "Tang moi phan tu len 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnChandau
            // 
            this.btnChandau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChandau.Location = new System.Drawing.Point(30, 91);
            this.btnChandau.Name = "btnChandau";
            this.btnChandau.Size = new System.Drawing.Size(254, 40);
            this.btnChandau.TabIndex = 4;
            this.btnChandau.Text = "Chon so chan dau";
            this.btnChandau.UseVisualStyleBackColor = true;
            this.btnChandau.Click += new System.EventHandler(this.btnChandau_Click);
            // 
            // btnLecuoi
            // 
            this.btnLecuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecuoi.Location = new System.Drawing.Point(30, 160);
            this.btnLecuoi.Name = "btnLecuoi";
            this.btnLecuoi.Size = new System.Drawing.Size(254, 40);
            this.btnLecuoi.TabIndex = 5;
            this.btnLecuoi.Text = "Chon so le cuoi";
            this.btnLecuoi.UseVisualStyleBackColor = true;
            this.btnLecuoi.Click += new System.EventHandler(this.btnLecuoi_Click);
            // 
            // btnXoachon
            // 
            this.btnXoachon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoachon.Location = new System.Drawing.Point(30, 225);
            this.btnXoachon.Name = "btnXoachon";
            this.btnXoachon.Size = new System.Drawing.Size(254, 40);
            this.btnXoachon.TabIndex = 6;
            this.btnXoachon.Text = "Xoa phan tu dang chon";
            this.btnXoachon.UseVisualStyleBackColor = true;
            this.btnXoachon.Click += new System.EventHandler(this.btnXoachon_Click);
            // 
            // btnXoadau
            // 
            this.btnXoadau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoadau.Location = new System.Drawing.Point(29, 293);
            this.btnXoadau.Name = "btnXoadau";
            this.btnXoadau.Size = new System.Drawing.Size(254, 40);
            this.btnXoadau.TabIndex = 7;
            this.btnXoadau.Text = "Xoa phan tu o dau";
            this.btnXoadau.UseVisualStyleBackColor = true;
            this.btnXoadau.Click += new System.EventHandler(this.btnXoadau_Click);
            // 
            // btnXoacuoi
            // 
            this.btnXoacuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoacuoi.Location = new System.Drawing.Point(29, 358);
            this.btnXoacuoi.Name = "btnXoacuoi";
            this.btnXoacuoi.Size = new System.Drawing.Size(254, 40);
            this.btnXoacuoi.TabIndex = 8;
            this.btnXoacuoi.Text = "Xoa phan tu o cuoi";
            this.btnXoacuoi.UseVisualStyleBackColor = true;
            // 
            // BT2
            // 
            this.AcceptButton = this.btnCapnhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKetthuc;
            this.ClientSize = new System.Drawing.Size(583, 542);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.txtNhapso);
            this.Controls.Add(this.lblnhapso);
            this.Name = "BT2";
            this.Text = "Bt2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhapso;
        private System.Windows.Forms.TextBox txtNhapso;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoacuoi;
        private System.Windows.Forms.Button btnXoadau;
        private System.Windows.Forms.Button btnXoachon;
        private System.Windows.Forms.Button btnLecuoi;
        private System.Windows.Forms.Button btnChandau;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnKetthuc;
        private System.Windows.Forms.Button btnCapnhat;
    }
}