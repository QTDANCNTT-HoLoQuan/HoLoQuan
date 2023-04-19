namespace HoLoQuan
{
    partial class FormQkyOrder
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
            this.components = new System.ComponentModel.Container();
            this.buttonDoiban = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewttb = new System.Windows.Forms.DataGridView();
            this.txtidb = new System.Windows.Forms.TextBox();
            this.buttonGiamgia = new System.Windows.Forms.Button();
            this.cbDoiban = new System.Windows.Forms.ComboBox();
            this.buttonquaylai = new System.Windows.Forms.Button();
            this.buttonThanhtoan = new System.Windows.Forms.Button();
            this.cbGiamgia = new System.Windows.Forms.ComboBox();
            this.nrSoluong = new System.Windows.Forms.NumericUpDown();
            this.buttonThemmon = new System.Windows.Forms.Button();
            this.comboBoxMon = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxLoai = new System.Windows.Forms.ComboBox();
            this.groupBoxBan = new System.Windows.Forms.GroupBox();
            this.dANHMUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewttb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSoluong)).BeginInit();
            this.groupBoxBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDoiban
            // 
            this.buttonDoiban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDoiban.Location = new System.Drawing.Point(675, 467);
            this.buttonDoiban.Name = "buttonDoiban";
            this.buttonDoiban.Size = new System.Drawing.Size(105, 36);
            this.buttonDoiban.TabIndex = 47;
            this.buttonDoiban.Text = "Đổi bàn";
            this.buttonDoiban.UseVisualStyleBackColor = true;
            this.buttonDoiban.Click += new System.EventHandler(this.buttonDoiban_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewttb);
            this.groupBox1.Controls.Add(this.txtidb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(675, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 317);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Bàn:";
            // 
            // dataGridViewttb
            // 
            this.dataGridViewttb.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewttb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewttb.Location = new System.Drawing.Point(6, 56);
            this.dataGridViewttb.Name = "dataGridViewttb";
            this.dataGridViewttb.ReadOnly = true;
            this.dataGridViewttb.RowHeadersWidth = 51;
            this.dataGridViewttb.RowTemplate.Height = 24;
            this.dataGridViewttb.Size = new System.Drawing.Size(411, 255);
            this.dataGridViewttb.TabIndex = 26;
            // 
            // txtidb
            // 
            this.txtidb.Location = new System.Drawing.Point(81, 24);
            this.txtidb.Name = "txtidb";
            this.txtidb.Size = new System.Drawing.Size(90, 26);
            this.txtidb.TabIndex = 24;
            this.txtidb.TextChanged += new System.EventHandler(this.txtidb_TextChanged);
            // 
            // buttonGiamgia
            // 
            this.buttonGiamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGiamgia.Location = new System.Drawing.Point(826, 467);
            this.buttonGiamgia.Name = "buttonGiamgia";
            this.buttonGiamgia.Size = new System.Drawing.Size(105, 36);
            this.buttonGiamgia.TabIndex = 43;
            this.buttonGiamgia.Text = "Giảm giá";
            this.buttonGiamgia.UseVisualStyleBackColor = true;
            // 
            // cbDoiban
            // 
            this.cbDoiban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoiban.FormattingEnabled = true;
            this.cbDoiban.Location = new System.Drawing.Point(675, 509);
            this.cbDoiban.Name = "cbDoiban";
            this.cbDoiban.Size = new System.Drawing.Size(105, 28);
            this.cbDoiban.TabIndex = 48;
            // 
            // buttonquaylai
            // 
            this.buttonquaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonquaylai.Location = new System.Drawing.Point(27, 9);
            this.buttonquaylai.Name = "buttonquaylai";
            this.buttonquaylai.Size = new System.Drawing.Size(123, 42);
            this.buttonquaylai.TabIndex = 46;
            this.buttonquaylai.Text = "Quay lại";
            this.buttonquaylai.UseVisualStyleBackColor = false;
            this.buttonquaylai.Click += new System.EventHandler(this.buttonquaylai_Click);
            // 
            // buttonThanhtoan
            // 
            this.buttonThanhtoan.BackColor = System.Drawing.Color.Silver;
            this.buttonThanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThanhtoan.Location = new System.Drawing.Point(966, 481);
            this.buttonThanhtoan.Name = "buttonThanhtoan";
            this.buttonThanhtoan.Size = new System.Drawing.Size(131, 56);
            this.buttonThanhtoan.TabIndex = 45;
            this.buttonThanhtoan.Text = "Thanh toán";
            this.buttonThanhtoan.UseVisualStyleBackColor = false;
            this.buttonThanhtoan.Click += new System.EventHandler(this.buttonThanhtoan_Click);
            // 
            // cbGiamgia
            // 
            this.cbGiamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGiamgia.FormattingEnabled = true;
            this.cbGiamgia.Items.AddRange(new object[] {
            "10%",
            "20%",
            "50%"});
            this.cbGiamgia.Location = new System.Drawing.Point(826, 509);
            this.cbGiamgia.Name = "cbGiamgia";
            this.cbGiamgia.Size = new System.Drawing.Size(105, 28);
            this.cbGiamgia.TabIndex = 44;
            this.cbGiamgia.SelectedIndexChanged += new System.EventHandler(this.cbGiamgia_SelectedIndexChanged);
            // 
            // nrSoluong
            // 
            this.nrSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrSoluong.Location = new System.Drawing.Point(916, 88);
            this.nrSoluong.Name = "nrSoluong";
            this.nrSoluong.Size = new System.Drawing.Size(57, 26);
            this.nrSoluong.TabIndex = 42;
            this.nrSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonThemmon
            // 
            this.buttonThemmon.BackColor = System.Drawing.Color.Silver;
            this.buttonThemmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemmon.Location = new System.Drawing.Point(988, 65);
            this.buttonThemmon.Name = "buttonThemmon";
            this.buttonThemmon.Size = new System.Drawing.Size(109, 71);
            this.buttonThemmon.TabIndex = 41;
            this.buttonThemmon.Text = "Thêm món";
            this.buttonThemmon.UseVisualStyleBackColor = false;
            this.buttonThemmon.Click += new System.EventHandler(this.buttonThemmon_Click);
            // 
            // comboBoxMon
            // 
            this.comboBoxMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMon.FormattingEnabled = true;
            this.comboBoxMon.Location = new System.Drawing.Point(675, 108);
            this.comboBoxMon.Name = "comboBoxMon";
            this.comboBoxMon.Size = new System.Drawing.Size(224, 28);
            this.comboBoxMon.TabIndex = 40;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(6, 25);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(576, 449);
            this.flpTable.TabIndex = 35;
            // 
            // comboBoxLoai
            // 
            this.comboBoxLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoai.FormattingEnabled = true;
            this.comboBoxLoai.Location = new System.Drawing.Point(675, 65);
            this.comboBoxLoai.Name = "comboBoxLoai";
            this.comboBoxLoai.Size = new System.Drawing.Size(224, 28);
            this.comboBoxLoai.TabIndex = 39;
            this.comboBoxLoai.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoai_SelectedIndexChanged);
            // 
            // groupBoxBan
            // 
            this.groupBoxBan.Controls.Add(this.flpTable);
            this.groupBoxBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBan.Location = new System.Drawing.Point(42, 65);
            this.groupBoxBan.Name = "groupBoxBan";
            this.groupBoxBan.Size = new System.Drawing.Size(588, 480);
            this.groupBoxBan.TabIndex = 37;
            this.groupBoxBan.TabStop = false;
            this.groupBoxBan.Text = "Bàn";
            // 
            // dANHMUCBindingSource
            // 
            this.dANHMUCBindingSource.DataMember = "DANHMUC";
            // 
            // FormQkyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoLoQuan.Properties.Resources.bghongtim;
            this.ClientSize = new System.Drawing.Size(1178, 582);
            this.Controls.Add(this.buttonDoiban);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGiamgia);
            this.Controls.Add(this.cbDoiban);
            this.Controls.Add(this.buttonquaylai);
            this.Controls.Add(this.buttonThanhtoan);
            this.Controls.Add(this.cbGiamgia);
            this.Controls.Add(this.nrSoluong);
            this.Controls.Add(this.buttonThemmon);
            this.Controls.Add(this.comboBoxMon);
            this.Controls.Add(this.comboBoxLoai);
            this.Controls.Add(this.groupBoxBan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQkyOrder";
            this.Text = "FormQkyOrder";
            this.Load += new System.EventHandler(this.FormQkyOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewttb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSoluong)).EndInit();
            this.groupBoxBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDoiban;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewttb;
        private System.Windows.Forms.TextBox txtidb;
        private System.Windows.Forms.Button buttonGiamgia;
        private System.Windows.Forms.BindingSource dANHMUCBindingSource;
        private System.Windows.Forms.ComboBox cbDoiban;
        private System.Windows.Forms.Button buttonquaylai;
        private System.Windows.Forms.Button buttonThanhtoan;
        private System.Windows.Forms.ComboBox cbGiamgia;
        private System.Windows.Forms.NumericUpDown nrSoluong;
        private System.Windows.Forms.Button buttonThemmon;
        private System.Windows.Forms.ComboBox comboBoxMon;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ComboBox comboBoxLoai;
        private System.Windows.Forms.GroupBox groupBoxBan;
    }
}