namespace Bai5._3_DATAGRIDVIEW_CƠ_BẢN
{
    public partial class frmQuanLySanPham : Form
    {
        public class Product
        {
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public double UnitPrice { get; set; }
            public int Quantity { get; set; }
            public string Category { get; set; }
        }


        private List<Product> listProducts = new List<Product>();
        private BindingSource bindingSource = new BindingSource();

        public frmQuanLySanPham()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {

            cboCategory.Items.AddRange(new string[] { "Điện thoại", "Máy tính bảng", "Phụ kiện", "Laptop" });
            cboCategory.SelectedIndex = 0;

            bindingSource.DataSource = listProducts;
            dgvProducts.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng cơ bản
            if (string.IsNullOrWhiteSpace(txtProductId.Text) || string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ Mã và Tên sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng Product mới từ giao diện
            Product newProduct = new Product
            {
                ProductId = txtProductId.Text,
                ProductName = txtProductName.Text,
                UnitPrice = Convert.ToDouble(txtUnitPrice.Text),
                Quantity = Convert.ToInt32(txtQuantity.Text),
                Category = cboCategory.SelectedItem.ToString()
            };

            // Thêm vào danh sách và làm mới DataGridView
            listProducts.Add(newProduct);
            bindingSource.ResetBindings(false);

            // Xóa rỗng các ô nhập liệu
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Text = "0";
            txtQuantity.Text = "0";
            txtProductId.Focus();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listProducts.Count)
            {
                // Lấy đối tượng Product tại dòng được click
                Product selectedProduct = listProducts[e.RowIndex];

                txtProductId.Text = selectedProduct.ProductId;
                txtProductName.Text = selectedProduct.ProductName;
                txtUnitPrice.Text = selectedProduct.UnitPrice.ToString();
                txtQuantity.Text = selectedProduct.Quantity.ToString();
                cboCategory.SelectedItem = selectedProduct.Category;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.Index >= 0)
                {
                    int index = dgvProducts.CurrentRow.Index;

                    // Hiển thị MessageBox xác nhận
                    DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {listProducts[index].ProductName}?",
                                                          "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        listProducts.RemoveAt(index);
                        bindingSource.ResetBindings(false); // Cập nhật lại giao diện

                        // Xóa rỗng Form
                        txtProductId.Clear();
                        txtProductName.Clear();
                        txtUnitPrice.Text = "0";
                        txtQuantity.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

