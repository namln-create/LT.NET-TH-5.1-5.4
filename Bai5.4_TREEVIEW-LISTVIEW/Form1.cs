namespace Bai5._4_TREEVIEW_LISTVIEW
{
    public partial class frmQuanLyNhanSu : Form
    {

        public class Employee
        {
            public string MaNV { get; set; }
            public string HoTen { get; set; }
            public string ChucVu { get; set; }
            public string NgayVaoLam { get; set; }
            public string ThuocNhom { get; set; }
        }

        List<Employee> listEmployees = new List<Employee>();

        public frmQuanLyNhanSu()
        {
            InitializeComponent();
        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmQuanLyNhanSu_Load(object sender, EventArgs e)
        {
            TreeNode rootNode = new TreeNode("Công ty TNHH ABC");

            TreeNode nodeIT = new TreeNode("Phòng IT");
            nodeIT.Nodes.Add("Nhóm Dev");
            nodeIT.Nodes.Add("Nhóm Test");

            TreeNode nodeKeToan = new TreeNode("Phòng Kế toán");
            nodeKeToan.Nodes.Add("Nhóm Thu chi");

            rootNode.Nodes.Add(nodeIT);
            rootNode.Nodes.Add(nodeKeToan);

            tvDepartments.Nodes.Add(rootNode);
            tvDepartments.ExpandAll();
            lsvEmployees.Columns.Add("Mã NV", 80);
            lsvEmployees.Columns.Add("Họ Tên", 150);
            lsvEmployees.Columns.Add("Chức vụ", 100);
            lsvEmployees.Columns.Add("Ngày vào làm", 100);

            listEmployees.Add(new Employee { MaNV = "NV01", HoTen = "Lê Văn A", ChucVu = "Trưởng nhóm", NgayVaoLam = "01/01/2020", ThuocNhom = "Nhóm Dev" });
            listEmployees.Add(new Employee { MaNV = "NV02", HoTen = "Nguyễn Thị B", ChucVu = "Lập trình viên", NgayVaoLam = "15/05/2022", ThuocNhom = "Nhóm Dev" });
            listEmployees.Add(new Employee { MaNV = "NV03", HoTen = "Trần Văn C", ChucVu = "Tester", NgayVaoLam = "10/08/2023", ThuocNhom = "Nhóm Test" });
            listEmployees.Add(new Employee { MaNV = "NV04", HoTen = "Phạm Thị D", ChucVu = "Kế toán viên", NgayVaoLam = "20/02/2021", ThuocNhom = "Nhóm Thu chi" });

            cboViewMode.SelectedIndex = 0;
        }

        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lsvEmployees.Items.Clear();
            string selectedNodeText = e.Node.Text;

            foreach (var emp in listEmployees)
            {
                if (emp.ThuocNhom == selectedNodeText)
                {
                    ListViewItem item = new ListViewItem(emp.MaNV);
                    item.SubItems.Add(emp.HoTen);
                    item.SubItems.Add(emp.ChucVu);
                    item.SubItems.Add(emp.NgayVaoLam);


                    lsvEmployees.Items.Add(item);
                }
            }
        }

        private void lsvEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cboViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboViewMode.SelectedItem == null) return;

            string selectedView = cboViewMode.SelectedItem.ToString();
            switch (selectedView)
            {
                case "Details": lsvEmployees.View = View.Details; break;
                case "LargeIcon": lsvEmployees.View = View.LargeIcon; break;
                case "SmallIcon": lsvEmployees.View = View.SmallIcon; break;
                case "List": lsvEmployees.View = View.List; break;
                case "Tile": lsvEmployees.View = View.Tile; break;
            }
        }
    }
}
