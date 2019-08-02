using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EducationHelper
{
    public partial class FormEdit : Form
    {
        string _path = String.Empty;
        public FormEdit()
        {
            InitializeComponent();            
            SetIcon();
            InitPathToFile();
            FillTextBox();
            this.KeyPreview = true;
            this.KeyDown += FormEdit_KeyDown; ;
        }

        private void FormEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                FormAbout fa = new FormAbout();
                fa.Show();
            }
        }

        private void SetIcon()
        {
            if (Settings.Lang == Language.Spanish)
            {
                this.Icon = EducationHelper.Properties.Resources.IconSpain;
            }
            else if (Settings.Lang == Language.Italian)
            {
                this.Icon = EducationHelper.Properties.Resources.IconItaly;
            }
            else
            {
                this.Icon = EducationHelper.Properties.Resources.IconEnglish;
            }
        }

        private void FillTextBox()
        {
            string[] lines = ReadQuestionsFromFile();
            foreach (var item in lines)
            {
                richTextBox_edit.AppendText(" " + item.Trim() + Environment.NewLine);
            }
            TextAlightment();
        }

        private void TextAlightment()
        {
            richTextBox_edit.SelectAll();
            richTextBox_edit.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox_edit.DeselectAll();
        }

        private string[] ReadQuestionsFromFile()
        {            
            return File.ReadAllLines(_path, Encoding.Default);
        }

        private void InitPathToFile()
        {
            string langDir = String.Empty;
            
            if (Settings.Lang == Language.Spanish)
            {
                langDir = "Spanish";
            }
            else if (Settings.Lang == Language.Italian)
            {
                langDir = "Italian";
            }
            else
            {
                langDir = "English";
            }
            _path = Path.Combine("Data", langDir, "questions.txt");           
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string text = richTextBox_edit.Text;
            SaveTextToFile(text);
            this.Close();
        }

        private void SaveTextToFile(string text)
        {
            try
            {
                File.WriteAllText(_path, text, Encoding.Default);
                MessageBox.Show("Questions updated successfully.", "Questions editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
