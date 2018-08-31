using System;
using System.Drawing;
using System.Windows.Forms;

namespace EducationHelper
{
    class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;
       
        public MyCustomApplicationContext()
        {
            // Initialize Tray Icon
            if (Mediator.Lang == Language.Spain)
            {
                trayIcon = new NotifyIcon()
                {
                    Icon = new Icon("..\\..\\img\\spain_flag.ico"),
                    ContextMenu = new ContextMenu(new MenuItem[] {
                                                    new MenuItem("Settings", Settings),
                                                    new MenuItem("Exit", Exit)
                                                              }),
                    Visible = true
                };
            }
            else
            {
                trayIcon = new NotifyIcon()
                {
                    Icon = new Icon("..\\..\\img\\italy_flag.ico"),
                    ContextMenu = new ContextMenu(new MenuItem[] {
                                                    new MenuItem("Settings", Settings),
                                                    new MenuItem("Exit", Exit)
                                                              }),
                    Visible = true
                };
            }          

            MyTimer.StartTimer();            
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
    }
}
