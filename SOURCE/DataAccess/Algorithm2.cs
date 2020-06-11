using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DataAccess.Models;

namespace DataAccess
{
    public class Algorithm2
    {
        //private ListSubject DsMonThi;
        //public ListSubject DsMonThiDaXep = new ListSubject();
        //List<TimeEntity> ListTime;
        //public Algorithm2(ListSubject dsmt, List<TimeEntity> ListTime)
        //{
        //    DsMonThi = dsmt;
        //    this.ListTime = ListTime;
        //}
        //public Algorithm2() { }
        //Thread TienTrinh;
        //frmProcess frm;
        //void ShowProcess()
        //{
        //    frm = new frmProcess();
        //    frm.ShowDialog();
        //}

        //private bool Available(SubjectEntity Subject, int color)
        //{
        //    return Subject.ColorsUsed.Contains(color);
        //}
        //void UpdateDs(SubjectEntity mt)
        //{
        //    DsMonThi.ThemTietDaTo(mt, ListTime.IndexOf(mt.Time));
        //    DsMonThi.Remove(mt);
        //    DsMonThiDaXep.Add(mt);
        //}
        //public bool Run()
        //{
        //    if (DsMonThi.SoLuongMau > ListTime.Count)
        //        return BatLoi.ThongBao2("Số lượng giờ thi sử dụng không đủ để xếp lịch. Vui lòng kiểm tra lại");
        //    try
        //    {
        //        TienTrinh = new Thread(ShowProcess);
        //        TienTrinh.Start();
        //        int TietXep = 0;
        //        while (DsMonThi.Length > 0)
        //        {

        //            DsMonThi.SortGiam();
        //            DsMonThi.SetGio(DsMonThi[0], ListTime[TietXep]);
        //            UpdateDs(DsMonThi[0]);

        //            for (int i = 0; i < DsMonThi.Length; i++)
        //            {
        //                SubjectEntity mt2 = DsMonThi[i];
        //                if (!Available(DsMonThi[i], TietXep))
        //                {
        //                    DsMonThi.SetGio(mt2, ListTime[TietXep]);
        //                    UpdateDs(mt2);
        //                    i--;
        //                }
        //            }
        //            TietXep++;
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        TienTrinh.Abort();
        //        return false;
        //    }
        //    TienTrinh.Abort();
        //    return true;
        //}
    }
}
