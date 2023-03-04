using Injector.Contracts.Services;
using System.Diagnostics;

namespace TestAppServices.Services
{
    public class SingletonGenericTestService : ISingletonGenericTestService, ISingleton<ISingletonGenericTestService>
    {
        public SingletonGenericTestService()
        {
            Debug.WriteLine("SingletonGenericTestService: CTOR");
        }

        public void Log()
        {
            Debug.WriteLine("SingletonGenericTestService: Log Called");
        }
    }
}
