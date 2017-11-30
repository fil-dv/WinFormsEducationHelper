
namespace EducationHelper
{
    public class SettingsChanger
    {
        int _oldInterval;
        public int OldInterval { get { return _oldInterval; } set { _oldInterval = value; } }
        
        public void IsIntervalChange()
        {
            if (_oldInterval != Settings.Interval)
            {
                MyTimer.StopTimer();
                MyTimer.StartTimer();
            }
        }
    }
}
