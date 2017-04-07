using SystemInterfaces;
using Common.DataEntites;

namespace GenSoft.Entities
{
    public class Process : BaseEntity, IProcessInfo
    {
        public virtual int ParentProcessId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Symbol { get; set; }
        public virtual string UserId { get; set; }
    }
}