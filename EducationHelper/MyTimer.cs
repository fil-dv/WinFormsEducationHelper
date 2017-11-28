using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationHelper
{
    public class MyTimer
    {
        private System.Timers.Timer _timer;
        SettingsChanger _changer = new SettingsChanger();
        

        public void StartTimer()
        {
            _changer.OnChange += ChangeInterval;
            _timer = new System.Timers.Timer();
            _timer.Enabled = true;
            _timer.Interval = EducationHelper.Settings.Interval; // 10sec
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            _timer.AutoReset = true;
            _timer.Start();
        }

        private void ChangeInterval(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("old = {0}, new = {1}", _changer.OldInterval, Settings.Interval));
            _timer.Interval = EducationHelper.Settings.Interval;
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            FormTask ft = new FormTask();
            ft.ShowDialog();          
        }
    }
}
