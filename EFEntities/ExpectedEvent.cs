using System;
using System.ComponentModel.DataAnnotations.Schema;
using SystemInterfaces;
using Common.DataEntites;

namespace GenSoft.Entities
{
    public class ExpectedEvent :BaseEntity
    {
        public virtual int ProcessId { get; set; }
        public IProcessStateInfo ProcessInfo => StateInfo;
        public ISourceType ExpectedSourceType => SourceType;
        public virtual StateInfo StateInfo { get; set; }
        public virtual SourceType SourceType { get; set; }

        public virtual string EventTypeString { get; set; }
        [NotMapped]
        public Type EventType => Type.GetType(EventTypeString);
        public virtual string Key { get; set; }

        public virtual Predicate EventPredicate { get; set; }
       
    }

    public class SourceType : BaseEntity, ISourceType
    {
        public virtual string SourceTypeString { get; set; }
        public Type Source_Type => Type.GetType(SourceTypeString);
    }

    public abstract class State: BaseEntity, IState
    {
        public virtual string Name { get; set; }
        public virtual string Status { get; set; }
        public virtual string Notes { get; set; }
    }

    public class StateCommand : State, IStateCommand
    {
        public virtual IStateEvent ExpectedEvent { get; set; }
    }

    public class StateEvent : State, IStateEvent
    {
        public virtual IStateCommand ExpectedCommand { get; set; }
    }
}