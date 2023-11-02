namespace QUanLyQuanCaPhe
{
    partial class frmThemNguoIDungVaoNhom
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
            this.cob_tennhom = new System.Windows.Forms.ComboBox();
            this.data_NguoiDung = new System.Windows.Forms.DataGridView();
            this.data_NguoiDungNhomNguoiDung = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_NguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_NguoiDungNhomNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // cob_tennhom
            // 
            this.cob_tennhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_tennhom.FormattingEnabled = true;
            this.cob_tennhom.Location = new System.Drawing.Point(681, 44);
            this.cob_tennhom.Name = "cob_tennhom";
            this.cob_tennhom.Size = new System.Drawing.Size(141, 28);
            this.cob_tennhom.TabIndex = 0;
            this.cob_tennhom.SelectedIndexChanged += new System.EventHandler(this.cob_tennhom_SelectedIndexChanged);
            // 
            // data_NguoiDung
            // 
            this.data_NguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_NguoiDung.Location = new System.Drawing.Point(12, 97);
            this.data_NguoiDung.Name = "data_NguoiDung";
            this.data_NguoiDung.RowHeadersWidth = 51;
            this.data_NguoiDung.RowTemplate.Height = 24;
            this.data_NguoiDung.Size = new System.Drawing.Size(428, 272);
            this.data_NguoiDung.TabIndex = 1;
            this.data_NguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_NguoiDung_CellClick);
            // 
            // data_NguoiDungNhomNguoiDung
            // 
            this.data_NguoiDungNhomNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_NguoiDungNhomNguoiDung.Location = new System.Drawing.Point(572, 97);
            this.data_NguoiDungNhomNguoiDung.Name = "data_NguoiDungNhomNguoiDung";
            this.data_NguoiDungNhomNguoiDung.RowHeadersWidth = 51;
            this.data_NguoiDungNhomNguoiDung.Size = new System.Drawing.Size(456, 272);
            this.data_NguoiDungNhomNguoiDung.TabIndex = 1;
            this.data_NguoiDungNhomNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_NguoiDungNhomNguoiDung_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(472, 184);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 40);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = ">>";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên nhóm ";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(472, 242);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 40);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "<<";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // frmThemNguoIDungVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.data_NguoiDungNhomNguoiDung);
            this.Controls.Add(this.data_NguoiDung);
            this.Controls.Add(this.cob_tennhom);
            this.Name = "frmThemNguoIDungVaoNhom";
            this.Text = "ThemNguoIDungVaoNhom";
            ((System.ComponentModel.ISupportInitialize)(this.data_NguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_NguoiDungNhomNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cob_tennhom;
        private System.Windows.Forms.DataGridView data_NguoiDung;
        private System.Windows.Forms.DataGridView data_NguoiDungNhomNguoiDung;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xoa;
    }
}