﻿namespace VanPhap.View
{
    partial class FormUpdateNguoiNhanCauAn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateNguoiNhanCauAn));
            this.lsv_danhsach_cauan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_id_so = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.lbl_tuoi = new System.Windows.Forms.Label();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.lbl_Sao = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.txt_sao = new System.Windows.Forms.TextBox();
            this.txt_idchubai = new System.Windows.Forms.TextBox();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.comboBox_gioitinh = new System.Windows.Forms.ComboBox();
            this.comboBox_NamSinh = new System.Windows.Forms.ComboBox();
            this.txt_gioitinh = new System.Windows.Forms.TextBox();
            this.txt_tuoiii = new System.Windows.Forms.TextBox();
            this.lbl_PhieuDiemThongTin = new System.Windows.Forms.Label();
            this.pnl_list = new System.Windows.Forms.Panel();
            this.lbl_danhsach = new System.Windows.Forms.Label();
            this.txt_update = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_Form.SuspendLayout();
            this.pnl_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsv_danhsach_cauan
            // 
            this.lsv_danhsach_cauan.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lsv_danhsach_cauan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_danhsach_cauan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9});
            this.lsv_danhsach_cauan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_danhsach_cauan.FullRowSelect = true;
            this.lsv_danhsach_cauan.GridLines = true;
            this.lsv_danhsach_cauan.HideSelection = false;
            this.lsv_danhsach_cauan.Location = new System.Drawing.Point(-3, -2);
            this.lsv_danhsach_cauan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsv_danhsach_cauan.Name = "lsv_danhsach_cauan";
            this.lsv_danhsach_cauan.Size = new System.Drawing.Size(1204, 367);
            this.lsv_danhsach_cauan.TabIndex = 23;
            this.lsv_danhsach_cauan.TabStop = false;
            this.lsv_danhsach_cauan.UseCompatibleStateImageBehavior = false;
            this.lsv_danhsach_cauan.View = System.Windows.Forms.View.Details;
            this.lsv_danhsach_cauan.ItemActivate += new System.EventHandler(this.lsv_danhsach_cauan_ItemActivate);
            this.lsv_danhsach_cauan.SelectedIndexChanged += new System.EventHandler(this.lsv_danhsach_cauan_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pháp danh";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Năm sinh";
            this.columnHeader4.Width = 143;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tuổi";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sao";
            this.columnHeader6.Width = 132;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "IDSo";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(1056, 185);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(12, 42);
            this.txt_id.TabIndex = 58;
            this.txt_id.TabStop = false;
            this.txt_id.Visible = false;
            // 
            // txt_id_so
            // 
            this.txt_id_so.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_so.Location = new System.Drawing.Point(1075, 185);
            this.txt_id_so.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id_so.Name = "txt_id_so";
            this.txt_id_so.Size = new System.Drawing.Size(12, 42);
            this.txt_id_so.TabIndex = 54;
            this.txt_id_so.TabStop = false;
            this.txt_id_so.Visible = false;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(172, 22);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(305, 42);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_nickname
            // 
            this.txt_nickname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(172, 75);
            this.txt_nickname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(305, 42);
            this.txt_nickname.TabIndex = 2;
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.Location = new System.Drawing.Point(12, 80);
            this.lbl_NickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(141, 34);
            this.lbl_NickName.TabIndex = 39;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.Location = new System.Drawing.Point(12, 134);
            this.lbl_Birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(135, 34);
            this.lbl_Birthday.TabIndex = 41;
            this.lbl_Birthday.Text = "Năm Sinh";
            this.lbl_Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_tuoi
            // 
            this.lbl_tuoi.AutoSize = true;
            this.lbl_tuoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tuoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_tuoi.Location = new System.Drawing.Point(533, 80);
            this.lbl_tuoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tuoi.Name = "lbl_tuoi";
            this.lbl_tuoi.Size = new System.Drawing.Size(70, 34);
            this.lbl_tuoi.TabIndex = 42;
            this.lbl_tuoi.Text = "Tuổi";
            this.lbl_tuoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.BackColor = System.Drawing.SystemColors.Control;
            this.txt_tuoi.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_tuoi.Enabled = false;
            this.txt_tuoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tuoi.Location = new System.Drawing.Point(671, 75);
            this.txt_tuoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.Size = new System.Drawing.Size(305, 42);
            this.txt_tuoi.TabIndex = 4;
            this.txt_tuoi.TabStop = false;
            // 
            // lbl_Sao
            // 
            this.lbl_Sao.AutoSize = true;
            this.lbl_Sao.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Sao.Location = new System.Drawing.Point(533, 134);
            this.lbl_Sao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sao.Name = "lbl_Sao";
            this.lbl_Sao.Size = new System.Drawing.Size(60, 34);
            this.lbl_Sao.TabIndex = 44;
            this.lbl_Sao.Text = "Sao";
            this.lbl_Sao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(12, 25);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(106, 34);
            this.lbl_name.TabIndex = 36;
            this.lbl_name.Text = "Họ Tên";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.Location = new System.Drawing.Point(533, 25);
            this.lbl_sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(121, 34);
            this.lbl_sex.TabIndex = 38;
            this.lbl_sex.Text = "Giới tính";
            // 
            // txt_sao
            // 
            this.txt_sao.BackColor = System.Drawing.SystemColors.Control;
            this.txt_sao.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_sao.Enabled = false;
            this.txt_sao.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sao.Location = new System.Drawing.Point(671, 129);
            this.txt_sao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_sao.Name = "txt_sao";
            this.txt_sao.Size = new System.Drawing.Size(305, 42);
            this.txt_sao.TabIndex = 5;
            this.txt_sao.TabStop = false;
            // 
            // txt_idchubai
            // 
            this.txt_idchubai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idchubai.Location = new System.Drawing.Point(1096, 185);
            this.txt_idchubai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idchubai.Name = "txt_idchubai";
            this.txt_idchubai.Size = new System.Drawing.Size(12, 42);
            this.txt_idchubai.TabIndex = 59;
            this.txt_idchubai.TabStop = false;
            this.txt_idchubai.Visible = false;
            // 
            // pnl_Form
            // 
            this.pnl_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Form.Controls.Add(this.comboBox_gioitinh);
            this.pnl_Form.Controls.Add(this.comboBox_NamSinh);
            this.pnl_Form.Controls.Add(this.lbl_name);
            this.pnl_Form.Controls.Add(this.lbl_NickName);
            this.pnl_Form.Controls.Add(this.txt_sao);
            this.pnl_Form.Controls.Add(this.lbl_Birthday);
            this.pnl_Form.Controls.Add(this.txt_nickname);
            this.pnl_Form.Controls.Add(this.lbl_sex);
            this.pnl_Form.Controls.Add(this.lbl_Sao);
            this.pnl_Form.Controls.Add(this.lbl_tuoi);
            this.pnl_Form.Controls.Add(this.txt_tuoi);
            this.pnl_Form.Controls.Add(this.txt_name);
            this.pnl_Form.Location = new System.Drawing.Point(23, 58);
            this.pnl_Form.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(1012, 205);
            this.pnl_Form.TabIndex = 65;
            // 
            // comboBox_gioitinh
            // 
            this.comboBox_gioitinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gioitinh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gioitinh.FormattingEnabled = true;
            this.comboBox_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_gioitinh.Location = new System.Drawing.Point(671, 22);
            this.comboBox_gioitinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_gioitinh.Name = "comboBox_gioitinh";
            this.comboBox_gioitinh.Size = new System.Drawing.Size(305, 42);
            this.comboBox_gioitinh.TabIndex = 4;
            this.comboBox_gioitinh.SelectedIndexChanged += new System.EventHandler(this.comboBox_gioitinh_SelectedIndexChanged_1);
            // 
            // comboBox_NamSinh
            // 
            this.comboBox_NamSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_NamSinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_NamSinh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_NamSinh.FormattingEnabled = true;
            this.comboBox_NamSinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_NamSinh.Location = new System.Drawing.Point(172, 129);
            this.comboBox_NamSinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_NamSinh.Name = "comboBox_NamSinh";
            this.comboBox_NamSinh.Size = new System.Drawing.Size(305, 42);
            this.comboBox_NamSinh.TabIndex = 3;
            this.comboBox_NamSinh.SelectedIndexChanged += new System.EventHandler(this.comboBox_NamSinh_SelectedIndexChanged_1);
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.BackColor = System.Drawing.SystemColors.Control;
            this.txt_gioitinh.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_gioitinh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioitinh.Location = new System.Drawing.Point(1136, 185);
            this.txt_gioitinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(12, 42);
            this.txt_gioitinh.TabIndex = 67;
            this.txt_gioitinh.TabStop = false;
            this.txt_gioitinh.Visible = false;
            this.txt_gioitinh.TextChanged += new System.EventHandler(this.txt_gioitinh_TextChanged);
            // 
            // txt_tuoiii
            // 
            this.txt_tuoiii.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tuoiii.Location = new System.Drawing.Point(1115, 185);
            this.txt_tuoiii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tuoiii.Name = "txt_tuoiii";
            this.txt_tuoiii.Size = new System.Drawing.Size(12, 42);
            this.txt_tuoiii.TabIndex = 64;
            this.txt_tuoiii.TabStop = false;
            this.txt_tuoiii.Visible = false;
            // 
            // lbl_PhieuDiemThongTin
            // 
            this.lbl_PhieuDiemThongTin.AutoSize = true;
            this.lbl_PhieuDiemThongTin.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhieuDiemThongTin.Location = new System.Drawing.Point(31, 12);
            this.lbl_PhieuDiemThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_PhieuDiemThongTin.Name = "lbl_PhieuDiemThongTin";
            this.lbl_PhieuDiemThongTin.Size = new System.Drawing.Size(422, 37);
            this.lbl_PhieuDiemThongTin.TabIndex = 102;
            this.lbl_PhieuDiemThongTin.Text = "Thông tin người nhận cầu an";
            this.lbl_PhieuDiemThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_list
            // 
            this.pnl_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_list.Controls.Add(this.lsv_danhsach_cauan);
            this.pnl_list.Location = new System.Drawing.Point(23, 322);
            this.pnl_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_list.Name = "pnl_list";
            this.pnl_list.Size = new System.Drawing.Size(1204, 367);
            this.pnl_list.TabIndex = 103;
            // 
            // lbl_danhsach
            // 
            this.lbl_danhsach.AutoSize = true;
            this.lbl_danhsach.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_danhsach.Location = new System.Drawing.Point(33, 274);
            this.lbl_danhsach.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_danhsach.Name = "lbl_danhsach";
            this.lbl_danhsach.Size = new System.Drawing.Size(163, 37);
            this.lbl_danhsach.TabIndex = 104;
            this.lbl_danhsach.Text = "Danh sách";
            this.lbl_danhsach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_update
            // 
            this.txt_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txt_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_update.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update.ImageIndex = 1;
            this.txt_update.Location = new System.Drawing.Point(1055, 57);
            this.txt_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_update.Name = "txt_update";
            this.txt_update.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.txt_update.Size = new System.Drawing.Size(173, 49);
            this.txt_update.TabIndex = 5;
            this.txt_update.Text = "Cập nhật";
            this.txt_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txt_update.UseVisualStyleBackColor = true;
            this.txt_update.Click += new System.EventHandler(this.txt_update_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "Button-Refresh-icon.png");
            this.imageList1.Images.SetKeyName(2, "delete-icon.png");
            this.imageList1.Images.SetKeyName(3, "Pencil-icon.png");
            this.imageList1.Images.SetKeyName(4, "search-icon.png");
            this.imageList1.Images.SetKeyName(5, "guide_icon.png");
            this.imageList1.Images.SetKeyName(6, "confirm_icon.png");
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ImageIndex = 1;
            this.btn_cancel.Location = new System.Drawing.Point(1056, 116);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_cancel.Size = new System.Drawing.Size(173, 49);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Hủy bỏ";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FormUpdateNguoiNhanCauAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1244, 709);
            this.Controls.Add(this.txt_gioitinh);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_danhsach);
            this.Controls.Add(this.pnl_list);
            this.Controls.Add(this.txt_tuoiii);
            this.Controls.Add(this.lbl_PhieuDiemThongTin);
            this.Controls.Add(this.txt_update);
            this.Controls.Add(this.txt_idchubai);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.txt_id_so);
            this.Controls.Add(this.txt_id);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUpdateNguoiNhanCauAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin";
            this.Load += new System.EventHandler(this.FormUpdateNguoiNhanCauAn_Load);
            this.Shown += new System.EventHandler(this.FormUpdateNguoiNhanCauAn_Shown);
            this.pnl_Form.ResumeLayout(false);
            this.pnl_Form.PerformLayout();
            this.pnl_list.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsv_danhsach_cauan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        protected System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_id_so;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Label lbl_tuoi;
        private System.Windows.Forms.TextBox txt_tuoi;
        private System.Windows.Forms.Label lbl_Sao;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.TextBox txt_sao;
        private System.Windows.Forms.TextBox txt_idchubai;
        private System.Windows.Forms.Button txt_update;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.Label lbl_PhieuDiemThongTin;
        private System.Windows.Forms.Panel pnl_list;
        private System.Windows.Forms.Label lbl_danhsach;
        private System.Windows.Forms.TextBox txt_tuoiii;
        private System.Windows.Forms.ComboBox comboBox_gioitinh;
        private System.Windows.Forms.ComboBox comboBox_NamSinh;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txt_gioitinh;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_cancel;
    }
}