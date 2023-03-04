using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injector.Builders
{
    public interface IBuilder
    {
        public IBuilder RegisterModule(Type assemblyMarkerType);
        public IBuilder RegisterModules(params Type[] assemblyMarkerTypes);
    }
}
