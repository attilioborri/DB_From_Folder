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
            this.ComboBox_FileFormat = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            this.labelpath.Size = new System.Drawing.Size(64, 13);
            this.labelpath.TabIndex = 1;
            this.labelpath.Text = "FolderName";
            // 
            // ComboBox_FileFormat
            // 
            this.ComboBox_FileFormat.FormattingEnabled = true;
            this.ComboBox_FileFormat.Items.AddRange(new object[] {
            "Access",
            "TXT",
            "CSV",
            "Excel"});
            this.ComboBox_FileFormat.Location = new System.Drawing.Point(13, 61);
            this.ComboBox_FileFormat.Name = "ComboBox_FileFormat";
            this.ComboBox_FileFormat.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_FileFormat.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "MP3",
            "JPG",
            "CR2",
            "MOV",
            "MP4"});
            this.checkedListBox1.Location = new System.Drawing.Point(172, 61);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(90, 94);
            this.checkedListBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Analizza e salva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.analyse_and_save);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 175);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 20);
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 236);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.ComboBox_FileFormat);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelpath);
            this.Controls.Add(this.FolderSelector);
            this.MaximumSize = new System.Drawing.Size(300, 270);
            this.MinimumSize = new System.Drawing.Size(300, 270);
            this.Name = "Form1";
            this.Text = "DBFromFS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FolderSelector;
        private System.Windows.Forms.Label labelpath;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox ComboBox_FileFormat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;

    }
}

