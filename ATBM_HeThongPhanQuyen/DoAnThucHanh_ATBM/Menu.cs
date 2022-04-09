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
    public partial class Menu : Form
    {
        private DangNhap _dn;
        public static string username;
        public static string _role_name;
        public Menu(DangNhap _dangNhap)
        {
            InitializeComponent();
            label_ds.Hide();
            DanhSach.Hide();
            dataGridView_ds_table.Hide();
            this._dn = _dangNhap;
            dataGridView_ds_role.Hide();
            Btn_TaoRole.Hide();
            Btn_xoa_quyen.Hide();
            label2.Hide();
            textBox1.Hide();
            button_tao_role.Hide();
            // Add a button column role
            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Chi tiết";
            buttonColumn.Name = "Xem chi tiet";
            buttonColumn.Text = "Xem";
            buttonColumn.UseColumnTextForButtonValue = true;

            DanhSach.Columns.Add(buttonColumn);
            // add check box collumn to list user 
            DataGridViewCheckBoxColumn column_bang = new DataGridViewCheckBoxColumn();
            column_bang.Name = "chon";
            DanhSach.Columns.Add(column_bang);
            // Add a button column to list role
            DataGridViewButtonColumn buttonColumn_role =
                new DataGridViewButtonColumn();
            buttonColumn_role.HeaderText = "Chi tiết";
            buttonColumn_role.Name = "Xem chi tiet";
            buttonColumn_role.Text = "Xem";
            buttonColumn_role.UseColumnTextForButtonValue = true;

            dataGridView_ds_role.Columns.Add(buttonColumn_role);
            // add check box collumn to list role 
            DataGridViewCheckBoxColumn column_bang_role = new DataGridViewCheckBoxColumn();
            column_bang_role.Name = "chon";
            dataGridView_ds_role.Columns.Add(column_bang_role);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hien thi danh sach nguoi dung

            Btn_xoa_quyen.Hide();
            label2.Hide();
            textBox1.Hide();
            Btn_TaoRole.Hide();
            button_tao_role.Hide();
            dataGridView_ds_role.Hide();
            dataGridView_ds_table.Hide();
            label_ds.Text = "DANH SÁCH NGƯỜI DÙNG TRONG HỆ THỐNG";
            label_ds.Show();
            DanhSach.Show();
            button1.Show();
            
            // lay danh sach người dùng và hiển thị lên data gridview 
            string cmdString = "select * from all_users";

            // tao data set 
            DataSet ds = new DataSet();
            OracleCommand cmd = new OracleCommand(cmdString, DangNhap.oraConnection);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            DanhSach.DataSource = ds.Tables[0];

            DanhSach.CellClick += new DataGridViewCellEventHandler(DanhSach_CellClick);
        }
        // Calls the Employee.RequestStatus method.
        void DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                DanhSach.Columns["Xem chi tiet"].Index) return;

            // Retrieve the user name.
            string user_name = (string)DanhSach[2, e.RowIndex].Value;
            username = user_name;
            // Show user's infor tab
            this.Hide();
            Thong_Tin_Nguoi_dung new_tab = new Thong_Tin_Nguoi_dung(this);
            new_tab.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // xem daanh sach role
            DanhSach.Hide();
            dataGridView_ds_table.Hide();
            button1.Hide();
            button1.Hide();
            label_ds.Text = "DANH SÁCH ROLE TRONG HỆ THỐNG";
            label_ds.Show();
            dataGridView_ds_role.Show();
            label2.Show();
            textBox1.Show();
            button_tao_role.Show();
            string cmdString = "SELECT * FROM USER_ROLE_PRIVS";
            //string cmdString = "SELECT * FROM DBA_ROLE_PRIVS ";
            OracleCommand cmd = new OracleCommand(cmdString, DangNhap.oraConnection);
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            dataGridView_ds_role.DataSource = ds.Tables[0];
            dataGridView_ds_role.CellClick += new DataGridViewCellEventHandler(DanhSach_role_CellClick);

        }
        void DanhSach_role_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                DanhSach.Columns["Xem chi tiet"].Index) return;

            // Retrieve the role name.
            string role_name = (string)dataGridView_ds_role[3, e.RowIndex].Value;
            _role_name = role_name;

            this.Hide();
            Quyen_cua_role new_tab = new Quyen_cua_role(this);
            new_tab.Show();

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Btn_LichSuCapQuyen_click_Click(object sender, EventArgs e)
        {
            // qua tab lich su cap quyen
        }

        private void Btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            _dn.Show();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Hide();
            textBox1.Hide();
            Btn_TaoRole.Hide();
            button_tao_role.Hide();

            DanhSach.Hide();
            button1.Hide();
            Btn_xoa_quyen.Hide();
            dataGridView_ds_role.Hide();
            dataGridView_ds_table.Show();
            label_ds.Text = "DANH SÁCH BẢNG TRONG HỆ THỐNG";
            label_ds.Show();
            // danh sách table
            string cmdString = "SELECT owner, table_name FROM all_tables where owner = '" +DangNhap.admin + "'";
            OracleCommand cmd = new OracleCommand(cmdString, DangNhap.oraConnection);
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            dataGridView_ds_table.DataSource = ds.Tables[0];
        }

        private void Btn_DSView_Click(object sender, EventArgs e)
        {
            // ds view 
            string cmdString = "";
            OracleCommand cmd = new OracleCommand(cmdString, DangNhap.oraConnection);
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            DanhSach.DataSource = ds.Tables[0];
        }

        private void Btn_TaoNguoiDung_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tao_nguoi_dung_moi new_tab = new Tao_nguoi_dung_moi(this);
            new_tab.Show();

        }

        private void DanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DanhSach.Column[e.RowIndex]
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // xoa người dùng
            List<string> rows_with_checked_column = new List<string>();
            foreach (DataGridViewRow row in DanhSach.Rows)
            {
                if (Convert.ToBoolean(row.Cells["chon"].Value) == true)
                {
                    //MessageBox.Show("OK!"); // Just to check if it undestands I've checked the row
                    string value = row.Cells["USERNAME"].Value.ToString();
                    rows_with_checked_column.Add(value);
                }

            }
            string[] List_userName_xoa = rows_with_checked_column.ToArray();
        }

        private void Btn_xoa_quyen_Click(object sender, EventArgs e)
        {
            // xoa cac quyền được chọn
        }

        private void Btn_Thu_hoi_quyen_Click(object sender, EventArgs e)
        {
            // Thu hồi các quyền được chọn

        }

        private void button_tao_role_Click(object sender, EventArgs e)
        {
            // tao role moi 
           
            string cmdstring = "proc_createRole";
            OracleCommand cmd = new OracleCommand(cmdstring, DangNhap.oraConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ip_rolename", OracleDbType.Varchar2, 20).Value = textBox1.Text;
            cmd.Parameters.Add("ip_identify", OracleDbType.Varchar2, 20).Value = textBox1.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tạo role thành công");
        }
    }
}
