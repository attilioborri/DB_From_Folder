using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            ComboBox_FileFormat.SelectedIndex = 1;
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
            if (labelpath.Text == "")
            {
                MessageBox.Show("É necessario selezionare una cartella da analizzare.");
                return;
            }
            if (ExtensionsListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("É necessario selezionare almeno una estensione.");
                return;
            }
            
            //MessageBox.Show(pathtoscan);
            //string command = string.Concat(string.Concat("/C \"dir /s/b/o:gn \"", pathtoscan),"\"\"");
            
            // Detect file types
            String[] commands = new String[10];

            
            

            int j=0;
            if (ExtensionsListBox.CheckedItems.Count > 0)
            {
                
                for (int i = 0; i < ExtensionsListBox.CheckedItems.Count; i++)
                {
                    String ext = String.Concat("*.",ExtensionsListBox.CheckedItems[i].ToString());
                    ext = String.Concat("\\", ext);
                    string pathwithextensions = pathtoscan.ToString();
                    pathwithextensions = String.Concat(pathwithextensions, ext);
                    commands[j]= string.Concat(string.Concat("/C \"dir /b /a-d /s \"", pathwithextensions), "\"\"");
                    j++;
                }
                for (int cmdresetcnt = j; cmdresetcnt < commands.Length; cmdresetcnt++)
                {
                    commands[cmdresetcnt] = null;
                }
            }
            


            
            
            
            string output="";
            string standard_output = "";
            for (int cmdcount = 0; cmdcount < commands.Length; cmdcount++)
            {
                String command = commands[cmdcount];
                
                if (commands[cmdcount]!=null)
                {
                    //MessageBox.Show(command);
                    
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
                    while ((standard_output = process.StandardOutput.ReadLine()) != null)
                    {
                        //MessageBox.Show(output);
                        output = String.Concat(String.Concat(output, standard_output), System.Environment.NewLine);
                    }
                    process.WaitForExit();
                }
                else
                {
                    //skip
                }
                
            }

            progressBar1.Increment(33);


            switch (ComboBox_FileFormat.SelectedIndex)
            {
                case 0:
                    //Access
                    break;
                case 1:
                    SaveFileDialog TXTsaveFileDialog = new SaveFileDialog();
                    progressBar1.Increment(33);
                    //TXTsaveFileDialog.Filter = "*.txt"  ;
                    TXTsaveFileDialog.FilterIndex = 2 ;
                    TXTsaveFileDialog.DefaultExt = "txt";
                    TXTsaveFileDialog.RestoreDirectory = true ;

                    if(TXTsaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(Path.GetFullPath(TXTsaveFileDialog.FileName), output);
                    }
                    progressBar1.Increment(34);
                    break;
                case 2:
                    // CSV
                    String[] lines = output.Split(System.Environment.NewLine.ToCharArray());
                    String csvout = "";
                    progressBar1.Increment(33);
                    foreach(String line in lines){
                        String[] pathelements = line.Split("\\".ToCharArray());
                        for (int i = pathelements.Length-1; i >0; i--)
                        {
                            String.Concat(csvout,pathelements[i]);
                        }
                    }
                    SaveFileDialog CSVsaveFileDialog = new SaveFileDialog();
                    //CSVsaveFileDialog.Filter = "*.csv";
                    CSVsaveFileDialog.DefaultExt="csv";
                    CSVsaveFileDialog.RestoreDirectory = true;
                    if(CSVsaveFileDialog.ShowDialog()==DialogResult.OK){
                        File.WriteAllText(Path.GetFullPath(CSVsaveFileDialog.FileName),csvout);
                    }
                    progressBar1.Increment(34);
                    break;
                case 3:
                    //Excel
                    break;
                default:
                    break;
            }

            
        }
    }
}