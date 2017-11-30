using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
