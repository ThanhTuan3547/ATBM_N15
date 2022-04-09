
namespace DoAnThucHanh_ATBM
{
    partial class Tao_nguoi_dung_moi
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
            this.Btn_TroVe = new System.Windows.Forms.Button();
            this.Btn_TaoNguoiDung = new System.Windows.Forms.Button();
            this.TaiKhoan = new System.Windows.Forms.TextBox();
            this.MatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_them_role = new System.Windows.Forms.Button();
            this.DS_role_box = new System.Windows.Forms.CheckedListBox();
            this.listBox_role = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Btn_TroVe
            // 
            this.Btn_TroVe.AutoSize = true;
            this.Btn_TroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TroVe.Location = new System.Drawing.Point(12, 12);
            this.Btn_TroVe.Name = "Btn_TroVe";
            this.Btn_TroVe.Size = new System.Drawing.Size(75, 30);
            this.Btn_TroVe.TabIndex = 0;
            this.Btn_TroVe.Text = "Trở về";
            this.Btn_TroVe.UseVisualStyleBackColor = true;
            this.Btn_TroVe.Click += new System.EventHandler(this.Btn_TroVe_Click);
            // 
            // Btn_TaoNguoiDung
            // 
            this.Btn_TaoNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TaoNguoiDung.Location = new System.Drawing.Point(286, 648);
            this.Btn_TaoNguoiDung.Name = "Btn_TaoNguoiDung";
            this.Btn_TaoNguoiDung.Size = new System.Drawing.Size(162, 49);
            this.Btn_TaoNguoiDung.TabIndex = 2;
            this.Btn_TaoNguoiDung.Text = "Tạo người dùng";
            this.Btn_TaoNguoiDung.UseVisualStyleBackColor = true;
            this.Btn_TaoNguoiDung.Click += new System.EventHandler(this.Btn_TaoNguoiDung_Click);
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaiKhoan.Location = new System.Drawing.Point(270, 105);
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Size = new System.Drawing.Size(178, 30);
            this.TaiKhoan.TabIndex = 3;
            this.TaiKhoan.TextChanged += new System.EventHandler(this.TaiKhoan_TextChanged);
            // 
            // MatKhau
            // 
            this.MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhau.Location = new System.Drawing.Point(270, 150);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.PasswordChar = '*';
            this.MatKhau.Size = new System.Drawing.Size(178, 30);
            this.MatKhau.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu ";
            // 
            // XacNhanMatKhau
            // 
            this.XacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XacNhanMatKhau.Location = new System.Drawing.Point(270, 190);
            this.XacNhanMatKhau.Name = "XacNhanMatKhau";
            this.XacNhanMatKhau.PasswordChar = '*';
            this.XacNhanMatKhau.Size = new System.Drawing.Size(178, 30);
            this.XacNhanMatKhau.TabIndex = 7;
            this.XacNhanMatKhau.TextChanged += new System.EventHandler(this.XacNhanMatKhau_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Xác nhận mật khẩu ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(660, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Danh sách Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(660, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Danh sách Role đã chọn ";
            // 
            // Btn_them_role
            // 
            this.Btn_them_role.AutoSize = true;
            this.Btn_them_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_them_role.Location = new System.Drawing.Point(831, 349);
            this.Btn_them_role.Name = "Btn_them_role";
            this.Btn_them_role.Size = new System.Drawing.Size(236, 33);
            this.Btn_them_role.TabIndex = 19;
            this.Btn_them_role.Text = "Thêm role ";
            this.Btn_them_role.UseVisualStyleBackColor = true;
            this.Btn_them_role.Click += new System.EventHandler(this.Btn_them_role_Click);
            // 
            // DS_role_box
            // 
            this.DS_role_box.AllowDrop = true;
            this.DS_role_box.CheckOnClick = true;
            this.DS_role_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DS_role_box.FormattingEnabled = true;
            this.DS_role_box.Location = new System.Drawing.Point(663, 118);
            this.DS_role_box.Name = "DS_role_box";
            this.DS_role_box.Size = new System.Drawing.Size(404, 225);
            this.DS_role_box.TabIndex = 23;
            this.DS_role_box.SelectedIndexChanged += new System.EventHandler(this.DS_role_box_SelectedIndexChanged);
            // 
            // listBox_role
            // 
            this.listBox_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_role.FormattingEnabled = true;
            this.listBox_role.ItemHeight = 20;
            this.listBox_role.Location = new System.Drawing.Point(665, 485);
            this.listBox_role.Name = "listBox_role";
            this.listBox_role.Size = new System.Drawing.Size(402, 204);
            this.listBox_role.TabIndex = 24;
            // 
            // Tao_nguoi_dung_moi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.listBox_role);
            this.Controls.Add(this.DS_role_box);
            this.Controls.Add(this.Btn_them_role);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.XacNhanMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.TaiKhoan);
            this.Controls.Add(this.Btn_TaoNguoiDung);
            this.Controls.Add(this.Btn_TroVe);
            this.Name = "Tao_nguoi_dung_moi";
            this.Text = "Tao_nguoi_dung_moi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_TroVe;
        private System.Windows.Forms.Button Btn_TaoNguoiDung;
        private System.Windows.Forms.TextBox TaiKhoan;
        private System.Windows.Forms.TextBox MatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox XacNhanMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_them_role;
        private System.Windows.Forms.CheckedListBox DS_role_box;
        private System.Windows.Forms.ListBox listBox_role;
    }
}