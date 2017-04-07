using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInterfaces;
using Common.DataEntites;
using Interfaces;

namespace GenSoft.Entities
{
    public class MachineInfo :BaseEntity, IMachineInfo
    {
       public virtual string MachineName { get; set; }
       public virtual int Processors { get; set; }
    }
}
