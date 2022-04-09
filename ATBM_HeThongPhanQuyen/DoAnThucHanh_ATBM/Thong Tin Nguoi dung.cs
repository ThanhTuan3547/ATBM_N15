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
    public partial class Thong_Tin_Nguoi_dung : Form
    {
        private Menu _menu;
        public Thong_Tin_Nguoi_dung(Menu _menu)
        {
            InitializeComponent();
            this._menu = _menu;
            // lay danh sach quyen tren bang 
            string cmdstring = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '" +DoAnThucHanh_ATBM.Menu.username+"'";
            OracleCommand cmd = new OracleCommand(cmdstring, DangNhap.oraConnection);
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            tab_privs.DataSource = ds.Tables[0];

            // lay danh sach quyen tren cot 
            cmdstring = "SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE = '" +DoAnThucHanh_ATBM.Menu.username+"'";
            cmd.CommandText = cmdstring;

            da = new OracleDataAdapter( cmd);
            DataSet ds_col = new DataSet();
            da.Fill(ds_col);
            col_privs.DataSource = ds_col.Tables[0];
            // tao collumn check box
            DataGridViewCheckBoxColumn column_bang = new DataGridViewCheckBoxColumn();
            column_bang.Name = "selected";
            column_bang.HeaderText = "Chọn";
            tab_privs.Columns.Add(column_bang);

            //DataGridViewCheckBoxColumn column_cot = new DataGridViewCheckBoxColumn();
            //column_cot.Name = "selected";
            //column_cot.HeaderText = "Chọn";
            //col_privs.Columns.Add(column_cot);

        }

        private void Thong_Tin_Nguoi_dung_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cap quyen nguoi dung 

            this.Hide();
            CapQuyenNguoiDung new_tab = new CapQuyenNguoiDung(this);
            new_tab.Show();
        }

        private void Btn_Tro_ve_Click(object sender, EventArgs e)
        {
            this.Hide();
            this._menu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc muốn hủy quyền của người dùng?";
            string caption = "Thu hồi quyền";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {

                // revoke quyen tren bang 
                string cmdstring = "proc_revoke_user";
                OracleCommand cmd = new OracleCommand(cmdstring, DangNhap.oraConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                // revoke tung role cua user 

                foreach (DataGridViewRow row in tab_privs.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["selected"].Value) == true)
                    {
                        cmd.Parameters.Clear();
                        //MessageBox.Show("OK!"); // Just to check if it undestands I've checked the row
                        // store table an privelige
                        string _user = row.Cells["GRANTEE"].Value.ToString();
                        string _table = row.Cells["TABLE_NAME"].Value.ToString();
                        string _priv = row.Cells["PRIVILEGE"].Value.ToString();
                        //revoke quyen
                        cmd.Parameters.Add("ip_user", OracleDbType.Varchar2, 20).Value = _user;
                        cmd.Parameters.Add("ip_table", OracleDbType.Varchar2, 30).Value = _table;
                        cmd.Parameters.Add("ip_pos", OracleDbType.Varchar2, 20).Value = _priv;
                        cmd.ExecuteNonQuery();
                         
                    }

                }
                MessageBox.Show("Thu hồi quyền thành công");
            }
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    string message = "Bạn có chắc muốn hủy quyền của người dùng?";
        //    string caption = "Thu hồi quyền";
        //    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        //    DialogResult result;

        //    Displays the MessageBox.

        //   result = MessageBox.Show(this, message, caption, buttons,
        //       MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
        //       MessageBoxOptions.RightAlign);

        //    if (result == DialogResult.Yes)
        //    {
        //        revoke quyen tren cot
        //        string cmdstring = "proc_revoke_user_update";
        //        OracleCommand cmd = new OracleCommand(cmdstring, DangNhap.oraConnection);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        revoke tung role cua user

        //        foreach (DataGridViewRow row in col_privs.Rows)
        //        {
        //            if (Convert.ToBoolean(row.Cells["selected"].Value) == true)
        //            {
        //                cmd.Parameters.Clear();
        //                MessageBox.Show("OK!"); // Just to check if it undestands I've checked the row
        //                store table an privelige
        //                string _user = row.Cells["GRANTEE"].Value.ToString();
        //                string _table = row.Cells["TABLE_NAME"].Value.ToString();
        //                string _col = row.Cells["COLUMN_NAME"].Value.ToString();
        //                revoke quyen
        //                cmd.Parameters.Add("ip_user", OracleDbType.Varchar2, 20).Value = _user;
        //                cmd.Parameters.Add("ip_table", OracleDbType.Varchar2, 30).Value = _table;
        //                cmd.Parameters.Add("ip_pos", OracleDbType.Varchar2, 20).Value = _col;

        //                cmd.ExecuteNonQuery();

        //            }

        //        }
        //        MessageBox.Show("Thu hồi quyền thành công");
        //    }
        //}
    }
}
