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
    public partial class FrmKhachHang : Form
    {
        private string _mess;

        public FrmKhachHang()
        {
            InitializeComponent();
        }

        public FrmKhachHang(string Mess):this()
        {
            _mess = Mess;

        }

        ketnoi kn = new ketnoi();

        private void visibleForm()
        {
            grbKhachHang.Visible = false;
            grbTTNQL.Visible = false;
            grbLS.Visible = false;
            grbKH.Visible = false;
            grbCTGD.Visible = false;
            grbGD.Visible = false;
            grbTKTK.Visible = false;
            picBG.Visible = false;
            logoBG.Visible = false;
            lblBG.Visible = false;
            pnlBG.Visible = false;
        }
        private void visibleHidden()
        {
           
            
            btnKH.Visible = false;
            btnTTNQL.Visible = false;
            btnTKTK.Visible = false;
            btnGD.Visible = false;
            btnCTGD.Visible = false;
            btnLS.Visible = false;
            btnKyHan.Visible = false;

        }

        private void backgroundTrans()
        {
            btnKH.FillColor = Color.FromArgb(24, 44, 79);
            btnTTNQL.FillColor = Color.FromArgb(24, 44, 79);          
            btnTKTK.FillColor = Color.FromArgb(24, 44, 79);
            btnGD.FillColor = Color.FromArgb(24, 44, 79);
            btnCTGD.FillColor = Color.FromArgb(24, 44, 79);
            btnKyHan.FillColor = Color.FromArgb(24, 44, 79);
            btnLS.FillColor = Color.FromArgb(24, 44, 79);

         
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1350, 900);
            visibleHidden();
            visibleForm();
            picBG.Visible = true;
            logoBG.Visible = true;
            lblBG.Visible = true;
            pnlBG.Visible = true;

            string sql = "select TenKH from KHACHHANG, DANGNHAP where DANGNHAP.TENDN = KHACHHANG.TENDN and DANGNHAP.TENDN = '" + _mess + "'";
            DataTable dta = kn.Lay_Dulieu(sql);
            lblKH.DataBindings.Add("Text", dta, "TENKH");


        }

        int btnTTCN1 = 0;
        int btnTTKH1 = 0;
        int btnTTLS1 = 0;

        private void btnTTCN_Click_1(object sender, EventArgs e)
        {
            btnTTCN1++;
            if (btnTTCN1 % 2 == 1)
            {
                visibleHidden();
                btnKH.Visible = true;


                
                btnTTCN.Location = new Point(0, 177);
                btnTTTK.Location = new Point(0, 257+7+52);
                btnTTLS.Location = new Point(0, 337+7+7 +52);
            }
            else
            {
                visibleHidden();
                btnTTCN.Location = new Point(0, 177);
                btnTTTK.Location = new Point(0, 257 + 7);
                btnTTLS.Location = new Point(0, 337 + 7 + 7);
            }
        }

        private void btnTTTK_Click(object sender, EventArgs e)
        {
            btnTTKH1++;
            if (btnTTKH1 % 2 == 1)
            {
                visibleHidden();
                btnTTNQL.Visible = true;
                btnTKTK.Visible = true;
                btnGD.Visible = true;
                btnCTGD.Visible = true;

                btnTTCN.Location = new Point(0, 177);
                btnTTTK.Location = new Point(0, 257 + 7);
                btnTTLS.Location = new Point(0, 337+7+7+54*4);

            }
            else
            {
                visibleHidden();
                btnTTCN.Location = new Point(0, 177);
                btnTTTK.Location = new Point(0, 257 + 7);
                btnTTLS.Location = new Point(0, 337 + 7 + 7);
            }
        }

        private void btnTTLS3_Click(object sender, EventArgs e)
        {
            btnTTLS1++;
            if (btnTTLS1 % 2 == 1)
            {
                visibleHidden();
                btnLS.Visible = true;
                btnKyHan.Visible = true;

                btnTTCN.Location = new Point(0, 177);
                btnTTTK.Location = new Point(0, 257 + 7);
                btnTTLS.Location = new Point(0, 337 + 7 + 7);


            }
            else
            {
                visibleHidden();
                btnTTCN.Location = new Point(0, 177);
                btnTTTK.Location = new Point(0, 257 + 7);
                btnTTLS.Location = new Point(0, 337 + 7 + 7);
            }
        }


        //-----------------------//

        private void btnKH_Click_1(object sender, EventArgs e)
        {
            backgroundTrans();
            visibleForm();
            grbKhachHang.Visible = true;
            btnKH.FillColor = Color.FromArgb(26, 154, 254);

            LAYBANG_KhachHang();
        }

        private void btnLS_Click_1(object sender, EventArgs e)
        {
            backgroundTrans();
            visibleForm();
            grbLS.Visible = true;
            btnLS.FillColor = Color.FromArgb(26, 154, 254);

            LAYBANG_LS();
        }

        private void btnKyHan_Click_1(object sender, EventArgs e)
        {
            backgroundTrans();
            visibleForm();
            grbKH.Visible = true;
            btnKyHan.FillColor = Color.FromArgb(26, 154, 254);


            LAYBANG_KH();
            LAYBANG_TTNQL_KH();
            LAYBANG_TKTK_KH();
            LAYBANG_LS_KH();
        }

        private void btnTTNQL_Click_1(object sender, EventArgs e)
        {
            backgroundTrans();
            visibleForm();
            grbTTNQL.Visible = true;
            btnTTNQL.FillColor = Color.FromArgb(26, 154, 254);

            LAYBANG_TTNQL();
        }

        private void btnGD_Click_1(object sender, EventArgs e)
        {
            backgroundTrans();
            visibleForm();
            grbGD.Visible = true;
            btnGD.FillColor = Color.FromArgb(26, 154, 254);


            LAYBANG_GD();
            LAYBANG_KH_GD();
            LAYBANG_TKTK_GD();
        }

        private void btnTKTK_Click_1(object sender, EventArgs e)
        {
            backgroundTrans();
            visibleForm();
            grbTKTK.Visible = true;
            btnTKTK.FillColor = Color.FromArgb(26, 154, 254);


            LAYBANG_TKTK();
            LAYBANG_KH_TKTK();
        }

        private void btnCTGD_Click_1(object sender, EventArgs e)
        {
            backgroundTrans();
            visibleForm();
            grbCTGD.Visible = true;
            btnCTGD.FillColor = Color.FromArgb(26, 154, 254);


            LAYBANG_CTGD();
            LAYBANG_KH_CTGD();
            LAYBANG_GD_CTGD();

           
        }


        /// <summary>
        /// ///////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Thông Tin Người Quản Lý
        private void LAYBANG_TTNQL()
        {
            DataTable dta = new DataTable();

            dta = kn.Lay_Dulieu("select THONGTINNGUOIQUANLY.MAQL, THONGTINNGUOIQUANLY.TENQL, THONGTINNGUOIQUANLY.DIACHIQL, THONGTINNGUOIQUANLY.SDT, THONGTINNGUOIQUANLY.EMAIL " 
                                +"from THONGTINNGUOIQUANLY, DANGNHAP, KYHAN, TAIKHOANTIETKIEM, KHACHHANG "
                                +"where  DANGNHAP.TENDN = KHACHHANG.TENDN  and THONGTINNGUOIQUANLY.MAQL = KYHAN.MAQL and KYHAN.MATK = TAIKHOANTIETKIEM.MATK and TAIKHOANTIETKIEM.MAKH = KHACHHANG.MAKH and DANGNHAP.TENDN = '"+ _mess +"'");
            dataTTNQL.DataSource = dta;
            Hienthi_Dulieu_TTNQL();

        }
        private void Hienthi_Dulieu_TTNQL()
        {
            txtMQL_TTNQL.DataBindings.Clear();
            txtMQL_TTNQL.DataBindings.Add("Text", dataTTNQL.DataSource, "MAQL");

            txtTQL_TTNQL.DataBindings.Clear();
            txtTQL_TTNQL.DataBindings.Add("Text", dataTTNQL.DataSource, "TENQL");

            txtSDT_TTNQL.DataBindings.Clear();
            txtSDT_TTNQL.DataBindings.Add("Text", dataTTNQL.DataSource, "SDT");

            txtEmail_TTNQL.DataBindings.Clear();
            txtEmail_TTNQL.DataBindings.Add("Text", dataTTNQL.DataSource, "EMAIL");

            txtDC_TTNQL.DataBindings.Clear();
            txtDC_TTNQL.DataBindings.Add("Text", dataTTNQL.DataSource, "DIACHIQL");

        }

        private void btnTM_TTNQL_Click(object sender, EventArgs e)
        {
            txtMQL_TTNQL.Text = "";
            txtTQL_TTNQL.Text = "";
            txtSDT_TTNQL.Text = "";
            txtEmail_TTNQL.Text = "";
            txtDC_TTNQL.Text = "";

            txtMQL_TTNQL.Focus();
        }

        private void btnSua_TTNQL_Click(object sender, EventArgs e)
        {
            kn.Execute("Update THONGTINNGUOIQUANLY SET TENQL = '" + txtTQL_TTNQL.Text + "', SDT = '" + txtSDT_TTNQL.Text + "', Email = '" + txtEmail_TTNQL.Text + "', DIACHIQL = '" + txtDC_TTNQL.Text + "' where MAQL = '" + txtMQL_TTNQL.Text + "'");

            LAYBANG_TTNQL();
        }

        private void btnLuu_TTNQL_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO THONGTINNGUOIQUANLY Values ('" + txtMQL_TTNQL.Text + "','" + txtTQL_TTNQL.Text + "','" + txtSDT_TTNQL.Text + "','" + txtEmail_TTNQL.Text + "','" + txtDC_TTNQL.Text + "')");
            LAYBANG_TTNQL();
        }

        private void btnXoa_TTNQL_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete THONGTINNGUOIQUANLY where MAQL = '" + txtMQL_TTNQL.Text + "'");
            LAYBANG_TTNQL();
        }


        //----------------//

        //Lãi Suất
        public void LAYBANG_LS()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("select LAISUAT.MALS, LAISUAT.MUCLS " +
                                "from KHACHHANG, LAISUAT, KYHAN, TAIKHOANTIETKIEM " +
                                 "where KHACHHANG.TENDN ='"+_mess+"' and KYHAN.MALS = LAISUAT.MALS and KYHAN.MATK = TAIKHOANTIETKIEM.MATK and TAIKHOANTIETKIEM.MAKH = KHACHHANG.MAKH" );
            dataLS.DataSource = data;
            Hienthi_Dulieu_LS();
        }

        private void Hienthi_Dulieu_LS()
        {
            txtMaLS_LS.DataBindings.Clear();
            txtMaLS_LS.DataBindings.Add("Text", dataLS.DataSource, "MALS");

            txtMucLS_LS.DataBindings.Clear();
            txtMucLS_LS.DataBindings.Add("Text", dataLS.DataSource, "MUCLS");
        }

        
        private void btnTM_LS_Click_1(object sender, EventArgs e)
        {
            txtMaLS_LS.Text = "";
            txtMucLS_LS.Text = "";

            txtMaLS_LS.Focus();
        }

        private void btnSua_LS_Click(object sender, EventArgs e)
        {
            kn.Execute("Update LAISUAT SET MUCLS = '" + txtMucLS_LS.Text + "' where MALS = '" + txtMaLS_LS.Text + "'");
            LAYBANG_LS();
        }

        private void btnLuu_LS_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO LAISUAT Values ('" + txtMaLS_LS.Text + "','" + txtMucLS_LS.Text + "')");
            LAYBANG_LS();
        }

        private void btnXoa_LS_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete LAISUAT where MALS = '" + txtMaLS_LS.Text + "'");
            LAYBANG_LS();
        }

        //Kỳ Hạn
        public void LAYBANG_KH()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("select KYHAN.KYHAN, KYHAN.LOAITIEN, KYHAN.MAKYHAN, KYHAN.MALS, KYHAN.MALS, KYHAN.MAQL, KYHAN.MATK " +
                                 "from KHACHHANG, KYHAN, TAIKHOANTIETKIEM " +
                                    "where KHACHHANG.TENDN = '"+_mess +"' and KYHAN.MATK = TAIKHOANTIETKIEM.MATK and TAIKHOANTIETKIEM.MAKH = KHACHHANG.MAKH ");
            dataKH.DataSource = data;
            Hienthi_Dulieu_KH();
        }

        public void LAYBANG_TTNQL_KH()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("select THONGTINNGUOIQUANLY.MAQL "
                               + "from THONGTINNGUOIQUANLY, DANGNHAP, KYHAN, TAIKHOANTIETKIEM, KHACHHANG "
                               + "where  DANGNHAP.TENDN = KHACHHANG.TENDN  and THONGTINNGUOIQUANLY.MAQL = KYHAN.MAQL and KYHAN.MATK = TAIKHOANTIETKIEM.MATK and TAIKHOANTIETKIEM.MAKH = KHACHHANG.MAKH and DANGNHAP.TENDN = '" + _mess + "'");

            txtMQL_KH.DataSource = data;
            txtMQL_KH.DisplayMember = "MAQL";
            txtMQL_KH.ValueMember = "MAQL";
        }

        public void LAYBANG_TKTK_KH()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("select TAIKHOANTIETKIEM.MATK " +
                              "from DANGNHAP, KHACHHANG, TAIKHOANTIETKIEM " +
                               "where DANGNHAP.TENDN = KHACHHANG.TENDN and TAIKHOANTIETKIEM.MAKH = KHACHHANG.MAKH  and DANGNHAP.TENDN = '" + _mess + "'");

            txtMTK_KH.DataSource = data;
            txtMTK_KH.DisplayMember = "MATK";
            txtMTK_KH.ValueMember = "MATK";
        }

        public void LAYBANG_LS_KH()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From LAISUAT");
            txtMLS_KH.DataSource = data;
            txtMLS_KH.DisplayMember = "MALS";
            txtMLS_KH.ValueMember = "MALS";
        }

        private void Hienthi_Dulieu_KH()
        {
            txtMKH_KH.DataBindings.Clear();
            txtMKH_KH.DataBindings.Add("Text", dataKH.DataSource, "MAKYHAN");

            txtMQL_KH.DataBindings.Clear();
            txtMQL_KH.DataBindings.Add("Text", dataKH.DataSource, "MAQL");

            txtMTK_KH.DataBindings.Clear();
            txtMTK_KH.DataBindings.Add("Text", dataKH.DataSource, "MATK");

            txtKH_KH.DataBindings.Clear();
            txtKH_KH.DataBindings.Add("Text", dataKH.DataSource, "KYHAN");

            txtMLS_KH.DataBindings.Clear();
            txtMLS_KH.DataBindings.Add("Text", dataKH.DataSource, "MALS");

            txtLT_KH.DataBindings.Clear();
            txtLT_KH.DataBindings.Add("Text", dataKH.DataSource, "LOAITIEN");
        }

        private void btnTM_KH_Click(object sender, EventArgs e)
        {
            txtMKH_KH.Text = "";
            txtMQL_KH.Text = "";
            txtMTK_KH.Text = "";
            txtKH_KH.Text = "";
            txtMLS_KH.Text = "";
            txtLT_KH.Text = "";


            txtMKH_KH.Focus();
        }

        private void btnSua_KH_Click(object sender, EventArgs e)
        {
            kn.Execute("Update KYHAN SET MAQL = '" + txtMQL_KH.Text + "', MATK = '" + txtMTK_KH.Text + "', KYHAN = '" + txtKH_KH.Text + "', MALS = '" + txtMLS_KH.Text + "', LOAITIEN = '" + txtLT_KH.Text + "' where MAKYHAN = '" + txtMKH_KH.Text + "'");
            LAYBANG_KH();
        }

        private void btnLuu_KH_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO KYHAN Values ('" + txtMKH_KH.Text + "','" + txtMQL_KH.Text + "','" + txtMTK_KH.Text + "','" + txtKH_KH.Text + "','" + txtLT_KH.Text + "','" + txtMLS_KH.Text + "')");
            LAYBANG_KH();
        }

        private void btnXoa_KH_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete KYHAN where MAKYHAN = '" + txtMKH_KH.Text + "'");
            LAYBANG_KH();
        }

        //------------------------------------------//


        //chi tiết giao dịch

        public void LAYBANG_CTGD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("select CHITIETGIAODICH.MACHITIET, CHITIETGIAODICH.MAGD, CHITIETGIAODICH.MAKH, CHITIETGIAODICH.NOIDUNG, CHITIETGIAODICH.SOTIEN " +
                                "from DANGNHAP, KHACHHANG, CHITIETGIAODICH " +
                                "where DANGNHAP.TENDN = KHACHHANG.TENDN and KHACHHANG.MAKH = CHITIETGIAODICH.MAKH and DANGNHAP.TENDN = '"+_mess +"'");
            dataCTGD.DataSource = data;
            Hienthi_Dulieu_CTGD();
        }

        public void LAYBANG_KH_CTGD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("select MAKH " +
              "from KHACHHANG, DANGNHAP " +
              "where  DANGNHAP.TENDN = KHACHHANG.TENDN and DANGNHAP.TENDN = '" + _mess + "'");
            txtMKH_CTGD.DataSource = data;
            txtMKH_CTGD.DisplayMember = "MAKH";
            txtMKH_CTGD.ValueMember = "MAKH";
        }

        public void LAYBANG_GD_CTGD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("select GIAODICH.MAGD " +
                              "from GIAODICH, DANGNHAP, khachhang, taikhoantietkiem " +
                             "where DANGNHAP.TENDN = KHACHHANG.TENDN and giaodich.Matk = taikhoantietkiem.matk and taikhoantietkiem.maKH = Khachhang.makh and DANGNHAP.TENDN = '" + _mess + "'");
            txtMGD_CTGD.DataSource = data;
            txtMGD_CTGD.DisplayMember = "MAGD";
            txtMGD_CTGD.ValueMember = "MAGD";
        }

        private void Hienthi_Dulieu_CTGD()
        {
            txtMCT_CTGD.DataBindings.Clear();
            txtMCT_CTGD.DataBindings.Add("Text", dataCTGD.DataSource, "MACHITIET");

            txtMKH_CTGD.DataBindings.Clear();
            txtMKH_CTGD.DataBindings.Add("Text", dataCTGD.DataSource, "MAKH");

            txtMGD_CTGD.DataBindings.Clear();
            txtMGD_CTGD.DataBindings.Add("Text", dataCTGD.DataSource, "MAGD");

            txtST_CTGD.DataBindings.Clear();
            txtST_CTGD.DataBindings.Add("Text", dataCTGD.DataSource, "SOTIEN");

            txtND_CTGD.DataBindings.Clear();
            txtND_CTGD.DataBindings.Add("Text", dataCTGD.DataSource, "NOIDUNG");
        }

        private void btnTM_CTGD_Click(object sender, EventArgs e)
        {
            txtMCT_CTGD.Text = "";
            txtMKH_CTGD.Text = "";
            txtMGD_CTGD.Text = "";
            txtST_CTGD.Text = "";
            txtND_CTGD.Text = "";

            txtMCT_CTGD.Focus();
        }

        private void btnSuaCTGD_Click(object sender, EventArgs e)
        {
            kn.Execute("Update CHITIETGIAODICH SET MAKH = '" + txtMKH_CTGD.Text + "', MAGD ='" + txtMGD_CTGD.Text + "', SOTIEN ='" + txtST_CTGD.Text + "', NOIDUNG ='" + txtND_CTGD.Text + "' where MACHITIET = '" + txtMCT_CTGD.Text + "'");
            LAYBANG_CTGD();
        }

        private void btnLuu_CTGD_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO CHITIETGIAODICH Values ('" + txtMCT_CTGD.Text + "','" + txtMKH_CTGD.Text + "','" + txtMGD_CTGD.Text + "','" + txtST_CTGD.Text + "','" + txtND_CTGD.Text + "')");
            LAYBANG_CTGD();
        }

        private void btnXoa_CTGD_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete CHITIETGIAODICH where MACHITIET = '" + txtMCT_CTGD.Text + "'");
            LAYBANG_CTGD();
        }

        //---------------------------------------//

        //Giao dịch

        public void LAYBANG_GD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("select GIAODICH.MAGD,GIAODICH.MATK,GIAODICH.NGAYGD,GIAODICH.LOAIGD, GIAODICH.SOTIEN, GIAODICH.LOAITIETKIEM, GIAODICH.MAKYHAN " +
                                 "from GIAODICH, DANGNHAP, khachhang, taikhoantietkiem " +
                                "where DANGNHAP.TENDN = KHACHHANG.TENDN and giaodich.Matk = taikhoantietkiem.matk and taikhoantietkiem.maKH = Khachhang.makh and DANGNHAP.TENDN = '" + _mess+ "'");
            dataGD.DataSource = data;
            Hienthi_Dulieu_GD();
        }

        public void LAYBANG_TKTK_GD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("select TAIKHOANTIETKIEM.MAKH,TAIKHOANTIETKIEM.MATK,TAIKHOANTIETKIEM.LOAITIEN,TAIKHOANTIETKIEM.NGAYMOSO,TAIKHOANTIETKIEM.SOTIENGOC " +
                              "from DANGNHAP, KHACHHANG, TAIKHOANTIETKIEM " +
                               "where DANGNHAP.TENDN = KHACHHANG.TENDN and TAIKHOANTIETKIEM.MAKH = KHACHHANG.MAKH  and DANGNHAP.TENDN = '" + _mess + "'");

            txtMTK_GD.DisplayMember = "MATK";
            txtMTK_GD.ValueMember = "MATK";
        }

        public void LAYBANG_KH_GD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From KYHAN");
            txtMKH_GD.DataSource = data;
            txtMKH_GD.DisplayMember = "MAKYHAN";
            txtMKH_GD.ValueMember = "MAKYHAN";
        }

        private void Hienthi_Dulieu_GD()
        {
            txtMGD_GD.DataBindings.Clear();
            txtMGD_GD.DataBindings.Add("Text", dataGD.DataSource, "MAGD");

            txtMTK_GD.DataBindings.Clear();
            txtMTK_GD.DataBindings.Add("Text", dataGD.DataSource, "MATK");

            txtNGD_GD.DataBindings.Clear();
            txtNGD_GD.DataBindings.Add("Text", dataGD.DataSource, "NGAYGD");

            txtLGD_GD.DataBindings.Clear();
            txtLGD_GD.DataBindings.Add("Text", dataGD.DataSource, "LOAIGD");


            txtST_GD.DataBindings.Clear();
            txtST_GD.DataBindings.Add("Text", dataGD.DataSource, "SOTIEN");

            txtLTK_GD.DataBindings.Clear();
            txtLTK_GD.DataBindings.Add("Text", dataGD.DataSource, "LOAITIETKIEM");

            txtMKH_GD.DataBindings.Clear();
            txtMKH_GD.DataBindings.Add("Text", dataGD.DataSource, "MAKYHAN");
        }

        private void btnTM_GD_Click(object sender, EventArgs e)
        {
            txtMGD_GD.Text = "";
            txtMTK_GD.Text = "";
            txtNGD_GD.Text = "";
            txtLGD_GD.Text = "";
            txtST_GD.Text = "";
            txtLTK_GD.Text = "";
            txtMKH_GD.Text = "";

            txtMGD_GD.Focus();

        }

        private void btnSua_GD_Click(object sender, EventArgs e)
        {
            kn.Execute("Update GIAODICH SET MATK = '" + txtMTK_GD.Text + "', NGAYGD ='" + txtNGD_GD.Value + "', LOAIGD ='" + txtLGD_GD.Text + "', SOTIEN ='" + txtST_GD.Text + "', LOAITIETKIEM ='" + txtLTK_GD.Text + "', MAKYHAN ='" + txtMKH_GD.Text + "' where MAGD = '" + txtMGD_GD.Text + "'");
            LAYBANG_GD();
        }

        private void btnLuu_GD_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO GIAODICH Values ('" + txtMGD_GD.Text + "','" + txtMTK_GD.Text + "','" + txtNGD_GD.Value + "','" + txtLGD_GD.Text + "','" + txtST_GD.Text + "','" + txtLTK_GD.Text + "','" + txtMKH_GD.Text + "')");
            LAYBANG_GD();
        }

        private void btnXoa_GD_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete GIAODICH where MAGD = '" + txtMGD_GD.Text + "'");
            LAYBANG_GD();
        }

        //-------------------------------------------------//


        //Tài khoản tiết kiệm

        public void LAYBANG_TKTK()
        {

            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("select TAIKHOANTIETKIEM.MAKH,TAIKHOANTIETKIEM.MATK,TAIKHOANTIETKIEM.LOAITIEN,TAIKHOANTIETKIEM.NGAYMOSO,TAIKHOANTIETKIEM.SOTIENGOC " +
                                "from DANGNHAP, KHACHHANG, TAIKHOANTIETKIEM " +
                                 "where DANGNHAP.TENDN = KHACHHANG.TENDN and TAIKHOANTIETKIEM.MAKH = KHACHHANG.MAKH  and DANGNHAP.TENDN = '"+ _mess +"'");
            dataTKTK.DataSource = data;
            Hienthi_Dulieu_TKTK();
        }

        public void LAYBANG_KH_TKTK()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("select MAKH " +
             "from KHACHHANG, DANGNHAP " +
             "where  DANGNHAP.TENDN = KHACHHANG.TENDN and DANGNHAP.TENDN = '" + _mess + "'");
            txtMKH_TKTK.DataSource = data;
            txtMKH_TKTK.DisplayMember = "MAKH";
            txtMKH_TKTK.ValueMember = "MAKH";
        }

        private void Hienthi_Dulieu_TKTK()
        {
            txtMTK_TKTK.DataBindings.Clear();
            txtMTK_TKTK.DataBindings.Add("Text", dataTKTK.DataSource, "MATK");

            txtMKH_TKTK.DataBindings.Clear();
            txtMKH_TKTK.DataBindings.Add("Text", dataTKTK.DataSource, "MAKH");

            txtNMS_TKTK.DataBindings.Clear();
            txtNMS_TKTK.DataBindings.Add("Text", dataTKTK.DataSource, "NGAYMOSO");

            txtSTG_TKTK.DataBindings.Clear();
            txtSTG_TKTK.DataBindings.Add("Text", dataTKTK.DataSource, "SOTIENGOC");

            txtLT_TKTK.DataBindings.Clear();
            txtLT_TKTK.DataBindings.Add("Text", dataTKTK.DataSource, "LOAITIEN");
        }

        private void btnTM_TKTK_Click(object sender, EventArgs e)
        {
            txtMTK_TKTK.Text = "";
            txtMKH_TKTK.Text = "";
            txtNMS_TKTK.Text = "";
            txtSTG_TKTK.Text = "";
            txtLT_TKTK.Text = "";

            txtMTK_TKTK.Focus();
        }

        private void btnSua_TKTK_Click(object sender, EventArgs e)
        {
            kn.Execute("Update TAIKHOANTIETKIEM SET MAKH = '" + txtMKH_TKTK.Text + "', NGAYMOSO ='" + txtNMS_TKTK.Value + "', SOTIENGOC = '" + txtSTG_TKTK.Text + "', LOAITIEN ='" + txtLT_TKTK.Text + "' where MATK = '" + txtMTK_TKTK.Text + "'");
            LAYBANG_TKTK();
        }

        private void btnLuu_TKTK_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO TAIKHOANTIETKIEM  Values ('" + txtMTK_TKTK.Text + "','" + txtMKH_TKTK.Text + "','" + txtNMS_TKTK.Value + "','" + txtSTG_TKTK.Text + "','" + txtLT_TKTK.Text + "')");
            LAYBANG_TKTK();
        }

        private void btnXoa_TKTK_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete TAIKHOANTIETKIEM where MATK = '" + txtMTK_TKTK.Text + "'");
            LAYBANG_TKTK();
        }

        //Khách Hàng

        public void LAYBANG_KhachHang()
        {

            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("select MAKH, TENKH, CMND, NGAYSINH,DIACHI, DIENTHOAIKH,MAIL " +
                "from KHACHHANG, DANGNHAP " +
                "where  DANGNHAP.TENDN = KHACHHANG.TENDN and DANGNHAP.TENDN = '" + _mess +"'");
            dataKhachHang.DataSource = data;
            Hienthi_Dulieu_KhachHang();
        }

        private void Hienthi_Dulieu_KhachHang()
        {
            txtMKH_KHang.DataBindings.Clear();
            txtMKH_KHang.DataBindings.Add("Text", dataKhachHang.DataSource, "MAKH");

            txtTKH_KHang.DataBindings.Clear();
            txtTKH_KHang.DataBindings.Add("Text", dataKhachHang.DataSource, "TENKH");

            txtDT_KHang.DataBindings.Clear();
            txtDT_KHang.DataBindings.Add("Text", dataKhachHang.DataSource, "DIENTHOAIKH");

            txtCCND_KHang.DataBindings.Clear();
            txtCCND_KHang.DataBindings.Add("Text", dataKhachHang.DataSource, "CMND");

            txtDC_KHang.DataBindings.Clear();
            txtDC_KHang.DataBindings.Add("Text", dataKhachHang.DataSource, "DIACHI");

            txtEmal_KHang.DataBindings.Clear();
            txtEmal_KHang.DataBindings.Add("Text", dataKhachHang.DataSource, "MAIL");

            txtNS_KHang.DataBindings.Clear();
            txtNS_KHang.DataBindings.Add("Text", dataKhachHang.DataSource, "NGAYSINH");

        }

        private void btnTM_KHang_Click(object sender, EventArgs e)
        {
            txtMKH_KHang.Text = "";
            txtTKH_KHang.Text = "";
            txtDC_KHang.Text = "";
            txtNS_KHang.Text = "";
            txtEmal_KHang.Text = "";
            txtDT_KHang.Text = "";
            txtCCND_KHang.Text = "";

            txtMKH_KHang.Focus();
        }

        private void btnSua_KHang_Click(object sender, EventArgs e)
        {
            kn.Execute("Update KHACHHANG SET TENKH = '" + txtTKH_KHang.Text + "', DIACHI ='" + txtDC_KHang.Text + "', NGAYSINH = '" + txtNS_KHang.Value + "', CMND ='" + txtCCND_KHang.Text + "', DIENTHOAIKH ='" + txtDT_KHang.Text + "', MAIL ='" + txtEmal_KHang.Text + "' where MAKH = '" + txtMKH_KHang.Text + "'");

            LAYBANG_KhachHang();
        }

        private void btnLuu_KHang_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO KHACHHANG  Values ('" + txtMKH_KHang.Text + "','" + txtTKH_KHang.Text + "','" + txtCCND_KHang.Text + "','" + txtNS_KHang.Value + "','" + txtDC_KHang.Text + "','" + txtDT_KHang.Text + "','" + txtEmal_KHang.Text + "')");

            LAYBANG_KhachHang();
        }

        private void btnXoa_KHang_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete KHACHHANG where MAKH = '" + txtMKH_KHang.Text + "'");
            LAYBANG_KhachHang();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBaoCao form = new frmBaoCao(txtMCT_CTGD.Text);
            form.Show();
        }
    }
}
