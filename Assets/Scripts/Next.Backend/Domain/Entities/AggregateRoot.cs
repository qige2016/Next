using System.Collections.Generic;
using System.Collections.ObjectModel;
using Next.Backend.Event;

namespace Next.Backend.Entities
{
    public abstract class AggregateRoot : Entity, IAggregateRoot, IGeneratesDomainEvents
    {
        private readonly ICollection<DomainEventRecord> _distributedEvents = new Collection<DomainEventRecord>();
        private readonly ICollection<DomainEventRecord> _localEvents = new Collection<DomainEventRecord>();

        public virtual IEnumerable<DomainEventRecord> GetLocalEvents()
        {
            return _localEvents;
        }

        public virtual IEnumerable<DomainEventRecord> GetDistributedEvents()
        {
            return _distributedEvents;
        }

        public virtual void ClearLocalEvents()
        {
            _localEvents.Clear();
        }

        public virtual void ClearDistributedEvents()
        {
            _distributedEvents.Clear();
        }

        protected virtual void AddLocalEvent(object eventData)
        {
            _localEvents.Add(new DomainEventRecord(eventData, EventOrderGenerator.GetNext()));
        }

        protected virtual void AddDistributedEvent(object eventData)
        {
            _distributedEvents.Add(new DomainEventRecord(eventData, EventOrderGenerator.GetNext()));
        }
    }

    public abstract class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot<TKey>, IGeneratesDomainEvents
    {
        private readonly ICollection<DomainEventRecord> _distributedEvents = new Collection<DomainEventRecord>();
        private readonly ICollection<DomainEventRecord> _localEvents = new Collection<DomainEventRecord>();

        protected AggregateRoot()
        {
        }

        protected AggregateRoot(TKey id) : base(id)
        {
        }

        public virtual IEnumerable<DomainEventRecord> GetLocalEvents()
        {
            return _localEvents;
        }

        public virtual IEnumerable<DomainEventRecord> GetDistributedEvents()
        {
            return _distributedEvents;
        }

        public virtual void ClearLocalEvents()
        {
            _localEvents.Clear();
        }

        public virtual void ClearDistributedEvents()
        {
            _distributedEvents.Clear();
        }

        protected virtual void AddLocalEvent(object eventData)
        {
            _localEvents.Add(new DomainEventRecord(eventData, EventOrderGenerator.GetNext()));
        }

        protected virtual void AddDistributedEvent(object eventData)
        {
            _distributedEvents.Add(new DomainEventRecord(eventData, EventOrderGenerator.GetNext()));
        }
    }
}