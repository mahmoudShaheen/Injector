namespace Injector.Builders
{
    public interface IBuilder
    {
        /// <summary>
        /// Scan Module For Injector.Contracts interfaces and register all to IOC Container
        /// </summary>
        /// <param name="assemblyMarkerType">Any Class type inside the assembly to scan</param>
        /// <returns></returns>
        public IBuilder RegisterModule(Type assemblyMarkerType);

        /// <summary>
        /// Scan Modules For Injector.Contracts interfaces and register all to IOC Container
        /// </summary>
        /// <param name="assemblyMarkerTypes">List of Class types inside the assemblies to scan</param>
        /// <returns></returns>
        public IBuilder RegisterModules(params Type[] assemblyMarkerTypes);
    }
}
