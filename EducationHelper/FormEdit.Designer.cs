namespace EducationHelper
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox_edit = new DevExpress.Tutorials.Controls.RichTextBoxEx();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_edit
            // 
            this.richTextBox_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_edit.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_edit.Name = "richTextBox_edit";
            this.richTextBox_edit.Size = new System.Drawing.Size(776, 426);
            this.richTextBox_edit.TabIndex = 0;
            this.richTextBox_edit.Text = "";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(713, 451);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.richTextBox_edit);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Tutorials.Controls.RichTextBoxEx richTextBox_edit;
        private System.Windows.Forms.Button button_save;
    }
}