using Oddmatics.RozWorld.Toolkit.UI.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oddmatics.RozWorld.Toolkit.UI
{
    public partial class MainGui : Form
    {
        public MainGui()
        {
            InitializeComponent();
        }


        #region Pass-on Menu/Toolbar Events

        private void New_MenuButton_Click(object sender, EventArgs e)
        {
            InvokeNewDialog();
        }

        private void Open_MenuButton_Click(object sender, EventArgs e)
        {
            InvokeOpenWhatDialog();
        }

        #endregion


        /// <summary>
        /// Opens and handles the new file/session dialog.
        /// </summary>
        public void InvokeNewDialog()
        {
            // TODO: Handle anything that needs to be dealt with before showing the new dialog

            var newDialog = new NewDialog();

            newDialog.ShowDialog();
        }

        public void InvokeOpenWhatDialog()
        {
            // TODO: Handle anything that needs to be dealt with before showing the open what dialog

            var openWhatDialog = new OpenWhatDialog();

            if (openWhatDialog.ShowDialog() == DialogResult.OK)
            {
                // Temporary test code
                switch (openWhatDialog.Selected)
                {
                    case OpenWhatResult.ClientByInstance:
                        var selectClientDialog = new SelectInstanceDialog();

                        selectClientDialog.Filter = "explorer";
                        selectClientDialog.Subject = "client";

                        selectClientDialog.ShowDialog();

                        break;

                    case OpenWhatResult.ServerByInstance:
                        var selectServerDialog = new SelectInstanceDialog();

                        selectServerDialog.Filter = "csrss";
                        selectServerDialog.Subject = "server";

                        selectServerDialog.ShowDialog();

                        break;
                }
            }
        }
    }
}
