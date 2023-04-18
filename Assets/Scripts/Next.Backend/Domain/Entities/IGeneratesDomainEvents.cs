using System.Collections.Generic;

namespace Next.Backend.Entities
{
    public interface IGeneratesDomainEvents
    {
        IEnumerable<DomainEventRecord> GetLocalEvents();

        IEnumerable<DomainEventRecord> GetDistributedEvents();

        void ClearLocalEvents();

        void ClearDistributedEvents();
    }
}