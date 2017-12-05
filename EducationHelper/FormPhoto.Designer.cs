namespace EducationHelper
{
    partial class FormPhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhoto));
            this.button_photo_ok = new System.Windows.Forms.Button();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_photo_ok
            // 
            this.button_photo_ok.Location = new System.Drawing.Point(577, 498);
            this.button_photo_ok.Name = "button_photo_ok";
            this.button_photo_ok.Size = new System.Drawing.Size(75, 23);
            this.button_photo_ok.TabIndex = 0;
            this.button_photo_ok.Text = "Ok";
            this.button_photo_ok.UseVisualStyleBackColor = true;
            this.button_photo_ok.Click += new System.EventHandler(this.button_photo_ok_Click);
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_photo.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(640, 480);
            this.pictureBox_photo.TabIndex = 1;
            this.pictureBox_photo.TabStop = false;
            // 
            // FormPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 525);
            this.Controls.Add(this.pictureBox_photo);
            this.Controls.Add(this.button_photo_ok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPhoto_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_photo_ok;
        private System.Windows.Forms.PictureBox pictureBox_photo;
    }
}