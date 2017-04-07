using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInterfaces;

namespace RevolutionEntities.Process
{
    public class ComplexEventActionInfo
    {
        public string Name { get; set; }
        public int ProcessId { get; set; }

        public string MessageType { get; set; }
        public Type ExpectedMessageType => Type.GetType(MessageType);
        public IList<IProcessExpectedEvent> ExpectedEvents { get; set; }
        public IStateCommand StateCommand { get; set; }
        public IStateEvent StateEvent { get; set; }
    }
}
