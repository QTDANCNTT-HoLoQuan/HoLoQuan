namespace HoLoQuan
{
    partial class FormQlyHoaDon
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
            this.dataGridViewcthd = new System.Windows.Forms.DataGridView();
            this.buttonquaylai = new System.Windows.Forms.Button();
            this.buttonTatca = new System.Windows.Forms.Button();
            this.buttonThongke = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtkt = new System.Windows.Forms.DateTimePicker();
            this.dtbd = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewDoanhthu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcthd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewcthd);
            this.groupBox1.Location = new System.Drawing.Point(124, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 259);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // dataGridViewcthd
            // 
            this.dataGridViewcthd.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcthd.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewcthd.Name = "dataGridViewcthd";
            this.dataGridViewcthd.ReadOnly = true;
            this.dataGridViewcthd.RowHeadersWidth = 51;
            this.dataGridViewcthd.RowTemplate.Height = 24;
            this.dataGridViewcthd.Size = new System.Drawing.Size(676, 232);
            this.dataGridViewcthd.TabIndex = 49;
            // 
            // buttonquaylai
            // 
            this.buttonquaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonquaylai.Location = new System.Drawing.Point(44, 43);
            this.buttonquaylai.Name = "buttonquaylai";
            this.buttonquaylai.Size = new System.Drawing.Size(123, 42);
            this.buttonquaylai.TabIndex = 56;
            this.buttonquaylai.Text = "Quay lại";
            this.buttonquaylai.UseVisualStyleBackColor = false;
            this.buttonquaylai.Click += new System.EventHandler(this.buttonquaylai_Click);
            // 
            // buttonTatca
            // 
            this.buttonTatca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonTatca.Location = new System.Drawing.Point(44, 118);
            this.buttonTatca.Name = "buttonTatca";
            this.buttonTatca.Size = new System.Drawing.Size(137, 37);
            this.buttonTatca.TabIndex = 55;
            this.buttonTatca.Text = "Hiển thị tất cả";
            this.buttonTatca.UseVisualStyleBackColor = true;
            this.buttonTatca.Click += new System.EventHandler(this.buttonTatca_Click);
            // 
            // buttonThongke
            // 
            this.buttonThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonThongke.Location = new System.Drawing.Point(743, 116);
            this.buttonThongke.Name = "buttonThongke";
            this.buttonThongke.Size = new System.Drawing.Size(117, 42);
            this.buttonThongke.TabIndex = 54;
            this.buttonThongke.Text = "Thống kê";
            this.buttonThongke.UseVisualStyleBackColor = true;
            this.buttonThongke.Click += new System.EventHandler(this.buttonThongke_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(276, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 53;
            this.label2.Text = "Từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(494, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Đến";
            // 
            // dtkt
            // 
            this.dtkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtkt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtkt.Location = new System.Drawing.Point(552, 122);
            this.dtkt.Name = "dtkt";
            this.dtkt.Size = new System.Drawing.Size(147, 24);
            this.dtkt.TabIndex = 51;
            // 
            // dtbd
            // 
            this.dtbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtbd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbd.Location = new System.Drawing.Point(317, 122);
            this.dtbd.Name = "dtbd";
            this.dtbd.Size = new System.Drawing.Size(148, 24);
            this.dtbd.TabIndex = 50;
            // 
            // dataGridViewDoanhthu
            // 
            this.dataGridViewDoanhthu.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanhthu.Location = new System.Drawing.Point(124, 169);
            this.dataGridViewDoanhthu.Name = "dataGridViewDoanhthu";
            this.dataGridViewDoanhthu.ReadOnly = true;
            this.dataGridViewDoanhthu.RowHeadersWidth = 51;
            this.dataGridViewDoanhthu.RowTemplate.Height = 24;
            this.dataGridViewDoanhthu.Size = new System.Drawing.Size(688, 242);
            this.dataGridViewDoanhthu.TabIndex = 49;
            this.dataGridViewDoanhthu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoanhthu_CellClick);
            // 
            // FormQlyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoLoQuan.Properties.Resources.bghongtim;
            this.ClientSize = new System.Drawing.Size(976, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonquaylai);
            this.Controls.Add(this.buttonTatca);
            this.Controls.Add(this.buttonThongke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtkt);
            this.Controls.Add(this.dtbd);
            this.Controls.Add(this.dataGridViewDoanhthu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQlyHoaDon";
            this.Text = "FormQlyHoaDon";
            this.Load += new System.EventHandler(this.FormQlyHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcthd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewcthd;
        private System.Windows.Forms.Button buttonquaylai;
        private System.Windows.Forms.Button buttonTatca;
        private System.Windows.Forms.Button buttonThongke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtkt;
        private System.Windows.Forms.DateTimePicker dtbd;
        private System.Windows.Forms.DataGridView dataGridViewDoanhthu;
    }
}