﻿namespace VanPhap.View
{
    partial class TimChuBai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimChuBai));
            this.pnl_List = new System.Windows.Forms.Panel();
            this.lsv_timchubai = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_tim_kiem = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_xoa = new System.Windows.Forms.Button();
            this.lbl_DanhsachChuBai = new System.Windows.Forms.Label();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.txt_nguyenquan = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.lbl_nguyenquan = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.pnl_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.pnl_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_List
            // 
            this.pnl_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_List.Controls.Add(this.lsv_timchubai);
            this.pnl_List.Controls.Add(this.dgv_list);
            this.pnl_List.Controls.Add(this.btn_Update);
            this.pnl_List.Controls.Add(this.btn_Add);
            this.pnl_List.Controls.Add(this.btn_Delete);
            this.pnl_List.Location = new System.Drawing.Point(16, 338);
            this.pnl_List.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(1432, 328);
            this.pnl_List.TabIndex = 30;
            // 
            // lsv_timchubai
            // 
            this.lsv_timchubai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsv_timchubai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_timchubai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_timchubai.FullRowSelect = true;
            this.lsv_timchubai.GridLines = true;
            this.lsv_timchubai.HideSelection = false;
            this.lsv_timchubai.Location = new System.Drawing.Point(0, 0);
            this.lsv_timchubai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsv_timchubai.Name = "lsv_timchubai";
            this.lsv_timchubai.Size = new System.Drawing.Size(1428, 324);
            this.lsv_timchubai.TabIndex = 0;
            this.lsv_timchubai.TabStop = false;
            this.lsv_timchubai.UseCompatibleStateImageBehavior = false;
            this.lsv_timchubai.View = System.Windows.Forms.View.Details;
            this.lsv_timchubai.ItemActivate += new System.EventHandler(this.lsv_timchubai_ItemActivate_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Chủ bái";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pháp danh";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 328;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nguyên quán";
            this.columnHeader5.Width = 153;
            // 
            // dgv_list
            // 
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(-3, -116);
            this.dgv_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowHeadersWidth = 51;
            this.dgv_list.Size = new System.Drawing.Size(1433, 442);
            this.dgv_list.TabIndex = 1;
            this.dgv_list.TabStop = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(0, 0);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.TabStop = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(0, 0);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(0, -49);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(400, 73);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.TabStop = false;
            // 
            // btn_tim_kiem
            // 
            this.btn_tim_kiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tim_kiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tim_kiem.FlatAppearance.BorderSize = 0;
            this.btn_tim_kiem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tim_kiem.ImageIndex = 4;
            this.btn_tim_kiem.Location = new System.Drawing.Point(1237, 30);
            this.btn_tim_kiem.Margin = new System.Windows.Forms.Padding(0);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_tim_kiem.Size = new System.Drawing.Size(200, 49);
            this.btn_tim_kiem.TabIndex = 5;
            this.btn_tim_kiem.Text = "Tìm kiếm";
            this.btn_tim_kiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tim_kiem.UseVisualStyleBackColor = true;
            this.btn_tim_kiem.Click += new System.EventHandler(this.btn_tim_kiem_Click);
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
            this.imageList1.Images.SetKeyName(6, "reload_icon.png");
            this.imageList1.Images.SetKeyName(7, "Button-Refresh-icon.png");
            this.imageList1.Images.SetKeyName(8, "bin.png");
            this.imageList1.Images.SetKeyName(9, "5172950_business_eye_focus_internet_security_icon.png");
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.ImageIndex = 8;
            this.btn_xoa.Location = new System.Drawing.Point(1237, 87);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(0);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_xoa.Size = new System.Drawing.Size(200, 49);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_DanhsachChuBai
            // 
            this.lbl_DanhsachChuBai.AutoSize = true;
            this.lbl_DanhsachChuBai.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhsachChuBai.Location = new System.Drawing.Point(28, 292);
            this.lbl_DanhsachChuBai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DanhsachChuBai.Name = "lbl_DanhsachChuBai";
            this.lbl_DanhsachChuBai.Size = new System.Drawing.Size(286, 38);
            this.lbl_DanhsachChuBai.TabIndex = 301;
            this.lbl_DanhsachChuBai.Text = "Danh sách chủ bái";
            this.lbl_DanhsachChuBai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_Form
            // 
            this.pnl_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Form.Controls.Add(this.lbl_diachi);
            this.pnl_Form.Controls.Add(this.txt_nguyenquan);
            this.pnl_Form.Controls.Add(this.txt_diachi);
            this.pnl_Form.Controls.Add(this.lbl_nguyenquan);
            this.pnl_Form.Controls.Add(this.lbl_name);
            this.pnl_Form.Controls.Add(this.txt_name);
            this.pnl_Form.Controls.Add(this.lbl_NickName);
            this.pnl_Form.Controls.Add(this.txt_nickname);
            this.pnl_Form.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Form.Location = new System.Drawing.Point(15, 30);
            this.pnl_Form.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(1213, 251);
            this.pnl_Form.TabIndex = 302;
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachi.Location = new System.Drawing.Point(43, 190);
            this.lbl_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(100, 34);
            this.lbl_diachi.TabIndex = 0;
            this.lbl_diachi.Text = "Địa chỉ";
            this.lbl_diachi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nguyenquan
            // 
            this.txt_nguyenquan.BackColor = System.Drawing.Color.Silver;
            this.txt_nguyenquan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nguyenquan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nguyenquan.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nguyenquan.Location = new System.Drawing.Point(236, 128);
            this.txt_nguyenquan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nguyenquan.Name = "txt_nguyenquan";
            this.txt_nguyenquan.ReadOnly = true;
            this.txt_nguyenquan.Size = new System.Drawing.Size(927, 42);
            this.txt_nguyenquan.TabIndex = 3;
            this.txt_nguyenquan.TabStop = false;
            this.txt_nguyenquan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nguyenquan_KeyPress);
            // 
            // txt_diachi
            // 
            this.txt_diachi.BackColor = System.Drawing.Color.Silver;
            this.txt_diachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_diachi.Location = new System.Drawing.Point(236, 183);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.ReadOnly = true;
            this.txt_diachi.Size = new System.Drawing.Size(927, 42);
            this.txt_diachi.TabIndex = 4;
            this.txt_diachi.TabStop = false;
            this.txt_diachi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_diachi_KeyPress);
            // 
            // lbl_nguyenquan
            // 
            this.lbl_nguyenquan.AutoSize = true;
            this.lbl_nguyenquan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nguyenquan.Location = new System.Drawing.Point(43, 134);
            this.lbl_nguyenquan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nguyenquan.Name = "lbl_nguyenquan";
            this.lbl_nguyenquan.Size = new System.Drawing.Size(174, 34);
            this.lbl_nguyenquan.TabIndex = 5;
            this.lbl_nguyenquan.Text = "Nguyên quán";
            this.lbl_nguyenquan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(43, 25);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(108, 34);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Chủ bái";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(236, 18);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(927, 42);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.Location = new System.Drawing.Point(43, 79);
            this.lbl_NickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(141, 34);
            this.lbl_NickName.TabIndex = 7;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nickname
            // 
            this.txt_nickname.BackColor = System.Drawing.Color.Silver;
            this.txt_nickname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nickname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(236, 73);
            this.txt_nickname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.ReadOnly = true;
            this.txt_nickname.Size = new System.Drawing.Size(927, 42);
            this.txt_nickname.TabIndex = 2;
            this.txt_nickname.TabStop = false;
            this.txt_nickname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nickname_KeyPress);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.ImageIndex = 8;
            this.btn_cancel.Location = new System.Drawing.Point(1237, 231);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_cancel.Size = new System.Drawing.Size(200, 49);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Hủy bỏ";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reload.FlatAppearance.BorderSize = 0;
            this.btn_reload.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reload.ImageIndex = 8;
            this.btn_reload.Location = new System.Drawing.Point(1237, 149);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_reload.Size = new System.Drawing.Size(200, 49);
            this.btn_reload.TabIndex = 303;
            this.btn_reload.Text = "Làm mới";
            this.btn_reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // TimChuBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1460, 683);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.lbl_DanhsachChuBai);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_tim_kiem);
            this.Controls.Add(this.pnl_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TimChuBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimChuBai";
            this.Load += new System.EventHandler(this.TimChuBai_Load_1);
            this.Shown += new System.EventHandler(this.TimChuBai_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimChuBai_KeyPress);
            this.pnl_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.pnl_Form.ResumeLayout(false);
            this.pnl_Form.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_tim_kiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.ListView lsv_timchubai;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl_DanhsachChuBai;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.TextBox txt_nguyenquan;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label lbl_nguyenquan;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_reload;
    }
}