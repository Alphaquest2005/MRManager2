using SystemInterfaces;
using Common.DataEntites;

namespace GenSoft.Entities
{
    public class ApplicationSetting : BaseEntity, IApplicationSetting
    { 
        public virtual bool AutoRun { get; set; }
    }
}