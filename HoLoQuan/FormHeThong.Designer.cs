namespace HoLoQuan
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
            this.SuspendLayout();
            // 
            // buttonDangxuat
            // 
            this.buttonDangxuat.Location = new System.Drawing.Point(796, 521);
            this.buttonDangxuat.Name = "buttonDangxuat";
            this.buttonDangxuat.Size = new System.Drawing.Size(129, 47);
            this.buttonDangxuat.TabIndex = 39;
            this.buttonDangxuat.Text = "Đăng xuất";
            this.buttonDangxuat.UseVisualStyleBackColor = true;
            // 
            // buttonXuat
            // 
            this.buttonXuat.Location = new System.Drawing.Point(684, 382);
            this.buttonXuat.Name = "buttonXuat";
            this.buttonXuat.Size = new System.Drawing.Size(175, 59);
            this.buttonXuat.TabIndex = 40;
            this.buttonXuat.Text = "Nhập/xuất kho";
            this.buttonXuat.UseVisualStyleBackColor = true;
            // 
            // buttonDichvu
            // 
            this.buttonDichvu.Location = new System.Drawing.Point(684, 276);
            this.buttonDichvu.Name = "buttonDichvu";
            this.buttonDichvu.Size = new System.Drawing.Size(175, 59);
            this.buttonDichvu.TabIndex = 41;
            this.buttonDichvu.Text = "Thông tin cá nhân";
            this.buttonDichvu.UseVisualStyleBackColor = true;
            // 
            // buttonPhonghat
            // 
            this.buttonPhonghat.Location = new System.Drawing.Point(684, 166);
            this.buttonPhonghat.Name = "buttonPhonghat";
            this.buttonPhonghat.Size = new System.Drawing.Size(175, 59);
            this.buttonPhonghat.TabIndex = 42;
            this.buttonPhonghat.Text = "Quản lý Order";
            this.buttonPhonghat.UseVisualStyleBackColor = true;
            // 
            // FormHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoLoQuan.Properties.Resources.background_nhe_nhang_dep;
            this.ClientSize = new System.Drawing.Size(937, 580);
            this.Controls.Add(this.buttonDangxuat);
            this.Controls.Add(this.buttonXuat);
            this.Controls.Add(this.buttonDichvu);
            this.Controls.Add(this.buttonPhonghat);
            this.Name = "FormHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHeThong";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDangxuat;
        private System.Windows.Forms.Button buttonXuat;
        private System.Windows.Forms.Button buttonDichvu;
        private System.Windows.Forms.Button buttonPhonghat;
    }
}