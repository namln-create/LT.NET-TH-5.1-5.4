namespace Bai5._2_LISTBOX_COMBOBOX
{
    public partial class frmTinhTienDichVu : Form
    {

        public class DichVu
        {
            public string Ten { get; set; }
            public double Gia { get; set; }
            public override string ToString()
            {
                return $"{Ten} - {Gia:N0} VNĐ";
            }
        }
        public frmTinhTienDichVu()
        {
            InitializeComponent();
        }

        private void frmTinhTienDichVu_Load(object sender, EventArgs e)
        {
            cboCategory.Items.AddRange(new string[] { "Khám bệnh", "Xét nghiệm", "Chụp X-Quang", "Vắc-xin" });
            cboCategory.SelectedIndex = 0;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();
            string category = cboCategory.SelectedItem.ToString();

            if (category == "Khám bệnh")
            {
                lstAvailableServices.Items.Add(new DichVu { Ten = "Khám tổng quát", Gia = 200000 });
                lstAvailableServices.Items.Add(new DichVu { Ten = "Khám chuyên khoa", Gia = 300000 });
            }
            else if (category == "Xét nghiệm")
            {
                lstAvailableServices.Items.Add(new DichVu { Ten = "Xét nghiệm máu", Gia = 150000 });
                lstAvailableServices.Items.Add(new DichVu { Ten = "Xét nghiệm nước tiểu", Gia = 100000 });
            }
            else if (category == "Chụp X-Quang")
            {
                lstAvailableServices.Items.Add(new DichVu { Ten = "X-Quang Phổi", Gia = 250000 });
                lstAvailableServices.Items.Add(new DichVu { Ten = "X-Quang Xương", Gia = 350000 });
            }
            else if (category == "Vắc-xin")
            {
                lstAvailableServices.Items.Add(new DichVu { Ten = "Vắc-xin Cúm", Gia = 400000 });
                lstAvailableServices.Items.Add(new DichVu { Ten = "Vắc-xin Viêm gan B", Gia = 500000 });
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Add(lstAvailableServices.SelectedItem);
                TinhTongTien();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Remove(lstSelectedServices.SelectedItem);
                TinhTongTien();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            TinhTongTien();
        }

        private void lstAvailableServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void TinhTongTien()
        {
            double tongTien = 0;

            foreach (DichVu item in lstSelectedServices.Items)
            {
                tongTien += item.Gia;
            }


            double chietKhau = 0;
            double.TryParse(txtChietKhau.Text, out chietKhau);
            if (chietKhau < 0)
            {
                chietKhau = 0;
                txtChietKhau.Text = "0"; 
                MessageBox.Show("Chiết khấu không được là số âm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (chietKhau > 100)
            {
                chietKhau = 100;
                txtChietKhau.Text = "100"; 
                MessageBox.Show("Chiết khấu không được vượt quá 100%!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            double thanhTien = tongTien - (tongTien * chietKhau / 100);

            txtTongTien.Text = tongTien.ToString("N0");
            txtThanhTien.Text = thanhTien.ToString("N0");
        }
    }
}