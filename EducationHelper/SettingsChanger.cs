using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationHelper
{
    public class SettingsChanger
    {
        //public delegate void MethodContainer();
        public event EventHandler OnChange = new EventHandler((e, a) => { });

        int _oldInterval;
        public int OldInterval { get { return _oldInterval; } set { _oldInterval = value; } }

        
        public void IsIntervalChange()
        {
            if (_oldInterval != Settings.Interval)
            {
                if (OnChange != null)
                {
                    OnChange(this, new EventArgs());
                }
            }
        }
    }
}
