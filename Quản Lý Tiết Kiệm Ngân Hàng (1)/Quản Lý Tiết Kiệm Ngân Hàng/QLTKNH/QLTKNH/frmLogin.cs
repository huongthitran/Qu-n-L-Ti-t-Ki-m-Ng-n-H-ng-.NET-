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
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }
        
        

        ketnoi ketnoi = new ketnoi();

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ketnoi.KetNoi_Dulieu();
            string TN = txtUN.Text;
            string MK = txtPass.Text;

            string sql_login = "Select TENDN,MATKHAU From DANGNHAP Where TENDN = '" + TN + "' and MATKHAU = '" + MK + "'";
           
             
           

            SqlCommand cmd = new SqlCommand(sql_login, ketnoi.cnn);

            SqlDataReader datRed = cmd.ExecuteReader();

         

            if (datRed.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                if(MK=="MKQL")
                {
                    // frmNguoiQuanLy form = new frmNguoiQuanLy();

                    frmNguoiQuanLy form = new frmNguoiQuanLy(txtUN.Text);
                    form.Show();
                }
                else
                {
                    FrmKhachHang form = new FrmKhachHang(txtUN.Text);
                    form.Show();
                }

                
                
                
            }
           
            else
            {
                MessageBox.Show("Hãy kiểm tra lại Tên Đăng Nhập hoặc Mật Khẩu");
            }



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form frmmain = new frmRegister();
            frmmain.Show();
        }
    }
}
