using GarbageCollectionApp;

Console.WriteLine("Hello, World!");
GC.Collect();


FileDataAccess dataAccess = null;
//new WeakReference<FileDataAccess>(dataAccess)
using (dataAccess = new FileDataAccess())
{
    Console.WriteLine(dataAccess.GetData());
}
//Console.WriteLine(dataAccess.GetData());

//FileDataAccess dataAccess = new FileDataAccess();
//Console.WriteLine(dataAccess.GetData());
//dataAccess.Disconnect();
//dataAccess = null;
Console.WriteLine("press any key to shut down");
Console.ReadKey();