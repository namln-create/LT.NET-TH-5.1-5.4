namespace Bai5._3_DATAGRIDVIEW_CƠ_BẢN
{
    partial class frmQuanLySanPham
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboCategory = new ComboBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductId = new TextBox();
            txtTimKiem = new TextBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            dgvProducts = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductId);
            groupBox1.Location = new Point(12, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 207);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 9;
            label5.Text = "Danh mục:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 166);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 119);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 7;
            label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 6;
            label2.Text = "Tên SP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã SP:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(137, 199);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(151, 28);
            cboCategory.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(137, 159);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(151, 27);
            txtQuantity.TabIndex = 3;
            txtQuantity.Text = "0";
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(137, 112);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(151, 27);
            txtUnitPrice.TabIndex = 2;
            txtUnitPrice.Text = "0";
            txtUnitPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(137, 72);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(151, 27);
            txtProductName.TabIndex = 1;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(137, 25);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(151, 27);
            txtProductId.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(19, 129);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(212, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(367, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 241);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 92);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 6;
            label6.Text = "Tìm theo tên:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(259, 129);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(163, 35);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button3_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(312, 35);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(19, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 248);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(776, 188);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // frmQuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducts);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmQuanLySanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sản Phẩm";
            Load += frmQuanLySanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboCategory;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private TextBox txtTimKiem;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label6;
        private DataGridView dgvProducts;
    }
}
