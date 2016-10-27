using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace TTDL_AMO.DataAccessLayer
{
    public class KetNoi
    {
        public static string strKetNoi = "Data Source=.;Initial Catalog=QLTV_UTEHY;Integrated Security=True";
        public static SqlConnection sqlCon;
        public static SqlCommand sqlCom;
        public static SqlDataAdapter sqlAdap;
        public static DataTable dt;

        public void MoKetNoi()
        {
            sqlCon = new SqlConnection(strKetNoi);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        public void DongKetNoi()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        public DataTable GetDataTable(string strDataTable)
        {
            MoKetNoi();
            sqlAdap = new SqlDataAdapter(strDataTable, sqlCon);
            dt = new DataTable();
            sqlAdap.Fill(dt);
            DongKetNoi();
            return dt;
        }
        public bool KTraMaTrung(string Sql)
        {
            MoKetNoi();
            bool kt = false;
            sqlAdap = new SqlDataAdapter(Sql, sqlCon);
            DataTable dt = new DataTable();
            sqlAdap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                kt = true;
            }
            DongKetNoi();
            return kt;
        }
        public int GetValue(string strValue)
        {
            MoKetNoi();
            sqlCom = new SqlCommand(strValue, sqlCon);
            int so = (int)sqlCom.ExecuteScalar();//pthuc lay gtri duy nhat
            DongKetNoi();
            return so;
        }
        //public DataTable LoadDuLieu1(string data)
        //{
        //    MoKetNoi();
        //    sqlCom = new SqlCommand();
        //    sqlCom.Connection = sqlCon;
        //    sqlCom.CommandType = CommandType.StoredProcedure;
        //    sqlCom.CommandText = data;
        //    sqlCom.ExecuteNonQuery();
        //    SqlDataReader reader = sqlCom.ExecuteReader();
        //    dt = new DataTable();
        //    dt.Load(reader);
        //    return dt;
        //}
        public DataTable LoadDuLieu(string strDataTable)
        {
            MoKetNoi();
            sqlAdap = new SqlDataAdapter(strDataTable, sqlCon);
            dt = new DataTable();
            sqlAdap.Fill(dt);//pthuc đổ du lieu len bang
            DongKetNoi();
            return dt;
        }
    }
}
