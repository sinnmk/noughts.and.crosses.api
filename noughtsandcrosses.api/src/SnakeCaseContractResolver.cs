using System.Text.RegularExpressions;
using Newtonsoft.Json.Serialization;

namespace noughtsandcrosses.api
{
    public class SnakeCaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return GetSnakeCase(propertyName);
        }

        private string GetSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return Regex.Replace(input, @"([a-z])([A-Z])", @"$1_$2", RegexOptions.None).ToLower();
        }
    }
}
