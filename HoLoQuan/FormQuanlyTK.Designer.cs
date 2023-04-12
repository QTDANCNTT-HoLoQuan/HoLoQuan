namespace HoLoQuan
{
    partial class FormQuanlyTK
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
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.buttonquaylai = new System.Windows.Forms.Button();
            this.txtMKnd = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonXoatk = new System.Windows.Forms.Button();
            this.buttonSuatk = new System.Windows.Forms.Button();
            this.buttonThemtk = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cbLoaitk = new System.Windows.Forms.ComboBox();
            this.TxtHoTen = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTentk = new System.Windows.Forms.TextBox();
            this.dataGridViewTk = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(691, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Địa chỉ:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDiachi.Location = new System.Drawing.Point(840, 284);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(210, 26);
            this.txtDiachi.TabIndex = 67;
            // 
            // buttonquaylai
            // 
            this.buttonquaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonquaylai.Location = new System.Drawing.Point(64, 23);
            this.buttonquaylai.Name = "buttonquaylai";
            this.buttonquaylai.Size = new System.Drawing.Size(123, 42);
            this.buttonquaylai.TabIndex = 66;
            this.buttonquaylai.Text = "Quay lại";
            this.buttonquaylai.UseVisualStyleBackColor = false;
            this.buttonquaylai.Click += new System.EventHandler(this.buttonquaylai_Click);
            // 
            // txtMKnd
            // 
            this.txtMKnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMKnd.Location = new System.Drawing.Point(840, 221);
            this.txtMKnd.Name = "txtMKnd";
            this.txtMKnd.Size = new System.Drawing.Size(210, 26);
            this.txtMKnd.TabIndex = 65;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(691, 225);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 20);
            this.label19.TabIndex = 64;
            this.label19.Text = "Mật khẩu:";
            // 
            // buttonXoatk
            // 
            this.buttonXoatk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonXoatk.Location = new System.Drawing.Point(929, 454);
            this.buttonXoatk.Name = "buttonXoatk";
            this.buttonXoatk.Size = new System.Drawing.Size(87, 44);
            this.buttonXoatk.TabIndex = 63;
            this.buttonXoatk.Text = "Xóa";
            this.buttonXoatk.UseVisualStyleBackColor = true;
            this.buttonXoatk.Click += new System.EventHandler(this.buttonXoatk_Click);
            // 
            // buttonSuatk
            // 
            this.buttonSuatk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSuatk.Location = new System.Drawing.Point(790, 494);
            this.buttonSuatk.Name = "buttonSuatk";
            this.buttonSuatk.Size = new System.Drawing.Size(87, 44);
            this.buttonSuatk.TabIndex = 62;
            this.buttonSuatk.Text = "Sửa";
            this.buttonSuatk.UseVisualStyleBackColor = true;
            this.buttonSuatk.Click += new System.EventHandler(this.buttonSuatk_Click);
            // 
            // buttonThemtk
            // 
            this.buttonThemtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonThemtk.Location = new System.Drawing.Point(790, 419);
            this.buttonThemtk.Name = "buttonThemtk";
            this.buttonThemtk.Size = new System.Drawing.Size(87, 44);
            this.buttonThemtk.TabIndex = 61;
            this.buttonThemtk.Text = "Thêm";
            this.buttonThemtk.UseVisualStyleBackColor = true;
            this.buttonThemtk.Click += new System.EventHandler(this.buttonThemtk_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(689, 345);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 20);
            this.label15.TabIndex = 60;
            this.label15.Text = "Loại tài khoản:";
            // 
            // cbLoaitk
            // 
            this.cbLoaitk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbLoaitk.FormattingEnabled = true;
            this.cbLoaitk.Items.AddRange(new object[] {
            "Nhân viên",
            "Admin"});
            this.cbLoaitk.Location = new System.Drawing.Point(840, 342);
            this.cbLoaitk.Name = "cbLoaitk";
            this.cbLoaitk.Size = new System.Drawing.Size(210, 28);
            this.cbLoaitk.TabIndex = 59;
            // 
            // TxtHoTen
            // 
            this.TxtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtHoTen.Location = new System.Drawing.Point(840, 160);
            this.TxtHoTen.Name = "TxtHoTen";
            this.TxtHoTen.Size = new System.Drawing.Size(210, 26);
            this.TxtHoTen.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(689, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 57;
            this.label14.Text = "Họ và tên:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(689, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 20);
            this.label13.TabIndex = 56;
            this.label13.Text = "Tên tài khoản:";
            // 
            // txtTentk
            // 
            this.txtTentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTentk.Location = new System.Drawing.Point(840, 98);
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.Size = new System.Drawing.Size(210, 26);
            this.txtTentk.TabIndex = 55;
            // 
            // dataGridViewTk
            // 
            this.dataGridViewTk.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTk.Location = new System.Drawing.Point(64, 98);
            this.dataGridViewTk.Name = "dataGridViewTk";
            this.dataGridViewTk.ReadOnly = true;
            this.dataGridViewTk.RowHeadersWidth = 51;
            this.dataGridViewTk.RowTemplate.Height = 24;
            this.dataGridViewTk.Size = new System.Drawing.Size(597, 456);
            this.dataGridViewTk.TabIndex = 54;
            // 
            // FormQuanlyTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoLoQuan.Properties.Resources.bghongtim;
            this.ClientSize = new System.Drawing.Size(1155, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.buttonquaylai);
            this.Controls.Add(this.txtMKnd);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.buttonXoatk);
            this.Controls.Add(this.buttonSuatk);
            this.Controls.Add(this.buttonThemtk);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbLoaitk);
            this.Controls.Add(this.TxtHoTen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTentk);
            this.Controls.Add(this.dataGridViewTk);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuanlyTK";
            this.Text = "FormQuanlyTK";
            this.Load += new System.EventHandler(this.FormQlyTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button buttonquaylai;
        private System.Windows.Forms.TextBox txtMKnd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonXoatk;
        private System.Windows.Forms.Button buttonSuatk;
        private System.Windows.Forms.Button buttonThemtk;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbLoaitk;
        private System.Windows.Forms.TextBox TxtHoTen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTentk;
        private System.Windows.Forms.DataGridView dataGridViewTk;
    }
}