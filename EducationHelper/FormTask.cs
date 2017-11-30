using System;
using System.Collections.Generic;
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
            richTextBox_task.Text = "";
            string taskStr = FileReader.ReadTask(Settings.Path);
            _taskArr = taskStr.Split('|');
            richTextBox_task.AppendText(_taskArr[0]);
            if (_taskArr[1] != null)
            {
                button_show_answer.Visible = true;
            }
        }

        private void button_task_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_show_answer_Click(object sender, EventArgs e)
        {
            if (_taskArr[1] != null)
            {
                richTextBox_task.AppendText("\n\n");
                richTextBox_task.AppendText(_taskArr[1]);
                button_show_answer.Visible = false;
            }            
        }
    }
}
