using FileOperations.Contracts;

namespace FileOperations
{
    public abstract class DocumentStorage : IInputRetriever, IDocumentPersister
    {
        public abstract string GetData(string fileName);
        public abstract void PersistDocument(string serializedDocument, string targetFileName);
    }
}
