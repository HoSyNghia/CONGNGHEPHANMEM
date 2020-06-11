using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;

namespace DataAccess.Models
{
    public class SubjectEntity: VerticeEntity
    {
        public string Code;
        public TimeEntity Color;

        public SubjectEntity(string Code)
        {
            this.Code = Code;
        }
        public void AddSubjectRelated(VerticeEntity Code)
        {
            VerticesRelated.Add(Code);
        }
    }

}
