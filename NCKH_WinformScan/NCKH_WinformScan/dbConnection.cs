using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace NCKH_WinformScan
{
    internal class dbConnection
    {
        SqlConnection sqlconn;
        string data = @"Data Source=LAPTOP-0G7N6LVV\TRANBATRIEU;Initial Catalog=ChuyenDiemSinhVien;Integrated Security=True";

        public dbConnection()
        {
            sqlconn = new SqlConnection(data);
            try
            {
                sqlconn.Open();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show("Connect Database Fail","Connect DB",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    sqlconn.Close();
                }
                throw e;
            }
        }

        public DataTable getBang(string tenBang)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmdBang = new SqlCommand("sp_get_table", sqlconn);

            sqlcmdBang.CommandType = CommandType.StoredProcedure;
            sqlcmdBang.Parameters.AddWithValue("@TableName", tenBang);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmdBang);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chua Lay Duoc Du Lieu Bang");
                throw ex;
            }
            return dt;
        }

        public string getTenHP(string maHP)
        {
            string tenHP = "";
            SqlCommand sqlcmd = new SqlCommand("getTenHP",sqlconn);

            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaHP", maHP);
            try
            {
                tenHP = (string)sqlcmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa Lấy Được Dữ Liệu Tên Học Phần");
                throw ex;
            }
            return tenHP;
        }

        public int SinhVienChuyenDiem(string maSV, string hoTen, string ngaySinh, string lop, string nghanh, string khoa, string bac, string quequan, string dclienlac,string email, string sodt, string maHP, string maHPC)
        {
            int ketQua = -1;
            SqlCommand sqlcmdSVChuyenDiem = new SqlCommand("SinhVienChuyenDiem", sqlconn);
            sqlcmdSVChuyenDiem.CommandType = CommandType.StoredProcedure;
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@MaSV", maSV);
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@HoTen", hoTen);
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@NgaySinh", DbType.DateTime).Value = DateTime.ParseExact(ngaySinh,"dd/MM/yyyy",CultureInfo.InvariantCulture);
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@Lop", lop);
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@Nghanh", nghanh);
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@Khoa", khoa);
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@Bac", bac);
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@QueQuan", quequan);
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@DiaChiLienHe", dclienlac);
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@Email", email);
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@DienThoai", sodt);
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@MaHP", maHP);
            sqlcmdSVChuyenDiem.Parameters.AddWithValue("@MaHPC", maHPC);

            try
            {
                ketQua = sqlcmdSVChuyenDiem.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ketQua;
                
        }
        
    }
}
