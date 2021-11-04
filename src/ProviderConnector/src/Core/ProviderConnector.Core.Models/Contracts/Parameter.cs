namespace ProviderConnector.Core.Models.Contracts
{
    public class Parameter
    {
        public Parameter() { }

        public Parameter(string key, string value) => (Key, Value) = (key, value);

        public string Key { get; set; }
        public string Value { get; set; }
    }
}