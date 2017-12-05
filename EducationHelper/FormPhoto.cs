using System;
using System.Windows.Forms;

namespace EducationHelper
{
    public partial class FormPhoto : Form
    {
        public FormPhoto()
        {
            InitializeComponent();
            ShowPhoto();
        }

        void ShowPhoto()
        {
            try
            {
                if (Mediator.Path != null)
                {
                    pictureBox_photo.ImageLocation = Mediator.Path;
                    pictureBox_photo.SizeMode = PictureBoxSizeMode.StretchImage;
                    Mediator.Path = null;
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
