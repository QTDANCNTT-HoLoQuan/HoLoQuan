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
    public partial class FormHeThong : Form
    {
        public FormHeThong()
        {
            InitializeComponent();
        }

        private void buttonqlod_Click(object sender, EventArgs e)
        {
            //FormOrder ht = new FormOrder();
            //this.Hide();
            //ht.ShowDialog();
            //this.Show();
        }

        private void buttonDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDichvu_Click(object sender, EventArgs e)
        {
            //FormThongTinCaNhan cn = new FormThongTinCaNhan();
            //this.Hide();
            //cn.ShowDialog();
            //this.Show();
        }

        private void buttonXuat_Click(object sender, EventArgs e)
        {
            //FormXuatkho xk = new FormXuatkho();
            //xk.ShowDialog();
        }
    }
}
