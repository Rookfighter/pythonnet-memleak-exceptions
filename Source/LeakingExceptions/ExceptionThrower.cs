using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
