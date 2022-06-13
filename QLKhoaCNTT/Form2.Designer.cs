
namespace QLKhoaCNTT {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.GiangVien = new System.Windows.Forms.Panel();
            this.GiangViencheckBox2 = new System.Windows.Forms.CheckBox();
            this.GiangViencheckBox1 = new System.Windows.Forms.CheckBox();
            this.GiangViencbMaHP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GiangViencbMaLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GiangViencbMaGV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HocPhan = new System.Windows.Forms.Panel();
            this.HocPhancbMaGV = new System.Windows.Forms.ComboBox();
            this.HocPhancheckBox1 = new System.Windows.Forms.CheckBox();
            this.HocPhancheckBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HocPhancbSoTC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HocPhancbMaHP = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Lop = new System.Windows.Forms.Panel();
            this.LopcbSoSV = new System.Windows.Forms.ComboBox();
            this.LopcheckBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LopcbTenLop = new System.Windows.Forms.ComboBox();
            this.LopcbMaLop = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SinhVien = new System.Windows.Forms.Panel();
            this.SinhViencbKhoa = new System.Windows.Forms.ComboBox();
            this.SinhViencheckBox2 = new System.Windows.Forms.CheckBox();
            this.SinhViencheckBox1 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SinhViencbMaLop = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SinhViencbMaSV = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.GiangVien.SuspendLayout();
            this.HocPhan.SuspendLayout();
            this.Lop.SuspendLayout();
            this.SinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(163, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO THỐNG KÊ KHOA CNTT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đối tượng:";
            // 
            // cbTable
            // 
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(155, 81);
            this.cbTable.Margin = new System.Windows.Forms.Padding(4);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(160, 24);
            this.cbTable.TabIndex = 2;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(43, 224);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.Size = new System.Drawing.Size(955, 293);
            this.dgvTable.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 527);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng: ";
            // 
            // txtCount
            // 
            this.txtCount.Enabled = false;
            this.txtCount.Location = new System.Drawing.Point(84, 523);
            this.txtCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(132, 22);
            this.txtCount.TabIndex = 5;
            // 
            // GiangVien
            // 
            this.GiangVien.Controls.Add(this.GiangViencheckBox2);
            this.GiangVien.Controls.Add(this.GiangViencheckBox1);
            this.GiangVien.Controls.Add(this.GiangViencbMaHP);
            this.GiangVien.Controls.Add(this.label6);
            this.GiangVien.Controls.Add(this.GiangViencbMaLop);
            this.GiangVien.Controls.Add(this.label5);
            this.GiangVien.Controls.Add(this.GiangViencbMaGV);
            this.GiangVien.Controls.Add(this.label4);
            this.GiangVien.Location = new System.Drawing.Point(47, 127);
            this.GiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.GiangVien.Name = "GiangVien";
            this.GiangVien.Size = new System.Drawing.Size(268, 97);
            this.GiangVien.TabIndex = 6;
            // 
            // GiangViencheckBox2
            // 
            this.GiangViencheckBox2.AutoSize = true;
            this.GiangViencheckBox2.Location = new System.Drawing.Point(231, 41);
            this.GiangViencheckBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GiangViencheckBox2.Name = "GiangViencheckBox2";
            this.GiangViencheckBox2.Size = new System.Drawing.Size(18, 17);
            this.GiangViencheckBox2.TabIndex = 2;
            this.GiangViencheckBox2.UseVisualStyleBackColor = true;
            this.GiangViencheckBox2.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // GiangViencheckBox1
            // 
            this.GiangViencheckBox1.AutoSize = true;
            this.GiangViencheckBox1.Location = new System.Drawing.Point(231, 7);
            this.GiangViencheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GiangViencheckBox1.Name = "GiangViencheckBox1";
            this.GiangViencheckBox1.Size = new System.Drawing.Size(18, 17);
            this.GiangViencheckBox1.TabIndex = 2;
            this.GiangViencheckBox1.UseVisualStyleBackColor = true;
            this.GiangViencheckBox1.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // GiangViencbMaHP
            // 
            this.GiangViencbMaHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GiangViencbMaHP.Enabled = false;
            this.GiangViencbMaHP.FormattingEnabled = true;
            this.GiangViencbMaHP.Location = new System.Drawing.Point(59, 68);
            this.GiangViencbMaHP.Margin = new System.Windows.Forms.Padding(4);
            this.GiangViencbMaHP.Name = "GiangViencbMaHP";
            this.GiangViencbMaHP.Size = new System.Drawing.Size(160, 24);
            this.GiangViencbMaHP.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã HP";
            // 
            // GiangViencbMaLop
            // 
            this.GiangViencbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GiangViencbMaLop.FormattingEnabled = true;
            this.GiangViencbMaLop.Location = new System.Drawing.Point(59, 37);
            this.GiangViencbMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.GiangViencbMaLop.Name = "GiangViencbMaLop";
            this.GiangViencbMaLop.Size = new System.Drawing.Size(160, 24);
            this.GiangViencbMaLop.TabIndex = 1;
            this.GiangViencbMaLop.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã lớp";
            // 
            // GiangViencbMaGV
            // 
            this.GiangViencbMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GiangViencbMaGV.FormattingEnabled = true;
            this.GiangViencbMaGV.Location = new System.Drawing.Point(59, 4);
            this.GiangViencbMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.GiangViencbMaGV.Name = "GiangViencbMaGV";
            this.GiangViencbMaGV.Size = new System.Drawing.Size(160, 24);
            this.GiangViencbMaGV.TabIndex = 1;
            this.GiangViencbMaGV.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã GV";
            // 
            // HocPhan
            // 
            this.HocPhan.Controls.Add(this.HocPhancbMaGV);
            this.HocPhan.Controls.Add(this.HocPhancheckBox1);
            this.HocPhan.Controls.Add(this.HocPhancheckBox2);
            this.HocPhan.Controls.Add(this.label7);
            this.HocPhan.Controls.Add(this.HocPhancbSoTC);
            this.HocPhan.Controls.Add(this.label8);
            this.HocPhan.Controls.Add(this.HocPhancbMaHP);
            this.HocPhan.Controls.Add(this.label9);
            this.HocPhan.Location = new System.Drawing.Point(323, 127);
            this.HocPhan.Margin = new System.Windows.Forms.Padding(4);
            this.HocPhan.Name = "HocPhan";
            this.HocPhan.Size = new System.Drawing.Size(268, 97);
            this.HocPhan.TabIndex = 6;
            // 
            // HocPhancbMaGV
            // 
            this.HocPhancbMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HocPhancbMaGV.Enabled = false;
            this.HocPhancbMaGV.FormattingEnabled = true;
            this.HocPhancbMaGV.Location = new System.Drawing.Point(59, 68);
            this.HocPhancbMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.HocPhancbMaGV.Name = "HocPhancbMaGV";
            this.HocPhancbMaGV.Size = new System.Drawing.Size(160, 24);
            this.HocPhancbMaGV.TabIndex = 1;
            // 
            // HocPhancheckBox1
            // 
            this.HocPhancheckBox1.AutoSize = true;
            this.HocPhancheckBox1.Location = new System.Drawing.Point(228, 7);
            this.HocPhancheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.HocPhancheckBox1.Name = "HocPhancheckBox1";
            this.HocPhancheckBox1.Size = new System.Drawing.Size(18, 17);
            this.HocPhancheckBox1.TabIndex = 2;
            this.HocPhancheckBox1.UseVisualStyleBackColor = true;
            this.HocPhancheckBox1.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // HocPhancheckBox2
            // 
            this.HocPhancheckBox2.AutoSize = true;
            this.HocPhancheckBox2.Location = new System.Drawing.Point(228, 37);
            this.HocPhancheckBox2.Margin = new System.Windows.Forms.Padding(4);
            this.HocPhancheckBox2.Name = "HocPhancheckBox2";
            this.HocPhancheckBox2.Size = new System.Drawing.Size(18, 17);
            this.HocPhancheckBox2.TabIndex = 2;
            this.HocPhancheckBox2.UseVisualStyleBackColor = true;
            this.HocPhancheckBox2.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã GV";
            // 
            // HocPhancbSoTC
            // 
            this.HocPhancbSoTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HocPhancbSoTC.FormattingEnabled = true;
            this.HocPhancbSoTC.Location = new System.Drawing.Point(59, 37);
            this.HocPhancbSoTC.Margin = new System.Windows.Forms.Padding(4);
            this.HocPhancbSoTC.Name = "HocPhancbSoTC";
            this.HocPhancbSoTC.Size = new System.Drawing.Size(160, 24);
            this.HocPhancbSoTC.TabIndex = 1;
            this.HocPhancbSoTC.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số TC";
            // 
            // HocPhancbMaHP
            // 
            this.HocPhancbMaHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HocPhancbMaHP.FormattingEnabled = true;
            this.HocPhancbMaHP.Location = new System.Drawing.Point(59, 4);
            this.HocPhancbMaHP.Margin = new System.Windows.Forms.Padding(4);
            this.HocPhancbMaHP.Name = "HocPhancbMaHP";
            this.HocPhancbMaHP.Size = new System.Drawing.Size(160, 24);
            this.HocPhancbMaHP.TabIndex = 1;
            this.HocPhancbMaHP.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã HP";
            // 
            // Lop
            // 
            this.Lop.Controls.Add(this.LopcbSoSV);
            this.Lop.Controls.Add(this.LopcheckBox1);
            this.Lop.Controls.Add(this.label11);
            this.Lop.Controls.Add(this.LopcbTenLop);
            this.Lop.Controls.Add(this.LopcbMaLop);
            this.Lop.Controls.Add(this.label);
            this.Lop.Controls.Add(this.label12);
            this.Lop.Location = new System.Drawing.Point(599, 127);
            this.Lop.Margin = new System.Windows.Forms.Padding(4);
            this.Lop.Name = "Lop";
            this.Lop.Size = new System.Drawing.Size(191, 97);
            this.Lop.TabIndex = 6;
            // 
            // LopcbSoSV
            // 
            this.LopcbSoSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LopcbSoSV.Enabled = false;
            this.LopcbSoSV.FormattingEnabled = true;
            this.LopcbSoSV.Location = new System.Drawing.Point(59, 62);
            this.LopcbSoSV.Margin = new System.Windows.Forms.Padding(4);
            this.LopcbSoSV.Name = "LopcbSoSV";
            this.LopcbSoSV.Size = new System.Drawing.Size(93, 24);
            this.LopcbSoSV.TabIndex = 1;
            // 
            // LopcheckBox1
            // 
            this.LopcheckBox1.AutoSize = true;
            this.LopcheckBox1.Location = new System.Drawing.Point(161, 7);
            this.LopcheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.LopcheckBox1.Name = "LopcheckBox1";
            this.LopcheckBox1.Size = new System.Drawing.Size(18, 17);
            this.LopcheckBox1.TabIndex = 2;
            this.LopcheckBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số SV";
            // 
            // LopcbTenLop
            // 
            this.LopcbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LopcbTenLop.Enabled = false;
            this.LopcbTenLop.FormattingEnabled = true;
            this.LopcbTenLop.Location = new System.Drawing.Point(59, 33);
            this.LopcbTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.LopcbTenLop.Name = "LopcbTenLop";
            this.LopcbTenLop.Size = new System.Drawing.Size(93, 24);
            this.LopcbTenLop.TabIndex = 1;
            // 
            // LopcbMaLop
            // 
            this.LopcbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LopcbMaLop.FormattingEnabled = true;
            this.LopcbMaLop.Location = new System.Drawing.Point(59, 4);
            this.LopcbMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.LopcbMaLop.Name = "LopcbMaLop";
            this.LopcbMaLop.Size = new System.Drawing.Size(93, 24);
            this.LopcbMaLop.TabIndex = 1;
            this.LopcbMaLop.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(4, 37);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 16);
            this.label.TabIndex = 0;
            this.label.Text = "Tên lớp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã lớp";
            // 
            // SinhVien
            // 
            this.SinhVien.Controls.Add(this.SinhViencbKhoa);
            this.SinhVien.Controls.Add(this.SinhViencheckBox2);
            this.SinhVien.Controls.Add(this.SinhViencheckBox1);
            this.SinhVien.Controls.Add(this.label13);
            this.SinhVien.Controls.Add(this.SinhViencbMaLop);
            this.SinhVien.Controls.Add(this.label14);
            this.SinhVien.Controls.Add(this.SinhViencbMaSV);
            this.SinhVien.Controls.Add(this.label15);
            this.SinhVien.Location = new System.Drawing.Point(797, 127);
            this.SinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.SinhVien.Name = "SinhVien";
            this.SinhVien.Size = new System.Drawing.Size(268, 97);
            this.SinhVien.TabIndex = 6;
            // 
            // SinhViencbKhoa
            // 
            this.SinhViencbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SinhViencbKhoa.FormattingEnabled = true;
            this.SinhViencbKhoa.Location = new System.Drawing.Point(59, 68);
            this.SinhViencbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.SinhViencbKhoa.Name = "SinhViencbKhoa";
            this.SinhViencbKhoa.Size = new System.Drawing.Size(160, 24);
            this.SinhViencbKhoa.TabIndex = 1;
            this.SinhViencbKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedIndexChanged);
            // 
            // SinhViencheckBox2
            // 
            this.SinhViencheckBox2.AutoSize = true;
            this.SinhViencheckBox2.Location = new System.Drawing.Point(228, 71);
            this.SinhViencheckBox2.Margin = new System.Windows.Forms.Padding(4);
            this.SinhViencheckBox2.Name = "SinhViencheckBox2";
            this.SinhViencheckBox2.Size = new System.Drawing.Size(18, 17);
            this.SinhViencheckBox2.TabIndex = 2;
            this.SinhViencheckBox2.UseVisualStyleBackColor = true;
            this.SinhViencheckBox2.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // SinhViencheckBox1
            // 
            this.SinhViencheckBox1.AutoSize = true;
            this.SinhViencheckBox1.Location = new System.Drawing.Point(228, 39);
            this.SinhViencheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.SinhViencheckBox1.Name = "SinhViencheckBox1";
            this.SinhViencheckBox1.Size = new System.Drawing.Size(18, 17);
            this.SinhViencheckBox1.TabIndex = 2;
            this.SinhViencheckBox1.UseVisualStyleBackColor = true;
            this.SinhViencheckBox1.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 71);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Khóa";
            // 
            // SinhViencbMaLop
            // 
            this.SinhViencbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SinhViencbMaLop.FormattingEnabled = true;
            this.SinhViencbMaLop.Location = new System.Drawing.Point(59, 37);
            this.SinhViencbMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.SinhViencbMaLop.Name = "SinhViencbMaLop";
            this.SinhViencbMaLop.Size = new System.Drawing.Size(160, 24);
            this.SinhViencbMaLop.TabIndex = 1;
            this.SinhViencbMaLop.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 41);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mã lớp";
            // 
            // SinhViencbMaSV
            // 
            this.SinhViencbMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SinhViencbMaSV.Enabled = false;
            this.SinhViencbMaSV.FormattingEnabled = true;
            this.SinhViencbMaSV.Location = new System.Drawing.Point(59, 4);
            this.SinhViencbMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.SinhViencbMaSV.Name = "SinhViencbMaSV";
            this.SinhViencbMaSV.Size = new System.Drawing.Size(160, 24);
            this.SinhViencbMaSV.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 7);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mã SV";
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(331, 74);
            this.btnFill.Margin = new System.Windows.Forms.Padding(4);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 38);
            this.btnFill.TabIndex = 7;
            this.btnFill.Text = "Lọc";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 554);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.SinhVien);
            this.Controls.Add(this.Lop);
            this.Controls.Add(this.HocPhan);
            this.Controls.Add(this.GiangVien);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.GiangVien.ResumeLayout(false);
            this.GiangVien.PerformLayout();
            this.HocPhan.ResumeLayout(false);
            this.HocPhan.PerformLayout();
            this.Lop.ResumeLayout(false);
            this.Lop.PerformLayout();
            this.SinhVien.ResumeLayout(false);
            this.SinhVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Panel GiangVien;
        private System.Windows.Forms.ComboBox GiangViencbMaHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox GiangViencbMaLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GiangViencbMaGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel HocPhan;
        private System.Windows.Forms.ComboBox HocPhancbMaGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox HocPhancbSoTC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox HocPhancbMaHP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel Lop;
        private System.Windows.Forms.ComboBox LopcbSoSV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox LopcbMaLop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel SinhVien;
        private System.Windows.Forms.ComboBox SinhViencbKhoa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox SinhViencbMaLop;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox SinhViencbMaSV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox LopcbTenLop;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.CheckBox GiangViencheckBox2;
        private System.Windows.Forms.CheckBox GiangViencheckBox1;
        private System.Windows.Forms.CheckBox HocPhancheckBox1;
        private System.Windows.Forms.CheckBox HocPhancheckBox2;
        private System.Windows.Forms.CheckBox LopcheckBox1;
        private System.Windows.Forms.CheckBox SinhViencheckBox2;
        private System.Windows.Forms.CheckBox SinhViencheckBox1;
    }
}