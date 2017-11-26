using FileOperations.Contracts;
using Newtonsoft.Json;

namespace FileOperations.Serializers
{
    public class JsonDocumentSerializer : IDocumentSerializer
    {
        public string Serialize(Document document)
        {
            return JsonConvert.SerializeObject(document);
        }
    }
}
