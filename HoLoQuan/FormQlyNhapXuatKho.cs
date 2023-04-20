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
    public partial class FormQlyNhapXuatKho : Form
    {
        Ketnoi kn = new Ketnoi();
        public FormQlyNhapXuatKho()
        {
            InitializeComponent();
        }

        public void loaddatamh()
        {
            string querydv = "select * from KHO";
            DataSet ds = kn.LayDuLieu(querydv, "KHO");
            dataGridViewkho.DataSource = ds.Tables["KHO"];
            cbtmh.DisplayMember = "TENMATHANG";
            cbtmh.ValueMember = "TENMATHANG";
            cbtmh.DataSource = ds.Tables["KHO"];
            cbtmh.Text = "";
        }
        public void resetttmh()
        {
            cbtmh.Text = "";
            nrSoluong.Value = 0;
        }

        private void buttonquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQlyNhapXuatKho_Load(object sender, EventArgs e)
        {
            loaddatamh();
        }

        private void buttonNh_Click(object sender, EventArgs e)
        {
            string querytt = "select * from NGUOIDUNG where ID='" + FormLogin.nsd + "'";
            DataSet ds0 = kn.LayDuLieu(querytt, "NGUOIDUNG");

            if (cbtmh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên mặt hàng");
            }
            else
            {
                string querydv = "select * from KHO where TENMATHANG=N'" + cbtmh.Text + "'";
                DataSet ds = kn.LayDuLieu(querydv, "KHO");
                if (ds.Tables["KHO"].Rows.Count == 0)
                {
                    string queryth = "insert into KHO(TENMATHANG,SOLUONG) values(N'" + cbtmh.Text + "','" + nrSoluong.Value + "')";
                    DataSet ds1 = kn.LayDuLieu(queryth, "KHO");
                    string querylt1 = "insert into LSNX(TENMATHANG,SOLUONG,TRANGTHAI,IDNV,TENNV)values(N'" + cbtmh.Text + "','" + nrSoluong.Value + "',N'Nhập','" + FormLogin.nsd + "',N'" + ds0.Tables["NGUOIDUNG"].Rows[0][1].ToString() + "')";
                    DataSet ds3 = kn.LayDuLieu(querylt1, "LSNX");
                    MessageBox.Show("Nhập kho thành công");
                    loaddatamh();
                }
                else if (ds.Tables["KHO"].Rows.Count == 1)
                {
                    string queryud = "update KHO set SOLUONG+='" + nrSoluong.Value + "' where TENMATHANG=N'" + cbtmh.Text + "' ";
                    DataSet ds2 = kn.LayDuLieu(queryud, "KHO");
                    string querylt2 = "insert into LSNX(TENMATHANG,SOLUONG,TRANGTHAI,IDNV,TENNV)values(N'" + cbtmh.Text + "','" + nrSoluong.Value + "',N'Nhập','" + FormLogin.nsd + "',N'" + ds0.Tables["NGUOIDUNG"].Rows[0][1].ToString() + "')";
                    DataSet ds4 = kn.LayDuLieu(querylt2, "LSNX");
                    MessageBox.Show("Nhập kho thành công");
                    loaddatamh();
                }
            }
        }

        private void buttonXh_Click(object sender, EventArgs e)
        {
            if (cbtmh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tên mặt hàng");
            }
            else
            {
                string querydv = "select * from KHO where TENMATHANG=N'" + cbtmh.Text + "'";
                DataSet ds = kn.LayDuLieu(querydv, "KHO");
                if (ds.Tables["KHO"].Rows.Count == 0)
                {
                    MessageBox.Show("Mặt hàng không tồn tại. Vui lòng kiểm tra lại");
                    cbtmh.Text = "";
                }
                else if (ds.Tables["KHO"].Rows.Count == 1)
                {
                    if (int.Parse(ds.Tables["KHO"].Rows[0][2].ToString()) < nrSoluong.Value)
                    {
                        MessageBox.Show("Mặt hàng này chỉ còn " + ds.Tables["KHO"].Rows[0][2].ToString());
                    }
                    else
                    {
                        string querytb = "update KHO set SOLUONG-='" + nrSoluong.Value + "' where TENMATHANG=N'" + cbtmh.Text + "' ";
                        DataSet ds2 = kn.LayDuLieu(querytb, "KHO");
                        MessageBox.Show("Xuất kho thành công");
                        loaddatamh();
                    }

                }
            }
        }
    }
}
