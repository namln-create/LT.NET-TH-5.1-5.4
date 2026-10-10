namespace Bai5._2_LISTBOX_COMBOBOX
{
    partial class frmTinhTienDichVu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboCategory = new ComboBox();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            txtTongTien = new TextBox();
            txtChietKhau = new TextBox();
            txtThanhTien = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(149, 24);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(151, 28);
            cboCategory.TabIndex = 0;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.Location = new Point(38, 118);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(206, 104);
            lstAvailableServices.TabIndex = 1;
            lstAvailableServices.SelectedIndexChanged += lstAvailableServices_SelectedIndexChanged;
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.Location = new Point(408, 118);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(206, 104);
            lstSelectedServices.TabIndex = 2;
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.Location = new Point(281, 118);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 3;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(281, 153);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(281, 193);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "<<";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(489, 245);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(125, 27);
            txtTongTien.TabIndex = 6;
            txtTongTien.Text = "0";
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // txtChietKhau
            // 
            txtChietKhau.Location = new Point(489, 278);
            txtChietKhau.Name = "txtChietKhau";
            txtChietKhau.Size = new Size(125, 27);
            txtChietKhau.TabIndex = 7;
            txtChietKhau.Text = "0";
            txtChietKhau.TextAlign = HorizontalAlignment.Right;
            txtChietKhau.TextChanged += txtChietKhau_TextChanged;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(489, 311);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(125, 27);
            txtThanhTien.TabIndex = 8;
            txtThanhTien.Text = "0";
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 9;
            label1.Text = "Loại dịch vụ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(38, 76);
            label2.Name = "label2";
            label2.Size = new Size(173, 28);
            label2.TabIndex = 10;
            label2.Text = "Danh sách dịch vụ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(408, 76);
            label3.Name = "label3";
            label3.Size = new Size(156, 28);
            label3.TabIndex = 11;
            label3.Text = "Dịch vụ đã chọn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 252);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 12;
            label4.Text = "Tổng tiền chưa giảm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 285);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 13;
            label5.Text = "Tỷ lệ chiết khấu (%):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(334, 318);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 14;
            label6.Text = "Thành tiền:";
            // 
            // frmTinhTienDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 355);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtThanhTien);
            Controls.Add(txtChietKhau);
            Controls.Add(txtTongTien);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnSelect);
            Controls.Add(lstSelectedServices);
            Controls.Add(lstAvailableServices);
            Controls.Add(cboCategory);
            Name = "frmTinhTienDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính Tiền Dịch Vụ";
            Load += frmTinhTienDichVu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCategory;
        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClear;
        private TextBox txtTongTien;
        private TextBox txtChietKhau;
        private TextBox txtThanhTien;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
