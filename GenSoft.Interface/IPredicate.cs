using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSoft.Interface
{
    public interface IPredicate
    {
        string Path { get; }
        string Operation { get; }
        string Value { get; }
    }
}
