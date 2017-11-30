using System;
using System.IO;
using System.Linq;

namespace EducationHelper
{
    public static class FileReader
    {
        static readonly Random _rnd = new Random();
        static readonly object _syncLock = new object();

        static int GetRandomNumber(int max)
        {
            lock (_syncLock)
            { // synchronize
                return _rnd.Next(0, max);
            }
        }

        static public string ReadTask(string fileName)
        {
            string task = "";
            using (var streamReader = File.OpenText(fileName))
            {                
                var tasks = streamReader.ReadToEnd().Split('#');
                int rnd = GetRandomNumber(tasks.Count());
                task = tasks[rnd];
            }
            return task;
        }
    }
}
