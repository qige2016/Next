namespace Next.Core.Entities
{
    public class DomainEventRecord
    {
        public object EventData { get; }

        public int EventOrder { get; }

        public DomainEventRecord(object eventData, int eventOrder)
        {
            EventData = eventData;
            EventOrder = eventOrder;
        }
    }
}