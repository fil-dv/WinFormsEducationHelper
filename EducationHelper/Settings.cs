
namespace EducationHelper
{
    public enum Language { Spanish, Italian }

    public static class Settings
    {
        public static string PathToFile { get ; set ; }
        static int _interval = 61 * 60 * 1000;   // 61 min 
        public static int Interval { get { return _interval; } set { _interval = value; } }

        public static string PathToAnswere { get; set; }
        public static Language Lang { get; set; }
    }
}
