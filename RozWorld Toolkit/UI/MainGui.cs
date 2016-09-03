﻿using Oddmatics.RozWorld.Toolkit.UI.Dialogs;
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
    }
}
