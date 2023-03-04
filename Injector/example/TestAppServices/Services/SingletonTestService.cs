using Injector.Contracts.Services;
using System.Diagnostics;

namespace TestAppServices.Services
{
    public class SingletonTestService : ISingleton
    {
        public SingletonTestService()
        {
            Debug.WriteLine("SingletonTestService: CTOR");
        }

        public void Log()
        {
            Debug.WriteLine("SingletonTestService: Log Called");
        }
    }
}
