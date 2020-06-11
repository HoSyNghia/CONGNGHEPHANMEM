using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DataAccess;
using DataAccess.Models;

namespace XepLichThi
{
    public partial class frmQlPhongHoc : DevComponents.DotNetBar.Office2007Form
    {
        public frmQlPhongHoc()
        {
            InitializeComponent();
        }

        List<RoomEntity> GetDsPhong()
        {
            List<RoomEntity> kq = new List<RoomEntity>();
            foreach (DataGridViewRow r in dgrDanhSach.Rows)
            {
                string st = Convert.ToString(r.Cells[0].Value);
                if (st.Trim() != "")
                {
                    kq.Add(new RoomEntity(st, Convert.ToInt32(r.Cells[1].Value)));
                }
            }
            return kq;
        }
        bool KiemTra()
        {
            if (BatLoi.TextNull(txtTenPhong.Text, "Vui lòng nhập tên phòng")
                && BatLoi.TextNull(txtSoLuong.Text, "Vui lòng nhập số chỗ ngồi")
                && BatLoi.SoLuong(txtSoLuong.Text, "Số lượng chỗ ngồi sai, vui lòng kiểm tra lại"))
            {
                foreach (DataGridViewRow r in dgrDanhSach.Rows)
                {
                    if (Convert.ToString(r.Cells[0].Value).ToLower() == txtTenPhong.Text.ToLower())
                        return BatLoi.ThongBao2("Phòng này đã có trong danh sách");
                }
                return !BatLoi.ThongBao2("Thêm thành công");
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
                dgrDanhSach.Rows.Add(txtTenPhong.Text, txtSoLuong.Text,"Xóa");
        }

        void LoadData(List<RoomEntity> ds)
        {
            dgrDanhSach.Rows.Clear();
            foreach (RoomEntity ph in ds)
                dgrDanhSach.Rows.Add(ph.RoomName, ph.Seat,"Xóa");
        }

        public void frmQlPhongHoc_Load(object sender, EventArgs e)
        {
            LoadData(XuLyXml.GetAllRooms());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgrDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                    dgrDanhSach.Rows.Remove(dgrDanhSach.CurrentRow);
            }
            catch (Exception)
            {
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            XuLyXml.SaveRoom(GetDsPhong());
            this.Close();

        }
    }
}