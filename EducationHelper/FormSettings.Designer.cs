namespace EducationHelper
{
    partial class FormSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_interval = new System.Windows.Forms.NumericUpDown();
            this.button_settings_ok = new System.Windows.Forms.Button();
            this.button_settings_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(87, 12);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(311, 20);
            this.textBox_path.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path to file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interval (min):";
            // 
            // numericUpDown_interval
            // 
            this.numericUpDown_interval.Location = new System.Drawing.Point(87, 43);
            this.numericUpDown_interval.Name = "numericUpDown_interval";
            this.numericUpDown_interval.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_interval.TabIndex = 4;
            // 
            // button_settings_ok
            // 
            this.button_settings_ok.Location = new System.Drawing.Point(323, 100);
            this.button_settings_ok.Name = "button_settings_ok";
            this.button_settings_ok.Size = new System.Drawing.Size(75, 23);
            this.button_settings_ok.TabIndex = 5;
            this.button_settings_ok.Text = "Ok";
            this.button_settings_ok.UseVisualStyleBackColor = true;
            this.button_settings_ok.Click += new System.EventHandler(this.button_settings_ok_Click);
            // 
            // button_settings_cancel
            // 
            this.button_settings_cancel.Location = new System.Drawing.Point(242, 100);
            this.button_settings_cancel.Name = "button_settings_cancel";
            this.button_settings_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_settings_cancel.TabIndex = 6;
            this.button_settings_cancel.Text = "Cancel";
            this.button_settings_cancel.UseVisualStyleBackColor = true;
            this.button_settings_cancel.Click += new System.EventHandler(this.button_settings_cancel_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 135);
            this.Controls.Add(this.button_settings_cancel);
            this.Controls.Add(this.button_settings_ok);
            this.Controls.Add(this.numericUpDown_interval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_path);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_interval;
        private System.Windows.Forms.Button button_settings_ok;
        private System.Windows.Forms.Button button_settings_cancel;
    }
}