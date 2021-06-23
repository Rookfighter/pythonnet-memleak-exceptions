using System;

namespace LeakingExceptions
{
    public class ExceptionThrower
    {
        public void ThrowException()
        {
            throw new Exception("a simple exception");
        }

        public void ThrowTimeoutException()
        {
            throw new TimeoutException("a timeout exception");
        }
    }
}
