using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SystemInterfaces;
using Actor.Interfaces;
using Common.DataEntites;

namespace GenSoft.Entities
{
    public class ComplexEventAction : BaseEntity, IComplexEventInfo
    {
        public virtual int ProcessId { get; set; }
        public virtual string Name { get; set; }
        public virtual string MessageType { get; set; }
        public virtual IList<ExpectedEvent> ExpectedEvents { get; set; }
        public virtual StateEvent StateEventInfo { get; set; }
        public virtual StateCommand StateCommandInfo { get; set; }
        public IList<IProcessExpectedEvent> ProcessExpectedEvents => (IList<IProcessExpectedEvent>) ExpectedEvents;
        public IStateEvent StateEvent => StateEventInfo;
        public IStateCommand StateCommand => StateCommandInfo;
    }
}