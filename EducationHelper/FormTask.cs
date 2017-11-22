using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EducationHelper
{
    public partial class FormTask : Form
    {
        public FormTask()
        {
            InitializeComponent();
            InitTextBox();
        }

        void InitTextBox()
        {
            richTextBox_task.Text = "";
            string task = FileReader.ReadTask(Settings.Path);
            richTextBox_task.AppendText(task);
        }

        private void button_task_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
