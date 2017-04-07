using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInterfaces
{
    public interface IComplexEventInfo
    {
        int ProcessId { get; }
        string Name { get;  }
        string MessageType { get; }
        IList<IProcessExpectedEvent> ProcessExpectedEvents { get;  }
        IStateEvent StateEvent { get; }
        IStateCommand StateCommand { get;  }
    }
}
