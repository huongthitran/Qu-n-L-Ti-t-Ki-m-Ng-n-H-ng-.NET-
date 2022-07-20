using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTKNH
{
    public partial class frmBaoCao : Form
    {
        private string _mess;
        public frmBaoCao()
        {
            InitializeComponent();
        }
        public frmBaoCao(String Mess):this()
        {
            _mess = Mess;
        }


        ketnoi kn = new ketnoi();
        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
             string sqltk = "Select  * from ChitietGIAODICH where MACHITiet = '"+_mess+"'";
            //string sqltk = "";
            dta = kn.Lay_Dulieu(sqltk);
            bcgd baocao = new bcgd();
            baocao.SetDataSource(dta);
            crystalReportViewer1.ReportSource = baocao;
        }
    }
}
