using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class Algorithm
    {
        public Algorithm()
        {

        }

        public int GetCountColor(List<VerticeEntity> listSubject)
        {
            return listSubject.Max(x => x.VerticesRelated.Count);
        }

        private bool IsAvailable(VerticeEntity Subject, Color color)
        {
            return Subject.ColorsUsed.Contains(color);
        }

        void Process(List<VerticeEntity> ListVertices, VerticeEntity Vertice, Color Color)
        {
            if (Vertice != null)
            {
                Vertice.Color = Color;
                Vertice.VerticesRelated.ForEach(x =>
                {
                    x.ColorsUsed.Add(Color);
                });
                ListVertices = ListVertices.FindAll(x => x.Color != null).Except(Vertice.VerticesRelated).ToList();
                ListVertices.ForEach(x =>
                {
                    Process(ListVertices, x, Color);
                });
            }
        }

        public void Run(List<VerticeEntity> ListVertices, List<Color> ListColors)
        {
            if (GetCountColor(ListVertices) < ListColors.Count)
            {
                throw new Exception("Không đủ màu để tô");
            }
            List<VerticeEntity> ListHandled = new List<VerticeEntity>();
            int ColorIndex = 0;

            ListVertices = ListVertices.OrderByDescending(x => x.VerticesRelated.Count).ToList();
            while (ListVertices.Count(x => x.Color == null) != 0)
            {
                var Color = ListColors[ColorIndex];
                var Vertice = ListVertices.FirstOrDefault();
                Process(ListVertices, Vertice, Color);
                ColorIndex++;
                ListVertices = ListVertices.FindAll(x => x.Color == null);
            }
        }
    }
}
