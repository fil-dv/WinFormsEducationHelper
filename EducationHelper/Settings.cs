
namespace EducationHelper
{
    public static class Settings
    {
        static string _path = @"d:\Dima\Programming\git\WinFormsEducationHelper\EducationHelper\text\spain.txt";
        public static string Path { get { return _path; } set { _path = value; } }
        static int _interval = 30 * 60 * 1000;   // 30 min 
        public static int Interval { get { return _interval; } set { _interval = value; } }
    }
}
