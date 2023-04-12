namespace HoLoQuan
{
    partial class FormQlyBan
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
            this.cbTrangthai = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonXoaban = new System.Windows.Forms.Button();
            this.buttonSuaban = new System.Windows.Forms.Button();
            this.buttonThemban = new System.Windows.Forms.Button();
            this.txtTenban = new System.Windows.Forms.TextBox();
            this.txtIdban = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewBan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonquaylai
            // 
            this.buttonquaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonquaylai.Location = new System.Drawing.Point(12, 12);
            this.buttonquaylai.Name = "buttonquaylai";
            this.buttonquaylai.Size = new System.Drawing.Size(123, 42);
            this.buttonquaylai.TabIndex = 52;
            this.buttonquaylai.Text = "Quay lại";
            this.buttonquaylai.UseVisualStyleBackColor = false;
            this.buttonquaylai.Click += new System.EventHandler(this.buttonquaylai_Click);
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.FormattingEnabled = true;
            this.cbTrangthai.Items.AddRange(new object[] {
            "Trống",
            "Đang sử dụng"});
            this.cbTrangthai.Location = new System.Drawing.Point(736, 246);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(210, 24);
            this.cbTrangthai.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(625, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Trạng thái";
            // 
            // buttonXoaban
            // 
            this.buttonXoaban.Location = new System.Drawing.Point(814, 342);
            this.buttonXoaban.Name = "buttonXoaban";
            this.buttonXoaban.Size = new System.Drawing.Size(87, 44);
            this.buttonXoaban.TabIndex = 49;
            this.buttonXoaban.Text = "Xóa";
            this.buttonXoaban.UseVisualStyleBackColor = true;
            this.buttonXoaban.Click += new System.EventHandler(this.buttonXoaban_Click);
            // 
            // buttonSuaban
            // 
            this.buttonSuaban.Location = new System.Drawing.Point(708, 418);
            this.buttonSuaban.Name = "buttonSuaban";
            this.buttonSuaban.Size = new System.Drawing.Size(87, 44);
            this.buttonSuaban.TabIndex = 48;
            this.buttonSuaban.Text = "Sửa";
            this.buttonSuaban.UseVisualStyleBackColor = true;
            this.buttonSuaban.Click += new System.EventHandler(this.buttonSuaban_Click);
            // 
            // buttonThemban
            // 
            this.buttonThemban.Location = new System.Drawing.Point(708, 342);
            this.buttonThemban.Name = "buttonThemban";
            this.buttonThemban.Size = new System.Drawing.Size(87, 44);
            this.buttonThemban.TabIndex = 47;
            this.buttonThemban.Text = "Thêm";
            this.buttonThemban.UseVisualStyleBackColor = true;
            this.buttonThemban.Click += new System.EventHandler(this.buttonThemban_Click);
            // 
            // txtTenban
            // 
            this.txtTenban.Location = new System.Drawing.Point(736, 169);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.Size = new System.Drawing.Size(210, 22);
            this.txtTenban.TabIndex = 46;
            // 
            // txtIdban
            // 
            this.txtIdban.Location = new System.Drawing.Point(736, 104);
            this.txtIdban.Name = "txtIdban";
            this.txtIdban.ReadOnly = true;
            this.txtIdban.Size = new System.Drawing.Size(210, 22);
            this.txtIdban.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(625, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Tên bàn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(625, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "ID:";
            // 
            // dataGridViewBan
            // 
            this.dataGridViewBan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBan.Location = new System.Drawing.Point(12, 102);
            this.dataGridViewBan.Name = "dataGridViewBan";
            this.dataGridViewBan.ReadOnly = true;
            this.dataGridViewBan.RowHeadersWidth = 51;
            this.dataGridViewBan.RowTemplate.Height = 24;
            this.dataGridViewBan.Size = new System.Drawing.Size(597, 432);
            this.dataGridViewBan.TabIndex = 42;
            // 
            // FormQlyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoLoQuan.Properties.Resources.bghongtim;
            this.ClientSize = new System.Drawing.Size(963, 599);
            this.Controls.Add(this.buttonquaylai);
            this.Controls.Add(this.cbTrangthai);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonXoaban);
            this.Controls.Add(this.buttonSuaban);
            this.Controls.Add(this.buttonThemban);
            this.Controls.Add(this.txtTenban);
            this.Controls.Add(this.txtIdban);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewBan);
            this.Name = "FormQlyBan";
            this.Text = "FormQlyBan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonquaylai;
        private System.Windows.Forms.ComboBox cbTrangthai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonXoaban;
        private System.Windows.Forms.Button buttonSuaban;
        private System.Windows.Forms.Button buttonThemban;
        private System.Windows.Forms.TextBox txtTenban;
        private System.Windows.Forms.TextBox txtIdban;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewBan;
    }
}