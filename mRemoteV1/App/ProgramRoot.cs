﻿using System;
using System.Windows.Forms;

namespace mRemoteNG.App
{
    public static class ProgramRoot
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            var mainForm = new frmMain();
            frmMain.Default = mainForm;
            Application.Run(mainForm);
        }
    }
}