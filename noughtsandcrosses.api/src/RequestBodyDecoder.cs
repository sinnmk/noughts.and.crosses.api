using System.Text;
using Nancy.IO;
using Newtonsoft.Json;

namespace noughtsandcrosses.api
{
    public static class RequestBodyDecoder
    {
        public static dynamic Decode(RequestStream ioStream)
        {
            int length = (int)ioStream.Length;
            byte[] data = new byte[length];
            ioStream.Read(data, 0, length);
            return JsonConvert.DeserializeObject<dynamic>(System.Text.Encoding.Default.GetString(data));
        }

        public static T Decode<T>(RequestStream ioStream)
        {
            int length = (int)ioStream.Length;
            byte[] data = new byte[length];
            ioStream.Read(data, 0, length);
            return JsonConvert.DeserializeObject<T>(System.Text.Encoding.Default.GetString(data));
        }

        public static T Decode<T>(string jsonText)
        {
            return JsonConvert.DeserializeObject<T>(jsonText);
        }

        public static T DecodeFromSnakeCase<T>(RequestStream ioStream)
        {
            var length = (int)ioStream.Length;
            var data = new byte[length];
            ioStream.Read(data, 0, length);
            return JsonConvert.DeserializeObject<T>(Encoding.Default.GetString(data), new JsonSerializerSettings
            {
                ContractResolver = new SnakeCaseContractResolver()
            });
        }

        public static T DecodeFromSnakeCase<T>(string jsonText)
        {
            return JsonConvert.DeserializeObject<T>(jsonText, new JsonSerializerSettings
            {
                ContractResolver = new SnakeCaseContractResolver()
            });
        }
    }
}