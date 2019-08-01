namespace EducationHelper
{
    partial class FormTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask));
            this.richTextBox_task = new System.Windows.Forms.RichTextBox();
            this.button_task_ok = new System.Windows.Forms.Button();
            this.button_show_answer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_task
            // 
            this.richTextBox_task.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_task.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox_task.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_task.Name = "richTextBox_task";
            this.richTextBox_task.Size = new System.Drawing.Size(440, 183);
            this.richTextBox_task.TabIndex = 0;
            this.richTextBox_task.Text = "";
            // 
            // button_task_ok
            // 
            this.button_task_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_task_ok.Location = new System.Drawing.Point(355, 211);
            this.button_task_ok.Name = "button_task_ok";
            this.button_task_ok.Size = new System.Drawing.Size(97, 23);
            this.button_task_ok.TabIndex = 1;
            this.button_task_ok.Text = "Ok";
            this.button_task_ok.UseVisualStyleBackColor = true;
            this.button_task_ok.Click += new System.EventHandler(this.button_task_ok_Click);
            // 
            // button_show_answer
            // 
            this.button_show_answer.Location = new System.Drawing.Point(12, 211);
            this.button_show_answer.Name = "button_show_answer";
            this.button_show_answer.Size = new System.Drawing.Size(97, 23);
            this.button_show_answer.TabIndex = 2;
            this.button_show_answer.Text = "Show answer";
            this.button_show_answer.UseVisualStyleBackColor = true;
            this.button_show_answer.Visible = false;
            this.button_show_answer.Click += new System.EventHandler(this.button_show_answer_Click);
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 244);
            this.Controls.Add(this.button_show_answer);
            this.Controls.Add(this.button_task_ok);
            this.Controls.Add(this.richTextBox_task);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_task;
        private System.Windows.Forms.Button button_task_ok;
        private System.Windows.Forms.Button button_show_answer;
    }
}