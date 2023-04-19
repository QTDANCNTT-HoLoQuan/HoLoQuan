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
    public partial class FormQkyOrder : Form
    {
        Ketnoi kn = new Ketnoi();
        public FormQkyOrder()
        {
            InitializeComponent();
        }

        public void loaddm()
        {
            string querydv = "select * from DANHMUC";
            DataSet ds = kn.LayDuLieu(querydv, "DANHMUC");
            comboBoxLoai.DisplayMember = "TENDANHMUC";
            comboBoxLoai.ValueMember = "TENDANHMUC";
            comboBoxLoai.DataSource = ds.Tables["DANHMUC"];
        }
        public void loaddvpdsd()
        {
            string querycthd = "select TenDV,SOLUONG,THANHTIEN from CTHOADON where IDBAN='" + txtidb.Text + "'";
            DataSet ds = kn.LayDuLieu(querycthd, "CTHOADON");
            dataGridViewttb.DataSource = ds.Tables["CTHOADON"];
        }
        public static int mb;
        public void loadttb()
        {
            flpTable.Controls.Clear();
            string querydv = "select * from BAN";
            DataSet ds = kn.LayDuLieu(querydv, "BAN");
            for (int i = 0; i < ds.Tables["BAN"].Rows.Count; i++)
            {
                string mb = ds.Tables["BAN"].Rows[i].ItemArray[0].ToString();
                Button btsb = new Button();
                btsb.Width = 95;
                btsb.Height = 95;
                btsb.Name = "Ban" + i;
                btsb.Tag = ds.Tables["BAN"].Rows[i].ItemArray[0].ToString();
                btsb.Text = "ID:" + ds.Tables["BAN"].Rows[i].ItemArray[0].ToString() + "\n" + "(" + ds.Tables["BAN"].Rows[i].ItemArray[1].ToString() + ")" + "\n" + ds.Tables["BAN"].Rows[i].ItemArray[2].ToString();
                if (ds.Tables["BAN"].Rows[i].ItemArray[2].ToString() == "Đang sử dụng")
                    btsb.BackColor = Color.OrangeRed;
                if (ds.Tables["BAN"].Rows[i].ItemArray[2].ToString() == "Trống")
                    btsb.BackColor = Color.YellowGreen;
                btsb.Click += Btsb_Click;
                flpTable.Controls.Add(btsb);
            }
        }

        private void Btsb_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtidb.Text = bt.Tag.ToString();
        }

        public void loaddoip()
        {
            string querydoip = "select ID from BAN where TRANGTHAI=N'Trống'";
            DataSet ds = kn.LayDuLieu(querydoip, "BAN");
            cbDoiban.DisplayMember = "ID";
            cbDoiban.ValueMember = "TRANGTHAI";
            cbDoiban.DataSource = ds.Tables["BAN"];

        }
        private void buttonquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQkyOrder_Load(object sender, EventArgs e)
        {
            loaddm();
            loadttb();
            loaddoip();
        }
        public class idbtt
        {
            static public string mb;
        }

        private void txtidb_TextChanged(object sender, EventArgs e)
        {
            idbtt.mb = txtidb.Text;
            string querycthd = "select TenDV,SOLUONG,THANHTIEN from CTHOADON where IDBAN='" + txtidb.Text + "'";
            DataSet ds = kn.LayDuLieu(querycthd, "CTHOADON");
            dataGridViewttb.DataSource = ds.Tables["CTHOADON"];
        }

        private void buttonThemmon_Click(object sender, EventArgs e)
        {
            string ktiddv, ktidhd;
            int dgdv, ktsl = 0;
            if (txtidb.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn");
            }
            else
            {
                string querydv = "select * from BAN where ID='" + txtidb.Text + "'";
                DataSet ds = kn.LayDuLieu(querydv, "BAN");
                if (ds.Tables["BAN"].Rows[0][2].ToString() == "Trống")
                {
                    string querycnb = "update BAN set TRANGTHAI=N'Đang sử dụng' where ID='" + txtidb.Text + "' ";
                    DataSet ds3 = kn.LayDuLieu(querycnb, "BAN");

                    string querythd = "insert into HOADON(IDBAN)values('" + txtidb.Text + "')";
                    DataSet ds4 = kn.LayDuLieu(querythd, "HOADON");

                    string querytdv = "select ID,GIATIEN from DICHVU where TENDICHVU=N'" + comboBoxMon.Text + "'";
                    DataSet ds5 = kn.LayDuLieu(querytdv, "DICHVU");
                    ktiddv = ds5.Tables["DICHVU"].Rows[0].ItemArray[0].ToString();
                    dgdv = int.Parse(ds5.Tables["DICHVU"].Rows[0].ItemArray[1].ToString());

                    string querytidhd = "select ID from HOADON where IDBAN='" + txtidb.Text + "'";
                    DataSet ds6 = kn.LayDuLieu(querytidhd, "HOADON");
                    ktidhd = ds6.Tables["HOADON"].Rows[0].ItemArray[0].ToString();

                    int tt = (int)(nrSoluong.Value * dgdv);
                    string querycthd = "insert into CTHOADON(IDHOADON,IDBAN,IDDV,TenDV,SOLUONG,THANHTIEN) values ('" + ktidhd + "','" + txtidb.Text + "','" + ktiddv + "',N'" + comboBoxMon.Text + "','" + nrSoluong.Value + "','" + tt + "')";
                    DataSet ds8 = kn.LayDuLieu(querycthd, "CTHOADON");
                    loadttb();
                    loaddvpdsd();
                }
                else
                {
                    string querytdv1 = "select ID,GIATIEN from DICHVU where TENDICHVU=N'" + comboBoxMon.Text + "'";
                    DataSet ds00 = kn.LayDuLieu(querytdv1, "DICHVU");
                    ktiddv = ds00.Tables["DICHVU"].Rows[0].ItemArray[0].ToString();
                    dgdv = int.Parse(ds00.Tables["DICHVU"].Rows[0].ItemArray[1].ToString());

                    string querytidhd1 = "select ID from HOADON where IDBAN='" + txtidb.Text + "'";
                    DataSet ds01 = kn.LayDuLieu(querytidhd1, "HOADON");
                    ktidhd = ds01.Tables["HOADON"].Rows[0].ItemArray[0].ToString();

                    string queryktsl = "select * from CTHOADON where IDDV='" + ktiddv + "' and IDBAN='" + txtidb.Text + "'";
                    DataSet ds03 = kn.LayDuLieu(queryktsl, "CTHOADON");

                    if (ds03.Tables["CTHOADON"].Rows.Count == 0)
                    {
                        int tt1 = (int)(nrSoluong.Value * dgdv);
                        string querycthd = "insert into CTHOADON(IDHOADON,IDBAN,IDDV,TenDV,SOLUONG,THANHTIEN) values ('" + ktidhd + "','" + txtidb.Text + "','" + ktiddv + "',N'" + comboBoxMon.Text + "','" + nrSoluong.Value + "','" + tt1 + "')";
                        DataSet ds04 = kn.LayDuLieu(querycthd, "CTHOADON");
                        loadttb();
                        loaddvpdsd();
                    }
                    else
                    {
                        ktsl = int.Parse(ds03.Tables["CTHOADON"].Rows[0].ItemArray[5].ToString());
                        int ttt = ktsl * dgdv;
                        string querytsl = "update CTHOADON set SOLUONG += '" + nrSoluong.Value + "',THANHTIEN+='" + ttt + "' where IDDV='" + ktiddv + "' and IDBAN='" + txtidb.Text + "'";
                        DataSet ds05 = kn.LayDuLieu(querytsl, "CTHOADON");
                        loadttb();
                        loaddvpdsd();
                    }
                }
            }
        }

        private void comboBoxLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMon.Text = "";
            string ktdm;
            if (comboBoxLoai.SelectedIndex == 0)
                ktdm = "1";
            else if (comboBoxLoai.SelectedIndex == 1)
                ktdm = "2";
            else
                ktdm = "3";
            string querydv = "select * from DICHVU where IDDANHMUC='" + ktdm + "'";
            DataSet ds = kn.LayDuLieu(querydv, "DICHVU");
            comboBoxMon.DisplayMember = "TENDICHVU";
            comboBoxMon.ValueMember = "TENDICHVU";
            comboBoxMon.DataSource = ds.Tables["DICHVU"];
        }

        private void buttonThanhtoan_Click(object sender, EventArgs e)
        {
            string queryttp = "select * from BAN where ID='" + txtidb.Text + "' and TRANGTHAI = N'Đang sử dụng' ";
            DataSet ds = kn.LayDuLieu(queryttp, "BAN");
            if (ds.Tables["BAN"].Rows.Count == 1)
            {
                FormHoadon fhd = new FormHoadon();
                this.Hide();
                fhd.ShowDialog();
                this.Show();
                loadttb();
                txtidb.Text = "";

            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn muốn thanh toán");
            }
        }
        public class mgg
        {
            static public int mg;
        }

        private void cbGiamgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGiamgia.SelectedIndex == 0)
                mgg.mg = 10;
            else if (cbGiamgia.SelectedIndex == 1)
                mgg.mg = 20;
            else
                mgg.mg = 50;
        }

        private void buttonDoiban_Click(object sender, EventArgs e)
        {
            string querypt = "select * from BAN where ID='" + txtidb.Text + "'and TRANGTHAI=N'Đang sử dụng'";
            DataSet ds = kn.LayDuLieu(querypt, "BAN");

            string querylidhd = "select ID from HOADON where IDBAN='" + txtidb.Text + "'";
            DataSet ds11 = kn.LayDuLieu(querylidhd, "HOADON");
            int idhd = int.Parse(ds11.Tables["HOADON"].Rows[0].ItemArray[0].ToString());

            if (ds.Tables["BAN"].Rows.Count == 1)
            {
                string querydcthd = "update CTHOADON set IDBAN='" + cbDoiban.Text + "' where IDHOADON ='" + idhd + "'";
                DataSet ds14 = kn.LayDuLieu(querydcthd, "CTHOADON");
                string query = "update HOADON set IDPHONG ='" + cbDoiban.Text + "' where ID = '" + idhd + "' ";
                DataSet ds1 = kn.LayDuLieu(query, "HOADON");
                string querypd = "update BAN set TRANGTHAI =N'Đang sử dụng' where ID = '" + cbDoiban.Text + "' ";
                DataSet ds2 = kn.LayDuLieu(querypd, "BAN");
                string queryttp = "update BAN set TRANGTHAI =N'Trống' where ID = '" + txtidb.Text + "' ";
                DataSet ds3 = kn.LayDuLieu(queryttp, "BAN");
                txtidb.Text = cbDoiban.Text;
                loadttb();
                loaddoip();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng muốn đổi");
            }
        }
    }
}
