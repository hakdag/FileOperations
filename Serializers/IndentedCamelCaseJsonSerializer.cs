using FileOperations.Contracts;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FileOperations.Serializers
{
    public class IndentedCamelCaseJsonSerializer : IDocumentSerializer
    {
        public string Serialize(Document document)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };
            return JsonConvert.SerializeObject(document, settings);
        }
    }
}
