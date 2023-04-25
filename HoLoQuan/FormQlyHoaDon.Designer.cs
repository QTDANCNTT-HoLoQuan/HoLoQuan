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
            this.groupBox1.Location = new System.Drawing.Point(139, 521);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(774, 324);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // dataGridViewcthd
            // 
            this.dataGridViewcthd.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcthd.Location = new System.Drawing.Point(7, 26);
            this.dataGridViewcthd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewcthd.Name = "dataGridViewcthd";
            this.dataGridViewcthd.ReadOnly = true;
            this.dataGridViewcthd.RowHeadersWidth = 51;
            this.dataGridViewcthd.RowTemplate.Height = 24;
            this.dataGridViewcthd.Size = new System.Drawing.Size(760, 290);
            this.dataGridViewcthd.TabIndex = 49;
            // 
            // buttonquaylai
            // 
            this.buttonquaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonquaylai.Location = new System.Drawing.Point(49, 54);
            this.buttonquaylai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonquaylai.Name = "buttonquaylai";
            this.buttonquaylai.Size = new System.Drawing.Size(138, 52);
            this.buttonquaylai.TabIndex = 56;
            this.buttonquaylai.Text = "Quay lại";
            this.buttonquaylai.UseVisualStyleBackColor = false;
            // 
            // buttonTatca
            // 
            this.buttonTatca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonTatca.Location = new System.Drawing.Point(49, 148);
            this.buttonTatca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTatca.Name = "buttonTatca";
            this.buttonTatca.Size = new System.Drawing.Size(154, 46);
            this.buttonTatca.TabIndex = 55;
            this.buttonTatca.Text = "Hiển thị tất cả";
            this.buttonTatca.UseVisualStyleBackColor = true;
            // 
            // buttonThongke
            // 
            this.buttonThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonThongke.Location = new System.Drawing.Point(836, 145);
            this.buttonThongke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThongke.Name = "buttonThongke";
            this.buttonThongke.Size = new System.Drawing.Size(132, 52);
            this.buttonThongke.TabIndex = 54;
            this.buttonThongke.Text = "Thống kê";
            this.buttonThongke.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(310, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 53;
            this.label2.Text = "Từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(556, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "Đến";
            // 
            // dtkt
            // 
            this.dtkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtkt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtkt.Location = new System.Drawing.Point(621, 152);
            this.dtkt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtkt.Name = "dtkt";
            this.dtkt.Size = new System.Drawing.Size(165, 28);
            this.dtkt.TabIndex = 51;
            // 
            // dtbd
            // 
            this.dtbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtbd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbd.Location = new System.Drawing.Point(357, 152);
            this.dtbd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtbd.Name = "dtbd";
            this.dtbd.Size = new System.Drawing.Size(166, 28);
            this.dtbd.TabIndex = 50;
            // 
            // dataGridViewDoanhthu
            // 
            this.dataGridViewDoanhthu.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanhthu.Location = new System.Drawing.Point(139, 211);
            this.dataGridViewDoanhthu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDoanhthu.Name = "dataGridViewDoanhthu";
            this.dataGridViewDoanhthu.ReadOnly = true;
            this.dataGridViewDoanhthu.RowHeadersWidth = 51;
            this.dataGridViewDoanhthu.RowTemplate.Height = 24;
            this.dataGridViewDoanhthu.Size = new System.Drawing.Size(774, 302);
            this.dataGridViewDoanhthu.TabIndex = 49;
            // 
            // FormQlyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoLoQuan.Properties.Resources.bghongtim;
            this.ClientSize = new System.Drawing.Size(1098, 868);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonquaylai);
            this.Controls.Add(this.buttonTatca);
            this.Controls.Add(this.buttonThongke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtkt);
            this.Controls.Add(this.dtbd);
            this.Controls.Add(this.dataGridViewDoanhthu);
            this.Name = "FormQlyHoaDon";
            this.Text = "FormQlyHoaDon";
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