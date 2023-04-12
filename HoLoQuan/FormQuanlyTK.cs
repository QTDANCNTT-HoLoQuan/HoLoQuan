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
    public partial class FormQuanlyTK : Form
    {
        Ketnoi kn = new Ketnoi();
        public FormQuanlyTK()
        {
            InitializeComponent();
        }
        public void loaddatatk()
        {
            string query = "select * from NGUOIDUNG";
            DataSet ds = kn.LayDuLieu(query, "NGUOIDUNG");
            dataGridViewTk.DataSource = ds.Tables["NGUOIDUNG"];
        }
        public void resetttindm()
        {
            txtTentk.Text = "";
            TxtHoTen.Text = "";
            txtMKnd.Text = "";
            txtDiachi.Text = "";

        }
        private void buttonquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewTk.CurrentRow.Index;
            txtTentk.Text = dataGridViewTk.Rows[i].Cells[2].Value.ToString();
            TxtHoTen.Text = dataGridViewTk.Rows[i].Cells[1].Value.ToString();
            txtMKnd.Text = dataGridViewTk.Rows[i].Cells[3].Value.ToString();
            txtDiachi.Text = dataGridViewTk.Rows[i].Cells[4].Value.ToString();
            if (dataGridViewTk.Rows[i].Cells[5].Value.ToString() == "1")
                cbLoaitk.SelectedIndex = 1;
            else cbLoaitk.SelectedIndex = 0;


        }

        private void FormQlyTK_Load(object sender, EventArgs e)
        {
            loaddatatk();
            cbLoaitk.SelectedIndex = 0;
        }

        private void buttonThemtk_Click(object sender, EventArgs e)
        {
            int loaitk = 0;
            if (cbLoaitk.SelectedIndex == 0)
                loaitk = 0;
            else loaitk = 1;

            string query0 = "select * from NGUOIDUNG where TENDANGNHAP=N'" + txtTentk.Text + "'";
            DataSet ds0 = kn.LayDuLieu(query0, "NGUOIDUNG");
            if (ds0.Tables["NGUOIDUNG"].Rows.Count == 1)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }
            else
            {
                string query = "insert into NGUOIDUNG(TENNGUOIDUNG,TENDANGNHAP,MATKHAU,DIACHI,LOAITK) values(N'" + TxtHoTen.Text + "','" + txtTentk.Text + "',N'" + txtMKnd.Text + "',N'" + txtDiachi.Text + "','" + loaitk + "')";
                DataSet ds = kn.LayDuLieu(query, "DANHMUC");
                resetttindm();
                loaddatatk();
            }
        }

        private void buttonSuatk_Click(object sender, EventArgs e)
        {
            int loaitk = 0;
            if (cbLoaitk.SelectedIndex == 0)
                loaitk = 0;
            else loaitk = 1;
            string query = "update NGUOIDUNG set TENNGUOIDUNG=N'" + TxtHoTen.Text + "',MATKHAU=N'" + txtMKnd.Text + "',DIACHI=N'" + txtDiachi.Text + "',LOAITK='" + loaitk + "' where TENDANGNHAP='" + txtTentk.Text + "'";
            DataSet ds = kn.LayDuLieu(query, "DANHMUC");
            resetttindm();
            loaddatatk();
        }

        private void buttonXoatk_Click(object sender, EventArgs e)
        {
            string query = "delete from NGUOIDUNG where TENDANGNHAP='" + txtTentk.Text + "'";
            DataSet ds = kn.LayDuLieu(query, "NGUOIDUNG");
            resetttindm();
            loaddatatk();
        }
    }
}
