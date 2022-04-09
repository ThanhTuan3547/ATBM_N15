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
    public partial class Tao_nguoi_dung_moi : Form
    {
        private Menu _menu;
        public Tao_nguoi_dung_moi(Menu _menu)
        {
            InitializeComponent();
            this._menu = _menu;
            string cmdString = "SELECT DISTINCT GRANTEE FROM USER_TAB_PRIVS WHERE OWNER = '" + DangNhap.admin + "'";
            OracleCommand cmd = new OracleCommand(cmdString, DangNhap.oraConnection);
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            //DS_role.DataSource = ds.Tables[0];
            // convert dataset to list 
            List<string> strDetailIDList = new List<string>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                strDetailIDList.Add(row[0].ToString());
            }
            // convert list to string array
            string[] strDetailID = strDetailIDList.ToArray();
            // add array to checked list box
            DS_role_box.Items.AddRange(strDetailID);
        }

        private void Btn_TaoNguoiDung_Click(object sender, EventArgs e)
        {
            if (XacNhanMatKhau.TextLength < 5 || MatKhau.TextLength < 5 || TaiKhoan.TextLength < 5)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ (tối thiểu là 5 kí tự)");
            }
            else if (XacNhanMatKhau.Text != MatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
            }
            else if (listBox_role.Items.Count < 1)
            {
                MessageBox.Show("Cần chọn ít nhất một role cho người dùng");
            }
            else
            {
                string cmdString = "createUSER";
                OracleCommand cmd = new OracleCommand(cmdString, DangNhap.oraConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("pi_username", OracleDbType.Varchar2, 20).Value = TaiKhoan.Text;
                cmd.Parameters.Add("pi_password", OracleDbType.Varchar2, 20).Value = MatKhau.Text;
                if (cmd.ExecuteNonQuery() == -1)
                {
                    MessageBox.Show("Tạo tài khoản thành công");
                }
                // gan role cho user 
                cmdString = "proc_grantRole";
                cmd = new OracleCommand(cmdString, DangNhap.oraConnection);
                cmd.CommandType = CommandType.StoredProcedure; 
                cmd.Parameters.Add("ip_username", OracleDbType.Varchar2, 20).Value = TaiKhoan.Text;
                cmd.Parameters.Add("ip_rolename", OracleDbType.Varchar2, 20).Value = " ";
                // gan tung role cho user 
                for (int i = 0; i < listBox_role.Items.Count; i++)
                {
                    cmd.Parameters.RemoveAt("ip_rolename");
                    cmd.Parameters.Add("ip_rolename", OracleDbType.Varchar2, 20).Value = listBox_role.Items[i];
                    
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            this._menu.Show();
            
        }

        // Moves the checked items from the CheckedListBox to the listBox.
        private void Btn_them_role_Click(object sender, EventArgs e)
        {
           
            listBox_role.Items.Clear();
            Btn_TaoNguoiDung.Enabled = false;
            for (int i = 0; i < DS_role_box.CheckedItems.Count; i++)
            {
                listBox_role.Items.Add(DS_role_box.CheckedItems[i]);
            }
            if (listBox_role.Items.Count > 0)
                Btn_TaoNguoiDung.Enabled = true;
        }

        private void DS_role_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void XacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
