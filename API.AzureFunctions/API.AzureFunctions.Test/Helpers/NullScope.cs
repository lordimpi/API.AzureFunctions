using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.AzureFunctions.Test.Helpers
{
    public class NullScope : IDisposable
    {
        public static NullScope Instance { get; } = new NullScope();
        public void Dispose()
        {
        }
        private NullScope() 
        { 
        }
    }
}
