namespace Form2
{
    partial class frmTimGiangVien
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
			this.grbTimTheo = new System.Windows.Forms.GroupBox();
			this.rdSoDT = new System.Windows.Forms.RadioButton();
			this.rdHoTen = new System.Windows.Forms.RadioButton();
			this.rdMaGV = new System.Windows.Forms.RadioButton();
			this.lblTimTheo = new System.Windows.Forms.Label();
			this.txtTim = new System.Windows.Forms.TextBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.grbTimTheo.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbTimTheo
			// 
			this.grbTimTheo.Controls.Add(this.rdSoDT);
			this.grbTimTheo.Controls.Add(this.rdHoTen);
			this.grbTimTheo.Controls.Add(this.rdMaGV);
			this.grbTimTheo.Dock = System.Windows.Forms.DockStyle.Top;
			this.grbTimTheo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbTimTheo.Location = new System.Drawing.Point(0, 0);
			this.grbTimTheo.Margin = new System.Windows.Forms.Padding(4);
			this.grbTimTheo.Name = "grbTimTheo";
			this.grbTimTheo.Padding = new System.Windows.Forms.Padding(4);
			this.grbTimTheo.Size = new System.Drawing.Size(483, 81);
			this.grbTimTheo.TabIndex = 0;
			this.grbTimTheo.TabStop = false;
			this.grbTimTheo.Text = "Tìm Theo";
			// 
			// rdSoDT
			// 
			this.rdSoDT.AutoSize = true;
			this.rdSoDT.Location = new System.Drawing.Point(305, 42);
			this.rdSoDT.Margin = new System.Windows.Forms.Padding(4);
			this.rdSoDT.Name = "rdSoDT";
			this.rdSoDT.Size = new System.Drawing.Size(129, 25);
			this.rdSoDT.TabIndex = 2;
			this.rdSoDT.Text = "Số điện thoại";
			this.rdSoDT.UseVisualStyleBackColor = true;
			this.rdSoDT.CheckedChanged += new System.EventHandler(this.rdSoDT_CheckedChanged);
			// 
			// rdHoTen
			// 
			this.rdHoTen.AutoSize = true;
			this.rdHoTen.Location = new System.Drawing.Point(161, 42);
			this.rdHoTen.Margin = new System.Windows.Forms.Padding(4);
			this.rdHoTen.Name = "rdHoTen";
			this.rdHoTen.Size = new System.Drawing.Size(88, 25);
			this.rdHoTen.TabIndex = 1;
			this.rdHoTen.Text = "Họ Tên";
			this.rdHoTen.UseVisualStyleBackColor = true;
			this.rdHoTen.CheckedChanged += new System.EventHandler(this.rdHoTen_CheckedChanged);
			// 
			// rdMaGV
			// 
			this.rdMaGV.AutoSize = true;
			this.rdMaGV.Checked = true;
			this.rdMaGV.Location = new System.Drawing.Point(16, 42);
			this.rdMaGV.Margin = new System.Windows.Forms.Padding(4);
			this.rdMaGV.Name = "rdMaGV";
			this.rdMaGV.Size = new System.Drawing.Size(87, 25);
			this.rdMaGV.TabIndex = 0;
			this.rdMaGV.TabStop = true;
			this.rdMaGV.Text = "Mã GV";
			this.rdMaGV.UseVisualStyleBackColor = true;
			this.rdMaGV.CheckedChanged += new System.EventHandler(this.rdMaGV_CheckedChanged);
			// 
			// lblTimTheo
			// 
			this.lblTimTheo.AutoSize = true;
			this.lblTimTheo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimTheo.Location = new System.Drawing.Point(35, 101);
			this.lblTimTheo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTimTheo.Name = "lblTimTheo";
			this.lblTimTheo.Size = new System.Drawing.Size(73, 22);
			this.lblTimTheo.TabIndex = 1;
			this.lblTimTheo.Text = "Mã GV:";
			// 
			// txtTim
			// 
			this.txtTim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTim.Location = new System.Drawing.Point(136, 97);
			this.txtTim.Margin = new System.Windows.Forms.Padding(4);
			this.txtTim.Name = "txtTim";
			this.txtTim.Size = new System.Drawing.Size(256, 29);
			this.txtTim.TabIndex = 2;
			// 
			// btnTim
			// 
			this.btnTim.BackColor = System.Drawing.Color.Turquoise;
			this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnTim.ForeColor = System.Drawing.Color.Black;
			this.btnTim.Location = new System.Drawing.Point(406, 98);
			this.btnTim.Margin = new System.Windows.Forms.Padding(4);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(64, 28);
			this.btnTim.TabIndex = 3;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = false;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// frmTimGiangVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 158);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txtTim);
			this.Controls.Add(this.lblTimTheo);
			this.Controls.Add(this.grbTimTheo);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmTimGiangVien";
			this.Text = "Tìm Thông Tin Giảng Viên";
			this.grbTimTheo.ResumeLayout(false);
			this.grbTimTheo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTimTheo;
        private System.Windows.Forms.RadioButton rdSoDT;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMaGV;
        private System.Windows.Forms.Label lblTimTheo;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
    }
}