namespace Quanlycoffe
{
    partial class FormMenu
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
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.cbDanhmuc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTimmenu = new System.Windows.Forms.TextBox();
            this.buttonTimmenu = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridViewmenu = new System.Windows.Forms.DataGridView();
            this.buttonquaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // numGia
            // 
            this.numGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGia.Location = new System.Drawing.Point(843, 390);
            this.numGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numGia.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(240, 30);
            this.numGia.TabIndex = 33;
            // 
            // cbDanhmuc
            // 
            this.cbDanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhmuc.FormattingEnabled = true;
            this.cbDanhmuc.Location = new System.Drawing.Point(843, 160);
            this.cbDanhmuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDanhmuc.Name = "cbDanhmuc";
            this.cbDanhmuc.Size = new System.Drawing.Size(239, 33);
            this.cbDanhmuc.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(709, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Danh mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(709, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(709, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(709, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "ID:";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(843, 312);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(239, 30);
            this.txtTen.TabIndex = 26;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(843, 240);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(239, 30);
            this.txtId.TabIndex = 25;
            // 
            // txtTimmenu
            // 
            this.txtTimmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimmenu.Location = new System.Drawing.Point(124, 109);
            this.txtTimmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimmenu.Name = "txtTimmenu";
            this.txtTimmenu.Size = new System.Drawing.Size(177, 30);
            this.txtTimmenu.TabIndex = 24;
            // 
            // buttonTimmenu
            // 
            this.buttonTimmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimmenu.Location = new System.Drawing.Point(14, 102);
            this.buttonTimmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTimmenu.Name = "buttonTimmenu";
            this.buttonTimmenu.Size = new System.Drawing.Size(90, 50);
            this.buttonTimmenu.TabIndex = 23;
            this.buttonTimmenu.Text = "Tìm";
            this.buttonTimmenu.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(942, 545);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(105, 52);
            this.buttonXoa.TabIndex = 21;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(794, 590);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(105, 52);
            this.buttonSua.TabIndex = 20;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(794, 492);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(105, 52);
            this.buttonThem.TabIndex = 19;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewmenu
            // 
            this.dataGridViewmenu.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmenu.Location = new System.Drawing.Point(14, 160);
            this.dataGridViewmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewmenu.Name = "dataGridViewmenu";
            this.dataGridViewmenu.RowHeadersWidth = 51;
            this.dataGridViewmenu.RowTemplate.Height = 24;
            this.dataGridViewmenu.Size = new System.Drawing.Size(672, 546);
            this.dataGridViewmenu.TabIndex = 18;
            // 
            // buttonquaylai
            // 
            this.buttonquaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonquaylai.Location = new System.Drawing.Point(14, 15);
            this.buttonquaylai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonquaylai.Name = "buttonquaylai";
            this.buttonquaylai.Size = new System.Drawing.Size(138, 52);
            this.buttonquaylai.TabIndex = 42;
            this.buttonquaylai.Text = "Quay lại";
            this.buttonquaylai.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoLoQuan.Properties.Resources.bghongtim;
            this.ClientSize = new System.Drawing.Size(1105, 721);
            this.Controls.Add(this.buttonquaylai);
            this.Controls.Add(this.numGia);
            this.Controls.Add(this.cbDanhmuc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTimmenu);
            this.Controls.Add(this.buttonTimmenu);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridViewmenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.ComboBox cbDanhmuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTimmenu;
        private System.Windows.Forms.Button buttonTimmenu;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridView dataGridViewmenu;
        private System.Windows.Forms.Button buttonquaylai;
    }
}