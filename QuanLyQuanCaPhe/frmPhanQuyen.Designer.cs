namespace QUanLyQuanCaPhe
{
    partial class frmPhanQuyen
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
            this.btn_luu = new System.Windows.Forms.Button();
            this.data_nhomnguoidung = new System.Windows.Forms.DataGridView();
            this.data_quyenchucnang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_nhomnguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_quyenchucnang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(25, 34);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(83, 33);
            this.btn_luu.TabIndex = 0;
            this.btn_luu.Text = "Lưu ";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // data_nhomnguoidung
            // 
            this.data_nhomnguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_nhomnguoidung.Location = new System.Drawing.Point(12, 116);
            this.data_nhomnguoidung.Name = "data_nhomnguoidung";
            this.data_nhomnguoidung.RowHeadersWidth = 51;
            this.data_nhomnguoidung.RowTemplate.Height = 24;
            this.data_nhomnguoidung.Size = new System.Drawing.Size(295, 288);
            this.data_nhomnguoidung.TabIndex = 1;
            this.data_nhomnguoidung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_nhomnguoidung_CellClick);
            this.data_nhomnguoidung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_nhomnguoidung_CellContentClick);
            // 
            // data_quyenchucnang
            // 
            this.data_quyenchucnang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_quyenchucnang.Location = new System.Drawing.Point(355, 116);
            this.data_quyenchucnang.Name = "data_quyenchucnang";
            this.data_quyenchucnang.RowHeadersWidth = 51;
            this.data_quyenchucnang.RowTemplate.Height = 24;
            this.data_quyenchucnang.Size = new System.Drawing.Size(436, 346);
            this.data_quyenchucnang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách nhóm người dùng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách quyền chức năng";
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 525);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_quyenchucnang);
            this.Controls.Add(this.data_nhomnguoidung);
            this.Controls.Add(this.btn_luu);
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            ((System.ComponentModel.ISupportInitialize)(this.data_nhomnguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_quyenchucnang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.DataGridView data_nhomnguoidung;
        private System.Windows.Forms.DataGridView data_quyenchucnang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}