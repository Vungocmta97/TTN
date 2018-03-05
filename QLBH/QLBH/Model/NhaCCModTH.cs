using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using QLBH.ObjectT;


namespace QLBH.Model
{
    class NhaCCModTH
    {
        ConnectToSQLTH con = new ConnectToSQLTH();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from NhaCC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conn;

            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public bool AddData(NhaCCObjTH Obj)
        {

            cmd.CommandText = " insert into NhaCC (MaNCC,TenNCC,DiaChi,SDT) values('" + Obj.mancc + "',N'" + Obj.tenncc + "',N'" + Obj.diachi + "','" + Obj.sdt + "')";
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
        public bool UpDate(NhaCCObjTH Obj)
        {

            cmd.CommandText = " update NhaCC set TenNCC = N'" + Obj.tenncc + "' , DiaChi = N'" + Obj.diachi + "' , SDT = '" + Obj.sdt + "' where MaNCC = '" + Obj.mancc + "'";
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
            DataTable dt = new DataTable();

            cmd.CommandText = "update HoaDonNhapHang set MaNCC = 'Null' where MaNCC = '" + ma + "' delete NhaCC where MaNCC =  '" + ma + "'";
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
            return false;
        }
        public DataTable GetDataNCC(string mancc)
        {

            DataTable dt = new DataTable();
            cmd.CommandText = " select MaHDN , MaNCC  from HoaDonNhapHang where MaNCC = '" + mancc + "'";
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
    }
}
