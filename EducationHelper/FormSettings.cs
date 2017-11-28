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
        SettingsChanger changer = new SettingsChanger();
        public FormSettings()
        {
            InitializeComponent();
            InitControls();
            changer.OldInterval = Settings.Interval;
        }

        void InitControls()
        {
            textBox_path.Text = Settings.Path;
            numericUpDown_interval.Value = Settings.Interval/60000; // to minutes           
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
                changer.IsIntervalChange();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from FormSettings. Method button_settings_ok_Click. " + ex.Message);
            }            
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            try
            {
                using (var selectFileDialog = new OpenFileDialog())
                {
                    selectFileDialog.Filter = "Text Files|*.txt;";
                    if (selectFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        textBox_path.Text = selectFileDialog.FileName;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from button_select_Click method. " + ex.Message);
            }
        }
    }
}
