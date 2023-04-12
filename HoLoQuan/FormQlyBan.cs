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
    public partial class FormQlyBan : Form
    {
        Ketnoi kn = new Ketnoi();
        public FormQlyBan()
        {
            InitializeComponent();
        }
        public void loaddatab()
        {
            string querydv = "select * from BAN";
            DataSet ds = kn.LayDuLieu(querydv, "BAN");
            dataGridViewBan.DataSource = ds.Tables["BAN"];
        }
        public void resetttinb()
        {
            txtIdban.Text = "";
            txtTenban.Text = "";
            cbTrangthai.Text = "";
        }

        private void buttonquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThemban_Click(object sender, EventArgs e)
        {
            string query0 = "select * from BAN where TENBAN=N'" + txtTenban.Text + "' ";
            DataSet ds0 = kn.LayDuLieu(query0, "BAN");
            if (ds0.Tables["BAN"].Rows.Count == 1)
            {
                MessageBox.Show("Tên bàn đã tồn tại");
            }
            else
            {
                string querydv = "insert into BAN(TENBAN,TRANGTHAI) values(N'" + txtTenban.Text + "',N'" + cbTrangthai.Text + "')";
                DataSet ds = kn.LayDuLieu(querydv, "BAN");
                resetttinb();
                loaddatab();
            }

        }

        private void buttonXoaban_Click(object sender, EventArgs e)
        {
            string query = "delete from BAN where ID = '" + txtIdban.Text + "' ";
            DataSet ds = kn.LayDuLieu(query, "BAN");
            resetttinb();
            loaddatab();
        }

        private void buttonSuaban_Click(object sender, EventArgs e)
        {
            string query0 = "select * from BAN where TENBAN=N'" + txtTenban.Text + "'and ID!='" + txtIdban.Text + "' ";
            DataSet ds0 = kn.LayDuLieu(query0, "BAN");
            if (ds0.Tables["BAN"].Rows.Count == 1)
            {
                MessageBox.Show("Tên bàn đã tồn tại");
            }
            else
            {
                string querytb = "update BAN set TENBAN=N'" + txtTenban.Text + "',TRANGTHAI=N'" + cbTrangthai.Text + "' where ID = '" + txtIdban.Text + "'";
                DataSet ds = kn.LayDuLieu(querytb, "BAN");
                resetttinb();
                loaddatab();
            }
        }

        private void FormQlyBan_Load(object sender, EventArgs e)
        {
            loaddatab();
            cbTrangthai.SelectedIndex = 0;
        }

        private void dataGridViewBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewBan.CurrentRow.Index;
            txtIdban.Text = dataGridViewBan.Rows[i].Cells[0].Value.ToString();
            txtTenban.Text = dataGridViewBan.Rows[i].Cells[1].Value.ToString();
            cbTrangthai.Text = dataGridViewBan.Rows[i].Cells[2].Value.ToString();
        }
    }
}
