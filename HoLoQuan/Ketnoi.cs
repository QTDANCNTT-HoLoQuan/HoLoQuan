using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoLoQuan
{
    internal class Ketnoi
    {
        string con_str = @"Data Source=QuanTran;Initial Catalog=QLYHLQ;Integrated Security=True"; // chuoi ket noi voi co so du lieu
        public DataSet LayDuLieu(string query, string table_name)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, table_name);
                return ds;
            }
            catch
            {

            }
            return null;
        }
        public bool KtraThucThi(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_str);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                con.Close();
                int sl = cmd.ExecuteNonQuery();
                if (sl > 0)
                {
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }
    }
}
