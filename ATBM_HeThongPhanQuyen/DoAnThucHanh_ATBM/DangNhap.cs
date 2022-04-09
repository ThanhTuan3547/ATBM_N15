using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client; 

namespace DoAnThucHanh_ATBM
{
    public partial class DangNhap : Form
    {
        public static OracleConnection oraConnection ;
        public static string admin;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_DangNhap_click_Click(object sender, EventArgs e)
        {
            string taikhoan = TaiKhoan.Text;
            string matkhau = MatKhau.Text; 
            admin = TaiKhoan.Text.ToUpper(); 
            string connString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE))); User Id= " +taikhoan+ ";Password = " +matkhau+";";
            //string connString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));DBA Privilege = SYSDBA; User Id=sys;Password =admin;";
            OracleConnection oraConn = new OracleConnection(connString);
            oraConn.Open();
            oraConnection = oraConn; 
            if (oraConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Da ket noi toi oracle server" + oraConn.ServerVersion);
                Menu _menu = new Menu(this);
                _menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chua ket noi toi oracle server");
            }
            //MessageBox.Show("Da ket noi toi oracle server"); 
            // dong keets noi 
            //oraConn.Close(); 
            //oraConn.Dispose(); 
        }
    }
}
