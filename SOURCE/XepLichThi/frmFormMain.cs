using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DataAccess;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using DataAccess.Models;

namespace XepLichThi
{
    public partial class frmFormMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmFormMain()
        {
            InitializeComponent();
        }
        string saveFileName = "";

        Thread TienTrinh;
        public delegate void HienThi(string Text);
        void ShowText(string Text)
        {
            //lbStatus.Text = Text;
        }
        void HideStatus()
        {
            Thread.Sleep(2000);
            this.Invoke(new HienThi(ShowText), "");
            TienTrinh.Abort();
        }
        void ShowStatus(string Text)
        {
            try
            {
                this.Invoke(new HienThi(ShowText), Text);
                TienTrinh = new Thread(HideStatus);
                TienTrinh.Start();
            }
            catch (Exception)
            {
            }
        }
        private void frmXepLichThi_Load(object sender, EventArgs e)
        {
            //pnTitle.Left = (this.Width - pnTitle.Width) / 2;
            lblTime.Text = DuLieu.GetDay();
            Active_Form();

        }
        #region RibonControl
        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (ribon.Expanded)
            {
                ribon.Expanded = false;
                btnExpand.Image = XepLichThi.Properties.Resources.a;
            }
            else
            {
                btnExpand.Image = XepLichThi.Properties.Resources.col;
                ribon.Expanded = true;
            }
        }
        private void ribbonTabItem_DClick(object sender, EventArgs e)
        {
            if (ribon.Expanded)
            {
                btnExpand.Image = XepLichThi.Properties.Resources.col;
            }
            else
            {
                btnExpand.Image = XepLichThi.Properties.Resources.a;
            }
        }
        #endregion
        #region Chuc nang======================

        void Active_Form()
        {

            if (!XuLyXml.HasCreatedLevel())
                if (BatLoi.DgResul("Bậc học chưa được cài đặt, bạn có muốn cài đặt không?"))
                {
                    frmQlBacHoc qlbh = new frmQlBacHoc();
                    qlbh.ShowDialog();
                }

        }
        private void btnThoatCT_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thoát khỏi chương trình", "Thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.OK)
                Application.Exit();
        }
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            DialogResult rs = op.ShowDialog();
            try
            {
                if (rs == DialogResult.OK)
                {
                    XuLyDataGridView.LoadData(grwDanhSach, op.FileName);
                    grwDanhSach.Columns[2].Width = 300;
                    btnChonNhom.Enabled = btnXuatExcel.Enabled = btnInKetQua.Enabled = true;
                    btnChonPhong.Enabled = btnXepLichThi.Enabled = false;
                    ShowStatus("Load Dữ Liệu Thành Công");
                }
            }
            catch (Exception)
            {
                BatLoi.ThongBao2("Lỗi! Không thể load dữ liệu từ file đã chọn");
            }
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (grwDanhSach.Rows.Count == 0)
                {
                    BatLoi.ThongBao2("Chưa có dữ liệu để lưu");
                    return;
                }
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    saveFileName = saveFileDialog.FileName;
                    DataColumn c = ((DataTable)grwDanhSach.DataSource).Columns["NHÓM"];
                    ((DataTable)grwDanhSach.DataSource).Columns.Remove(c);
                    Excel.Export((DataTable)grwDanhSach.DataSource, saveFileName, "KẾT QUẢ XẾP LỊCH THI");
                    ((DataTable)grwDanhSach.DataSource).Columns.Add(c);
                    ShowStatus("Lưu Kết Quả Thành Công");
                }
            }
            catch (Exception)
            {
                ShowStatus("Đã xảy ra lỗi... Dữ liệu chưa được lưu");
            }
        }
        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            if (grwDanhSach.Rows.Count > 0)
            {
                Printer pr = new Printer();
                DataGridViewColumn c = grwDanhSach.Columns["NHÓM"];
                grwDanhSach.Columns.Remove(c);
                pr.print(grwDanhSach);
                grwDanhSach.Columns.Add(c);
            }
        }
        private void btnXepLichThi_Click(object sender, EventArgs e)
        {
            List<VerticeEntity> ListVertice = DsMonThi();
            new Algorithm().Run(ListVertice, TimeEntity.GetAll);
            XuLyDataGridView.ShowData(ListVertice, grwDanhSach, "NGÀY", "GIỜ THI");
        }
        private void btnQlNhom_Click(object sender, EventArgs e)
        {
            frmQlBacHoc ql = new frmQlBacHoc();
            ql.ShowDialog();
        }
        private void btnQlPhong_Click(object sender, EventArgs e)
        {
            frmQlPhongHoc ql = new frmQlPhongHoc();
            ql.ShowDialog();
        }
        private void btnQlGioThi_Click(object sender, EventArgs e)
        {
            frmQlTiet qlt = new frmQlTiet();
            qlt.ShowDialog();
        }
        bool DangNhap = false;
        #endregion
        #region DataGridView=======================
        private void grwDanhSach_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                grwDanhSach.CurrentCell = grwDanhSach.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
            catch (Exception)
            {
            }
        }
        List<VerticeEntity> DsMonThi()
        {
            List<VerticeEntity> ListVertice = new List<VerticeEntity>();
            foreach (DataGridViewRow r in grwDanhSach.Rows)
                if (Convert.ToString(r.Cells["NHÓM"].Value) != "")
                {

                    SubjectEntity mt = new SubjectEntity(Convert.ToString(r.Cells["MÃ HP"].Value));
                    string phong1 = Convert.ToString(((DataGridViewTextBoxCell)r.Cells["PHÒNG"]).Value);
                    string nhom1 = Convert.ToString(r.Cells["NHÓM"].Value);
                    foreach (DataGridViewRow r2 in grwDanhSach.Rows)
                    {
                        if (r2.Index != r.Index)
                        {
                            string nhom2 = Convert.ToString(r2.Cells["NHÓM"].Value);
                            string phong2 = Convert.ToString(((DataGridViewTextBoxCell)r2.Cells["PHÒNG"]).Value);
                            if (DuLieu.CheckContain(nhom1, nhom2) || DuLieu.CheckContain(phong1, phong2))
                                mt.AddSubjectRelated(Convert.ToString(r2.Cells[1].Value));
                        }
                    }
                    ListVertice.Add(mt);
                }
            return ListVertice;
        }
        #endregion
        private void btnChonNhom_Click(object sender, EventArgs e)
        {
            DataTable kq = XuLyDataGridView.GetTable(new string[] { "MÃ HP", "TÊN HỌC PHẦN", "LỚP", "NHÓM" }, (DataTable)grwDanhSach.DataSource);
            frmChonNhom fcn = new frmChonNhom(kq);
            if (fcn.ShowDialog() == DialogResult.OK)
            {
                XuLyDataGridView.ShowData(fcn.dgrDanhSach, grwDanhSach, "NHÓM", "NHÓM");
                btnChonPhong.Enabled = btnXepLichThi.Enabled = true;
            }
        }

        void MonXepPhong(DataTable tb)
        {
            for (int i = 0; i < tb.Rows.Count; i++)
                if (tb.Rows[i]["HT THI"].ToString().ToLower().CompareTo("Thi Máy".ToLower()) != 0
                    && tb.Rows[i]["HT THI"].ToString().ToLower().CompareTo("Vấn Đáp".ToLower()) != 0)
                {
                    tb.Rows.RemoveAt(i);
                    i--;
                }
        }

        private void btnChonPhong_Click(object sender, EventArgs e)
        {
            DataTable kq = XuLyDataGridView.GetTable(new string[] { "MÃ HP", "TÊN HỌC PHẦN", "SỐ SV", "HT THI", "PHÒNG" }, (DataTable)grwDanhSach.DataSource);
            MonXepPhong(kq);
            frmChonPhong fcp = new frmChonPhong(kq);
            if (fcp.ShowDialog() == DialogResult.OK)
                XuLyDataGridView.ShowData(fcp.dgrDanhSach, grwDanhSach, "PHÒNG", "PHÒNG");
        }
        private void grwDanhSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DateTime columnValue;
            if (e.ColumnIndex == 8)
                if (e.Value != null && DateTime.TryParse((e.Value.ToString()), out columnValue))
                    e.Value = DateTime.Parse(e.Value.ToString()).ToShortTimeString();
            if (e.ColumnIndex == 7)
                if (e.Value != null && DateTime.TryParse((e.Value.ToString()), out columnValue))
                    e.Value = DateTime.Parse(e.Value.ToString()).ToShortDateString();
        }
        public void frmFormMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized && this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Maximized;
        }
        private void btnLuuBieuMau_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.FileName = "BieuMau.xls";
                sv.Filter = "Excel Worksheet|*.xls;*.xlsx";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    Assembly Assemb = Assembly.GetExecutingAssembly();
                    FileStream fs;
                    BinaryWriter bw;
                    if (File.Exists(sv.FileName))
                        File.Delete(sv.FileName);
                    fs = new FileStream(sv.FileName, FileMode.CreateNew);
                    bw = new BinaryWriter(fs);
                    bw.Write(global::XepLichThi.Properties.Resources.BieuMau, 0, global::XepLichThi.Properties.Resources.BieuMau.Length);
                    bw.Flush();
                    bw.Close();
                }
            }
            catch (Exception)
            {
            }

        }
        private void btnHuongDanSuDung_Click(object sender, EventArgs e)
        {
            if (File.Exists("Help.chm"))
                Process.Start("Help.chm");
            else
                BatLoi.ThongBao2("Lỗi: Không tìm thấy file Help.chm");
        }



    }
}
