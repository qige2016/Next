namespace Next.Backend.Event
{
    public static class EventOrderGenerator
    {
        private static int _lastOrder;

        public static int GetNext()
        {
            return _lastOrder++;
        }
    }
}