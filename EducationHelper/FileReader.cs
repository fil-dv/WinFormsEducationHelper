using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EducationHelper
{
    public static class FileReader
    {
        static readonly Random _rnd = new Random();
        static readonly object _syncLock = new object();

        public static int GetRandomNumber(int max)
        {
            lock (_syncLock)
            { // synchronize
                return _rnd.Next(0, max);
            }
        }

        static List<string> ReadTask(string fileName)
        {
            List<string> resList = new List<string>();

            using (var streamReader = File.OpenText(fileName))
            {                
                var tasks = streamReader.ReadToEnd().Split(',');
                int rnd = GetRandomNumber(tasks.Count());

                string task = tasks[rnd];
                string[] lines = streamReader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                foreach (var line in lines)
                {
                    resList.Add(line.Trim());
                }
            }
            return resList;
        }
    }
}
