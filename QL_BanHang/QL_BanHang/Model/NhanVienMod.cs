using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Object;

namespace QL_BanHang.Model
{
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from tb_NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return dt;
        }

        public bool Login(NhanVienObj khachHangObj)
        {
            cmd.CommandText = "Select * from tb_KhachHang where Emails = '" + khachHangObj.TenNhanVien + "' AND MatKhau = '" + khachHangObj.MatKhau + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
            }
            catch (Exception)
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool AddData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Insert into tb_NhanVien values ('" + nvObj.MaNhanVien + "','" + nvObj.TenNhanVien + "',N'" + nvObj.GioiTinh + "','" + nvObj.NamSinh + "', '" + nvObj.DiaChi + "','" + nvObj.SDT + "','" + nvObj.MatKhau + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return false;
        }

        public bool UpdData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Update tb_NhanVien set TenNhanVien =  '" + nvObj.TenNhanVien + "', GioiTinh = '" + nvObj.GioiTinh + "', NamSinh = '" + nvObj.NamSinh + "', DiaChi = '" + nvObj.DiaChi + "',SDT = '" + nvObj.SDT + "', MatKhau = '" + nvObj.MatKhau + "' Where MaNV = '" + nvObj.MaNhanVien + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete tb_NhanVien Where MaNV = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }


    }
}
