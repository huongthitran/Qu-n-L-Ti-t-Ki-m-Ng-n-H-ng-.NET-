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
    public partial class frmNguoiQuanLy : Form
    {
        private string _mess;
        public frmNguoiQuanLy()
        {
            InitializeComponent();
        }

        public frmNguoiQuanLy(string Mess) : this()
        {
            _mess = Mess;
            //lblNQL.Text = _mess;
        }

        ketnoi kn = new ketnoi();


        private void visibleGrb()
        {
            grbKhachHang.Visible = false;
            grbTTNQL.Visible = false;
            grbPQL.Visible = false;
            grbTKTK.Visible = false;
            grbCTGD.Visible = false;
            grbLS.Visible = false;
            grbKH.Visible = false;
            picBG.Visible = false;
            logoBG.Visible = false;
            lblBG.Visible = false;
            pnlBG.Visible = false;
            grbTK.Visible = false;
        }

        private void visibleBtn()
        {
            btnKhachHang.Visible = false;
            btnTTNQL.Visible = false;
            btnPQL.Visible = false;
            btnTKTK.Visible = false;
           
            btnCTGD.Visible = false;
            btnLaiSuat.Visible = false;
            btnKyHan.Visible = false;
            btnBC.Visible = false;
            btnTK.Visible = false;
            btnTK.Visible = false;
            btnBC.Visible = false;

            
        }

        private void btnTrans()
        {
            btnKhachHang.FillColor = Color.FromArgb(24, 44, 79);
            btnTTNQL.FillColor = Color.FromArgb(24, 44, 79);
            btnPQL.FillColor = Color.FromArgb(24, 44, 79);
            btnTKTK.FillColor = Color.FromArgb(24, 44, 79);
          
            btnCTGD.FillColor = Color.FromArgb(24, 44, 79);
            btnKyHan.FillColor = Color.FromArgb(24, 44, 79);
            btnLaiSuat.FillColor = Color.FromArgb(24, 44, 79);
            btnBC.FillColor = Color.FromArgb(24, 44, 79);
            btnTK.FillColor = Color.FromArgb(24, 44, 79);



        }




        private void frmNguoiQuanLy_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1300, 900);
            visibleGrb();
            visibleBtn();
            picBG.Visible = true;
            logoBG.Visible = true;
            lblBG.Visible = true;
            pnlBG.Visible = true;


            string sql = "select TenQl from THONGTINNGUOIQUANLY, DANGNHAP where DANGNHAP.TENDN = THONGTINNGUOIQUANLY.TENDN and DANGNHAP.TENDN = '" + _mess+ "'";
            DataTable dta = kn.Lay_Dulieu(sql);
            lblNQL.DataBindings.Add("Text", dta, "TENQL");


        }
        
      

        //-------------------------------------------------//


        //Thông Tin Người Quản Lý
        private void LAYBANG_TTNQL()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * From THONGTINNGUOIQUANLY");
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
            kn.Execute("Delete THONGTINNGUOIQUANLY where MAQL = '" +txtMQL_TTNQL.Text + "'");
            LAYBANG_TTNQL();
        }

        //-------------------------------------------------//


        //Phòng Quản Lý
        private void LAYBANG_PHONGQUANLY()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select* From PHONG");
            dataPQL.DataSource = dta;
            Hienthi_Dulieu_PQL();

        }

        private void Hienthi_Dulieu_PQL()
        {
            txtMP_PQL.DataBindings.Clear();
            txtMP_PQL.DataBindings.Add("Text", dataPQL.DataSource, "MAPHONG");

            txtTP_PQL.DataBindings.Clear();
            txtTP_PQL.DataBindings.Add("Text", dataPQL.DataSource, "TENPHONG");
        }

        private void btnTaoMoi_PQL_Click(object sender, EventArgs e)
        {
            txtMP_PQL.Text = "";
            txtTP_PQL.Text = "";

            txtMP_PQL.Focus();
        }

        private void btnSua_PQL_Click(object sender, EventArgs e)
        {
            kn.Execute("Update PHONG SET TENPHONG = '" + txtTP_PQL.Text +"' where MAPHONG = '" + txtMP_PQL.Text + "'");
            LAYBANG_PHONGQUANLY();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete PHONG where MAPHONG = '" + txtMP_PQL.Text + "'");
            LAYBANG_PHONGQUANLY();
        }

        private void btnLuu_PQL_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO PHONG Values ('" + txtMP_PQL.Text + "','" + txtTP_PQL.Text +"')");
            LAYBANG_PHONGQUANLY();
        }
        //-------------------------------------------------//


        //Khách Hàng

        public void LAYBANG_KhachHang()
        {

            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  KHACHHANG");
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
            kn.Execute("Update KHACHHANG SET TENKH = '" + txtTKH_KHang.Text + "', DIACHI ='" + txtDC_KHang.Text + "', NGAYSINH = '" + txtNS_KHang.Value + "', CMND ='" + txtCCND_KHang.Text + "', DIENTHOAIKH ='" + txtDT_KHang.Text + "', MAIL ='" +txtEmal_KHang.Text + "' where MAKH = '" + txtMKH_KHang.Text + "'");

            LAYBANG_KhachHang();
        }

        private void btnLuu_KHang_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO KHACHHANG  Values ('" + txtMKH_KHang.Text + "','" +txtTKH_KHang.Text + "','" + txtCCND_KHang.Text + "','" + txtNS_KHang.Value + "','" + txtDC_KHang.Text + "','" + txtDT_KHang.Text + "','" + txtEmal_KHang.Text + "')");

            LAYBANG_KhachHang();
        }

        private void btnXoa_KHang_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete KHACHHANG where MAKH = '" + txtMKH_KHang.Text + "'");
            LAYBANG_KhachHang();
        }




        //-------------------------------------------------//


        //Tài khoản tiết kiệm

        public void LAYBANG_TKTK()
        {

            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  TAIKHOANTIETKIEM");
            dataTKTK.DataSource = data;
            Hienthi_Dulieu_TKTK();
        }

        public void LAYBANG_KH_TKTK()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  KHACHHANG");
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
            kn.Execute("Update TAIKHOANTIETKIEM SET MAKH = '" + txtMKH_TKTK.Text +"', NGAYMOSO ='"+ txtNMS_TKTK.Value + "', SOTIENGOC = '" + txtSTG_TKTK.Text + "', LOAITIEN ='"+ txtLT_TKTK.Text + "' where MATK = '" + txtMTK_TKTK.Text + "'");
            LAYBANG_TKTK();
        }

        private void btnLuu_TKTK_Click(object sender, EventArgs e)
        {
            kn.Execute("INSERT INTO TAIKHOANTIETKIEM  Values ('" + txtMTK_TKTK.Text + "','" + txtMKH_TKTK.Text  + "','" + txtNMS_TKTK.Value + "','"+ txtSTG_TKTK.Text + "','" + txtLT_TKTK.Text + "')");
            LAYBANG_TKTK();
        }

        private void btnXoa_TKTK_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete TAIKHOANTIETKIEM where MATK = '" + txtMTK_TKTK.Text + "'");
            LAYBANG_TKTK();
        }

        

        //------------------------------------------//


        //chi tiết giao dịch

        public void LAYBANG_CTGD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  CHITIETGIAODICH");
            dataCTGD.DataSource = data;
            Hienthi_Dulieu_CTGD();
        }

        public void LAYBANG_KH_CTGD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  KHACHHANG");
            txtMKH_CTGD.DataSource = data;
            txtMKH_CTGD.DisplayMember = "MAKH";
            txtMKH_CTGD.ValueMember = "MAKH";
        }

        public void LAYBANG_GD_CTGD()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From GIAODICH");
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
            kn.Execute("INSERT INTO CHITIETGIAODICH Values ('" + txtMCT_CTGD.Text + "','" + txtMKH_CTGD.Text + "','" + txtMGD_CTGD.Text + "','" + txtST_CTGD.Text + "','" + txtND_CTGD.Text  + "')");
            LAYBANG_CTGD();
        }

        private void btnXoa_CTGD_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete CHITIETGIAODICH where MACHITIET = '" + txtMCT_CTGD.Text + "'");
            LAYBANG_CTGD();
        }



        //--------------------------------------------//


        //Lãi Suất

        public void LAYBANG_LS()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  LAISUAT");
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

        private void btnTM_LS_Click(object sender, EventArgs e)
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

        //--------------------------------------------//


        //Kỳ Hạn

        public void LAYBANG_KH()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From  KYHAN");
            dataKH.DataSource = data;
            Hienthi_Dulieu_KH();
        }
       
        public void LAYBANG_TTNQL_KH()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From THONGTINNGUOIQUANLY");
            txtMQL_KH.DataSource = data;
            txtMQL_KH.DisplayMember = "MAQL";
            txtMQL_KH.ValueMember = "MAQL";
        }

        public void LAYBANG_TKTK_KH()
        {
            DataTable data = new DataTable();
            data = kn.Lay_Dulieu("Select * From TAIKHOANTIETKIEM");
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
            kn.Execute("Update KYHAN SET MAQL = '" + txtMQL_KH.Text + "', MATK = '" + txtMTK_KH.Text+ "', KYHAN = '" + txtKH_KH.Text+ "', MALS = '" + txtMLS_KH.Text +"', LOAITIEN = '" + txtLT_KH.Text + "' where MAKYHAN = '" + txtMKH_KH.Text + "'");
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



        //button Thoat

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Xử lí

        int btnTTCN1 = 0;
        private void btnTTCN_Click(object sender, EventArgs e)
        {
           // int btnTTCN1 = 0;
            
           
        }

        int btnTTKH1 = 0;

        private void btnTTKH_Click(object sender, EventArgs e)
        {
            
        }
        int btnTTLS1 = 0;
        private void btnTTLS_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTTCN_Click_1(object sender, EventArgs e)
        {
            btnTTCN1++;

            if (btnTTCN1 % 2 == 1)
            {
                visibleBtn();
                btnPQL.Visible = true;
                btnTTNQL.Visible = true;


                btnTTCN.Location = new Point(0, 177);
                btnTTKH.Location = new Point(0, 257 + 7 + 53*2);
                btnTTLS.Location = new Point(0, 337 + 7 + 7 + 53*2);
                btnTKVBC.Location = new Point(0, 417 + 7 + 7 +7+ 53 * 2);
            }

            else
            {
                visibleBtn();
                btnTTCN.Location = new Point(0, 177);
                btnTTKH.Location = new Point(0, 257 + 7 );
                btnTTLS.Location = new Point(0, 337 + 7 + 7);
                btnTKVBC.Location = new Point(0, 417 + 7 + 7+ 7 );

            }
        }

        private void btnTTKH_Click_1(object sender, EventArgs e)
        {
            btnTTKH1++;
            if (btnTTKH1 % 2 == 1)
            {
                visibleBtn();
                btnTKTK.Visible = true;
                btnKhachHang.Visible = true;
                btnCTGD.Visible = true;



                btnTTCN.Location = new Point(0, 177);
                btnTTKH.Location = new Point(0, 257 + 7 );
                btnTTLS.Location = new Point(0, 337 + 7 + 7 +53*3);
                btnTKVBC.Location = new Point(0, 417 + 7 + 7 + 7 + 53*3);

            }
            else
            {
                visibleBtn();
                btnTTCN.Location = new Point(0, 177);
                btnTTKH.Location = new Point(0, 257 + 7);
                btnTTLS.Location = new Point(0, 337 + 7 + 7);
                btnTKVBC.Location = new Point(0, 417 + 7 + 7 + 7);
            }
        }

        private void btnTTLS_Click_1(object sender, EventArgs e)
        {
            btnTTLS1++;
            if (btnTTLS1 % 2 == 1)
            {
                visibleBtn();
                btnLaiSuat.Visible = true;
                btnKyHan.Visible = true;


                btnTTCN.Location = new Point(0, 177);
                btnTTKH.Location = new Point(0, 257 + 7);
                btnTTLS.Location = new Point(0, 337 + 7 + 7);
                btnTKVBC.Location = new Point(0, 417 + 7 + 7 + 7 + 53*2);
            }
            else
            {

               

                visibleBtn();
                btnTTCN.Location = new Point(0, 177);
                btnTTKH.Location = new Point(0, 257 + 7);
                btnTTLS.Location = new Point(0, 337 + 7 + 7);
                btnTKVBC.Location = new Point(0, 417 + 7 + 7 + 7);
            }
        }

        private void btnTTNQL_Click_1(object sender, EventArgs e)
        {
            visibleGrb();
            grbTTNQL.Visible = true;

            btnTrans();
            btnTTNQL.FillColor = Color.FromArgb(26, 154, 254);


            LAYBANG_TTNQL();
        }

        private void btnPQL_Click_1(object sender, EventArgs e)
        {
            visibleGrb();
            grbPQL.Visible = true;

            btnTrans();
            btnPQL.FillColor = Color.FromArgb(26, 154, 254);

            LAYBANG_PHONGQUANLY();
        }

        private void btnKhachHang_Click_1(object sender, EventArgs e)
        {
            visibleGrb();
            grbKhachHang.Visible = true;


            btnTrans();
            btnKhachHang.FillColor = Color.FromArgb(26, 154, 254);


            LAYBANG_KhachHang();
        }

        private void btnTKTK_Click_1(object sender, EventArgs e)
        {
            visibleGrb();
            grbTKTK.Visible = true;

            btnTrans();
            btnTKTK.FillColor = Color.FromArgb(26, 154, 254);


            LAYBANG_TKTK();
            LAYBANG_KH_TKTK();
        }

        private void btnCTGD_Click_1(object sender, EventArgs e)
        {
            visibleGrb();
            grbCTGD.Visible = true;

            btnTrans();
            btnCTGD.FillColor = Color.FromArgb(26, 154, 254);

            LAYBANG_CTGD();
            LAYBANG_KH_CTGD();
            LAYBANG_GD_CTGD();
        }

        private void btnLaiSuat_Click_1(object sender, EventArgs e)
        {
            visibleGrb();
            grbLS.Visible = true;

            btnTrans();
            btnLaiSuat.FillColor = Color.FromArgb(26, 154, 254);

            LAYBANG_LS();
        }

        private void btnKyHan_Click_1(object sender, EventArgs e)
        {
            visibleGrb();
            grbKH.Visible = true;

            btnTrans();
            btnKyHan.FillColor = Color.FromArgb(26, 154, 254);

            LAYBANG_KH();
            LAYBANG_TTNQL_KH();
            LAYBANG_TKTK_KH();
            LAYBANG_LS_KH();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        int TKVBC = 0;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TKVBC++;
            if(TKVBC % 2 ==1)
            {
                visibleBtn();
                btnBC.Visible = true;
                btnTK.Visible = true;
                btnTTCN.Location = new Point(0, 177);
                btnTTKH.Location = new Point(0, 257 + 7);
                btnTTLS.Location = new Point(0, 337 + 7 + 7);
                btnTKVBC.Location = new Point(0, 417 + 7 + 7 + 7);
            }
            else {
                visibleBtn();
                btnTTCN.Location = new Point(0, 177);
                btnTTKH.Location = new Point(0, 257 + 7);
                btnTTLS.Location = new Point(0, 337 + 7 + 7);
                btnTKVBC.Location = new Point(0, 417 + 7 + 7 + 7);
            }
           
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if (rdbTKH.Checked == true)
            {
                sqltk = "Select * from KHACHHANG where TENKH like '" + txtTKH.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (rdbMKH.Checked == true)
            {
                sqltk = "Select * from KHACHHANG where MAKH like '" + txtMKH.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (rdbTNV.Checked == true)
            {
                sqltk = "Select * from THONGTINNGUOIQUANLY where TENQL like '" + txtTNV.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            if (rdbMNV.Checked == true)
            {
                sqltk = "Select * from THONGTINNGUOIQUANLY where MAQL like '" + txtMNV.Text + "'";
                dta = kn.Lay_Dulieu(sqltk);
            }
            dataTK.DataSource = dta;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
                visibleGrb();
                grbTK.Visible = true;

                btnTrans();
                btnTK.FillColor = Color.FromArgb(26, 154, 254);

                DataTable dta,data;
           
                dta = kn.Lay_Dulieu("Select * from THONGTINNGUOIQUANLY");
                txtMNV.DataSource = dta;
                txtMNV.DisplayMember = "MAQL";
                txtMNV.ValueMember = "MAQL";
            
                data = kn.Lay_Dulieu("Select * from KHACHHANG");
                txtMKH.DataSource = data;
                txtMKH.DisplayMember = "MAKH";
                txtMKH.ValueMember = "MAKH";
            
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            frmBCTTKH form = new frmBCTTKH();
            form.Show();
        }
    }
}
