using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EducationHelper
{
    class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon _trayIcon;
       
        public MyCustomApplicationContext()
        {
            try
            {
                string settings = ReadLangSettingsFile();
                string[] arr = settings.Split(new char[] { ':' });

                switch (arr[0])  // set language 
                {
                    case "Spanish":
                        EducationHelper.Settings.Lang = Language.Spanish;
                        break;
                    case "Italian":
                        EducationHelper.Settings.Lang = Language.Italian;
                        break;
                    case "English":
                        EducationHelper.Settings.Lang = Language.English;
                        break;
                    default:
                        EducationHelper.Settings.Lang = Language.Spanish;
                        break;
                }

                int interval = Convert.ToInt32(arr[1]);
                EducationHelper.Settings.Interval = interval * 60 * 1000;   // set interval in minutes

                SetTrayIcon();
                FormSettings.LanguageChanged += FormSettings_LanguageChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from MyCustomApplicationContext(). " + ex.Message);
            }            
        }

        private string ReadLangSettingsFile()
        {            
            string str = "";

            try
            {
                if (!File.Exists("Data\\settings.txt"))
                {
                    File.Create("Data\\settings.txt").Close();
                    File.WriteAllText("Data\\settings.txt", "English:21", Encoding.Default);
                }
                str = File.ReadAllText("Data\\settings.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from ReadLangSettingsFile(). " + ex.Message);
            }
            return str;
        }


        private void FormSettings_LanguageChanged()
        {
            if (_trayIcon != null)
            {
                if (EducationHelper.Settings.Lang == Language.Spanish)
                {
                    _trayIcon.Icon = EducationHelper.Properties.Resources.IconSpain;
                }
                else if (EducationHelper.Settings.Lang == Language.Italian)
                {
                    _trayIcon.Icon = EducationHelper.Properties.Resources.IconItaly;
                }
                else
                {
                    _trayIcon.Icon = EducationHelper.Properties.Resources.IconEnglish;
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
                    Icon = new Icon(Properties.Resources.IconSpain, 16, 16),
                    ContextMenu = new ContextMenu(new MenuItem[] {
                                                    new MenuItem("Settings", Settings),
                                                    new MenuItem("Exit", Exit)
                                                              }),
                    Visible = true
                };
            }
            else if (EducationHelper.Settings.Lang == Language.Italian)
            {
                _trayIcon = new NotifyIcon()
                {
                    Icon = new Icon(Properties.Resources.IconItaly, 16, 16),
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
                    Icon = new Icon(Properties.Resources.IconEnglish, 16, 16),

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
            else if (EducationHelper.Settings.Lang == Language.Italian)
            {
                EducationHelper.Settings.PathToFile = @"Data\Italian\questions.txt ";
            }
            else
            {
                EducationHelper.Settings.PathToFile = @"Data\English\questions.txt ";
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
