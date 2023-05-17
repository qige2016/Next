using System;
using System.Threading;

namespace Next.Backend.Repositories
{
    internal class InSaveIdGenerator
    {
        private int lastInt;
        private long lastLong;

        public TId GenerateNext<TId>()
        {
            if (typeof(TId) == typeof(Guid))
            {
                return (TId) (object) Guid.NewGuid();
            }

            if (typeof(TId) == typeof(int))
            {
                return (TId) (object) Interlocked.Increment(ref lastInt);
            }

            if (typeof(TId) == typeof(long))
            {
                return (TId) (object) Interlocked.Increment(ref lastLong);
            }

            throw new Exception("Not supported PrimaryKey type: " + typeof(TId).FullName);
        }
    }
}