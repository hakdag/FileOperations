using FileOperations.Contracts;
using FileOperations.Exceptions;
using System.Net;

namespace FileOperations.Retrievers
{
    public class HttpInputRetriever : IInputRetriever
    {
        public string GetData(string fileName)
        {
            if (!fileName.StartsWith("http"))
            {
                throw new InvalidTargetException();
            }

            var client = new WebClient();
            var input = client.DownloadString(fileName);

            return input;
        }
    }
}
