namespace XepLichThi
{
    partial class frmFormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribon = new DevComponents.DotNetBar.RibbonControl();
            this.rp2 = new DevComponents.DotNetBar.RibbonPanel();
            this.rb3 = new DevComponents.DotNetBar.RibbonBar();
            this.btnLoadFile = new DevComponents.DotNetBar.ButtonItem();
            this.btnChonNhom = new DevComponents.DotNetBar.ButtonItem();
            this.btnChonPhong = new DevComponents.DotNetBar.ButtonItem();
            this.btnXepLichThi = new DevComponents.DotNetBar.ButtonItem();
            this.btnXuatExcel = new DevComponents.DotNetBar.ButtonItem();
            this.btnInKetQua = new DevComponents.DotNetBar.ButtonItem();
            this.rp3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonCaiDat = new DevComponents.DotNetBar.RibbonBar();
            this.btnQlPhong = new DevComponents.DotNetBar.ButtonItem();
            this.btnQlNhom = new DevComponents.DotNetBar.ButtonItem();
            this.btnQlGioThi = new DevComponents.DotNetBar.ButtonItem();
            this.rp4 = new DevComponents.DotNetBar.RibbonPanel();
            this.rb5 = new DevComponents.DotNetBar.RibbonBar();
            this.btnHuongDanSuDung = new DevComponents.DotNetBar.ButtonItem();
            this.btnLuuBieuMau = new DevComponents.DotNetBar.ButtonItem();
            this.rtChucNang = new DevComponents.DotNetBar.RibbonTabItem();
            this.rtGiaoDien = new DevComponents.DotNetBar.RibbonTabItem();
            this.rtHelp = new DevComponents.DotNetBar.RibbonTabItem();
            this.lblTime = new DevComponents.DotNetBar.LabelItem();
            this.btnExpand = new DevComponents.DotNetBar.ButtonItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.op = new System.Windows.Forms.OpenFileDialog();
            this.grwDanhSach = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ribon.SuspendLayout();
            this.rp2.SuspendLayout();
            this.rp3.SuspendLayout();
            this.rp4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grwDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // ribon
            // 
            // 
            // 
            // 
            this.ribon.BackgroundStyle.Class = "";
            this.ribon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribon.CaptionVisible = true;
            this.ribon.Controls.Add(this.rp2);
            this.ribon.Controls.Add(this.rp3);
            this.ribon.Controls.Add(this.rp4);
            this.ribon.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribon.ForeColor = System.Drawing.Color.Red;
            this.ribon.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rtChucNang,
            this.rtGiaoDien,
            this.rtHelp,
            this.lblTime,
            this.btnExpand});
            this.ribon.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribon.Location = new System.Drawing.Point(5, 1);
            this.ribon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribon.Name = "ribon";
            this.ribon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribon.Size = new System.Drawing.Size(1278, 220);
            this.ribon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribon.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribon.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribon.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribon.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribon.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribon.SystemText.QatDialogAddButton = "&Add >>";
            this.ribon.SystemText.QatDialogCancelButton = "Cancel";
            this.ribon.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribon.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribon.SystemText.QatDialogOkButton = "OK";
            this.ribon.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribon.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribon.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribon.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribon.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribon.TabGroupHeight = 14;
            this.ribon.TabIndex = 0;
            this.ribon.Text = "ribbonControl1";
            this.ribon.TitleText = "PHẦN MỀM XẾP LỊCH THI CHO CÁC KHOA TRƯỜNG ĐẠI HỌC ĐÀ LẠT";
            // 
            // rp2
            // 
            this.rp2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rp2.Controls.Add(this.rb3);
            this.rp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rp2.Location = new System.Drawing.Point(0, 63);
            this.rp2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rp2.Name = "rp2";
            this.rp2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.rp2.Size = new System.Drawing.Size(1278, 155);
            // 
            // 
            // 
            this.rp2.Style.Class = "";
            this.rp2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rp2.StyleMouseDown.Class = "";
            this.rp2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rp2.StyleMouseOver.Class = "";
            this.rp2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rp2.TabIndex = 2;
            // 
            // rb3
            // 
            this.rb3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rb3.BackgroundMouseOverStyle.Class = "";
            this.rb3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rb3.BackgroundStyle.Class = "";
            this.rb3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rb3.ContainerControlProcessDialogKey = true;
            this.rb3.Dock = System.Windows.Forms.DockStyle.Left;
            this.rb3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLoadFile,
            this.btnChonNhom,
            this.btnChonPhong,
            this.btnXepLichThi,
            this.btnXuatExcel,
            this.btnInKetQua});
            this.rb3.Location = new System.Drawing.Point(4, 0);
            this.rb3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(1015, 151);
            this.rb3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rb3.TabIndex = 4;
            // 
            // 
            // 
            this.rb3.TitleStyle.Class = "";
            this.rb3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rb3.TitleStyleMouseOver.Class = "";
            this.rb3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnLoadFile.FixedSize = new System.Drawing.Size(120, 100);
            this.btnLoadFile.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadFile.Image")));
            this.btnLoadFile.ImageFixedSize = new System.Drawing.Size(60, 50);
            this.btnLoadFile.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.SubItemsExpandWidth = 14;
            this.btnLoadFile.Text = "Load Tập Tin";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnChonNhom
            // 
            this.btnChonNhom.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnChonNhom.Enabled = false;
            this.btnChonNhom.FixedSize = new System.Drawing.Size(120, 100);
            this.btnChonNhom.Image = global::XepLichThi.Properties.Resources.User_Group_icon;
            this.btnChonNhom.ImageFixedSize = new System.Drawing.Size(60, 50);
            this.btnChonNhom.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnChonNhom.Name = "btnChonNhom";
            this.btnChonNhom.SubItemsExpandWidth = 14;
            this.btnChonNhom.Text = "Chọn Nhóm";
            this.btnChonNhom.Click += new System.EventHandler(this.btnChonNhom_Click);
            // 
            // btnChonPhong
            // 
            this.btnChonPhong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnChonPhong.Enabled = false;
            this.btnChonPhong.FixedSize = new System.Drawing.Size(120, 100);
            this.btnChonPhong.Image = global::XepLichThi.Properties.Resources._1348675936_Home;
            this.btnChonPhong.ImageFixedSize = new System.Drawing.Size(60, 50);
            this.btnChonPhong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnChonPhong.Name = "btnChonPhong";
            this.btnChonPhong.SubItemsExpandWidth = 14;
            this.btnChonPhong.Text = "Chọn Phòng";
            this.btnChonPhong.Click += new System.EventHandler(this.btnChonPhong_Click);
            // 
            // btnXepLichThi
            // 
            this.btnXepLichThi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnXepLichThi.Enabled = false;
            this.btnXepLichThi.FixedSize = new System.Drawing.Size(120, 100);
            this.btnXepLichThi.Image = ((System.Drawing.Image)(resources.GetObject("btnXepLichThi.Image")));
            this.btnXepLichThi.ImageFixedSize = new System.Drawing.Size(60, 50);
            this.btnXepLichThi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXepLichThi.Name = "btnXepLichThi";
            this.btnXepLichThi.SubItemsExpandWidth = 14;
            this.btnXepLichThi.Text = "Xếp Lịch";
            this.btnXepLichThi.Click += new System.EventHandler(this.btnXepLichThi_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnXuatExcel.Enabled = false;
            this.btnXuatExcel.FixedSize = new System.Drawing.Size(120, 100);
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.ImageFixedSize = new System.Drawing.Size(60, 50);
            this.btnXuatExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.SubItemsExpandWidth = 14;
            this.btnXuatExcel.Text = "Lưu Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnInKetQua
            // 
            this.btnInKetQua.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnInKetQua.Enabled = false;
            this.btnInKetQua.FixedSize = new System.Drawing.Size(120, 100);
            this.btnInKetQua.Image = ((System.Drawing.Image)(resources.GetObject("btnInKetQua.Image")));
            this.btnInKetQua.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnInKetQua.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInKetQua.Name = "btnInKetQua";
            this.btnInKetQua.SubItemsExpandWidth = 14;
            this.btnInKetQua.Text = "In Kết Quả";
            this.btnInKetQua.Click += new System.EventHandler(this.btnInKetQua_Click);
            // 
            // rp3
            // 
            this.rp3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rp3.Controls.Add(this.ribbonCaiDat);
            this.rp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rp3.Location = new System.Drawing.Point(0, 73);
            this.rp3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rp3.Name = "rp3";
            this.rp3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.rp3.Size = new System.Drawing.Size(1299, 145);
            // 
            // 
            // 
            this.rp3.Style.Class = "";
            this.rp3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rp3.StyleMouseDown.Class = "";
            this.rp3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rp3.StyleMouseOver.Class = "";
            this.rp3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rp3.TabIndex = 3;
            this.rp3.Visible = false;
            // 
            // ribbonCaiDat
            // 
            this.ribbonCaiDat.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonCaiDat.BackgroundMouseOverStyle.Class = "";
            this.ribbonCaiDat.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonCaiDat.BackgroundStyle.Class = "";
            this.ribbonCaiDat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonCaiDat.ContainerControlProcessDialogKey = true;
            this.ribbonCaiDat.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonCaiDat.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQlPhong,
            this.btnQlNhom,
            this.btnQlGioThi});
            this.ribbonCaiDat.Location = new System.Drawing.Point(4, 0);
            this.ribbonCaiDat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonCaiDat.Name = "ribbonCaiDat";
            this.ribbonCaiDat.Size = new System.Drawing.Size(535, 141);
            this.ribbonCaiDat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonCaiDat.TabIndex = 5;
            this.ribbonCaiDat.Text = "Quản Lý";
            // 
            // 
            // 
            this.ribbonCaiDat.TitleStyle.Class = "";
            this.ribbonCaiDat.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonCaiDat.TitleStyleMouseOver.Class = "";
            this.ribbonCaiDat.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnQlPhong
            // 
            this.btnQlPhong.FixedSize = new System.Drawing.Size(120, 100);
            this.btnQlPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnQlPhong.Image")));
            this.btnQlPhong.ImageFixedSize = new System.Drawing.Size(70, 50);
            this.btnQlPhong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQlPhong.Name = "btnQlPhong";
            this.btnQlPhong.SubItemsExpandWidth = 14;
            this.btnQlPhong.Text = "Quản Lý Phòng";
            this.btnQlPhong.Click += new System.EventHandler(this.btnQlPhong_Click);
            // 
            // btnQlNhom
            // 
            this.btnQlNhom.FixedSize = new System.Drawing.Size(140, 100);
            this.btnQlNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnQlNhom.Image")));
            this.btnQlNhom.ImageFixedSize = new System.Drawing.Size(70, 50);
            this.btnQlNhom.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQlNhom.Name = "btnQlNhom";
            this.btnQlNhom.SubItemsExpandWidth = 14;
            this.btnQlNhom.Text = "Quản Lý Bậc Học";
            this.btnQlNhom.Click += new System.EventHandler(this.btnQlNhom_Click);
            // 
            // btnQlGioThi
            // 
            this.btnQlGioThi.FixedSize = new System.Drawing.Size(120, 100);
            this.btnQlGioThi.Image = ((System.Drawing.Image)(resources.GetObject("btnQlGioThi.Image")));
            this.btnQlGioThi.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnQlGioThi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQlGioThi.Name = "btnQlGioThi";
            this.btnQlGioThi.SubItemsExpandWidth = 14;
            this.btnQlGioThi.Text = "Quản Lý Giờ Thi";
            this.btnQlGioThi.Click += new System.EventHandler(this.btnQlGioThi_Click);
            // 
            // rp4
            // 
            this.rp4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rp4.Controls.Add(this.rb5);
            this.rp4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rp4.Location = new System.Drawing.Point(0, 73);
            this.rp4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rp4.Name = "rp4";
            this.rp4.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.rp4.Size = new System.Drawing.Size(1299, 145);
            // 
            // 
            // 
            this.rp4.Style.Class = "";
            this.rp4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rp4.StyleMouseDown.Class = "";
            this.rp4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rp4.StyleMouseOver.Class = "";
            this.rp4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rp4.TabIndex = 4;
            this.rp4.Visible = false;
            // 
            // rb5
            // 
            this.rb5.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rb5.BackgroundMouseOverStyle.Class = "";
            this.rb5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rb5.BackgroundStyle.Class = "";
            this.rb5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rb5.ContainerControlProcessDialogKey = true;
            this.rb5.Dock = System.Windows.Forms.DockStyle.Left;
            this.rb5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHuongDanSuDung,
            this.btnLuuBieuMau});
            this.rb5.Location = new System.Drawing.Point(4, 0);
            this.rb5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(380, 141);
            this.rb5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rb5.TabIndex = 3;
            this.rb5.Text = "Sản Phẩm";
            // 
            // 
            // 
            this.rb5.TitleStyle.Class = "";
            this.rb5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rb5.TitleStyleMouseOver.Class = "";
            this.rb5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnHuongDanSuDung
            // 
            this.btnHuongDanSuDung.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHuongDanSuDung.FixedSize = new System.Drawing.Size(145, 100);
            this.btnHuongDanSuDung.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongDanSuDung.Image")));
            this.btnHuongDanSuDung.ImageFixedSize = new System.Drawing.Size(60, 50);
            this.btnHuongDanSuDung.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHuongDanSuDung.Name = "btnHuongDanSuDung";
            this.btnHuongDanSuDung.SubItemsExpandWidth = 14;
            this.btnHuongDanSuDung.Text = "Hướng Dẫn";
            this.btnHuongDanSuDung.Click += new System.EventHandler(this.btnHuongDanSuDung_Click);
            // 
            // btnLuuBieuMau
            // 
            this.btnLuuBieuMau.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnLuuBieuMau.FixedSize = new System.Drawing.Size(120, 100);
            this.btnLuuBieuMau.Image = global::XepLichThi.Properties.Resources.Excel_icon;
            this.btnLuuBieuMau.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnLuuBieuMau.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLuuBieuMau.Name = "btnLuuBieuMau";
            this.btnLuuBieuMau.SubItemsExpandWidth = 14;
            this.btnLuuBieuMau.Text = "Lưu Biểu Mẫu";
            this.btnLuuBieuMau.Click += new System.EventHandler(this.btnLuuBieuMau_Click);
            // 
            // rtChucNang
            // 
            this.rtChucNang.Checked = true;
            this.rtChucNang.Name = "rtChucNang";
            this.rtChucNang.Panel = this.rp2;
            this.rtChucNang.Text = "Chức năng";
            // 
            // rtGiaoDien
            // 
            this.rtGiaoDien.Name = "rtGiaoDien";
            this.rtGiaoDien.Panel = this.rp3;
            this.rtGiaoDien.Text = "Cài đặt";
            this.rtGiaoDien.DoubleClick += new System.EventHandler(this.ribbonTabItem_DClick);
            // 
            // rtHelp
            // 
            this.rtHelp.Name = "rtHelp";
            this.rtHelp.Panel = this.rp4;
            this.rtHelp.Text = "Trợ giúp";
            this.rtHelp.DoubleClick += new System.EventHandler(this.ribbonTabItem_DClick);
            // 
            // lblTime
            // 
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.lblTime.Name = "lblTime";
            this.lblTime.PaddingBottom = 5;
            this.lblTime.SingleLineColor = System.Drawing.Color.Transparent;
            this.lblTime.Stretch = true;
            this.lblTime.Text = "?";
            this.lblTime.Width = 400;
            // 
            // btnExpand
            // 
            this.btnExpand.ForeColor = System.Drawing.Color.Red;
            this.btnExpand.Image = ((System.Drawing.Image)(resources.GetObject("btnExpand.Image")));
            this.btnExpand.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExpand.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Excel 97 - 2003 WorkBook|*.xls|Excel WorkBook|*.xlsx";
            // 
            // op
            // 
            this.op.FileName = "openFileDialog1";
            this.op.Filter = "Excel Worksheet|*.xls;*.xlsx";
            // 
            // grwDanhSach
            // 
            this.grwDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.grwDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grwDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grwDanhSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.grwDanhSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grwDanhSach.Location = new System.Drawing.Point(5, 223);
            this.grwDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.grwDanhSach.Name = "grwDanhSach";
            this.grwDanhSach.ReadOnly = true;
            this.grwDanhSach.RowHeadersWidth = 51;
            this.grwDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grwDanhSach.Size = new System.Drawing.Size(1278, 49);
            this.grwDanhSach.TabIndex = 3;
            this.grwDanhSach.Visible = false;
            this.grwDanhSach.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grwDanhSach_CellFormatting);
            this.grwDanhSach.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grwDanhSach_CellMouseMove);
            // 
            // frmFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1288, 677);
            this.Controls.Add(this.grwDanhSach);
            this.Controls.Add(this.ribon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1127, 605);
            this.Name = "frmFormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXepLichThi_Load);
            this.SizeChanged += new System.EventHandler(this.frmFormMain_SizeChanged);
            this.ribon.ResumeLayout(false);
            this.ribon.PerformLayout();
            this.rp2.ResumeLayout(false);
            this.rp3.ResumeLayout(false);
            this.rp4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grwDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private DevComponents.DotNetBar.RibbonControl ribon;
        private DevComponents.DotNetBar.RibbonPanel rp2;
        private DevComponents.DotNetBar.RibbonPanel rp4;
        private DevComponents.DotNetBar.RibbonTabItem rtChucNang;
        private DevComponents.DotNetBar.RibbonTabItem rtGiaoDien;
        private DevComponents.DotNetBar.RibbonTabItem rtHelp;
        private DevComponents.DotNetBar.RibbonPanel rp3;
        private DevComponents.DotNetBar.ButtonItem btnExpand;
        private DevComponents.DotNetBar.LabelItem lblTime;
        private DevComponents.DotNetBar.RibbonBar rb5;
        private DevComponents.DotNetBar.ButtonItem btnHuongDanSuDung;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private DevComponents.DotNetBar.RibbonBar ribbonCaiDat;
        private DevComponents.DotNetBar.ButtonItem btnQlPhong;
        private DevComponents.DotNetBar.ButtonItem btnQlNhom;
        private DevComponents.DotNetBar.ButtonItem btnQlGioThi;
        private DevComponents.DotNetBar.RibbonBar rb3;
        private DevComponents.DotNetBar.ButtonItem btnLoadFile;
        private DevComponents.DotNetBar.ButtonItem btnXepLichThi;
        private DevComponents.DotNetBar.ButtonItem btnXuatExcel;
        private DevComponents.DotNetBar.ButtonItem btnInKetQua;
        private DevComponents.DotNetBar.ButtonItem btnChonNhom;
        private DevComponents.DotNetBar.ButtonItem btnChonPhong;
        private DevComponents.DotNetBar.ButtonItem btnLuuBieuMau;
        private System.Windows.Forms.OpenFileDialog op;
        private DevComponents.DotNetBar.Controls.DataGridViewX grwDanhSach;
    }
}

