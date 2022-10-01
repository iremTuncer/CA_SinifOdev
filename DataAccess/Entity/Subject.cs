using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Subject:BaseClass
    {
        public string KonuAdı { get; set; }
        public Student student { get; set; }

    }
}
