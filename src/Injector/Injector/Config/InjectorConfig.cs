namespace Injector.Config
{
    public class InjectorConfig
    {
        public bool RegisterServices { get; set; } = true;
        public bool RegisterHostedServices { get; set; } = true;
        public RegistrationStrategy RegistrationStrategy { get; set; } = RegistrationStrategy.IgnoreIssues;
    }
}
