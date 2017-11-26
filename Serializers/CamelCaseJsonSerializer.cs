using FileOperations.Contracts;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FileOperations.Serializers
{
    public class CamelCaseJsonSerializer : IDocumentSerializer
    {
        public string Serialize(Document document)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            return JsonConvert.SerializeObject(document, settings);
        }
    }
}
