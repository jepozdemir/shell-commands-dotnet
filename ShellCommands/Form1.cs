using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShellCommands
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "calc";
            proc.Start();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "c:\\ShellTests\\netdrv.bat";
            proc.Start();
            MessageBox.Show("Map Drive Created");



        }

        private void btnExplorer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
proc.EnableRaisingEvents=false;
proc.StartInfo.FileName="iexplore";
proc.StartInfo.Arguments="http://www.google.com/";
proc.Start();
proc.WaitForExit();
MessageBox.Show("You have just visited www.microsoft.com");



        }

        private void btnNewDoc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "winword";
            proc.StartInfo.Arguments = "C:\\ShellTests\\TestDocument.doc";
            proc.Start();



        }
    }
}
