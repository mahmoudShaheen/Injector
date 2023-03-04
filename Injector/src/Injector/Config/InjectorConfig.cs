namespace Injector.Config
{
    public class InjectorConfig
    {
        /// <summary>
        /// Whether to Register Services
        /// </summary>
        public bool RegisterServices { get; set; } = true;

        /// <summary>
        /// Whether to Register HostedServices
        /// </summary>
        public bool RegisterHostedServices { get; set; } = true;

        /// <summary>
        /// <see cref="RegistrationStrategy"/>
        /// </summary>
        public RegistrationStrategy RegistrationStrategy { get; set; } = RegistrationStrategy.IgnoreIssues;

        /// <summary>
        /// Create new Instance of 
        /// </summary>
        /// <param name="registerServices"><see cref="RegisterServices"/></param>
        /// <param name="registerHostedServices"><see cref="RegisterHostedServices"/></param>
        /// <param name="registrationStrategy"><see cref="RegistrationStrategy"/></param>
        public InjectorConfig(
            bool registerServices = true,
            bool registerHostedServices = true,
            RegistrationStrategy registrationStrategy = RegistrationStrategy.IgnoreIssues)
        {
            RegisterServices = registerServices;
            RegisterHostedServices = registerHostedServices;
            RegistrationStrategy = registrationStrategy;
        }
    }
}
