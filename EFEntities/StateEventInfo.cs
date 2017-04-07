using SystemInterfaces;

namespace GenSoft.Entities
{
    public class StateEventInfo : ProcessStateInfo, IStateEventInfo
    {
        public new virtual IStateEvent State { get; set; }
    }
}