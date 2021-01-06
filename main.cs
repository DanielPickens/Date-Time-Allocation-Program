using System;
using System.IO;
class Program
{
    static void Main()
    {
        FileInfo info = new FileInfo("C:\\sri\\srip.txt");
        DateTime time = info.CreationTime;
        Console.WriteLine("File Creation Time     : {0}", time);
        time = info.LastAccessTime;
        Console.WriteLine("File Last Access Time  : {0}", time);
        time = info.LastWriteTime;
        Console.WriteLine("File Last Write Time   : {0} ", time);
        Console.Read();
    }
}
