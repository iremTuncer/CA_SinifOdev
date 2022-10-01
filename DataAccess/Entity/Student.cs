using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Student:BaseClass
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Anlattı { get; set; }
        public DateTime AnlatımTarihi { get; set; }
        public int SubjectId { get; set; }
    }
}
