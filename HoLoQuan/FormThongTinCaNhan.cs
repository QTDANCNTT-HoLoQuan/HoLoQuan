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
    public partial class FormThongTinCaNhan : Form
    {
        Ketnoi kn = new Ketnoi();
        public FormThongTinCaNhan()
        {
            InitializeComponent();
        }
        public void loaddatattnv()
        {
            string querydv = "select * from NGUOIDUNG where ID='" + FormLogin.nsd + "'";
            DataSet ds = kn.LayDuLieu(querydv, "NGUOIDUNG");
            txtTendangnhap.Text = ds.Tables["NGUOIDUNG"].Rows[0][2].ToString();
            txtHoten.Text = ds.Tables["NGUOIDUNG"].Rows[0][1].ToString();
            txtDiachi.Text = ds.Tables["NGUOIDUNG"].Rows[0][4].ToString();
        }
        private void buttonCapnhat_Click(object sender, EventArgs e)
        {
            string querydv = "select * from NGUOIDUNG where ID='" + FormLogin.nsd + "'";
            DataSet ds = kn.LayDuLieu(querydv, "NGUOIDUNG");
            if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu để cập nhật thông tin");
            }
            else if (ds.Tables["NGUOIDUNG"].Rows[0][3].ToString() == txtMatkhau.Text)
            {
                if (txtMatkhaumoi.Text == "" && txtNhaplaimk.Text == "")
                {
                    string querydc = "update NGUOIDUNG set DIACHI=N'" + txtDiachi.Text + "' where ID='" + FormLogin.nsd + "' ";
                    DataSet ds1 = kn.LayDuLieu(querydc, "NGUOIDUNG");
                    MessageBox.Show("Cập nhật thông tin thành công");
                    txtMatkhau.Text = "";
                }
                else if (txtMatkhaumoi.Text == txtNhaplaimk.Text && txtMatkhaumoi.Text != "" && txtNhaplaimk.Text != "")
                {
                    string querymk = "update NGUOIDUNG set MATKHAU=N'" + txtMatkhaumoi.Text + "',DIACHI=N'" + txtDiachi.Text + "' where ID='" + FormLogin.nsd + "' ";
                    DataSet ds2 = kn.LayDuLieu(querymk, "NGUOIDUNG");
                    MessageBox.Show("Cập nhật thông tin thành công");
                    txtMatkhau.Text = txtMatkhaumoi.Text = txtNhaplaimk.Text = "";

                }
                else
                {
                    MessageBox.Show("Thông tin không đúng");
                }

            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng");
            }
        }

        private void buttonquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThongTinCaNhan_Load(object sender, EventArgs e)
        {
            loaddatattnv();
        }
    }
}
