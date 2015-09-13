using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zada4a
{
    class SentenceNotCompletedException : Exception
    {
        public SentenceNotCompletedException(String message)
            : base(message)
        {
        }
    }
}
