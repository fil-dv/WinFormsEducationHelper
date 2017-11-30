using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationHelper
{
    public static class MyTimer
    {
        static System.Timers.Timer _timer;
        static SettingsChanger _changer = new SettingsChanger();
        

        public static void StartTimer()
        {
            //_changer.OnChange += ChangeInterval;
            _timer = new System.Timers.Timer();
            _timer.Enabled = true;
            _timer.Interval = EducationHelper.Settings.Interval; // 10sec
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            _timer.AutoReset = true;
            _timer.Start();
        }

        static void ChangeInterval(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("old = {0}, new = {1}", _changer.OldInterval, Settings.Interval));
            _timer.Interval = EducationHelper.Settings.Interval;
        }

        static void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            FormTask ft = new FormTask();
            ft.ShowDialog();          
        }

        public static void StopTimer()
        {
            try
            {
                _timer.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from StopTimer(). " + ex.Message);
            }
        }
    }
}
