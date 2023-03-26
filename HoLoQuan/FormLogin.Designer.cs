namespace HoLoQuan
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBoxMK = new System.Windows.Forms.CheckBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonDangnhap = new System.Windows.Forms.Button();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(202, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(202, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // checkBoxMK
            // 
            this.checkBoxMK.AutoSize = true;
            this.checkBoxMK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMK.Location = new System.Drawing.Point(352, 319);
            this.checkBoxMK.Name = "checkBoxMK";
            this.checkBoxMK.Size = new System.Drawing.Size(150, 23);
            this.checkBoxMK.TabIndex = 53;
            this.checkBoxMK.Text = "Hiển thị mật khẩu";
            this.checkBoxMK.UseVisualStyleBackColor = true;
            this.checkBoxMK.CheckedChanged += new System.EventHandler(this.checkBoxMK_CheckedChanged);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(462, 376);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(166, 66);
            this.buttonThoat.TabIndex = 52;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonDangnhap
            // 
            this.buttonDangnhap.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.buttonDangnhap.Location = new System.Drawing.Point(202, 376);
            this.buttonDangnhap.Name = "buttonDangnhap";
            this.buttonDangnhap.Size = new System.Drawing.Size(166, 66);
            this.buttonDangnhap.TabIndex = 51;
            this.buttonDangnhap.Text = "Đăng nhập";
            this.buttonDangnhap.UseVisualStyleBackColor = true;
            this.buttonDangnhap.Click += new System.EventHandler(this.buttonDangnhap_Click);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(352, 262);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(264, 34);
            this.txtMatkhau.TabIndex = 50;
            this.txtMatkhau.UseSystemPasswordChar = true;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaikhoan.Location = new System.Drawing.Point(352, 177);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(264, 34);
            this.txtTaikhoan.TabIndex = 49;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoLoQuan.Properties.Resources.background_nhe_nhang_dep;
            this.ClientSize = new System.Drawing.Size(849, 561);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBoxMK);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonDangnhap);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBoxMK;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonDangnhap;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
    }
}

