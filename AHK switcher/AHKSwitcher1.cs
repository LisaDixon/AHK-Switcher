using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AHK_switcher
{
    public partial class AHKSwitcher1 : Form
    {
      
        public AHKSwitcher1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Open the users files explorer
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            //Populate txtFileLocation with file location
            txtFileLocation.Text = folderBrowserDialog1.SelectedPath;
            //Identifies all .ahk files
            string[] filenamesandlocation = Directory.GetFiles(txtFileLocation.Text, "*.ahk", SearchOption.AllDirectories);
            //Remove filepath and display only file name
            foreach (string file in filenamesandlocation)
                //Populates cmbAHKSelector with .ahk files 
                cmbAHKSelector.Items.Add(Path.GetFileName(file));
        }


        private void btnStartAHK_Click(object sender, EventArgs e)
        {
            //Start exe for .ahk selected in cmbAHKSelector
            Process.Start(txtFileLocation.Text+@"\"+cmbAHKSelector.SelectedItem.ToString());
            //Set start button and cmbAHKSelector to disabled/read only
            btnStartAHK.Enabled = false;
            cmbAHKSelector.Enabled = false;
        }

        private void btnStopAHK_Click(object sender, EventArgs e)
        {
            //Stop process for AHK
            Process[] AHK = Process.GetProcessesByName("AutoHotkey");
            AHK[0].Kill();
            //Enable start button and cmbAHKSelector
            btnStartAHK.Enabled = true;
            cmbAHKSelector.Enabled = true;
        }
    }
}
