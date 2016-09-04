using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Oddmatics.RozWorld.Toolkit.UI.Dialogs
{
    public partial class SelectInstanceDialog : Form
    {
        public string Subject = "object";
        public string Filter = "";

        private Process[] Processes;


        private string Article
        {
            get
            {
                if (vowelRule.IsMatch(Subject))
                    return "an";
                else
                    return "a";
            }
        }

        private Regex vowelRule = new Regex("^[aeiou]");


        public SelectInstanceDialog()
        {
            InitializeComponent();
        }


        public new DialogResult ShowDialog()
        {
            this.InstructionLabel.Text = this.InstructionLabel.Text.Replace("$SUBJECT$", Subject);
            this.InstructionLabel.Text = this.InstructionLabel.Text.Replace("$ARTICLE$", Article);

            Processes = Process.GetProcesses();

            foreach (Process process in Processes)
            {
                if (Filter != "" && process.ProcessName.ToLower() != Filter.ToLower())
                    continue;

                ProcessList.Items.Add(process.ProcessName);
            }

            return base.ShowDialog();
        }


        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
