using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationHelper
{
    public enum Language { Spain, Italy }

    public static class Mediator
    {
        static string _path;
        public static string Path { get { return _path; } set { _path = value; } }
        static Language _lang = Language.Spain;
        public static Language Lang { get { return _lang; } set { _lang = value; } }
    }
}
