namespace bai2._6
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnHieu = new System.Windows.Forms.Button();
            this.btnTich = new System.Windows.Forms.Button();
            this.btnThuong = new System.Windows.Forms.Button();
            this.txtSo_A = new System.Windows.Forms.TextBox();
            this.txtSo__B = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSo__B);
            this.groupBox1.Controls.Add(this.txtSo_A);
            this.groupBox1.Controls.Add(this.txtSoa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(226, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHEP TOAN";
            // 
            // txtSoa
            // 
            this.txtSoa.AutoSize = true;
            this.txtSoa.Location = new System.Drawing.Point(37, 44);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(18, 16);
            this.txtSoa.TabIndex = 2;
            this.txtSoa.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "b:";
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(195, 311);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(75, 23);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Tong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnHieu
            // 
            this.btnHieu.Location = new System.Drawing.Point(281, 311);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(75, 23);
            this.btnHieu.TabIndex = 5;
            this.btnHieu.Text = "Hieu";
            this.btnHieu.UseVisualStyleBackColor = true;
            this.btnHieu.Click += new System.EventHandler(this.btnHieu_Click);
            // 
            // btnTich
            // 
            this.btnTich.Location = new System.Drawing.Point(373, 311);
            this.btnTich.Name = "btnTich";
            this.btnTich.Size = new System.Drawing.Size(75, 23);
            this.btnTich.TabIndex = 6;
            this.btnTich.Text = "Tich";
            this.btnTich.UseVisualStyleBackColor = true;
            this.btnTich.Click += new System.EventHandler(this.btnTich_Click);
            // 
            // btnThuong
            // 
            this.btnThuong.Location = new System.Drawing.Point(463, 311);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(75, 23);
            this.btnThuong.TabIndex = 7;
            this.btnThuong.Text = "Thương";
            this.btnThuong.UseVisualStyleBackColor = true;
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);
            // 
            // txtSo_A
            // 
            this.txtSo_A.Location = new System.Drawing.Point(110, 38);
            this.txtSo_A.Name = "txtSo_A";
            this.txtSo_A.Size = new System.Drawing.Size(100, 22);
            this.txtSo_A.TabIndex = 8;
            // 
            // txtSo__B
            // 
            this.txtSo__B.Location = new System.Drawing.Point(110, 83);
            this.txtSo__B.Name = "txtSo__B";
            this.txtSo__B.Size = new System.Drawing.Size(100, 22);
            this.txtSo__B.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThuong);
            this.Controls.Add(this.btnTich);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "bai2.6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSo__B;
        private System.Windows.Forms.TextBox txtSo_A;
        private System.Windows.Forms.Label txtSoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.Button btnTich;
        private System.Windows.Forms.Button btnThuong;
    }
}

