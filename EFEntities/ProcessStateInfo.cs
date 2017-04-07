using SystemInterfaces;
using Common.DataEntites;

namespace GenSoft.Entities
{
    public abstract class ProcessStateInfo :BaseEntity, IProcessStateInfo
    {
        public virtual int ProcessId { get; set; }
        public virtual IState State { get; set; }
    }
}