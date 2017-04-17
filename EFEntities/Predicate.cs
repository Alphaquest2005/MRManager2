using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DataEntites;
using GenSoft.Interface;

namespace GenSoft.Entities
{


    public class Predicate:BaseEntity, IPredicate
    {
            public string Path { get; set; }
            public string Operation { get; set; }
            public string Value { get; set; }
            public string Type { get; set; }
    }
   
}
