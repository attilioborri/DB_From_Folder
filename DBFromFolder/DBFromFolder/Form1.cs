using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBFromFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FolderSelector_Click(object sender, EventArgs e)
        {
            string selectedpath=" ";
            using (FolderBrowserDialog SelectedFolder = new FolderBrowserDialog())
            {
                //selectedpath = SelectedFolder.SelectedPath.ToString()
                if (SelectedFolder.ShowDialog() == DialogResult.OK)   
                {  
                    selectedpath = SelectedFolder.SelectedPath;  
                }  
            }
            MessageBox.Show(selectedpath);
        }
    }
}