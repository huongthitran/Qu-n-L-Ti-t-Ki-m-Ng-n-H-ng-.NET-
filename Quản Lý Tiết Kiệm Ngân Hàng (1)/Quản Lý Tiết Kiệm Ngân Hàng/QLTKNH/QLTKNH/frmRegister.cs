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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtUN.Text != "" && txtP.Text != "" && txtP.Text == txtCP.Text)
            {

                kn.Execute("INSERT INTO DANGNHAP Values ('" + txtUN.Text+ "','"+txtP.Text + "')");
                MessageBox.Show("Đăng ký thành công");
                this.Close();

            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
