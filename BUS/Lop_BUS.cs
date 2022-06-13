using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;
using System.Data.SqlClient;

namespace BUS
{
    public class Lop_BUS
    {
        Lop_DAL da = new Lop_DAL();
        Lop_DTO L = new Lop_DTO();
        //Hàm lấy thông tin lớp đó ra 1 datagridview

        public DataTable ShowLop()
        {
            string sql = "select * from Lop";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertLop(string ml, string tl, int ssv)
        {
            string sql = "insert into Lop values(N'" + ml + "',N'" + tl + "','" + ssv + "')";
            //Lệnh thực hiện không trả về bảng đã viết bên lớp DAL
            da.ExcuteNonQuery(sql);
        }
        public void UpdateLop(string ml, string tl, int ssv)
        {
            string sql = "update Lop set TenLop = N'" + tl + "', SoSV = N'" + ssv + "' where MaLop = N'" + ml + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteLop(string ml)
        {
            string sql = " delete from Lop where MaLop = N'" + ml + "'";
            da.ExcuteNonQuery(sql);
        }       
        //
        //
        //
        public DataTable ShowSinhVien()
        {
            string sql = "select * from SinhVien";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertSinhVien(string msv, string tsv, string malop,string khoa )
        {
            string sql = "insert into SinhVien values(N'" + msv + "',N'" + tsv + "',N'" + malop + "', N'" + khoa + "')";
            //Lệnh thực hiện không trả về bảng đã viết bên lớp DAL
            da.ExcuteNonQuery(sql);
        }
        public void UpdateSinhVien(string msv, string tsv, string malop, string khoa )
        {
            string sql = $"update SinhVien set TenSV = N'{tsv}', Malop = N'{malop}', Khoa = N'{khoa}' where Masv = N'{msv}'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteSinhVien(string msv)
        {
            string sql = " delete from SinhVien where MaSV = N'" + msv + "'";
            da.ExcuteNonQuery(sql);
        }
        //
        //
        //
        public DataTable GetTableName() {
            string sql = $"select name from sys.tables\n";
            //MessageBox.Show(sql);
            DataTable dt = da.GetTable(sql);
            return dt;
        }

        public DataTable ShowTable(string sql) {
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable ShowDGV(string table, string condition1) {
            string sql = $"select * from {table} where {condition1}";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowDGV2(string table,string condition1, string condition2) {
            string sql = $"select * from {table} where {condition1} AND {condition2}";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }



        public DataTable ShowSinhVienTheoLop(string malop) {
            string sql = $"select SV.MaSV, SV.TenSV, SV.MaLop, L.TenLop, SV.Khoa " +
                            $"from SinhVien SV, Lop L " +
                            $"where SV.MaLop = '{malop}' and SV.MaLop = L.MaLop";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable ShowGiangVien()
        {
            string sql = "select * from GiangVien";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertGiangVien(string mgv, string tgv, string malop, string mahp)
        {
            string sql = "insert into GiangVien values(N'" + mgv + "',N'" + tgv + "', N'" + malop + "', N'" + mahp + "')";
            //Lệnh thực hiện không trả về bảng đã viết bên lớp DAL
            da.ExcuteNonQuery(sql);
        }
        public void UpdateGiangVien(string mgv, string tgv, string malop, string mahp)
        {
            string sql = "update GiangVien set TenGV = N'" + tgv + "', MaLop = N'" + malop + "', MaHP = N'" + mahp + "' where MaGV = N'" + mgv + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteGiangVien(string mgv)
        {
            string sql = " delete from GiangVien where MaGV = N'" + mgv + "'";
            da.ExcuteNonQuery(sql);
        }
        //
        //
        //
        public DataTable ShowHocPhan()
        {
            string sql = "select * from HocPhan";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertHocPhan(string mhp, string thp, int stc, string mgv)
        {
            string sql = "insert into HocPhan values(N'" + mhp + "',N'" + thp + "',N'" + stc + "', N'" + mgv + "')";
            //Lệnh thực hiện không trả về bảng đã viết bên lớp DAL
            da.ExcuteNonQuery(sql);
        }
        public void UpdateHocPhan(string mhp, string thp, int stc, string mgv)
        {
            string sql = "update HocPhan set TenHP = N'" + thp + "', SoTC = N'" + stc + "',MaGV = N'" + mgv + "'  where MaHP = N'" + mhp + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteHocPhan(string mhp)
        {
            string sql = " delete from HocPhan where MaHP = N'" + mhp + "'";
            da.ExcuteNonQuery(sql);
        }
    }
}
