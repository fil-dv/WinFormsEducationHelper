using System.Windows.Forms;

namespace EducationHelper
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            SetIcon();
            SetText();
        }

        private void SetText()
        {
            if (Settings.Lang == Language.Spanish)
            {
                label1.Text = "Las preguntas y respuestas están separadas por \" | \".";
                label2.Text = "Coloque un nuevo registro en una nueva línea";
                label3.Text = "Use \" -- \" para comentarios.";
                label4.Text = "¡Buena suerte!";
            }
            else if (Settings.Lang == Language.Italian)
            {
                label1.Text = "Le domande e le risposte sono separate da \" | \".";
                label2.Text = "Posiziona un nuovo record su una nuova riga.";
                label3.Text = "Usa \" -- \" per i commenti.";
                label4.Text = "In bocca al lupo!";
            }
            else
            {
                label1.Text = "Questions and answers are separated by \" | \".";
                label2.Text = "Place a new record on a new line.";
                label3.Text = "Use \" -- \" for comments.";
                label4.Text = "Good luck!";
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
    }
}
