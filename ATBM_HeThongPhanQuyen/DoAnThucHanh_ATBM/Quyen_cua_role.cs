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

    public partial class Quyen_cua_role : Form
    {
        private Menu _menu;

        public Quyen_cua_role(Menu _menu)
        {
            InitializeComponent();
            this._menu = _menu;
            // Show role's privs
            string cmdString = "  SELECT *  FROM ROLE_TAB_PRIVS WHERE ROLE = '" + DoAnThucHanh_ATBM.Menu._role_name + "' ";
            dataGridView_quyen_tren_role.Show();
            OracleCommand cmd = new OracleCommand(cmdString, DangNhap.oraConnection);
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            dataGridView_quyen_tren_role.DataSource = ds.Tables[0];
            // add check box column to list role's privs
            DataGridViewCheckBoxColumn column_privs_role = new DataGridViewCheckBoxColumn();
            column_privs_role.HeaderText = "Chọn";
            column_privs_role.Name = "chon";
            dataGridView_quyen_tren_role.Columns.Add(column_privs_role);
            // add check box column to check Xem priv
            DataGridViewCheckBoxColumn column_privs_role_Xem = new DataGridViewCheckBoxColumn();
            column_privs_role_Xem.HeaderText = "Xem";
            column_privs_role_Xem.Name = "xem";
            dataGridView_ds_cot.Columns.Add(column_privs_role_Xem);
            // add check box column to check Sua priv
            DataGridViewCheckBoxColumn column_privs_role_Sua = new DataGridViewCheckBoxColumn();
            column_privs_role_Sua.HeaderText = "Sửa";
            column_privs_role_Sua.Name = "sua";
            dataGridView_ds_cot.Columns.Add(column_privs_role_Sua);

            cmdString = "SELECT table_name FROM all_tables where owner = '" + DangNhap.admin + "'";
            cmd.CommandText.Remove(0);
            cmd.CommandText = cmdString;

            // load len combo box
            DataSet ds_ds_bang = new DataSet();
            da = new OracleDataAdapter(cmd);
            da.Fill(ds_ds_bang);
            //DS_role.DataSource = ds.Tables[0];
            // convert dataset to list 
            List<string> strDetailIDList = new List<string>();

            foreach (DataRow row in ds_ds_bang.Tables[0].Rows)
            {
                strDetailIDList.Add(row[0].ToString());
            }
            // convert list to string array
            string[] strDetailID = strDetailIDList.ToArray();
            // add array to checked list box
            comboBox_bang.Items.AddRange(strDetailID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // nút trở về trang Menu
            this.Hide();
            this._menu.Show();
        }

        private void button_Hien_thi_cot_Click(object sender, EventArgs e)
        {
            // hien thi cot trong bang duoc chon
            string cmdstring = "SELECT column_name FROM user_tab_cols WHERE table_name = '" + comboBox_bang.SelectedItem.ToString() + "' ";
            OracleCommand cmd = new OracleCommand(cmdstring, DangNhap.oraConnection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds_col = new DataSet();
            da.Fill(ds_col);
            dataGridView_ds_cot.DataSource = ds_col.Tables[0];
        }

        private void button_cap_quyen_Click(object sender, EventArgs e)
        {
            // thuc hien cap quyen cho role
            string message = "Cấp quyền cho role?";
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
                //string _user_name = DoAnThucHanh_ATBM.Menu.username;


                // cap quyen select
                string cmdstring = "proc_role_select";
                OracleCommand cmd = new OracleCommand(cmdstring, DangNhap.oraConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (DataGridViewRow row in dataGridView_ds_cot.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["xem"].Value) == true)
                    {
                        cmd.Parameters.Clear();

                        cmd.Parameters.Add("ip_role", OracleDbType.Varchar2, 20).Value = DoAnThucHanh_ATBM.Menu._role_name;
                        cmd.Parameters.Add("ip_table", OracleDbType.Varchar2, 30).Value = _table;

                        cmd.ExecuteNonQuery();

                    }

                }
                //cap quyen update 
                cmdstring = "proc_role_update";
                cmd.CommandText.Remove(0);
                cmd.CommandText = cmdstring;
                string _col = "";
                foreach (DataGridViewRow row in dataGridView_ds_cot.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["sua"].Value) == true)
                    {
                        cmd.Parameters.Clear();

                        _col = row.Cells["COLUMN_NAME"].Value.ToString();
                        cmd.Parameters.Add("ip_role", OracleDbType.Varchar2, 20).Value = DoAnThucHanh_ATBM.Menu._role_name;
                        cmd.Parameters.Add("ip_table", OracleDbType.Varchar2, 30).Value = _table;
                        cmd.Parameters.Add("ip_column", OracleDbType.Varchar2, 30).Value = _col;
                        cmd.ExecuteNonQuery();

                    }

                }
                // cap quyen insert 
                if (checkbox_Them.Checked == true)
                {
                    cmdstring = "proc_role_insert";
                    cmd.CommandText.Remove(0);
                    cmd.CommandText = cmdstring;
                    cmd.Parameters.Clear();

                    cmd.Parameters.Add("ip_role", OracleDbType.Varchar2, 20).Value = DoAnThucHanh_ATBM.Menu._role_name;
                    cmd.Parameters.Add("ip_table", OracleDbType.Varchar2, 30).Value = _table;

                    cmd.ExecuteNonQuery();
                }

                // cap quyen delete 
                if (checkBox_Xoa.Checked == true)
                {
                    cmdstring = "proc_role_delete";
                    cmd.CommandText.Remove(0);
                    cmd.CommandText = cmdstring;
                    cmd.Parameters.Clear();

                    cmd.Parameters.Add("ip_role", OracleDbType.Varchar2, 20).Value = DoAnThucHanh_ATBM.Menu._role_name;
                    cmd.Parameters.Add("ip_table", OracleDbType.Varchar2, 30).Value = _table;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cấp quyền thành công");
            }
        }
    }
}
