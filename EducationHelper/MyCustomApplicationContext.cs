using System;
using System.Drawing;
using System.Windows.Forms;

namespace EducationHelper
{
    class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;
        private System.Timers.Timer _timer;

        public MyCustomApplicationContext()
        {
            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = new Icon("..\\..\\img\\spain_flag.ico"),
                ContextMenu = new ContextMenu(new MenuItem[] {
                                                    new MenuItem("Settings", Settings),
                                                    new MenuItem("Exit", Exit)          
                                                              }),
                Visible = true
            };

            StartTimer();
        }       

        void Settings(object sender, EventArgs e)
        {
            FormSettings fs = new FormSettings();
            fs.ShowDialog();  
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;
            Application.Exit();
        }

        void StartTimer()
        {
            _timer = new System.Timers.Timer();
            _timer.Enabled = true;
            _timer.Interval = EducationHelper.Settings.Interval; // 10sec
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
            _timer.AutoReset = true;
            _timer.Start();
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //MessageBox.Show("Hola de tray!");
            FormTask ft = new FormTask();
            ft.ShowDialog();
        }
    }
}
