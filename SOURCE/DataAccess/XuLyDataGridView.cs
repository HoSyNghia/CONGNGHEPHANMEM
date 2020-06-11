using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using DataAccess.Models;

namespace DataAccess
{
    public class XuLyDataGridView
    {
        public static DataGridViewComboBoxColumn CreateComboboxColumn(String HeaderText, List<RoomEntity> items)
        {
            DataGridViewComboBoxColumn objColumn = new DataGridViewComboBoxColumn();
            objColumn.HeaderText = HeaderText;
            objColumn.MaxDropDownItems = 10;
            objColumn.FlatStyle = FlatStyle.Standard;
            foreach (RoomEntity st in items)
                objColumn.Items.Add(st.RoomName);
            return objColumn;
        }
        public static DataGridViewTextBoxColumn CreateTextboxColumn(String HeaderText)
        {
            DataGridViewTextBoxColumn objText = new DataGridViewTextBoxColumn();
            objText.HeaderText = HeaderText;
            objText.ReadOnly = true;
            return objText;
        }
        public static DataGridViewButtonColumn CreateButtonColumn(String HeaderText)
        {
            DataGridViewButtonColumn objBot = new DataGridViewButtonColumn();
            objBot.HeaderText = objBot.Text =  HeaderText;
            objBot.UseColumnTextForButtonValue = true;
            return objBot;
        }
        public static DataGridViewComboBoxColumn CreateComboboxColumn(String HeaderText, List<string> items)
        {
            DataGridViewComboBoxColumn objColumn = new DataGridViewComboBoxColumn();
            objColumn.HeaderText = HeaderText;
            objColumn.MaxDropDownItems = 10;
            objColumn.FlatStyle = FlatStyle.Standard;
            foreach (string st in items)
                objColumn.Items.Add(st);
            return objColumn;
        }
        public static DataGridViewCheckBoxColumn CreateCheckBoxColumn(String HeaderText)
        {
            DataGridViewCheckBoxColumn objColumn = new DataGridViewCheckBoxColumn();
            objColumn.HeaderText = HeaderText;
            objColumn.Width = 100;
            objColumn.FlatStyle = FlatStyle.Standard;
            return objColumn;
        }
        public static void LoadData(DataGridView grwDanhSach, string FileName)
        {
            DataTable tb = Excel.Import(FileName);
            tb.Columns.Add("NHÓM");
            grwDanhSach.DataSource = tb;
            grwDanhSach.Visible = true;
        }

        public static DataTable GetTable(string[] arrayvalue, DataTable main)
        {
            DataTable kq = AddColumns(arrayvalue);
            for (int i = 0; i < main.Rows.Count; i++)
            {
                kq.Rows.Add(i + 1);
                foreach (string st in arrayvalue)
                    kq.Rows[i][st] = main.Rows[i][st];
            }
            return kq;
        }

        static DataTable AddColumns(string[] HeadText)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("STT");
            foreach (string st in HeadText)
                tb.Columns.Add(st);
            return tb;
        }


        public static DataGridViewRow GetRow(string MaHP, DataGridView grwDanhSach)
        {
            foreach (DataGridViewRow r in grwDanhSach.Rows)
                if (Convert.ToString(r.Cells[1].Value) == MaHP)
                    return r;
            return null;
        }
        public static void ShowData(List<VerticeEntity> ListVertice, DataGridView grwDanhSach, int ColumnNgay, int ColumnGio)
        {
            foreach (SubjectEntity mt in ListVertice)
            {
                DataGridViewRow r = GetRow(mt.Code, grwDanhSach);
                r.Cells[ColumnNgay].Value = mt.Color.Date;
                r.Cells[ColumnGio].Value = mt.Color.Time;
            }
        }
        public static void ShowData(List<VerticeEntity> ListVertice, DataGridView grwDanhSach, string ColumnNgay, string ColumnGio)
        {
            
            foreach (SubjectEntity mt in ListVertice)
            {
                DataGridViewRow r = GetRow(mt.Code, grwDanhSach);
                r.Cells[ColumnNgay].Value = mt.Color.Date;
                r.Cells[ColumnGio].Value = mt.Color.Time;
            }
        }
        public static void ShowData(DataGridView src, DataGridView dst, int columnsrc, int columndst)
        {
            DataTable sou = (DataTable)src.DataSource;
            foreach (DataRow r in sou.Rows)
                GetRow(r[1].ToString(), dst).Cells[columndst].Value = r[columnsrc].ToString();
        }
        public static void ShowData(DataGridView src, DataGridView dst, string columnsrc, string columndst)
        {
            DataTable sou = (DataTable)src.DataSource;
            foreach (DataRow r in sou.Rows)
                GetRow(r[1].ToString(), dst).Cells[columndst].Value = r[columnsrc].ToString();
        }
        public static void ReadOnly(DataGridView dgr)
        {
            foreach (DataGridViewColumn c in dgr.Columns)
                c.ReadOnly = true;
        }
    }
}
