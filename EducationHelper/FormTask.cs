using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EducationHelper
{
    public partial class FormTask : Form
    {
        String[] _taskArr = new string[2];
        public FormTask()
        {
            InitializeComponent();
            InitTextBox();
        }

        void InitTextBox()
        {
            try
            {
                richTextBox_task.Text = "";
                string taskStr = FileReader.ReadTask(Settings.Path);
                _taskArr = taskStr.Split('|');
                richTextBox_task.AppendText(_taskArr[0]);
                if (_taskArr.Length > 1)
                {
                    button_show_answer.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("InitTextBox Method exception. " + ex.Message);
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
                    richTextBox_task.AppendText(_taskArr[1]);
                    button_show_answer.Visible = false;
                }
                else
                {
                    Mediator.Path = _taskArr[1].Trim();
                    FormPhoto fp = new FormPhoto();
                    fp.Owner = this;
                    fp.ShowDialog();
                }
            }            
        }

        bool IsItPhoto()
        {            
            //string regex = @"([a-z]:\)";
            //if (Regex.IsMatch(_taskArr[1].Trim(), @"/[a-z]:\/"))
            if(_taskArr[1].Contains(@":\"))
            {
                return true;
            }
            return false;
        }
    }
}
