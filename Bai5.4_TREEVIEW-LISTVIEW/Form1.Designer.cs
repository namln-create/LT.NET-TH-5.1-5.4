namespace Bai5._4_TREEVIEW_LISTVIEW
{
    partial class frmQuanLyNhanSu
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
            components = new System.ComponentModel.Container();
            cboViewMode = new ComboBox();
            splitContainer1 = new SplitContainer();
            tvDepartments = new TreeView();
            imgSmall = new ImageList(components);
            lsvEmployees = new ListView();
            imgLarge = new ImageList(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // cboViewMode
            // 
            cboViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboViewMode.FormattingEnabled = true;
            cboViewMode.Items.AddRange(new object[] { "Details", "LargeIcon", "SmallIcon", "List", "Tile" });
            cboViewMode.Location = new Point(137, 18);
            cboViewMode.Name = "cboViewMode";
            cboViewMode.Size = new Size(613, 28);
            cboViewMode.TabIndex = 0;
            cboViewMode.SelectedIndexChanged += cboViewMode_SelectedIndexChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 52);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvDepartments);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lsvEmployees);
            splitContainer1.Size = new Size(782, 402);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 1;
            // 
            // tvDepartments
            // 
            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.ImageIndex = 0;
            tvDepartments.ImageList = imgSmall;
            tvDepartments.Location = new Point(0, 0);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.SelectedImageIndex = 0;
            tvDepartments.Size = new Size(260, 402);
            tvDepartments.TabIndex = 0;
            tvDepartments.AfterSelect += tvDepartments_AfterSelect;
            // 
            // imgSmall
            // 
            imgSmall.ColorDepth = ColorDepth.Depth32Bit;
            imgSmall.ImageSize = new Size(16, 16);
            imgSmall.TransparentColor = Color.Transparent;
            // 
            // lsvEmployees
            // 
            lsvEmployees.Dock = DockStyle.Fill;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.LargeImageList = imgLarge;
            lsvEmployees.Location = new Point(0, 0);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(518, 402);
            lsvEmployees.SmallImageList = imgSmall;
            lsvEmployees.TabIndex = 0;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            lsvEmployees.SelectedIndexChanged += lsvEmployees_SelectedIndexChanged;
            // 
            // imgLarge
            // 
            imgLarge.ColorDepth = ColorDepth.Depth32Bit;
            imgLarge.ImageSize = new Size(32, 32);
            imgLarge.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 2;
            label1.Text = "Chế độ xem:";
            // 
            // frmQuanLyNhanSu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(label1);
            Controls.Add(cboViewMode);
            Controls.Add(splitContainer1);
            Name = "frmQuanLyNhanSu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Sự";
            Load += frmQuanLyNhanSu_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboViewMode;
        private SplitContainer splitContainer1;
        private Label label1;
        private TreeView tvDepartments;
        private ListView lsvEmployees;
        private ImageList imgSmall;
        private ImageList imgLarge;
    }
}
