namespace HoLoQuan
{
    partial class FormQuanlyBan
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
            this.buttonquaylai.Location = new System.Drawing.Point(38, 22);
            this.buttonquaylai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonquaylai.Name = "buttonquaylai";
            this.buttonquaylai.Size = new System.Drawing.Size(138, 52);
            this.buttonquaylai.TabIndex = 52;
            this.buttonquaylai.Text = "Quay lại";
            this.buttonquaylai.UseVisualStyleBackColor = false;
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.FormattingEnabled = true;
            this.cbTrangthai.Items.AddRange(new object[] {
            "Trống",
            "Đang sử dụng"});
            this.cbTrangthai.Location = new System.Drawing.Point(852, 315);
            this.cbTrangthai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(236, 28);
            this.cbTrangthai.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(727, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "Trạng thái";
            // 
            // buttonXoaban
            // 
            this.buttonXoaban.Location = new System.Drawing.Point(940, 435);
            this.buttonXoaban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXoaban.Name = "buttonXoaban";
            this.buttonXoaban.Size = new System.Drawing.Size(98, 55);
            this.buttonXoaban.TabIndex = 49;
            this.buttonXoaban.Text = "Xóa";
            this.buttonXoaban.UseVisualStyleBackColor = true;
            // 
            // buttonSuaban
            // 
            this.buttonSuaban.Location = new System.Drawing.Point(820, 529);
            this.buttonSuaban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSuaban.Name = "buttonSuaban";
            this.buttonSuaban.Size = new System.Drawing.Size(98, 55);
            this.buttonSuaban.TabIndex = 48;
            this.buttonSuaban.Text = "Sửa";
            this.buttonSuaban.UseVisualStyleBackColor = true;
            // 
            // buttonThemban
            // 
            this.buttonThemban.Location = new System.Drawing.Point(820, 435);
            this.buttonThemban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThemban.Name = "buttonThemban";
            this.buttonThemban.Size = new System.Drawing.Size(98, 55);
            this.buttonThemban.TabIndex = 47;
            this.buttonThemban.Text = "Thêm";
            this.buttonThemban.UseVisualStyleBackColor = true;
            // 
            // txtTenban
            // 
            this.txtTenban.Location = new System.Drawing.Point(852, 218);
            this.txtTenban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.Size = new System.Drawing.Size(236, 26);
            this.txtTenban.TabIndex = 46;
            // 
            // txtIdban
            // 
            this.txtIdban.Location = new System.Drawing.Point(852, 137);
            this.txtIdban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdban.Name = "txtIdban";
            this.txtIdban.ReadOnly = true;
            this.txtIdban.Size = new System.Drawing.Size(236, 26);
            this.txtIdban.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(727, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Tên bàn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(727, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "ID:";
            // 
            // dataGridViewBan
            // 
            this.dataGridViewBan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBan.Location = new System.Drawing.Point(38, 135);
            this.dataGridViewBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBan.Name = "dataGridViewBan";
            this.dataGridViewBan.ReadOnly = true;
            this.dataGridViewBan.RowHeadersWidth = 51;
            this.dataGridViewBan.RowTemplate.Height = 24;
            this.dataGridViewBan.Size = new System.Drawing.Size(672, 540);
            this.dataGridViewBan.TabIndex = 42;
            // 
            // FormQuanlyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoLoQuan.Properties.Resources.bghongtim;
            this.ClientSize = new System.Drawing.Size(1235, 696);
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
            this.Name = "FormQuanlyBan";
            this.Text = "FormQuanlyBan";
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