using System;
using System.Drawing;
using System.Windows.Forms;

namespace EducationHelper
{
    class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon _trayIcon;
       
        public MyCustomApplicationContext()
        {
            EducationHelper.Settings.Lang = Language.Italian;             /////////////////////       set default language        ///////////////////            
            SetTrayIcon();
            FormSettings.LanguageChanged += FormSettings_LanguageChanged;       
        }

        private void FormSettings_LanguageChanged()
        {
            if (_trayIcon != null)
            {
                if (EducationHelper.Settings.Lang == Language.Spanish)
                {
                    _trayIcon.Icon = EducationHelper.Properties.Resources.IconSpain;
                }
                else
                {
                    _trayIcon.Icon = EducationHelper.Properties.Resources.IconItaly;
                }
                SetPathToQuerstions();
            }           
        }

        private void SetTrayIcon()
        {
            if (EducationHelper.Settings.Lang == Language.Spanish)
            {
                _trayIcon = new NotifyIcon()
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
                _trayIcon = new NotifyIcon()
                {
                    Icon = new Icon("..\\..\\img\\italy_flag.ico"),
                    ContextMenu = new ContextMenu(new MenuItem[] {
                                                    new MenuItem("Settings", Settings),
                                                    new MenuItem("Exit", Exit)
                                                              }),
                    Visible = true
                };
            }

            SetPathToQuerstions();
            MyTimer.StartTimer();
        }

        private void SetPathToQuerstions()
        {
            if (EducationHelper.Settings.Lang == Language.Spanish)
            {
                EducationHelper.Settings.PathToFile = @"Data\Spanish\questions.txt";
            }
            else
            {
                EducationHelper.Settings.PathToFile = @"Data\Italian\questions.txt ";
            }
        }

        void Settings(object sender, EventArgs e)
        {
            FormSettings fs = new FormSettings();
            fs.ShowDialog();  
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            _trayIcon.Visible = false;
            Application.Exit();
        }
    }
}
