using System.Collections.Generic;
using System.Collections.ObjectModel;
using Next.Backend.Event;

namespace Next.Backend.Entities
{
    public abstract class AggregateRoot : Entity, IAggregateRoot, IGeneratesDomainEvents
    {
        private readonly ICollection<DomainEventRecord> distributedEvents = new Collection<DomainEventRecord>();
        private readonly ICollection<DomainEventRecord> localEvents = new Collection<DomainEventRecord>();

        public virtual IEnumerable<DomainEventRecord> GetLocalEvents()
        {
            return localEvents;
        }

        public virtual IEnumerable<DomainEventRecord> GetDistributedEvents()
        {
            return distributedEvents;
        }

        public virtual void ClearLocalEvents()
        {
            localEvents.Clear();
        }

        public virtual void ClearDistributedEvents()
        {
            distributedEvents.Clear();
        }

        protected virtual void AddLocalEvent(object eventData)
        {
            localEvents.Add(new DomainEventRecord(eventData, EventOrderGenerator.GetNext()));
        }

        protected virtual void AddDistributedEvent(object eventData)
        {
            distributedEvents.Add(new DomainEventRecord(eventData, EventOrderGenerator.GetNext()));
        }
    }

    public abstract class AggregateRoot<TId> : Entity<TId>, IAggregateRoot<TId>, IGeneratesDomainEvents
    {
        private readonly ICollection<DomainEventRecord> distributedEvents = new Collection<DomainEventRecord>();
        private readonly ICollection<DomainEventRecord> localEvents = new Collection<DomainEventRecord>();

        protected AggregateRoot()
        {
        }

        protected AggregateRoot(TId id) : base(id)
        {
        }

        public virtual IEnumerable<DomainEventRecord> GetLocalEvents()
        {
            return localEvents;
        }

        public virtual IEnumerable<DomainEventRecord> GetDistributedEvents()
        {
            return distributedEvents;
        }

        public virtual void ClearLocalEvents()
        {
            localEvents.Clear();
        }

        public virtual void ClearDistributedEvents()
        {
            distributedEvents.Clear();
        }

        protected virtual void AddLocalEvent(object eventData)
        {
            localEvents.Add(new DomainEventRecord(eventData, EventOrderGenerator.GetNext()));
        }

        protected virtual void AddDistributedEvent(object eventData)
        {
            distributedEvents.Add(new DomainEventRecord(eventData, EventOrderGenerator.GetNext()));
        }
    }
}