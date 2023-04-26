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
    public partial class FormQlyHoaDon : Form
    {
        Ketnoi kn = new Ketnoi();
        public FormQlyHoaDon()
        {
            InitializeComponent();
        }

        private void buttonquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loaddatadt()
        {
            string querydv = "select * from LSGD";
            DataSet ds = kn.LayDuLieu(querydv, "LSGD");
            dataGridViewDoanhthu.DataSource = ds.Tables["LSGD"];
            dataGridViewDoanhthu.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
            dataGridViewDoanhthu.Columns[3].Width = 140;

        }

        private void FormQlyHoaDon_Load(object sender, EventArgs e)
        {
            loaddatadt();
        }

        private void buttonTatca_Click(object sender, EventArgs e)
        {
            loaddatadt();
        }

        private void buttonThongke_Click(object sender, EventArgs e)
        {
            string query = "select * from LSGD where NGAY BETWEEN '" + dtbd.Value.ToString("MM/dd/yyyy 00:00:00") + "' and '" + dtkt.Value.ToString("MM/dd/yyyy 23:59:59") + "'";
            DataSet ds = kn.LayDuLieu(query, "LSGD");
            dataGridViewDoanhthu.DataSource = ds.Tables["LSGD"];
        }

        public class cthd
        {
            static public string idhd;
            static public string idb;
            static public string ngay;
        }

        private void dataGridViewDoanhthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewDoanhthu.CurrentRow.Index;
            cthd.idhd = dataGridViewDoanhthu.Rows[i].Cells[0].Value.ToString();
            cthd.idb = dataGridViewDoanhthu.Rows[i].Cells[1].Value.ToString();
            cthd.ngay = dataGridViewDoanhthu.Rows[i].Cells[2].Value.ToString();
            string query = "select ID,IDHOADON,IDBAN,TenDV,SOLUONG,THANHTIEN,THOIGIAN from CTLSGD where IDHOADON='" + cthd.idhd + "' and IDBAN='" + cthd.idb + "'  ";
            DataSet ds0 = kn.LayDuLieu(query, "CTLSGD");
            dataGridViewcthd.DataSource = ds0.Tables["CTLSGD"];
            dataGridViewcthd.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
            dataGridViewcthd.Columns[6].Width = 140;
            dataGridViewcthd.Columns[3].Width = 160;
        }
    }
}
