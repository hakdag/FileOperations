using System;
using System.IO;

namespace FileOperations.Storages
{
    public class FileDocumentStorage : DocumentStorage
    {
        public override string GetData(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException("Could not find a file with that name...");

            using (var stream = File.OpenRead(fileName))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public override void PersistDocument(string serializedDocument, string targetFileName)
        {
            try
            {
                using (var stream = File.Open(targetFileName, FileMode.Create, FileAccess.Write))
                using (var sw = new StreamWriter(stream))
                {
                    sw.Write(serializedDocument);
                    sw.Close();
                }
            }
            catch (Exception)
            {
                throw new AccessViolationException();
            }
        }
    }
}
