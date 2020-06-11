using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class RoomEntity
    {
        public string RoomName;
        public int Seat;
        public RoomEntity(string ten, int sl)
        {
            RoomName = ten;
            Seat = sl;
        }
        public static List<RoomEntity> GetAll
        {
            get
            {
                return XuLyXml.GetAllRooms();
            }
        }


    }
}
