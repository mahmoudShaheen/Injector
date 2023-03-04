using Injector.Contracts.Services;
using System.Diagnostics;

namespace TestAppServices.Services
{
    public class ScopedTestService : IScoped
    {
        public ScopedTestService()
        {
            Debug.WriteLine("ScopedTestService: CTOR");
        }

        public void Log()
        {
            Debug.WriteLine("ScopedTestService: Log Called");
        }
    }
}
