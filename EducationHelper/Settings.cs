
namespace EducationHelper
{
    public static class Settings
    {
        static string _path = @"D:\Dima\Google\Spanish\spain.txt";
        public static string Path { get { return _path; } set { _path = value; } }
        static int _interval = 21 * 60 * 1000;   // 21 min 
        public static int Interval { get { return _interval; } set { _interval = value; } }
    }
}
