using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTKNH
{
    public partial class frmBCTTKH : Form
    {
        public frmBCTTKH()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void frmBCTTKH_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk = "Select  * from KHACHHANG, TAIKHOANTIETKIEM ";
            dta = kn.Lay_Dulieu(sqltk);
            bcttkh baocao = new bcttkh();
            baocao.SetDataSource(dta);
            crystalReportViewer1.ReportSource = baocao;
        }
    }
}
