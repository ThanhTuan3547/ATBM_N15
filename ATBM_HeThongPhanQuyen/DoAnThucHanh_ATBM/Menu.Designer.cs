
namespace DoAnThucHanh_ATBM
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_XemDSUser_click = new System.Windows.Forms.Button();
            this.Btn_XemDSRole_click = new System.Windows.Forms.Button();
            this.Btn_LichSuCapQuyen_click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_TroVe = new System.Windows.Forms.Button();
            this.DanhSach = new System.Windows.Forms.DataGridView();
            this.Btn_DSTable = new System.Windows.Forms.Button();
            this.Btn_DSView = new System.Windows.Forms.Button();
            this.Btn_TaoNguoiDung = new System.Windows.Forms.Button();
            this.Btn_TaoRole = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_ds_table = new System.Windows.Forms.DataGridView();
            this.dataGridView_ds_role = new System.Windows.Forms.DataGridView();
            this.Btn_xoa_quyen = new System.Windows.Forms.Button();
            this.label_ds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_tao_role = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ds_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ds_role)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_XemDSUser_click
            // 
            this.Btn_XemDSUser_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_XemDSUser_click.Location = new System.Drawing.Point(12, 48);
            this.Btn_XemDSUser_click.Name = "Btn_XemDSUser_click";
            this.Btn_XemDSUser_click.Size = new System.Drawing.Size(185, 50);
            this.Btn_XemDSUser_click.TabIndex = 0;
            this.Btn_XemDSUser_click.Text = "Danh sách User ";
            this.Btn_XemDSUser_click.UseVisualStyleBackColor = true;
            this.Btn_XemDSUser_click.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_XemDSRole_click
            // 
            this.Btn_XemDSRole_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_XemDSRole_click.Location = new System.Drawing.Point(12, 104);
            this.Btn_XemDSRole_click.Name = "Btn_XemDSRole_click";
            this.Btn_XemDSRole_click.Size = new System.Drawing.Size(185, 50);
            this.Btn_XemDSRole_click.TabIndex = 1;
            this.Btn_XemDSRole_click.Text = "Danh sách Role";
            this.Btn_XemDSRole_click.UseVisualStyleBackColor = true;
            this.Btn_XemDSRole_click.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_LichSuCapQuyen_click
            // 
            this.Btn_LichSuCapQuyen_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LichSuCapQuyen_click.Location = new System.Drawing.Point(12, 272);
            this.Btn_LichSuCapQuyen_click.Name = "Btn_LichSuCapQuyen_click";
            this.Btn_LichSuCapQuyen_click.Size = new System.Drawing.Size(185, 50);
            this.Btn_LichSuCapQuyen_click.TabIndex = 2;
            this.Btn_LichSuCapQuyen_click.Text = "LS cấp quyền";
            this.Btn_LichSuCapQuyen_click.UseVisualStyleBackColor = true;
            this.Btn_LichSuCapQuyen_click.Click += new System.EventHandler(this.Btn_LichSuCapQuyen_click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_TroVe
            // 
            this.Btn_TroVe.AutoSize = true;
            this.Btn_TroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TroVe.Location = new System.Drawing.Point(12, 12);
            this.Btn_TroVe.Name = "Btn_TroVe";
            this.Btn_TroVe.Size = new System.Drawing.Size(75, 30);
            this.Btn_TroVe.TabIndex = 4;
            this.Btn_TroVe.Text = "Trở về";
            this.Btn_TroVe.UseVisualStyleBackColor = true;
            this.Btn_TroVe.Click += new System.EventHandler(this.Btn_TroVe_Click);
            // 
            // DanhSach
            // 
            this.DanhSach.AllowUserToAddRows = false;
            this.DanhSach.AllowUserToDeleteRows = false;
            this.DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSach.Location = new System.Drawing.Point(247, 133);
            this.DanhSach.Name = "DanhSach";
            this.DanhSach.RowHeadersWidth = 51;
            this.DanhSach.RowTemplate.Height = 24;
            this.DanhSach.Size = new System.Drawing.Size(1534, 587);
            this.DanhSach.TabIndex = 5;
            this.DanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DanhSach_CellContentClick);
            // 
            // Btn_DSTable
            // 
            this.Btn_DSTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DSTable.Location = new System.Drawing.Point(12, 160);
            this.Btn_DSTable.Name = "Btn_DSTable";
            this.Btn_DSTable.Size = new System.Drawing.Size(185, 50);
            this.Btn_DSTable.TabIndex = 6;
            this.Btn_DSTable.Text = "Danh sách table";
            this.Btn_DSTable.UseVisualStyleBackColor = true;
            this.Btn_DSTable.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Btn_DSView
            // 
            this.Btn_DSView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DSView.Location = new System.Drawing.Point(12, 216);
            this.Btn_DSView.Name = "Btn_DSView";
            this.Btn_DSView.Size = new System.Drawing.Size(185, 50);
            this.Btn_DSView.TabIndex = 7;
            this.Btn_DSView.Text = "Danh sách view";
            this.Btn_DSView.UseVisualStyleBackColor = true;
            this.Btn_DSView.Click += new System.EventHandler(this.Btn_DSView_Click);
            // 
            // Btn_TaoNguoiDung
            // 
            this.Btn_TaoNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TaoNguoiDung.Location = new System.Drawing.Point(12, 328);
            this.Btn_TaoNguoiDung.Name = "Btn_TaoNguoiDung";
            this.Btn_TaoNguoiDung.Size = new System.Drawing.Size(185, 50);
            this.Btn_TaoNguoiDung.TabIndex = 8;
            this.Btn_TaoNguoiDung.Text = "Tạo user mới ";
            this.Btn_TaoNguoiDung.UseVisualStyleBackColor = true;
            this.Btn_TaoNguoiDung.Click += new System.EventHandler(this.Btn_TaoNguoiDung_Click);
            // 
            // Btn_TaoRole
            // 
            this.Btn_TaoRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TaoRole.Location = new System.Drawing.Point(12, 384);
            this.Btn_TaoRole.Name = "Btn_TaoRole";
            this.Btn_TaoRole.Size = new System.Drawing.Size(185, 50);
            this.Btn_TaoRole.TabIndex = 9;
            this.Btn_TaoRole.Text = "Tạo Role mới ";
            this.Btn_TaoRole.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1596, 764);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xóa người dùng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dataGridView_ds_table
            // 
            this.dataGridView_ds_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ds_table.Location = new System.Drawing.Point(247, 133);
            this.dataGridView_ds_table.Name = "dataGridView_ds_table";
            this.dataGridView_ds_table.RowHeadersWidth = 51;
            this.dataGridView_ds_table.RowTemplate.Height = 24;
            this.dataGridView_ds_table.Size = new System.Drawing.Size(411, 400);
            this.dataGridView_ds_table.TabIndex = 11;
            // 
            // dataGridView_ds_role
            // 
            this.dataGridView_ds_role.AllowUserToAddRows = false;
            this.dataGridView_ds_role.AllowUserToDeleteRows = false;
            this.dataGridView_ds_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ds_role.Location = new System.Drawing.Point(247, 133);
            this.dataGridView_ds_role.Name = "dataGridView_ds_role";
            this.dataGridView_ds_role.RowHeadersWidth = 51;
            this.dataGridView_ds_role.RowTemplate.Height = 24;
            this.dataGridView_ds_role.Size = new System.Drawing.Size(1534, 337);
            this.dataGridView_ds_role.TabIndex = 12;
            // 
            // Btn_xoa_quyen
            // 
            this.Btn_xoa_quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_xoa_quyen.Location = new System.Drawing.Point(1596, 496);
            this.Btn_xoa_quyen.Name = "Btn_xoa_quyen";
            this.Btn_xoa_quyen.Size = new System.Drawing.Size(185, 42);
            this.Btn_xoa_quyen.TabIndex = 14;
            this.Btn_xoa_quyen.Text = "Xóa role";
            this.Btn_xoa_quyen.UseVisualStyleBackColor = true;
            this.Btn_xoa_quyen.Click += new System.EventHandler(this.Btn_xoa_quyen_Click);
            // 
            // label_ds
            // 
            this.label_ds.AutoSize = true;
            this.label_ds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ds.Location = new System.Drawing.Point(862, 41);
            this.label_ds.Name = "label_ds";
            this.label_ds.Size = new System.Drawing.Size(150, 32);
            this.label_ds.TabIndex = 15;
            this.label_ds.Text = "Danh sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(876, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tạo role mới";
            // 
            // button_tao_role
            // 
            this.button_tao_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tao_role.Location = new System.Drawing.Point(882, 764);
            this.button_tao_role.Name = "button_tao_role";
            this.button_tao_role.Size = new System.Drawing.Size(185, 50);
            this.button_tao_role.TabIndex = 17;
            this.button_tao_role.Text = "Tạo role";
            this.button_tao_role.UseVisualStyleBackColor = true;
            this.button_tao_role.Click += new System.EventHandler(this.button_tao_role_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(882, 649);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 30);
            this.textBox1.TabIndex = 18;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_tao_role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_ds);
            this.Controls.Add(this.Btn_xoa_quyen);
            this.Controls.Add(this.dataGridView_ds_role);
            this.Controls.Add(this.dataGridView_ds_table);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_TaoRole);
            this.Controls.Add(this.Btn_TaoNguoiDung);
            this.Controls.Add(this.Btn_DSView);
            this.Controls.Add(this.Btn_DSTable);
            this.Controls.Add(this.DanhSach);
            this.Controls.Add(this.Btn_TroVe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_LichSuCapQuyen_click);
            this.Controls.Add(this.Btn_XemDSRole_click);
            this.Controls.Add(this.Btn_XemDSUser_click);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ds_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ds_role)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_XemDSUser_click;
        private System.Windows.Forms.Button Btn_XemDSRole_click;
        private System.Windows.Forms.Button Btn_LichSuCapQuyen_click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_TroVe;
        private System.Windows.Forms.DataGridView DanhSach;
        private System.Windows.Forms.Button Btn_DSTable;
        private System.Windows.Forms.Button Btn_DSView;
        private System.Windows.Forms.Button Btn_TaoNguoiDung;
        private System.Windows.Forms.Button Btn_TaoRole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_ds_table;
        private System.Windows.Forms.DataGridView dataGridView_ds_role;
        private System.Windows.Forms.Button Btn_xoa_quyen;
        private System.Windows.Forms.Label label_ds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_tao_role;
        private System.Windows.Forms.TextBox textBox1;
    }
}