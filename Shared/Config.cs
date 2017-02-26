namespace Shared
{
    public class Config : IConfig
    {
        private string _ageLimit;

        public Config()
        {
            _ageLimit = DependencyInjectionExample.App.config.AppSettings["AgeLimit"];
        }

        public string AgeLimit
        {
            get { return _ageLimit; }
            set { _ageLimit = AgeLimit; }
        }
    }
}
