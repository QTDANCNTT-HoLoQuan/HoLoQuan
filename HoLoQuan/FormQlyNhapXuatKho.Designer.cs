﻿namespace HoLoQuan
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
            this.buttonquaylai.Location = new System.Drawing.Point(37, 22);
            this.buttonquaylai.Name = "buttonquaylai";
            this.buttonquaylai.Size = new System.Drawing.Size(123, 42);
            this.buttonquaylai.TabIndex = 60;
            this.buttonquaylai.Text = "Quay lại";
            this.buttonquaylai.UseVisualStyleBackColor = false;
            this.buttonquaylai.Click += new System.EventHandler(this.buttonquaylai_Click);
            // 
            // dataGridViewkho
            // 
            this.dataGridViewkho.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkho.Location = new System.Drawing.Point(37, 74);
            this.dataGridViewkho.Name = "dataGridViewkho";
            this.dataGridViewkho.ReadOnly = true;
            this.dataGridViewkho.RowHeadersWidth = 51;
            this.dataGridViewkho.RowTemplate.Height = 24;
            this.dataGridViewkho.Size = new System.Drawing.Size(513, 384);
            this.dataGridViewkho.TabIndex = 59;
            // 
            // nrSoluong
            // 
            this.nrSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrSoluong.Location = new System.Drawing.Point(723, 155);
            this.nrSoluong.Name = "nrSoluong";
            this.nrSoluong.Size = new System.Drawing.Size(187, 26);
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
            this.label5.Location = new System.Drawing.Point(590, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Tên mặt hàng:";
            // 
            // cbtmh
            // 
            this.cbtmh.FormattingEnabled = true;
            this.cbtmh.Location = new System.Drawing.Point(723, 90);
            this.cbtmh.Name = "cbtmh";
            this.cbtmh.Size = new System.Drawing.Size(187, 24);
            this.cbtmh.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Số lượng:";
            // 
            // buttonXh
            // 
            this.buttonXh.BackColor = System.Drawing.Color.Silver;
            this.buttonXh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXh.Location = new System.Drawing.Point(790, 250);
            this.buttonXh.Name = "buttonXh";
            this.buttonXh.Size = new System.Drawing.Size(120, 50);
            this.buttonXh.TabIndex = 54;
            this.buttonXh.Text = "Xuất";
            this.buttonXh.UseVisualStyleBackColor = false;
            this.buttonXh.Click += new System.EventHandler(this.buttonXh_Click);
            // 
            // buttonNh
            // 
            this.buttonNh.BackColor = System.Drawing.Color.Silver;
            this.buttonNh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNh.Location = new System.Drawing.Point(594, 250);
            this.buttonNh.Name = "buttonNh";
            this.buttonNh.Size = new System.Drawing.Size(120, 50);
            this.buttonNh.TabIndex = 53;
            this.buttonNh.Text = "Nhập";
            this.buttonNh.UseVisualStyleBackColor = false;
            this.buttonNh.Click += new System.EventHandler(this.buttonNh_Click);
            // 
            // FormQlyNhapXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoLoQuan.Properties.Resources.bghongtim;
            this.ClientSize = new System.Drawing.Size(1010, 472);
            this.Controls.Add(this.buttonquaylai);
            this.Controls.Add(this.dataGridViewkho);
            this.Controls.Add(this.nrSoluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbtmh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonXh);
            this.Controls.Add(this.buttonNh);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQlyNhapXuatKho";
            this.Text = "FormQlyNhapXuatKho";
            this.Load += new System.EventHandler(this.FormQlyNhapXuatKho_Load);
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