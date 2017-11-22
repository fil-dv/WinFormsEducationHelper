using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationHelper
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void button_settings_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_settings_ok_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Path = textBox_path.Text;
                Settings.Interval = (int)numericUpDown_interval.Value * 60000; //to milliseconds
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from FormSettings. Method button_settings_ok_Click. " + ex.Message);
            }            
        }
    }
}
