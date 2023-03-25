namespace Quanlycoffe
{
    partial class FormHeThong
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
            this.buttonDangxuat = new System.Windows.Forms.Button();
            this.buttonXuat = new System.Windows.Forms.Button();
            this.buttonDichvu = new System.Windows.Forms.Button();
            this.buttonPhonghat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDangxuat
            // 
            this.buttonDangxuat.Location = new System.Drawing.Point(896, 651);
            this.buttonDangxuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDangxuat.Name = "buttonDangxuat";
            this.buttonDangxuat.Size = new System.Drawing.Size(145, 59);
            this.buttonDangxuat.TabIndex = 35;
            this.buttonDangxuat.Text = "Đăng xuất";
            this.buttonDangxuat.UseVisualStyleBackColor = true;
            // 
            // buttonXuat
            // 
            this.buttonXuat.Location = new System.Drawing.Point(770, 478);
            this.buttonXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXuat.Name = "buttonXuat";
            this.buttonXuat.Size = new System.Drawing.Size(197, 74);
            this.buttonXuat.TabIndex = 36;
            this.buttonXuat.Text = "Nhập/xuất kho";
            this.buttonXuat.UseVisualStyleBackColor = true;
            // 
            // buttonDichvu
            // 
            this.buttonDichvu.Location = new System.Drawing.Point(770, 345);
            this.buttonDichvu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDichvu.Name = "buttonDichvu";
            this.buttonDichvu.Size = new System.Drawing.Size(197, 74);
            this.buttonDichvu.TabIndex = 37;
            this.buttonDichvu.Text = "Thông tin cá nhân";
            this.buttonDichvu.UseVisualStyleBackColor = true;
            // 
            // buttonPhonghat
            // 
            this.buttonPhonghat.Location = new System.Drawing.Point(770, 208);
            this.buttonPhonghat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPhonghat.Name = "buttonPhonghat";
            this.buttonPhonghat.Size = new System.Drawing.Size(197, 74);
            this.buttonPhonghat.TabIndex = 38;
            this.buttonPhonghat.Text = "Quản lý Order";
            this.buttonPhonghat.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 144);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(699, 528);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 89);
            this.label1.TabIndex = 48;
            this.label1.Text = "Hồ Lô Quán";
            // 
            // FormHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 725);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDangxuat);
            this.Controls.Add(this.buttonXuat);
            this.Controls.Add(this.buttonDichvu);
            this.Controls.Add(this.buttonPhonghat);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHeThong";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDangxuat;
        private System.Windows.Forms.Button buttonXuat;
        private System.Windows.Forms.Button buttonDichvu;
        private System.Windows.Forms.Button buttonPhonghat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}