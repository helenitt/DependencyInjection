using System.Configuration;

namespace Shared
{
    public class Config : IConfig
    {
        private string _ageLimit;

        public Config()
        {
            _ageLimit = ConfigurationManager.AppSettings["AgeLimit"];
        }

        public string AgeLimit
        {
            get { return _ageLimit; }
            set { _ageLimit = value; }
        }
    }
}
