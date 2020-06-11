using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using DataAccess.Models;

namespace DataAccess
{

    public class XuLyXml
    {
        static string FileName = "Data\\Data.xml";
        public static void AddNode(XmlDocument doc, XmlNode Items, string Name, string value)
        {
            XmlNode Node = doc.CreateNode(XmlNodeType.Element, Name, "");
            Node.InnerText = value;
            Items.AppendChild(Node);
        }
        public static void RemoveNode(XmlDocument doc, string NodeName, bool save)
        {
            try
            {
                XmlNodeList nodes = doc.SelectNodes("Data/" + NodeName);
                foreach (XmlNode xno in nodes)
                    xno.ParentNode.RemoveChild(xno);
            }
            catch (Exception)
            {
            }
            if (save)
                SaveFile(doc);
        }
        public static void CreateFile(string FileName)
        {
            XmlTextWriter writer = new XmlTextWriter(FileName, System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Data");
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
        public static XmlDocument OpenFile()
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                if (!Directory.Exists("data"))
                    Directory.CreateDirectory("Data");
                if (!File.Exists(FileName))
                    CreateFile(FileName);
                doc.Load(FileName);
            }
            catch (Exception)
            {
            }
            return doc;
        }
        public static XmlDocument MoFile(string FileName)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(FileName);
            }
            catch (Exception)
            {
            }
            return doc;
        }
        public static bool SaveFile(XmlDocument doc)
        {
            try
            {
                if (!File.Exists(FileName))
                    CreateFile(FileName);
                doc.Save(FileName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static List<RoomEntity> GetAllRooms()
        {
            List<RoomEntity> kq = new List<RoomEntity>();
            try
            {
                XmlDocument doc = OpenFile();
                XmlNodeList Nodes = doc.SelectNodes("Data/Room/Items");
                foreach (XmlNode xno in Nodes)
                    kq.Add(new RoomEntity(xno.ChildNodes[0].InnerText, Convert.ToInt32(xno.ChildNodes[1].InnerText)));
                return kq;
            }
            catch (Exception)
            {
                return new List<RoomEntity>();
            }
        }
        public static bool HasCreatedLevel()
        {
            try
            {
                XmlDocument doc = OpenFile();
                XmlNodeList Nodes = doc.SelectNodes("Data/Level/Items");
                if (Nodes.Count > 0)
                    return true;
            }
            catch { }
            return false;
        }




        public static List<Color> GetAllTimes()
        {
            List<Color> kq = new List<Color>();
            try
            {
                XmlDocument doc = OpenFile();
                XmlNodeList Nodes = doc.SelectNodes("Data/Time/Items");
                foreach (XmlNode xno in Nodes)
                    kq.Add(new TimeEntity(xno.ChildNodes[0].InnerText, xno.ChildNodes[1].InnerText));
                return kq;
            }
            catch (Exception)
            {
                return new List<Color>();
            }
        }

        public static List<string> GetAllLevels()
        {
            List<string> kq = new List<string>();
            try
            {
                XmlDocument doc = OpenFile();
                XmlNodeList Nodes = doc.SelectNodes("Data/Level/Items");
                foreach (XmlNode xno in Nodes)
                    kq.Add(xno.InnerText);
                return kq;
            }
            catch (Exception)
            {
                return new List<string>();
            }
        }
        public static bool SaveLevel(List<string> ListLevel, string NodeName, string NodeItems)
        {
            try
            {
                XmlDocument doc = OpenFile();
                RemoveNode(doc, NodeName, true);
                XmlNode Items = doc.CreateNode(XmlNodeType.Element, NodeName, "");
                foreach (string st in ListLevel)
                    AddNode(doc, Items, NodeItems, st);
                doc.DocumentElement.AppendChild(Items);
                SaveFile(doc);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public static bool SaveRoom(List<RoomEntity> ListRoom)
        {
            try
            {
                XmlDocument doc = OpenFile();
                RemoveNode(doc, "Room", true);
                XmlNode Items = doc.CreateNode(XmlNodeType.Element, "Room", "");
                foreach (RoomEntity ph in ListRoom)
                {
                    XmlNode Items2 = doc.CreateNode(XmlNodeType.Element, "Items", "");
                    AddNode(doc, Items2, "RoomName", ph.RoomName);
                    AddNode(doc, Items2, "Seat", ph.Seat.ToString());
                    Items.AppendChild(Items2);
                }
                doc.DocumentElement.AppendChild(Items);
                SaveFile(doc);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public static bool SaveTime(List<TimeEntity> ListTime)
        {
            try
            {
                XmlDocument doc = OpenFile();
                RemoveNode(doc, "Time", true);
                XmlNode Items = doc.CreateNode(XmlNodeType.Element, "Time", "");
                foreach (TimeEntity gt in ListTime)
                {
                    XmlNode Items2 = doc.CreateNode(XmlNodeType.Element, "Items", "");
                    AddNode(doc, Items2, "Date", gt.Date);
                    AddNode(doc, Items2, "Time", gt.Time);
                    Items.AppendChild(Items2);
                }
                doc.DocumentElement.AppendChild(Items);
                SaveFile(doc);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }        
    }
}
