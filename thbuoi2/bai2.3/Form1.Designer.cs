namespace bai2._3
{
    partial class frmChuongTrinhThoiGian
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
            this.btnHienthi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(313, 156);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(75, 23);
            this.btnHienthi.TabIndex = 0;
            this.btnHienthi.Text = "Hien Thi";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChuongTrinhThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHienthi);
            this.Name = "frmChuongTrinhThoiGian";
            this.Text = "CHƯƠNG TRÌNH THỜI GIAN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHienthi;
    }
}

