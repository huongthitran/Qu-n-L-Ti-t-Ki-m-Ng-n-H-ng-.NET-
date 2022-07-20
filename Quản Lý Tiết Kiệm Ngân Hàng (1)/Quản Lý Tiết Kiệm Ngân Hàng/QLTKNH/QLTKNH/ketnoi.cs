using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLTKNH
{
    class ketnoi
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void KetNoi_Dulieu()
        {
            string strKetNoi = @"Data Source=DESKTOP-QUA3K1M\SQLEXPRESS;Initial Catalog=Nhom4_QLTK;Integrated Security=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open) cnn.Close();
        }

        public DataTable Lay_Dulieu(string Sql)
        {
            KetNoi_Dulieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }


        public void Execute(string sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }

    }
}
