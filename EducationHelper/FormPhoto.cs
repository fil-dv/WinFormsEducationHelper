using System;
using System.Windows.Forms;

namespace EducationHelper
{
    public partial class FormPhoto : Form
    {
        public FormPhoto()
        {
            InitializeComponent();
            if (Settings.Lang == Language.Spanish)
            {
                this.Icon = EducationHelper.Properties.Resources.IconSpain;
                this.Text = "¡Hola!";
            }
            else
            {
                this.Icon = EducationHelper.Properties.Resources.IconItaly;
                this.Text = "Ciao!";
            }            
            ShowPhoto();
        }

        void ShowPhoto()
        {
            try
            {
                if (Settings.PathToAnswere != null)
                {
                    pictureBox_photo.ImageLocation = Settings.PathToAnswere;
                    pictureBox_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                    Settings.PathToAnswere = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception from ShowPhoto(). " + ex.Message);
            }                    
        }

        private void button_photo_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPhoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            var parentForm = this.Owner;
            parentForm.RemoveOwnedForm(this);
            parentForm.Close();
        }
    }
}
