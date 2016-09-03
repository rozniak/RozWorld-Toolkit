using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oddmatics.RozWorld.Toolkit.UI.Dialogs
{
    public partial class OpenWhatDialog : Form
    {
        public OpenWhatResult Selected { get; private set; }


        public OpenWhatDialog()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            if (CbfRadioButton.Checked)
                Selected = OpenWhatResult.ClientByFolder;
            else if (CbiRadioButton.Checked)
                Selected = OpenWhatResult.ClientByInstance;
            else if (IdvlFileRadioButton.Checked)
                Selected = OpenWhatResult.IndividualFile;
            else if (SbfRadioButton.Checked)
                Selected = OpenWhatResult.ServerByFolder;
            else if (SbiRadioButton.Checked)
                Selected = OpenWhatResult.ServerByInstance;

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
