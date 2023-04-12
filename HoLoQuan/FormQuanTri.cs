using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoLoQuan
{
    public partial class FormQuanTri : Form
    {
        public FormQuanTri()
        {
            InitializeComponent();
        }

        private void buttonDoanhthu_Click(object sender, EventArgs e)
        {
            //FormDoanhThu dt = new FormDoanhThu();
            //this.Hide();
            //dt.ShowDialog();
            //this.Show();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            //FormMenu mn = new FormMenu();
            //this.Hide();
            //mn.ShowDialog();
            //this.Show();
        }

        private void buttonTaikhoan_Click(object sender, EventArgs e)
        {
            //FormQlyTK tk = new FormQlyTK();
            //this.Hide();
            //tk.ShowDialog();
            //this.Show();
        }

        private void buttonDanhmuc_Click(object sender, EventArgs e)
        {
            //FormQlyDM dm = new FormQlyDM();
            //this.Hide();
            //dm.ShowDialog();
            //this.Show();
        }

        private void buttonBan_Click(object sender, EventArgs e)
        {
            FormQlyBan qlb = new FormQlyBan();
            this.Hide();
            qlb.ShowDialog();
            this.Show();
        }

        private void buttonKho_Click(object sender, EventArgs e)
        {
            //FormQlyKho qlk = new FormQlyKho();
            //this.Hide();
            //qlk.ShowDialog();
            //this.Show();
        }
        
        private void buttonqlod_Click(object sender, EventArgs e)
        {
            //FormOrder qlo = new FormOrder();
            //this.Hide();
            //qlo.ShowDialog();
            //this.Show();
        }

        private void buttonDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
