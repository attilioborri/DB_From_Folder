namespace DBFromFolder
{
    partial class Form1
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
            this.FolderSelector = new System.Windows.Forms.Button();
            this.labelpath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FolderSelector
            // 
            this.FolderSelector.Location = new System.Drawing.Point(12, 12);
            this.FolderSelector.Name = "FolderSelector";
            this.FolderSelector.Size = new System.Drawing.Size(116, 23);
            this.FolderSelector.TabIndex = 0;
            this.FolderSelector.Text = "Scegli cartella";
            this.FolderSelector.UseVisualStyleBackColor = true;
            this.FolderSelector.Click += new System.EventHandler(this.FolderSelector_Click);
            // 
            // labelpath
            // 
            this.labelpath.AutoSize = true;
            this.labelpath.Location = new System.Drawing.Point(135, 21);
            this.labelpath.Name = "labelpath";
            this.labelpath.Size = new System.Drawing.Size(35, 13);
            this.labelpath.TabIndex = 1;
            this.labelpath.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 236);
            this.Controls.Add(this.labelpath);
            this.Controls.Add(this.FolderSelector);
            this.MaximumSize = new System.Drawing.Size(430, 270);
            this.MinimumSize = new System.Drawing.Size(430, 270);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FolderSelector;
        private System.Windows.Forms.Label labelpath;

    }
}

