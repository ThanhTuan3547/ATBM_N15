
namespace DoAnThucHanh_ATBM
{
    partial class CapQuyenNguoiDung
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_bang = new System.Windows.Forms.ComboBox();
            this.Ds_Cot = new System.Windows.Forms.DataGridView();
            this.Btn_hienThiCot = new System.Windows.Forms.Button();
            this.checkBox_Them = new System.Windows.Forms.CheckBox();
            this.checkBox_Xoa = new System.Windows.Forms.CheckBox();
            this.Grant_option = new System.Windows.Forms.CheckBox();
            this.Btn_TroVe = new System.Windows.Forms.Button();
            this.Btn_PhanQuyen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_Cot)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cấp quyền cho người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người dùng hiện tại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bảng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox_bang
            // 
            this.comboBox_bang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_bang.FormattingEnabled = true;
            this.comboBox_bang.Location = new System.Drawing.Point(415, 186);
            this.comboBox_bang.Name = "comboBox_bang";
            this.comboBox_bang.Size = new System.Drawing.Size(204, 33);
            this.comboBox_bang.TabIndex = 3;
            this.comboBox_bang.SelectedIndexChanged += new System.EventHandler(this.comboBox_bang_SelectedIndexChanged);
            // 
            // Ds_Cot
            // 
            this.Ds_Cot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ds_Cot.Location = new System.Drawing.Point(224, 276);
            this.Ds_Cot.Name = "Ds_Cot";
            this.Ds_Cot.RowHeadersWidth = 51;
            this.Ds_Cot.RowTemplate.Height = 24;
            this.Ds_Cot.Size = new System.Drawing.Size(614, 236);
            this.Ds_Cot.TabIndex = 4;
            // 
            // Btn_hienThiCot
            // 
            this.Btn_hienThiCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_hienThiCot.Location = new System.Drawing.Point(692, 186);
            this.Btn_hienThiCot.Name = "Btn_hienThiCot";
            this.Btn_hienThiCot.Size = new System.Drawing.Size(146, 33);
            this.Btn_hienThiCot.TabIndex = 5;
            this.Btn_hienThiCot.Text = "Hiển thị cột";
            this.Btn_hienThiCot.UseVisualStyleBackColor = true;
            this.Btn_hienThiCot.Click += new System.EventHandler(this.Btn_hienThiCot_Click);
            // 
            // checkBox_Them
            // 
            this.checkBox_Them.AutoSize = true;
            this.checkBox_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Them.Location = new System.Drawing.Point(978, 276);
            this.checkBox_Them.Name = "checkBox_Them";
            this.checkBox_Them.Size = new System.Drawing.Size(85, 29);
            this.checkBox_Them.TabIndex = 6;
            this.checkBox_Them.Text = "Thêm";
            this.checkBox_Them.UseVisualStyleBackColor = true;
            // 
            // checkBox_Xoa
            // 
            this.checkBox_Xoa.AutoSize = true;
            this.checkBox_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Xoa.Location = new System.Drawing.Point(978, 341);
            this.checkBox_Xoa.Name = "checkBox_Xoa";
            this.checkBox_Xoa.Size = new System.Drawing.Size(70, 29);
            this.checkBox_Xoa.TabIndex = 7;
            this.checkBox_Xoa.Text = "Xóa";
            this.checkBox_Xoa.UseVisualStyleBackColor = true;
            // 
            // Grant_option
            // 
            this.Grant_option.AutoSize = true;
            this.Grant_option.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grant_option.Location = new System.Drawing.Point(978, 410);
            this.Grant_option.Name = "Grant_option";
            this.Grant_option.Size = new System.Drawing.Size(414, 29);
            this.Grant_option.TabIndex = 8;
            this.Grant_option.Text = "Cho phép phân quyền cho người dùng khác";
            this.Grant_option.UseVisualStyleBackColor = true;
            // 
            // Btn_TroVe
            // 
            this.Btn_TroVe.AutoSize = true;
            this.Btn_TroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TroVe.Location = new System.Drawing.Point(12, 12);
            this.Btn_TroVe.Name = "Btn_TroVe";
            this.Btn_TroVe.Size = new System.Drawing.Size(75, 30);
            this.Btn_TroVe.TabIndex = 9;
            this.Btn_TroVe.Text = "Trở về";
            this.Btn_TroVe.UseVisualStyleBackColor = true;
            this.Btn_TroVe.Click += new System.EventHandler(this.Btn_TroVe_Click);
            // 
            // Btn_PhanQuyen
            // 
            this.Btn_PhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PhanQuyen.Location = new System.Drawing.Point(978, 481);
            this.Btn_PhanQuyen.Name = "Btn_PhanQuyen";
            this.Btn_PhanQuyen.Size = new System.Drawing.Size(154, 31);
            this.Btn_PhanQuyen.TabIndex = 10;
            this.Btn_PhanQuyen.Text = "Phân quyền";
            this.Btn_PhanQuyen.UseVisualStyleBackColor = true;
            this.Btn_PhanQuyen.Click += new System.EventHandler(this.Btn_PhanQuyen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ten nguoi dung";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CapQuyenNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_PhanQuyen);
            this.Controls.Add(this.Btn_TroVe);
            this.Controls.Add(this.Grant_option);
            this.Controls.Add(this.checkBox_Xoa);
            this.Controls.Add(this.checkBox_Them);
            this.Controls.Add(this.Btn_hienThiCot);
            this.Controls.Add(this.Ds_Cot);
            this.Controls.Add(this.comboBox_bang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CapQuyenNguoiDung";
            this.Text = "CapQuyenNguoiDung";
            this.Load += new System.EventHandler(this.CapQuyenNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ds_Cot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_bang;
        private System.Windows.Forms.DataGridView Ds_Cot;
        private System.Windows.Forms.Button Btn_hienThiCot;
        private System.Windows.Forms.CheckBox checkBox_Them;
        private System.Windows.Forms.CheckBox checkBox_Xoa;
        private System.Windows.Forms.CheckBox Grant_option;
        private System.Windows.Forms.Button Btn_TroVe;
        private System.Windows.Forms.Button Btn_PhanQuyen;
        private System.Windows.Forms.Label label4;
    }
}