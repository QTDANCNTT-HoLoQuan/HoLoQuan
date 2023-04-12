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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        public void loaddatadv()
        {
            string querydsdv = "select * from DICHVU";
            DataSet ds = kn.LayDuLieu(querydsdv, "DICHVU");
            ds.Tables["DICHVU"].Columns["TENDICHVU"].ColumnName = "Tên dịch vụ";
            ds.Tables["DICHVU"].Columns["IDDANHMUC"].ColumnName = "ID danh mục";
            ds.Tables["DICHVU"].Columns["GIATIEN"].ColumnName = "Giá tiền";
            dataGridViewmenu.DataSource = ds.Tables["DICHVU"];
        }
        public void resetttindv()
        {
            txtId.Text = "";
            txtTen.Text = "";
            numGia.Value = 0;
        }
        public void loaddm()
        {
            string querydv = "select * from DANHMUC";
            DataSet ds = kn.LayDuLieu(querydv, "DANHMUC");
            cbDanhmuc.DisplayMember = "TENDANHMUC";
            cbDanhmuc.ValueMember = "TENDANHMUC";
            cbDanhmuc.DataSource = ds.Tables["DANHMUC"];
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            int dm = 0;
            string query = "select * from DANHMUC";
            DataSet ds = kn.LayDuLieu(query, "DANHMUC");
            for (int j = 0; j < ds.Tables["DANHMUC"].Rows.Count; j++)
            {
                if (String.Compare(cbDanhmuc.Text, ds.Tables["DANHMUC"].Rows[j].ItemArray[1].ToString(), true) == 0)
                {
                    dm = int.Parse(ds.Tables["DANHMUC"].Rows[j].ItemArray[0].ToString());
                }
            }
            string query0 = "select * from DICHVU where TENDICHVU=N'" + txtTen.Text + "'and IDDANHMUC='" + dm + "' ";
            DataSet ds0 = kn.LayDuLieu(query0, "DICHVU");
            if (ds0.Tables["DICHVU"].Rows.Count == 1)
            {
                MessageBox.Show("Dịch vụ đã tồn tại");
            }
            else
            {
                string query1 = "insert into DICHVU(TENDICHVU,IDDANHMUC,GIATIEN) values(N'" + txtTen.Text + "','" + dm + "','" + numGia.Value + "')";
                DataSet ds1 = kn.LayDuLieu(query1, "DICHVU");
                MessageBox.Show("Thêm thành công");
                resetttindv();
                loaddatadv();
            }   
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            int dm = 0;
            string query = "select * from DANHMUC";
            DataSet ds = kn.LayDuLieu(query, "DANHMUC");
            for (int j = 0; j < ds.Tables["DANHMUC"].Rows.Count; j++)
            {
                if (String.Compare(cbDanhmuc.Text, ds.Tables["DANHMUC"].Rows[j].ItemArray[1].ToString(), true) == 0)
                {
                    dm = int.Parse(ds.Tables["DANHMUC"].Rows[j].ItemArray[0].ToString());
                }
            }
            string query0 = "select * from DICHVU where TENDICHVU=N'" + txtTen.Text + "'and IDDANHMUC='" + dm + "' and ID!='" + txtId.Text + "' ";
            DataSet ds0 = kn.LayDuLieu(query0, "DICHVU");
            if (ds0.Tables["DICHVU"].Rows.Count == 1)
            {
                MessageBox.Show("Dịch vụ đã tồn tại");
            }
            else
            {
                string query1 = "update DICHVU set TENDICHVU =N'" + txtTen.Text + "',IDDANHMUC='" + dm + "',GIATIEN='" + numGia.Value + "'where ID = '" + txtId.Text + "' ";
                DataSet ds1 = kn.LayDuLieu(query1, "DICHVU");
                MessageBox.Show("Sửa thành công");
                resetttindv();
                loaddatadv();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string query = "delete from DICHVU where ID = '" + txtId.Text + "' ";
            DataSet ds = kn.LayDuLieu(query, "DICHVU");
            MessageBox.Show("Xóa thành công");
            resetttindv();
            loaddatadv();
        }

        private void dataGridViewmenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "select * from DANHMUC";
            DataSet ds = kn.LayDuLieu(query, "DANHMUC");
            int i;
            i = dataGridViewmenu.CurrentRow.Index;
            txtId.Text = dataGridViewmenu.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dataGridViewmenu.Rows[i].Cells[1].Value.ToString();
            for (int j = 0; j < ds.Tables["DANHMUC"].Rows.Count; j++)
            {
                if (dataGridViewmenu.Rows[i].Cells[2].Value.ToString() == ds.Tables["DANHMUC"].Rows[j].ItemArray[0].ToString() && i < dataGridViewmenu.Rows.Count)
                    cbDanhmuc.SelectedIndex = j;
            }
            if (i > dataGridViewmenu.Rows.Count)
                cbDanhmuc.Text = "";
            numGia.Text = dataGridViewmenu.Rows[i].Cells[3].Value.ToString();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            loaddm();
            loaddatadv();
        }

        private void buttonTimmenu_Click(object sender, EventArgs e)
        {
            string query = "select * from DICHVU where TENDICHVU like N'%" + @txtTimmenu.Text + "%' ";
            DataSet ds = kn.LayDuLieu(query, "DICHVU");
            dataGridViewmenu.DataSource = ds.Tables["DICHVU"];
        }

        private void buttonquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
