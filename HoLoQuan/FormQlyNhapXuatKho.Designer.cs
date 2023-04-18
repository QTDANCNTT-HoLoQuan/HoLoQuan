namespace HoLoQuan
{
    partial class FormQlyNhapXuatKho
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
            this.buttonquaylai = new System.Windows.Forms.Button();
            this.dataGridViewkho = new System.Windows.Forms.DataGridView();
            this.nrSoluong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbtmh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonXh = new System.Windows.Forms.Button();
            this.buttonNh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonquaylai
            // 
            this.buttonquaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonquaylai.Location = new System.Drawing.Point(42, 27);
            this.buttonquaylai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonquaylai.Name = "buttonquaylai";
            this.buttonquaylai.Size = new System.Drawing.Size(138, 52);
            this.buttonquaylai.TabIndex = 60;
            this.buttonquaylai.Text = "Quay lại";
            this.buttonquaylai.UseVisualStyleBackColor = false;
            // 
            // dataGridViewkho
            // 
            this.dataGridViewkho.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkho.Location = new System.Drawing.Point(42, 92);
            this.dataGridViewkho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewkho.Name = "dataGridViewkho";
            this.dataGridViewkho.ReadOnly = true;
            this.dataGridViewkho.RowHeadersWidth = 51;
            this.dataGridViewkho.RowTemplate.Height = 24;
            this.dataGridViewkho.Size = new System.Drawing.Size(577, 480);
            this.dataGridViewkho.TabIndex = 59;
            // 
            // nrSoluong
            // 
            this.nrSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrSoluong.Location = new System.Drawing.Point(813, 194);
            this.nrSoluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nrSoluong.Name = "nrSoluong";
            this.nrSoluong.Size = new System.Drawing.Size(210, 30);
            this.nrSoluong.TabIndex = 58;
            this.nrSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Tên mặt hàng:";
            // 
            // cbtmh
            // 
            this.cbtmh.FormattingEnabled = true;
            this.cbtmh.Location = new System.Drawing.Point(813, 113);
            this.cbtmh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbtmh.Name = "cbtmh";
            this.cbtmh.Size = new System.Drawing.Size(210, 28);
            this.cbtmh.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Số lượng:";
            // 
            // buttonXh
            // 
            this.buttonXh.BackColor = System.Drawing.Color.Silver;
            this.buttonXh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXh.Location = new System.Drawing.Point(889, 313);
            this.buttonXh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXh.Name = "buttonXh";
            this.buttonXh.Size = new System.Drawing.Size(135, 62);
            this.buttonXh.TabIndex = 54;
            this.buttonXh.Text = "Xuất";
            this.buttonXh.UseVisualStyleBackColor = false;
            // 
            // buttonNh
            // 
            this.buttonNh.BackColor = System.Drawing.Color.Silver;
            this.buttonNh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNh.Location = new System.Drawing.Point(668, 313);
            this.buttonNh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNh.Name = "buttonNh";
            this.buttonNh.Size = new System.Drawing.Size(135, 62);
            this.buttonNh.TabIndex = 53;
            this.buttonNh.Text = "Nhập";
            this.buttonNh.UseVisualStyleBackColor = false;
            // 
            // FormQlyNhapXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoLoQuan.Properties.Resources.bghongtim;
            this.ClientSize = new System.Drawing.Size(1136, 590);
            this.Controls.Add(this.buttonquaylai);
            this.Controls.Add(this.dataGridViewkho);
            this.Controls.Add(this.nrSoluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbtmh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonXh);
            this.Controls.Add(this.buttonNh);
            this.Name = "FormQlyNhapXuatKho";
            this.Text = "FormQlyNhapXuatKho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonquaylai;
        private System.Windows.Forms.DataGridView dataGridViewkho;
        private System.Windows.Forms.NumericUpDown nrSoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbtmh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonXh;
        private System.Windows.Forms.Button buttonNh;
    }
}