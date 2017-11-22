using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationHelper
{
    public static class Settings
    {
        static string _path = @"d:\Dima\Programming\git\WinFormsEducationHelper\EducationHelper\text\spain.txt";
        public static string Path { get { return _path; } set { _path = value; } }

        static int _interval = 5000; //1800000;   // 30 min 
        public static int Interval { get { return _interval; } set { _interval = value; } }
    }
}
