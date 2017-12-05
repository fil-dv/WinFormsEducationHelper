using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationHelper
{
    public static class Mediator
    {
        static string _path;
        public static string Path { get { return _path; } set { _path = value; } }
    }
}
