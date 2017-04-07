using SystemInterfaces;

namespace GenSoft.Entities
{
    public class StateCommandInfo : ProcessStateInfo, IStateCommandInfo
    {
        public new IStateCommand State { get; set; }
    }
}