using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionApp
{
    public class FileDataAccess : IDisposable
    {
        StreamReader sr;
        public FileDataAccess() { }
        ~FileDataAccess()
        {
            sr?.Close();
            Console.WriteLine("destroying...");
        }

        public void Dispose()
        {
            Console.WriteLine("disposing....");
            GC.SuppressFinalize(this);
            sr?.Close();
        }

        public string GetData()
        {
            string data = string.Empty;
            using (sr = new StreamReader("data.txt"))
            {
                data += sr.ReadToEnd();                
            }
            return data;
        }

    }
}
