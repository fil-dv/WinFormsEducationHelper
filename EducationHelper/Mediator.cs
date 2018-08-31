using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationHelper
{
    public enum Language { Spanish, Italian }

    public static class Mediator
    {
        static string _path;
        public static string Path { get { return _path; } set { _path = value; } }
        public static Language Lang { get; set; }
    }
}
