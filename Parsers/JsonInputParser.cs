using Newtonsoft.Json;
using System;

namespace FileOperations.Parsers
{
    public class JsonInputParser : InputParser
    {
        public override Document ParseInput(string input)
        {
            try
            {
                return JsonConvert.DeserializeObject<Document>(input);
            }
            catch (Exception)
            {
                return base.ParseInput(input);
            }
        }
    }
}
