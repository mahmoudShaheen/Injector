using Injector.Contracts.Services;
using System.Diagnostics;

namespace TestAppServices.Services
{
    public class TransientTestService : ITransient
    {
        public TransientTestService()
        {
            Debug.WriteLine("TransientTestService: CTOR");
        }

        public void Log()
        {
            Debug.WriteLine("TransientTestService: Log Called");
        }
    }
}
