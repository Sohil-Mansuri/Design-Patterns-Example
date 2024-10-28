
namespace SingletonPattern
{
    internal class ConfigurationManager
    {
        private Dictionary<string, object> _configuration = [];
        private static ConfigurationManager _instance;
        private ConfigurationManager()
        {

        }

        public static ConfigurationManager GetInstance()
        {
            _instance ??= new ConfigurationManager();
            return _instance;
        }

        public void AddConfiguration(string key, object value)
        {
            _configuration.Add(key, value);
        }

        public object GetConfiguration(string key)
        {
            _configuration.TryGetValue(key, out var value);
            return value;
        }
    }
}
