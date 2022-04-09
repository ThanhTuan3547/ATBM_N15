
namespace DoAnThucHanh_ATBM
{
    partial class Thong_Tin_Nguoi_dung
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
            this.tab_privs = new System.Windows.Forms.DataGridView();
            this.col_privs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Tro_ve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tab_privs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_privs)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_privs
            // 
            this.tab_privs.AllowUserToAddRows = false;
            this.tab_privs.AllowUserToDeleteRows = false;
            this.tab_privs.AllowUserToOrderColumns = true;
            this.tab_privs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_privs.Location = new System.Drawing.Point(253, 145);
            this.tab_privs.Name = "tab_privs";
            this.tab_privs.RowHeadersWidth = 51;
            this.tab_privs.RowTemplate.Height = 24;
            this.tab_privs.Size = new System.Drawing.Size(1158, 349);
            this.tab_privs.TabIndex = 0;
            // 
            // col_privs
            // 
            this.col_privs.AllowUserToAddRows = false;
            this.col_privs.AllowUserToDeleteRows = false;
            this.col_privs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.col_privs.Location = new System.Drawing.Point(253, 619);
            this.col_privs.Name = "col_privs";
            this.col_privs.RowHeadersWidth = 51;
            this.col_privs.RowTemplate.Height = 24;
            this.col_privs.Size = new System.Drawing.Size(1158, 349);
            this.col_privs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quyền trên bảng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quyền trên cột";
            // 
            // Btn_Tro_ve
            // 
            this.Btn_Tro_ve.AutoSize = true;
            this.Btn_Tro_ve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Tro_ve.Location = new System.Drawing.Point(13, 13);
            this.Btn_Tro_ve.Name = "Btn_Tro_ve";
            this.Btn_Tro_ve.Size = new System.Drawing.Size(75, 30);
            this.Btn_Tro_ve.TabIndex = 4;
            this.Btn_Tro_ve.Text = "Trở về";
            this.Btn_Tro_ve.UseVisualStyleBackColor = true;
            this.Btn_Tro_ve.Click += new System.EventHandler(this.Btn_Tro_ve_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cấp quyền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(253, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Revoke";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Thong_Tin_Nguoi_dung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Tro_ve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.col_privs);
            this.Controls.Add(this.tab_privs);
            this.Name = "Thong_Tin_Nguoi_dung";
            this.Text = "Thong_Tin_Nguoi_dung";
            this.Load += new System.EventHandler(this.Thong_Tin_Nguoi_dung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab_privs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_privs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tab_privs;
        private System.Windows.Forms.DataGridView col_privs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Tro_ve;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}