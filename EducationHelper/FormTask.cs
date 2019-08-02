using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EducationHelper
{
    public partial class FormTask : Form
    {
        private static readonly Random getrandom = new Random();

        String[] _taskArr = new string[2];
        public FormTask()
        {
            InitializeComponent();

            if (Settings.Lang == Language.Spanish)
            {
                this.Icon = EducationHelper.Properties.Resources.IconSpain;
                this.Text = "¡Hola!";
            }
            else if (Settings.Lang == Language.Italian)
            {
                this.Icon = EducationHelper.Properties.Resources.IconItaly;
                this.Text = "Ciao!";
            }
            else
            {
                this.Icon = EducationHelper.Properties.Resources.IconEnglish;
                this.Text = "Hi!";
            }
            InitTextBox();
        }

        void InitTextBox()
        {
            try
            {
                richTextBox_task.Text = "";
                string[] allStr = File.ReadAllLines(EducationHelper.Settings.PathToFile, Encoding.Default);
                List<string> strList = new List<string>();
                foreach (var item in allStr)
                {
                    
                    if (item.TrimStart()[0] == '-' || item.TrimStart()[1] == '-')
                    {
                        continue;
                    }
                    else
                    {
                        strList.Add(item.Trim());
                    }
                }
                string taskStr = GetRandonStr(strList);
                _taskArr = taskStr.Trim().Split('|');
                richTextBox_task.AppendText("\n\n\n" + _taskArr[0].Trim());
                TextAlightment();
                if (_taskArr.Length > 1)
                {
                    button_show_answer.Visible = true;
                }

                richTextBox_task.ReadOnly = true;
                richTextBox_task.TabStop = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("InitTextBox Method exception. " + ex.Message);
            }            
        }

        private void TextAlightment()
        {
            richTextBox_task.SelectAll();
            richTextBox_task.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox_task.DeselectAll();
        }

        private string GetRandonStr(List<string> strArr)
        {
            return strArr[GetRandomNumber(0, strArr.Count)];
        }

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        private void button_task_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_show_answer_Click(object sender, EventArgs e)
        {
            if (_taskArr.Length > 1)
            {
                if (IsItPhoto() == false)
                {
                    richTextBox_task.AppendText("\n\n");
                    richTextBox_task.AppendText(_taskArr[1].Trim());
                    button_show_answer.Visible = false;

                }
                else
                {
                    Settings.PathToAnswere = _taskArr[1].Trim();
                    FormPhoto fp = new FormPhoto();
                    fp.Owner = this;
                    this.Hide();
                    fp.ShowDialog();
                }
            }            
        }

        bool IsItPhoto()
        {            
            if(_taskArr[1].Contains(@"\"))
            {
                return true;
            }
            return false;
        }
    }
}
