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
        private string pathtoscan;
        public Form1()
        {
            InitializeComponent();
            pathtoscan = " ";
            labelpath.Text = "";
            ComboBox_FileFormat.SelectedIndex = 2;
        }

        private void FolderSelector_Click(object sender, EventArgs e)
        {
            
            using (FolderBrowserDialog SelectedFolder = new FolderBrowserDialog())
            {
                // Si può solo selezionare un percorso, non aggiungere nuove cartelle.
                SelectedFolder.ShowNewFolderButton = false;

                //selectedpath = SelectedFolder.SelectedPath.ToString()
                if (SelectedFolder.ShowDialog() == DialogResult.OK)   
                {  
                    pathtoscan = SelectedFolder.SelectedPath;

                    // Nel label scrivo solo la cartella foglia del percorso specificato
                    labelpath.Text = pathtoscan.Split('\\')[pathtoscan.Split('\\').Length-1];
                }  
            }
            
        }

        private void analyse_and_save(object sender, EventArgs e)
        {
            
            
            switch (ComboBox_FileFormat.SelectedIndex)
            {
                case 0:
                    //Access
                    break;
                case 1:
                    // MySQL
                    break;
                case 2:
                    // TXT
                    break;
                case 3:
                    // CSV
                    break;
                case 4:
                    //Excel
                    break;
                default:
                    break;
            }
            //MessageBox.Show(pathtoscan);
            string command = string.Concat(string.Concat("/C \"dir /s/b/o:gn \"", pathtoscan),"\"\"");
            MessageBox.Show(command);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            process.Start();
            //string output = process.StandardOutput.ReadToEnd();
            //string lineoutput = process.StandardOutput.ReadLine();
            string output="";
            string standard_output = "";
            while ((standard_output = process.StandardOutput.ReadLine()) != null)
            {
                //MessageBox.Show(output);
                output = string.Concat(string.Concat(output, "\n"), process.StandardOutput.ReadLine());
            }
            
            process.WaitForExit();
            MessageBox.Show(output);
            

        }
    }
}