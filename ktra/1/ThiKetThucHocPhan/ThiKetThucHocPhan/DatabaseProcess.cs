﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranTruongThuc222631147
{
    public class DatabaseProcess
    {
        static public string _connectionString = "Data Source=THUCVIVO;Initial Catalog=QuanLyKhachHang;Integrated Security=True";
        SqlConnection con = new SqlConnection(_connectionString);

        public void KetNoi()
        {
            con = new SqlConnection(_connectionString);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        public void DongKetNoi()
        {
            if (con.State != ConnectionState.Closed)
            {
              
                con.Close();
            }
            con.Dispose();
        }

        public DataTable DocBang(string sql)
        {
            KetNoi(); 
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con); 

            da.Fill(tb);
            da.Dispose();
            DongKetNoi();

            return tb;
            
        }

        public void CapNhat(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            KetNoi();

            cmd.Connection = con;
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();
            DongKetNoi();
            cmd.Dispose();
        }
    }
}
