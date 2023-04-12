using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoLoQuan
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();

        public static int nsd;

        private void buttonDangnhap_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from NGUOIDUNG where TENDANGNHAP='" + txtTaikhoan.Text + "'and MATKHAU='" + txtMatkhau.Text + "'");
            DataSet ds = kn.LayDuLieu(query, "NGUOIDUNG");
            if (txtTaikhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");

            }
            else if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");

            }
            else
            {
                if (ds.Tables["NGUOIDUNG"].Rows.Count == 1 && ds.Tables["NGUOIDUNG"].Rows[0][5].ToString() == "0")
                {
                    nsd = int.Parse(ds.Tables["NGUOIDUNG"].Rows[0][0].ToString());
                    FormHeThong ht = new FormHeThong();
                    txtMatkhau.Text = "";
                    txtTaikhoan.Text = "";
                    this.Hide();
                    ht.ShowDialog();
                    this.Show();
                }
                else if (ds.Tables["NGUOIDUNG"].Rows.Count == 1 && ds.Tables["NGUOIDUNG"].Rows[0][5].ToString() == "1")
                {
                    FormQuanTri ql = new FormQuanTri();
                    txtMatkhau.Text = "";
                    txtTaikhoan.Text = "";
                    this.Hide();
                    ql.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu không đúng");
                    txtMatkhau.Text = "";
                    txtTaikhoan.Text = "";
                }
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMK.Checked)
            {
                txtMatkhau.UseSystemPasswordChar = false;
            }
            else
                txtMatkhau.UseSystemPasswordChar = true;
        }
    }
}
