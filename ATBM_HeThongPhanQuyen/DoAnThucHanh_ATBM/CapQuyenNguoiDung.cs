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
    public partial class CapQuyenNguoiDung : Form
    {
        private Thong_Tin_Nguoi_dung _tab;
        public CapQuyenNguoiDung(Thong_Tin_Nguoi_dung tab)
        {
            InitializeComponent();
            _tab = tab;
            label4.Text = DoAnThucHanh_ATBM.Menu.username;
            string cmdString = "SELECT table_name FROM all_tables where owner = '" + DangNhap.admin + "'";
            OracleCommand cmd = new OracleCommand(cmdString, DangNhap.oraConnection);

            // load len combo box
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
            comboBox_bang.Items.AddRange(strDetailID);

            // tao collumn check box
            DataGridViewCheckBoxColumn check_xem = new DataGridViewCheckBoxColumn();
            check_xem.Name = "Xem";
            check_xem.HeaderText = "Xem";
            Ds_Cot.Columns.Add(check_xem);
            DataGridViewCheckBoxColumn check_update = new DataGridViewCheckBoxColumn();
            check_update.Name = "CapNhat";
            check_update.HeaderText = "Sửa";
            Ds_Cot.Columns.Add(check_update);
        }

        private void Btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            this._tab.Show();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CapQuyenNguoiDung_Load(object sender, EventArgs e)
        {

        }

        private void Btn_hienThiCot_Click(object sender, EventArgs e)
        {
            string cmdstring = "SELECT column_name FROM user_tab_cols WHERE table_name = '"+comboBox_bang.SelectedItem.ToString()+"' ";
            OracleCommand cmd = new OracleCommand(cmdstring, DangNhap.oraConnection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds_col = new DataSet();
            da.Fill(ds_col);
            Ds_Cot.DataSource = ds_col.Tables[0];
            
        }

        private void Btn_PhanQuyen_Click(object sender, EventArgs e)
        {
            
            string message = "Cấp quyền cho người dùng?";
            string caption = "Cấp quyền";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                string _table = comboBox_bang.SelectedItem.ToString();
                string _user_name = DoAnThucHanh_ATBM.Menu.username;
                Int32 grant_option = 0;
                if (Grant_option.Checked == true) grant_option = 1;
                // cap quyen select
                string cmdstring = "proc_user_select";
                OracleCommand cmd = new OracleCommand(cmdstring, DangNhap.oraConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DataGridViewRow row in Ds_Cot.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Xem"].Value) == true)
                    {
                        cmd.Parameters.Clear();
                        
                        cmd.Parameters.Add("ip_user", OracleDbType.Varchar2, 20).Value = _user_name;
                        cmd.Parameters.Add("ip_table", OracleDbType.Varchar2, 30).Value = _table;
                        
                        cmd.Parameters.Add("check01", OracleDbType.Int32).Value = grant_option;
                        cmd.ExecuteNonQuery();

                    }

                }
                //cap quyen update 
                cmdstring = "proc_user_update";
                cmd.CommandText.Remove(0);
                cmd.CommandText = cmdstring;
                string _col = "";
                foreach (DataGridViewRow row in Ds_Cot.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["CapNhat"].Value) == true)
                    {
                        cmd.Parameters.Clear();

                        _col = row.Cells["COLUMN_NAME"].Value.ToString();
                        cmd.Parameters.Add("ip_user", OracleDbType.Varchar2, 20).Value = _user_name;
                        cmd.Parameters.Add("ip_table", OracleDbType.Varchar2, 30).Value = _table;
                        cmd.Parameters.Add("ip_column", OracleDbType.Varchar2, 30).Value = _col;
                        cmd.Parameters.Add("check01", OracleDbType.Int32).Value = grant_option;
                        cmd.ExecuteNonQuery();

                    }

                }
                // cap quyen insert 
                if (checkBox_Them.Checked == true)
                {
                    cmdstring = "proc_user_insert";
                    cmd.CommandText.Remove(0);
                    cmd.CommandText = cmdstring;
                    cmd.Parameters.Clear();

                    cmd.Parameters.Add("ip_user", OracleDbType.Varchar2, 20).Value = _user_name;
                    cmd.Parameters.Add("ip_table", OracleDbType.Varchar2, 30).Value = _table;
                    cmd.Parameters.Add("check01", OracleDbType.Int32).Value = grant_option;

                    cmd.ExecuteNonQuery();
                }

                // cap quyen delete 
                if (checkBox_Xoa.Checked == true)
                {
                    cmdstring = "proc_user_delete";
                    cmd.CommandText.Remove(0);
                    cmd.CommandText = cmdstring;
                    cmd.Parameters.Clear();

                    cmd.Parameters.Add("ip_user", OracleDbType.Varchar2, 20).Value = _user_name;
                    cmd.Parameters.Add("ip_table", OracleDbType.Varchar2, 30).Value = _table;
                    cmd.Parameters.Add("check01", OracleDbType.Int32).Value = grant_option;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cấp quyền thành công");
            }
        }

        private void comboBox_bang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
