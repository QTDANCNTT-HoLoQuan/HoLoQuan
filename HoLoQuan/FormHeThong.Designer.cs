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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeThong));
            this.buttonDangxuat = new System.Windows.Forms.Button();
            this.buttonXuat = new System.Windows.Forms.Button();
            this.buttonDichvu = new System.Windows.Forms.Button();
            this.buttonqlod = new System.Windows.Forms.Button();
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
            this.buttonDangxuat.Click += new System.EventHandler(this.buttonDangxuat_Click);
            // 
            // buttonXuat
            // 
            this.buttonXuat.Location = new System.Drawing.Point(684, 382);
            this.buttonXuat.Name = "buttonXuat";
            this.buttonXuat.Size = new System.Drawing.Size(175, 59);
            this.buttonXuat.TabIndex = 40;
            this.buttonXuat.Text = "Nhập/xuất kho";
            this.buttonXuat.UseVisualStyleBackColor = true;
            this.buttonXuat.Click += new System.EventHandler(this.buttonXuat_Click);
            // 
            // buttonDichvu
            // 
            this.buttonDichvu.Location = new System.Drawing.Point(684, 276);
            this.buttonDichvu.Name = "buttonDichvu";
            this.buttonDichvu.Size = new System.Drawing.Size(175, 59);
            this.buttonDichvu.TabIndex = 41;
            this.buttonDichvu.Text = "Thông tin cá nhân";
            this.buttonDichvu.UseVisualStyleBackColor = true;
            this.buttonDichvu.Click += new System.EventHandler(this.buttonDichvu_Click);
            // 
            // buttonqlod
            // 
            this.buttonqlod.Location = new System.Drawing.Point(684, 166);
            this.buttonqlod.Name = "buttonqlod";
            this.buttonqlod.Size = new System.Drawing.Size(175, 59);
            this.buttonqlod.TabIndex = 42;
            this.buttonqlod.Text = "Quản lý Order";
            this.buttonqlod.UseVisualStyleBackColor = true;
            this.buttonqlod.Click += new System.EventHandler(this.buttonqlod_Click);
            // 
            // FormHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(937, 580);
            this.Controls.Add(this.buttonDangxuat);
            this.Controls.Add(this.buttonXuat);
            this.Controls.Add(this.buttonDichvu);
            this.Controls.Add(this.buttonqlod);
            this.Name = "FormHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHeThong";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDangxuat;
        private System.Windows.Forms.Button buttonXuat;
        private System.Windows.Forms.Button buttonDichvu;
        private System.Windows.Forms.Button buttonqlod;
    }
}